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
    public partial class Moderate : Form
    {
        DB dataBase = new DB();
        private string requestID;
        public Moderate(string requestID)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.requestID = requestID;

            try
            {
                dataBase.OpenConnection();

                string query = "SELECT fio FROM Users WHERE lvl = 'Мастер'";
                SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxMasters.Items.Add(reader[0].ToString());
                }
                reader.Close();
                dataBase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private string GetMasterid()
        {
            try
            {
                string query = $"SELECT userID FROM Users WHERE fio = '{comboBoxMasters.Text}'";
                SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
                SqlDataReader reader = command.ExecuteReader();
                string modelID = null;
                if (reader.Read())
                {
                    modelID = reader[0].ToString();
                }
                reader.Close();
                return modelID;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
                return null;
            }
        }

        private void buttonModerate_Click(object sender, EventArgs e)
        {
            if (comboBoxMasters.Text == "")
            {
                MessageBox.Show("Выберите мастера для выполнения заявки!");
                return;
            }

            try
            {
                dataBase.OpenConnection();

                string query = $"UPDATE Requests SET masterID = @masterID, requestStatus = @status WHERE requestID = @requestID";

                using (SqlCommand command = new SqlCommand(query, dataBase.GetConnection()))
                {
                    command.Parameters.AddWithValue("@masterID", GetMasterid());
                    command.Parameters.AddWithValue("@status", "В работе");
                    command.Parameters.AddWithValue("@requestID", requestID);

                    command.ExecuteNonQuery();
                }

                Comments();
                dataBase.CloseConnection();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void Comments()
        {
            string query = $"INSERT INTO Comments (message, masterID, requestID) " +
                $"VALUES ('{textBoxMessage.Text}', {Authorization.userID.ToString()}, {requestID})";
            SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
            command.ExecuteNonQuery();
        }
    }
}
