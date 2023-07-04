using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Manager.Models
{
    public class MySQLHelper
    {
        public void MySqlConnector()
        {

        }

        private MySqlConnection GetSqlConnection() {
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "127.0.0.1",
                UserID = "root",
                Password = "mothaiba",
                Database = "staff_management"
            };
            return new MySqlConnection(builder.ConnectionString);
        }

        protected MySqlDataReader GetReader(string query)
        {
            var connection = GetSqlConnection();
            connection.Open();
            var command = connection.CreateCommand();

            command.CommandText = query;
            var reader = command.ExecuteReader(CommandBehavior.CloseConnection);

            return reader;
        }

        

        protected void ExecuteQuery(string query)
        {
            try
            {
                var connection = GetSqlConnection();
                connection.Open();

                // Create new SQL Command to execute query
                var command = new MySqlCommand(query, connection);

                // Execute SQL query
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
    }
}
