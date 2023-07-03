using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Manager.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime dateOfBirth { get; set; }
        public String dateOfBirdString { get => dateOfBirth.ToString("yyyy-MM-dd"); }
        public double salary { get; set; }
        public string department { get; set; }
        public string project { get; set; }
        public DateTime creationDate { get; set; }
        public String creationDateString { get => creationDate.ToString("yyyy-MM-dd"); }

        public string ToString()
        {
            return $"\nEmployee Information:" +
                $"\nID = {this.id}" +
                $"\nName = {name}" +
                $"\nDate of Birth = {dateOfBirth.ToString("yyyy-MM-dd")}" +
                $"\nSalary = {salary}" +
                $"\nDepartment = {department}" +
                $"\nProject = {project}" +
                $"\nCreation Date = {creationDate}\n";
        }
    }

}
