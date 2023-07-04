using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Manager.Models
{
    public class Project
    {
        public int id { get; set; }
        public String pro_name { get; set; }
        public DateTime creationDate { get; set; }
        public String creationDateString { get => creationDate.ToString("yyyy-MM-dd"); }

        public override string ToString()
        {
            return $"Department: ID = {id}, name = {pro_name}, date = {creationDateString}";
        }
    }
}
