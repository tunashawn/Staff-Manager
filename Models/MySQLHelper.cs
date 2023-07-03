using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
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

        public Staff Login(string username, string password)
        {

            var id = -1;
            try
            {
                var connection = GetSqlConnection();
                connection.Open();
                var command = connection.CreateCommand();

                command.CommandText = $"SELECT u.staff FROM users AS u WHERE u.username = \"{username}\" AND u.`password` = \"{password}\";";
                
                var reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (id != -1)
            {
                return GetStaff(id);
            }

            return null;

        }

        private Staff GetStaff(int id)
        {
            var connection = GetSqlConnection();
            connection.Open();
            var command = connection.CreateCommand();

            // SQL command
            command.CommandText = $"SELECT s.id, s.fullName, s.dateOfBirth, s.salary, d.dep_name, p.pro_name, s.creationDate\r\nFROM staffs AS s, departments AS d, projects AS p \r\nWHERE s.id = {id} AND s.department = d.id AND s.project = p.id;\r\n";

            var reader = command.ExecuteReader(CommandBehavior.CloseConnection); //Close connection asap

            var staff = new Staff();
            while (reader.Read())
            {
                staff.id = reader.GetInt32(0);
                staff.name = reader.GetString(1);
                staff.dateOfBirth = reader.GetDateTime(2);
                staff.salary = reader.GetDouble(3);
                staff.department = reader.GetString(4);
                staff.project = reader.GetString(5);
                staff.creationDate = reader.GetDateTime(6);
            }
            return staff;
        }

        public List<Staff> GetStaffs()
        {
            var staffList = new List<Staff>();
            var connection = GetSqlConnection();
            connection.Open();
            var command = connection.CreateCommand();

            // SQL command
            command.CommandText = "SELECT s.id, s.fullName, s.dateOfBirth, s.salary, d.dep_name, p.pro_name, s.creationDate\r\nFROM staffs AS s, departments AS d, projects AS p \r\nWHERE s.department = d.id AND s.project = p.id;\r\n";
            
            var reader = command.ExecuteReader(CommandBehavior.CloseConnection); //Close connection asap
               
            var temp = new Staff();
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

        public List<Department> GetDepartments()
        {
            var departments = new List<Department>();
            var connection = GetSqlConnection();
            connection.Open();
            var command = connection.CreateCommand();

            command.CommandText = "SELECT * FROM departments;";

            var reader = command.ExecuteReader(CommandBehavior.CloseConnection);

            var temp = new Department();
            while (reader.Read())
            {
                temp.id= reader.GetInt32(0);
                temp.dep_name = reader.GetString(1);
                temp.creationDate= reader.GetDateTime(2);
                departments.Add(temp);
            }
            return departments;
        }

        public List<Project> GetProjects()
        {
            var projects = new List<Project>();
            var connection = GetSqlConnection();
            connection.Open();
            var command = connection.CreateCommand();   

            command.CommandText = "SELECT * FROM projects;";

            var reader = command.ExecuteReader(CommandBehavior.CloseConnection);

            var temp = new Project();
            while (reader.Read())
            {
                temp.id= reader.GetInt32(0);
                temp.pro_name = reader.GetString(1);
                temp.creationDate = reader.GetDateTime(2);
                projects.Add(temp);
            }
            return projects;
        }
    }
}
