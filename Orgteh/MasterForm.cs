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
    public partial class MasterForm : Form
    {
        DB dataBase = new DB();

        public MasterForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadTable("В работе", dataGridViewRequest);
        }

        private void MasterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoadTable(string searchText, DataGridView dataGridView)
        {
            dataBase.OpenConnection();
            string query = @"SELECT Requests.requestID, startDate, modelName, requestStatus, problemDescryption, fio, phone 
                    FROM Requests
                    INNER JOIN ModelsOrg ON Requests.orgTechModel = ModelsOrg.modelID
                    INNER JOIN Users ON Users.userID = Requests.clientID 
                    WHERE requestStatus = @statusDescription AND masterID = @masterID";

            if (!string.IsNullOrEmpty(searchText))
            {
                query += " AND (modelName LIKE @searchText OR problemDescryption LIKE @searchText OR fio LIKE @searchText)";
            }

            using (SqlCommand command = new SqlCommand(query, dataBase.GetConnection()))
            {
                command.Parameters.AddWithValue("@statusDescription", "В работе");
                command.Parameters.AddWithValue("@masterID", Authorization.userID.ToString());
                if (!string.IsNullOrEmpty(searchText))
                {
                    command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView.Columns.Clear();
                dataGridView.Rows.Clear();

                foreach (DataColumn column in dt.Columns)
                {
                    DataGridViewColumn dataGridViewColumn = new DataGridViewTextBoxColumn
                    {
                        Name = column.ColumnName,
                        HeaderText = HeadertableText(column.ColumnName)
                    };
                    dataGridView.Columns.Add(dataGridViewColumn);
                }

                foreach (DataRow row in dt.Rows)
                {
                    dataGridView.Rows.Add(row.ItemArray);
                }
                labelRecordCount.Text = $"Количество записей: {dt.Rows.Count}";
            }
            dataBase.CloseConnection();
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
                case "requestStatus":
                    return "Статус заявки";
                case "problemDescryption":
                    return "Описание проблемы";
                case "fio":
                    return "ФИО клиента";
                case "phone":
                    return "Телефон клиента";
                default:
                    return columnName;
            }
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            if (dataGridViewRequest.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridViewRequest.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewRequest.Rows[selectedRowIndex];
                string requestID = selectedRow.Cells[0].Value.ToString();
                ReportRequest reportRequest = new ReportRequest(requestID);
                if (reportRequest.ShowDialog() == DialogResult.Cancel)
                {
                    LoadTable("В работе", dataGridViewRequest);
                }
                LoadTable("", dataGridViewRequest);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите заявку из таблицы для формирования отчета.");
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim();
            LoadTable(searchText, dataGridViewRequest);
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            LoadTable("", dataGridViewRequest);
        }
    }
}
