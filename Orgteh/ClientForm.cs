using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orgteh
{
    public partial class ClientForm : Form
    {
        DB dataBase = new DB();
        private string userID = Authorization.userID.ToString();
        public ClientForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoadTable(string filter = "")
        {
            dataBase.OpenConnection();
            string query = @"SELECT Requests.requestID, startDate, ModelsOrg.modelName, problemDescryption, requestStatus, completionDate, message 
                     FROM Requests
                     INNER JOIN ModelsOrg ON Requests.orgTechModel = ModelsOrg.modelID
                     INNER JOIN TypesOrg ON ModelsOrg.typeID = TypesOrg.typeID
                     LEFT JOIN Comments ON Comments.requestID = Requests.requestID
                     WHERE Requests.clientID = @clientID";

            if (!string.IsNullOrEmpty(filter))
            {
                query += " AND (ModelsOrg.modelName LIKE @filter OR problemDescryption LIKE @filter OR message LIKE @filter)";
            }

            SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
            command.Parameters.AddWithValue("@clientID", userID);
            if (!string.IsNullOrEmpty(filter))
            {
                command.Parameters.AddWithValue("@filter", "%" + filter + "%");
            }

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewRequest.Columns.Clear();
            dataGridViewRequest.Rows.Clear();
            foreach (DataColumn column in dt.Columns)
            {
                DataGridViewColumn dataGridViewColumn = new DataGridViewTextBoxColumn
                {
                    Name = column.ColumnName,
                    HeaderText = HeadertableText(column.ColumnName)
                };
                dataGridViewRequest.Columns.Add(dataGridViewColumn);
            }
            foreach (DataRow row in dt.Rows)
            {
                dataGridViewRequest.Rows.Add(row.ItemArray);
            }
            dataBase.CloseConnection();

            labelRecordCount.Text = $"Количество записей: {dt.Rows.Count}";
        }



        private string HeadertableText(string columnName)
        {
            switch (columnName)
            {
                case "requestID":
                    return "Код заявки";
                case "startDate":
                    return "Дата создания";
                case "modelName":
                    return "Техника";
                case "problemDescryption":
                    return "Описание проблемы";
                case "requestStatus":
                    return "Статус заявки";
                case "completionDate":
                    return "Дата окончания работ";
                case "message":
                    return "Комментарий";
                default:
                    return columnName;
            }
        }

        private void buttoncreateRequest_Click(object sender, EventArgs e)
        {
            CreateRequest newRequest = new CreateRequest();
            if (newRequest.ShowDialog() == DialogResult.Cancel)
            {
                LoadTable();
            }
        }

        private void buttonEditRequest_Click(object sender, EventArgs e)
        {
            if (dataGridViewRequest.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridViewRequest.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewRequest.Rows[selectedRowIndex];
                if (selectedRow.Cells[4].Value.ToString() != "Новая заявка")
                {
                    MessageBox.Show("Вы можете изменять только заявки, которые имеют статус Новая заявка'.");
                    return;
                }
                string requestID = selectedRow.Cells[0].Value.ToString();
                EditRequest editRequest = new EditRequest(requestID);
                if (editRequest.ShowDialog() == DialogResult.Cancel)
                {
                    LoadTable();
                }
            }
            else
            {
                MessageBox.Show("Выберите заявку из списка в таблице.");
            }
        }

        private void buttonDelRequest_Click(object sender, EventArgs e)
        {
            if (dataGridViewRequest.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridViewRequest.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewRequest.Rows[selectedRowIndex];
                if (selectedRow.Cells[4].Value.ToString() != "Новая заявка")
                {
                    MessageBox.Show("Вы можете удалять только заявки, которые имеют статус Новая заявка'.");
                    return;
                }
                string requestID = selectedRow.Cells[0].Value.ToString();
                dataBase.OpenConnection();
                string query = $"DELETE FROM Requests WHERE requestID = {requestID}";
                SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
                command.ExecuteNonQuery();
                dataBase.CloseConnection();
                MessageBox.Show("Заявка была успешно удалена.");
                LoadTable();
            }
            else
            {
                MessageBox.Show("Выберите заявку из списка в таблице.");
            }
        }

        private void ExitBttn_Click(object sender, EventArgs e)
        {
            Authorization logIn = new Authorization();
            foreach (Form form in Application.OpenForms)
            {
                form.Hide();
            }
            logIn.ShowDialog();
        }

        private void ClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim();
            LoadTable(searchText);
        }
    }
}