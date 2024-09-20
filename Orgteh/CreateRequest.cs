using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Orgteh
{
    public partial class CreateRequest : Form
    {
        DB dataBase = new DB();

        public CreateRequest()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            try
            {
                dataBase.OpenConnection();

                string query = "SELECT modelName FROM ModelsOrg";
                SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxModel.Items.Add(reader[0].ToString());
                }
                reader.Close();
                dataBase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private string OrgModelid()
        {
            try
            {
                string query = "SELECT modelID FROM ModelsOrg WHERE modelName = @modelName";

                using (SqlCommand command = new SqlCommand(query, dataBase.GetConnection()))
                {
                    command.Parameters.AddWithValue("@modelName", comboBoxModel.Text);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader["modelID"].ToString();
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
                return null;
            }
        }

        public void buttonCreate_Click(object sender, EventArgs e)
        {
            if (comboBoxModel.Text == "" || textBoxproblemdesk.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            try
            {
                dataBase.OpenConnection();

                string query = @"INSERT INTO Requests (startDate, orgTechModel, problemDescryption, requestStatus, clientID) 
                         VALUES (@startDate, @techModelID, @problemDescription, @status, @clientID)";

                using (SqlCommand command = new SqlCommand(query, dataBase.GetConnection()))
                {
                    command.Parameters.AddWithValue("@startDate", DateTime.Now);
                    command.Parameters.AddWithValue("@techModelID", OrgModelid());
                    command.Parameters.AddWithValue("@problemDescription", textBoxproblemdesk.Text);
                    command.Parameters.AddWithValue("@status", "Новая заявка");
                    command.Parameters.AddWithValue("@clientID", Authorization.userID);

                    int result = command.ExecuteNonQuery();
                    dataBase.CloseConnection();

                    if (result > 0)
                    {
                        MessageBox.Show("Запись успешно создана!");
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при добавлении записи!");
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
