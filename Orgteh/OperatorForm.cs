using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Orgteh
{
    public partial class OperatorForm : Form
    {
        DB dataBase = new DB();

        public OperatorForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadTable("Новая заявка", string.Empty);
        }

        public void LoadTable(string status, string searchText)
        {
            dataBase.OpenConnection();

            string query = @"SELECT Requests.requestID, startDate, modelName, requestStatus, problemDescryption, fio, phone 
                FROM Requests
                INNER JOIN ModelsOrg ON Requests.orgTechModel = ModelsOrg.modelID
                INNER JOIN Users ON Users.userID = Requests.clientID 
                WHERE requestStatus = @status";

            if (!string.IsNullOrEmpty(searchText))
            {
                query += " AND (modelName LIKE @searchText OR problemDescryption LIKE @searchText OR fio LIKE @searchText)";
            }

            using (SqlCommand command = new SqlCommand(query, dataBase.GetConnection()))
            {
                command.Parameters.AddWithValue("@status", status);
                if (!string.IsNullOrEmpty(searchText))
                {
                    command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
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

        private void OperatorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttondismiss_Click(object sender, EventArgs e)
        {
            if (dataGridViewRequest.SelectedCells.Count > 0)
            {
                ModerateRequest("Отказано", dataGridViewRequest);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите заявку для отказа или обработки заявки.");
            }
        }

        public void ModerateRequest(string requestStatus, DataGridView dataGridView)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Выберите заявку из списка в таблице.");
                return;
            }

            string requestID = dataGridView.CurrentRow.Cells[0].Value?.ToString();
            if (string.IsNullOrEmpty(requestID))
            {
                MessageBox.Show("Невозможно получить ID заявки.");
                return;
            }

            try
            {
                string query = "UPDATE Requests SET requestStatus = @status WHERE requestID = @requestID";
                using (SqlCommand command = new SqlCommand(query, dataBase.GetConnection()))
                {
                    command.Parameters.AddWithValue("@status", requestStatus);
                    command.Parameters.AddWithValue("@requestID", requestID);
                    dataBase.OpenConnection();
                    command.ExecuteNonQuery();
                }
                LoadTable("Новая заявка", textBoxSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                dataBase.CloseConnection();
            }
        }

        private void buttonaccept_Click(object sender, EventArgs e)
        {
            if (dataGridViewRequest.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridViewRequest.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewRequest.Rows[selectedRowIndex];
                string requestID = selectedRow.Cells[0].Value.ToString();
                Moderate processRequest = new Moderate(requestID);
                if (processRequest.ShowDialog() == DialogResult.Cancel)
                {
                    LoadTable("В процессе", textBoxSearch.Text);
                }
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            LoadTable("Новая заявка", textBoxSearch.Text);
        }
    }
}
