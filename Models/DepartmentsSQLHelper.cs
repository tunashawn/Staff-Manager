using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Manager.Models
{
    public class DepartmentsSQLHelper : MySQLHelper
    {
        public DepartmentsSQLHelper() { }

        public List<Department> GetDepartments(string query = "SELECT * FROM departments;")
        {
            var reader = GetReader(query);

            var departments = new List<Department>();

            while (reader.Read())
            {
                var temp = new Department();
                temp.id = reader.GetInt32(0);
                temp.dep_name = reader.GetString(1);
                temp.creationDate = reader.GetDateTime(2);
                departments.Add(temp);
            }
            return departments;
        }

        public List<Department> FindDepartments(string searchKey)
        {
            var query = $"SELECT * FROM departments WHERE departments.dep_name LIKE \'%{searchKey}%\';";
            return GetDepartments(query);
        }

        public void AddDepartment(Department d)
        {
            var query = $"INSERT INTO departments VALUES ({d.id}, \'{d.dep_name}\', \'{d.creationDateString}\');";
            ExecuteQuery(query);
        }

        public void RemoveDepartment(string id)
        {
            var query = $"DELETE FROM departments WHERE departments.id = \'{id}\'";
            ExecuteQuery(query);
        }

        public void EditDepartment(Department d)
        {
            var query = $"UPDATE departments SET " +
                $"departments.dep_name = \'{d.dep_name}\'," +
                $"departments.creationDate = \'{d.creationDateString}\' " +
                $"WHERE departments.id = \'{d.id}\';";
            ExecuteQuery(query);
        }
    }
}
