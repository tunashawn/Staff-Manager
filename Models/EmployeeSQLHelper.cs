using MySqlConnector;
using System;
using System.Collections.Generic;

namespace Employee_Manager.Models
{
    public class EmployeeSQLHelper : MySQLHelper
    {
        public EmployeeSQLHelper() { }
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
            }
            catch (Exception ex)
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
            var employee = new Employee
            {
                id = reader.GetInt32(0),
                name = reader.GetString(1),
                dateOfBirth = reader.GetDateTime(2),
                salary = reader.GetDouble(3),
                department = reader.GetValue(4).ToString(),
                project = reader.GetValue(5).ToString(),
                creationDate = reader.GetDateTime(6)
            };

            return employee;
        }

        public Employee GetEmployee(int id)
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
        public List<Employee> GetEmployees(string query = "SELECT " +
                                    "s.id, s.fullName, s.dateOfBirth, " +
                                    "s.salary, d.dep_name, p.pro_name, s.creationDate " +
                                    "FROM staffs AS s, departments AS d, projects AS p " +
                                    "WHERE s.department = d.id AND s.project = p.id;")
        {
            var reader = GetReader(query);

            var staffList = new List<Employee>();

            while (reader.Read())
            {
                var emp = EmployeeReader(reader);
                staffList.Add(emp);
            }
            return staffList;
        }

        

        public List<Project> GetProjects()
        {
            var projects = new List<Project>();

            var reader = GetReader("SELECT * FROM projects;");

            while (reader.Read())
            {
                var temp = new Project();
                temp.id = reader.GetInt32(0);
                temp.pro_name = reader.GetString(1);
                temp.creationDate = reader.GetDateTime(2);
                projects.Add(temp);
            }
            return projects;
        }


        public void AddNewEmployee(Employee employee)
        {
            ExecuteQuery($"INSERT INTO staffs VALUES(" +
                            $"{employee.id}, " +
                            $"\'{employee.name}\', " +
                            $"\'{employee.dateOfBirthString}\', " +
                            $"{employee.salary}, " +
                            $"{employee.department}, " +
                            $"{employee.project}, " +
                            $"\'{employee.creationDateString}\');");
        }

        public void DeleteStaff(string employee_id)
        {
            ExecuteQuery($"DELETE FROM staffs WHERE staffs.id = \'{employee_id}\';");
        }
        public void EditEmployee(Employee employee)
        {
            Console.WriteLine(employee.ToString());
            ExecuteQuery($"UPDATE staffs SET " +
                            $"staffs.fullName =  \'{employee.name}\', " +
                            $"staffs.dateOfBirth = \'{employee.dateOfBirthString}\', " +
                            $"staffs.salary = {employee.salary}, " +
                            $"staffs.department = {employee.department}, " +
                            $"staffs.project = {employee.project}, " +
                            $"staffs.creationDate = \'{employee.creationDateString}\'" +
                            $"WHERE staffs.id = {employee.id};");
        }

        public List<Employee> FindEmployee(string emp_name)
        {
            var query = $"SELECT * FROM staffs WHERE staffs.fullName LIKE \'%{emp_name}%\';";
            return GetEmployees(query);
        }
    }
}
