using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    public  abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public virtual string GetInfo()
        {
            return $@"Full Name: {FirstName} {LastName}
Address: {Address}";
        }

        public abstract string ID { get; set; }

        public abstract string GenerateCheck();
    }
}
