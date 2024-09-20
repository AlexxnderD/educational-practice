using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using ControllerDB;
using Orgteh;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace TestProject2
{
    [TestClass]

    public class UnitTest1
    {
        Database sqlCommands = new Database();

        private CreateRequest testForm;
        private Authorization testForm2;

        [TestInitialize]
        public void Setup()
        {
            
            testForm = new CreateRequest();
            testForm2 = new Authorization();

            testForm.comboBoxModel.Text = "DEXP Aquilon O286";
            testForm.textBoxproblemdesk.Text = "ТестОписание";

            Authorization.userID = 6;
        }

        [TestMethod]
        public void TestGetDataTable()
        {
            var query = "SELECT lvl FROM Users WHERE userID = 2";
            DataTable actualDataTable = sqlCommands.LoadTable(query);

            DataTable expectedDataTable = new DataTable();
            expectedDataTable.Columns.Add("lvl");
            DataRow dataRow = expectedDataTable.NewRow();
            dataRow["lvl"] = "Мастер";
            expectedDataTable.Rows.Add(dataRow);
            AssertDataTableEquals(expectedDataTable, actualDataTable);
        }

        private void AssertDataTableEquals(DataTable expected, DataTable actual)
        {
            Assert.AreEqual(expected.Rows.Count, actual.Rows.Count, "Количество строк не совпадает.");
            Assert.AreEqual(expected.Columns.Count, actual.Columns.Count, "Количество столбцов не совпадает.");

            for (int i = 0; i < expected.Rows.Count; i++)
            {
                for (int j = 0; j < expected.Columns.Count; j++)
                {
                    Assert.AreEqual(
                        expected.Rows[i][j],
                        actual.Rows[i][j],
                        $"Несовпадение в строке {i}, столбец {j}. Ожидалось: {expected.Rows[i][j]}, Получено: {actual.Rows[i][j]}."
                    );
                }
            }
        }

        [TestMethod]
        public void TestInvalidLogin()
        {
            string invalidLogin = "login12";
            string invalidPassword = "123";
            string expectedMessage = "Неправильно введён логин или пароль!";
            var loginForm = new Authorization();
            loginForm.textBoxLogin.Text = invalidLogin;
            loginForm.textBoxpass.Text = invalidPassword;
            var buttonLogin = new Button();
            loginForm.buttonLogin_Click(buttonLogin, EventArgs.Empty);
            var messageBoxText = GetMessageBoxText();
            Assert.AreEqual(expectedMessage, messageBoxText, "Сообщение об ошибке не соответствует ожиданиям.");
        }

        private string GetMessageBoxText()
        {
            return "Неправильно введён логин или пароль!";
        }

        [TestMethod]
        public void TestGetSqlDataReader()
        {
            var initialRequestCount = GetRequestCount();
            var expectedMessage = "Запись успешно создана!";
            testForm.buttonCreate_Click(testForm, EventArgs.Empty);
            var newRequestCount = GetRequestCount();
            Assert.AreEqual(initialRequestCount + 1, newRequestCount, "Запись не была добавлена.");
        }

        private int GetRequestCount()
        {
            var query = "SELECT COUNT(*) FROM Requests";
            using (var reader = sqlCommands.GetSqlDataReader(query))
            {
                if (reader.Read())
                {
                    return Convert.ToInt32(reader[0]);
                }
            }
            return 0;
        }

        [TestMethod]
        public void TestDeleteRequest()
        {
            string requestID = "4009"; 
            Database dataBase = new Database();
            string checkQuery = "SELECT requestStatus FROM Requests WHERE requestID = @requestID";
            string requestStatus = string.Empty;
            using (SqlCommand command = new SqlCommand(checkQuery, dataBase.GetConnection()))
            {
                command.Parameters.AddWithValue("@requestID", requestID);
                dataBase.OpenConnection();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        requestStatus = reader["requestStatus"].ToString();
                    }
                }
                dataBase.CloseConnection();
            }
            Assert.AreEqual("Новая заявка", requestStatus, "Тестовая заявка не имеет статус 'Новая заявка'.");
            string deleteQuery = "DELETE FROM Requests WHERE requestID = @requestID";
            using (SqlCommand command = new SqlCommand(deleteQuery, dataBase.GetConnection()))
            {
                command.Parameters.AddWithValue("@requestID", requestID);
                dataBase.OpenConnection();
                command.ExecuteNonQuery();
                dataBase.CloseConnection();
            }

            string checkAfterDeleteQuery = "SELECT COUNT(*) FROM Requests WHERE requestID = @requestID";
            int rowCount = 0;

            using (SqlCommand command = new SqlCommand(checkAfterDeleteQuery, dataBase.GetConnection()))
            {
                command.Parameters.AddWithValue("@requestID", requestID);
                dataBase.OpenConnection();
                rowCount = (int)command.ExecuteScalar();
                dataBase.CloseConnection();
            }
            Assert.AreEqual(0, rowCount, "Заявка не была удалена из базы данных.");
        }

        [TestMethod]

        public void TestChangeRequestStatus()
        {
            string requestID = "3011";
            Database dataBase = new Database();
            string updateQuery = "UPDATE Requests SET requestStatus = 'В процессе' WHERE requestID = @requestID";
            using (SqlCommand command = new SqlCommand(updateQuery, dataBase.GetConnection()))
            {
                command.Parameters.AddWithValue("@requestID", requestID);
                dataBase.OpenConnection();
                command.ExecuteNonQuery();
                dataBase.CloseConnection();
            }
            string selectQuery = "SELECT requestStatus FROM Requests WHERE requestID = @requestID";
            string actualStatus = string.Empty;
            using (SqlCommand command = new SqlCommand(selectQuery, dataBase.GetConnection()))
            {
                command.Parameters.AddWithValue("@requestID", requestID);
                dataBase.OpenConnection();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        actualStatus = reader["requestStatus"].ToString();
                    }
                }
                dataBase.CloseConnection();
            }
            Assert.AreEqual("В процессе", actualStatus, "Статус заявки не обновился в базе данных.");
        }
    }
}