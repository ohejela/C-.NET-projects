using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Test2
{
    public class Customer:Person
    {
        public double Purchases { get; set; }
        public override string GetInfo()
        {
            return $@"{FirstName} {LastName} : {Purchases.ToString("C")}";
        } 
    }
}
