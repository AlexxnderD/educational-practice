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
    public partial class EditRequest : Form
    {
        DB dataBase = new DB();
        private string requestID;
        public EditRequest(string requestID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.requestID = requestID;
            LoadTable();
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
        private void LoadTable()
        {
            try
            {
                dataBase.OpenConnection();
                string query = $"SELECT modelName, problemDescryption FROM Requests " +
                    $"INNER JOIN ModelsOrg ON orgTechModel = modelID" +
                    $" WHERE requestID = {requestID}";
                SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    comboBoxModel.Text = reader[0].ToString();
                    textBoxproblemdesc.Text = reader[1].ToString();
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxModel.Text) || string.IsNullOrWhiteSpace(textBoxproblemdesc.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            try
            {
                dataBase.OpenConnection();
                string modelID = OrgModelid();
                if (modelID == null)
                {
                    MessageBox.Show("Модель не найдена!");
                    return;
                }

                string query = "UPDATE Requests SET orgTechModel = @orgTechModel, problemDescryption = @problemDescryption WHERE requestID = @requestID";
                using (SqlCommand command = new SqlCommand(query, dataBase.GetConnection()))
                {
                    command.Parameters.AddWithValue("@orgTechModel", modelID);
                    command.Parameters.AddWithValue("@problemDescryption", textBoxproblemdesc.Text);
                    command.Parameters.AddWithValue("@requestID", requestID);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Заявка успешно сохранена.");
                dataBase.CloseConnection();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
