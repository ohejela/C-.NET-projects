using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    public class Professor : Person
    {
        public string EmployeeID { get; set; }
        public decimal Salary { get; set; }

        public override string ID { get; set; }
        public override string GetInfo()
        {
            return $@"{base.GetInfo()}
Employee ID: {EmployeeID}
Salary: {Salary.ToString("c")}";
        }

        public override string GenerateCheck()
        {
            return $@" {(Salary/12).ToString("C")}";
        }
    }
}
