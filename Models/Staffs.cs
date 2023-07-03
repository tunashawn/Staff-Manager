using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Manager.Models
{
    public class Staffs
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime dateOfBirth { get; set; }
        public double salary { get; set; }
        public string department { get; set; }
        public string project { get; set; }
        public DateTime creationDate { get; set; }
    }

}
