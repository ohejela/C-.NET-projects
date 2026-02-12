using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Manipulation_check_email_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string email = inputTextBox.Text;
            bool valid = false;
            int index1 = email.IndexOf("@");
            int index2 = email.IndexOf(".");
            string a = email.Substring(0,index1);
            string b = email.Substring(index1 + 1, 1);
            
            string d = email.Substring(index2 + 1);

            if (email.Contains("@"))
            {
                valid = true;
            }
            else
            {
                valid = false;
            }
            if (email.Contains("."))
            {
                valid = true;
            }
            else
            {
                valid = false;
            }
            if(index1 > index2)
            {
                valid = true;
            }
            else
            {
                valid = false;
            }

            if (a.Length >= 1 && b.Length >= 1)
            {
                valid = true;
            }
            else
            {
                valid = false;
            }
            if ( d.Length >= 3)
            {
                valid = true;
            }
            else
            {
                valid = false;
            }
            if (valid)
            {
                outputLabel.Text = "Valid Email Address";
            }
            else { outputLabel.Text = "Invalid Email Address"; }



        }
    }
}
