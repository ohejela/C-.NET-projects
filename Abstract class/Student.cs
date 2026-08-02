using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    public class Student :Person
    {
        public string Classification { get; set; }
        public decimal Balance { get; set; }

        public decimal Scholarship { get; set; }

        public override string ID { get; set; }
        public override string GetInfo()
        {
            return $@"{base.GetInfo()}
Classification: {Classification}
Balance Due: {Balance.ToString("C")}";
        }

        public override string GenerateCheck()
        {
            return $@" {(Scholarship - Balance).ToString("C")}";
        }
    }
}
