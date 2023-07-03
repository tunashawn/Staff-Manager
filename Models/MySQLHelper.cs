using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<Staffs> GetStaffs()
        {
            var staffList = new List<Staffs>();
            var connection = GetSqlConnection();
            connection.Open();
            var command = connection.CreateCommand();

            // SQL command
            command.CommandText = "SELECT s.id, s.fullName, s.dateOfBirth, s.salary, d.dep_name, p.pro_name, s.creationDate\r\nFROM staffs AS s, departments AS d, projects AS p \r\nWHERE s.department = d.id AND s.project = p.id;\r\n";
            
            var reader = command.ExecuteReader(CommandBehavior.CloseConnection); //Close connection asap
               
            var temp = new Staffs();
            while (reader.Read())
            {
                temp.id = reader.GetInt32(0);
                temp.name = reader.GetString(1);
                temp.dateOfBirth = reader.GetDateTime(2);
                temp.salary = reader.GetDouble(3);
                temp.department = reader.GetString(4);
                temp.project = reader.GetString(5);
                temp.creationDate = reader.GetDateTime(6);
                staffList.Add(temp);
            }
            return staffList;
        }
    }
}
