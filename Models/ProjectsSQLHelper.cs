using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Manager.Models
{
    public class ProjectsSQLHelper : MySQLHelper
    {
        public ProjectsSQLHelper() { }

        public List<Project> GetProjects(string query = "SELECT * FROM projects;")
        {
            var reader = GetReader(query);

            var projects = new List<Project>();

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

        public List<Project> FindProjects(string searchKey)
        {
            var query = $"SELECT * FROM projects WHERE projects.pro_name LIKE \'%{searchKey}%\';";
            Console.WriteLine(query);
            return GetProjects(query);
        }

        public void AddProject(Project project)
        {
            var query = $"INSERT INTO projects VALUES ({project.id}, \'{project.pro_name}\', \'{project.creationDateString}\');";
            ExecuteQuery(query);
        }

        public void RemoveProject(string id)
        {
            var query = $"DELETE FROM projects WHERE projects.id = \'{id}\'";
            ExecuteQuery(query);
        }

        public void EditProject(Project project)
        {
            var query = $"UPDATE projects SET " +
                $"projects.pro_name = \'{project.pro_name}\'," +
                $"projects.creationDate = \'{project.creationDateString}\' " +
                $"WHERE projects.id = \'{project.id}\';";
            ExecuteQuery(query);
        }

    }
}
