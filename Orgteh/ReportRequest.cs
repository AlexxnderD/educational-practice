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
    public partial class ReportRequest : Form
    {
        DB dataBase = new DB();
        private string requestID;
        public ReportRequest(string requestID)
        {
            InitializeComponent();
            this.requestID = requestID;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            try
            {
                dataBase.OpenConnection();

                string query = @"UPDATE Requests 
                         SET requestStatus = @status, 
                             completionDate = @completionDate, 
                             repairParts = @repairParts
                         WHERE requestID = @requestID";

                using (SqlCommand command = new SqlCommand(query, dataBase.GetConnection()))
                {
                    command.Parameters.AddWithValue("@completionDate", DateTime.Now);
                    command.Parameters.AddWithValue("@status", "Завершено");
                    command.Parameters.AddWithValue("@repairParts", textBox1.Text);
                    command.Parameters.AddWithValue("@requestID", requestID);

                    command.ExecuteNonQuery();
                }

                dataBase.CloseConnection();
                MessageBox.Show("Отчет успешно создан.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

    }
}
