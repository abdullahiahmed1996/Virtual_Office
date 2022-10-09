using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Office
{
    public class Employee : Person
    {
        public decimal Salary { get; set; }
        public string Bio { get; set; }
        public string Department { get; set; }

        public override string GetInfo()
        {
            return $"{FirstName} {LastName} - {Department}";
        }

        public override string PrintBio()
        {
            return "";
        }
    }
}
