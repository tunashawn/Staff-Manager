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

        private MySqlDataReader GetReader(string querry)
        {
            var connection = GetSqlConnection();
            connection.Open();
            var command = connection.CreateCommand();

            command.CommandText = querry;
            var reader = command.ExecuteReader(CommandBehavior.CloseConnection);

            return reader;

        }

        public Employee Login(string username, string password)
        {
            var id = -1;
            try
            {
                var reader = GetReader($"SELECT u.employee FROM users AS u WHERE u.username = \"{username}\" AND u.`password` = \"{password}\";");

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
                return GetEmployee(id);
            }

            return null;

        }

        private Employee EmployeeReader(MySqlDataReader reader)
        {
            var employee = new Employee();

            employee.id = reader.GetInt32(0);
            employee.name = reader.GetString(1);
            employee.dateOfBirth = reader.GetDateTime(2);
            employee.salary = reader.GetDouble(3);
            employee.department = reader.GetString(4);
            employee.project = reader.GetString(5);
            employee.creationDate = reader.GetDateTime(6);
            
            return employee;
        }

        private Employee GetEmployee(int id)
        {
            var reader = GetReader($"SELECT s.id, s.fullname, s.dateofbirth, " +
                                    $"s.salary, d.dep_name, p.pro_name, s.creationdate " +
                                    $"FROM staffs as s, departments as d, projects as p " +
                                    $"WHERE s.id = {id} and s.department = d.id and s.project = p.id;");

            var employee = new Employee();

            reader.Read();
            
            employee = EmployeeReader(reader);
            
            return employee;
        }

        // GET ALL EMPLOYEES IN DEFAULT
        public List<Employee> GetEmployees(string querry = "SELECT " +
                                    "s.id, s.fullName, s.dateOfBirth, " +
                                    "s.salary, d.dep_name, p.pro_name, s.creationDate " +
                                    "FROM staffs AS s, departments AS d, projects AS p " +
                                    "WHERE s.department = d.id AND s.project = p.id;")
        {
            var reader = GetReader(querry);
               
            var staffList = new List<Employee>();
            
            while (reader.Read())
            {
                var emp = EmployeeReader(reader);
                staffList.Add(emp);
            }
            return staffList;
        }

        public List<Department> GetDepartments()
        {
            var reader = GetReader("SELECT * FROM departments;"); 

            var departments = new List<Department>();

            while (reader.Read())
            {
                var temp = new Department();
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

            var reader = GetReader("SELECT * FROM projects;");

            while (reader.Read())
            {
                var temp = new Project();
                temp.id= reader.GetInt32(0);
                temp.pro_name = reader.GetString(1);
                temp.creationDate = reader.GetDateTime(2);
                projects.Add(temp);
            }
            return projects;
        }


        public void AddNewStaff(Employee employee)
        {
            ExecuteQuerry($"INSERT INTO staffs VALUES(" +
                            $"{employee.id}, " +
                            $"\'{employee.name}\', " +
                            $"\'{employee.dateOfBirdString}\', " +
                            $"{employee.salary}, " +
                            $"{employee.department}, " +
                            $"{employee.project}, " +
                            $"\'{employee.creationDateString}\');");
        }

        public void DeleteStaff(Employee employee)
        {
            ExecuteQuerry($"DELETE FROM staffs WHERE staffs.id = \'{employee.id}\';");
        }
        public void EditStaff(Employee employee)
        {
            ExecuteQuerry($"UPDATE staffs SET" +
                            $"employee.name = \'{employee.name}\', " +
                            $"employee.dateOfBird = \'{employee.dateOfBirdString}\', " +
                            $"employee.salary = {employee.salary}, " +
                            $"employee.department = {employee.department}, " +
                            $"employee.project = {employee.project}, " +
                            $"employee.creationDate = \'{employee.creationDateString}\'" +
                            $"WHERE staffs.id = {employee.id};");
        }

        public List<Employee> FindStaff(string emp_name)
        {
            return GetEmployees($"SELECT * FROM staffs WHERE staffs.fullName LIKE '%{emp_name}%';");
        }

        private void ExecuteQuerry(string querry)
        {
            try
            {
                var connection = GetSqlConnection();
                connection.Open();

                // Create new SQL Command to execute querry
                var command = new MySqlCommand(querry, connection);

                // Execute SQL querry
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
