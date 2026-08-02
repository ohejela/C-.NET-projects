using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_and_Extension
{
    public class AnotherClass : Interface1
    {
        public  string Name { get; set; }
        

        public void someMethod(string name)
        {
            throw new NotImplementedException();
        }
    }
}
