using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Manager.Models
{
    public class Department
    {
        public int id { get; set; }
        public String dep_name { get; set; }
        public DateTime creationDate { get; set; }
        public String creationDateString { get => creationDate.ToString("yyyy-MM-dd"); }

        public override string ToString()
        {
            return $"Department: ID = {id}, name = {dep_name}, date = {creationDateString}";
        }
    }
}
