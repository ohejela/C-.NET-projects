using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    internal class calc
    {
        public double Number1 {get; set;}
        public double Number2 { get; set;  }
        public double Result { get; set; }

        public void Add()
        {
            Result = Number1 + Number2;
        }

        public void Subtract()
        {
            Result = Number1 - Number2; 
        }

        public void Multiply()
        {
            Result = Number1 * Number2;
        }

        public void Divide()
        {if (Number2 == 0)
            { 
                MessageBox.Show("Error!!");
            
            }

            else
            {
                Result = Number1/Number2;
            }
        }
        public void sqrt()
        {
            if (Result > 0)
            {
                Result = Math.Sqrt(Result);
            }
        }
        public void Calculator(double num1,  double num2, double num3)
        {
            Number1 = num1;
            Number2 = num2;
            Result = num3;
        }
    }
}
