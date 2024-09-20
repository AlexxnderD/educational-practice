using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerDB
{
    public class Database
    {
        public SqlConnection sqlConnection = new SqlConnection(@"Data Source = (LocalDb)\DBLocal; Initial Catalog=Orgtehnika; Integrated Security=True");

        public void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
        public DataTable LoadTable(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand sqlCommand = new SqlCommand(query, GetConnection());
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw new Exception("Данные не были получены!");
            }
        }
        public void ExecuteQuery(string query)
        {
            try
            {
                OpenConnection();
                using (SqlCommand command = new SqlCommand(query, GetConnection()))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ошибка запроса!");
            }

            finally
            {
                CloseConnection();
            }
        }

        public SqlDataReader GetSqlDataReader(string query)
        {
            SqlDataReader reader = null;
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand(query, GetConnection());
                reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception)
            {
                throw new Exception("Данные не были получены!");
            }
        }
    }
}