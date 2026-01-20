using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassProject20
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            CreateAccountForm CAForm = new CreateAccountForm();
            CAForm.Show();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            StreamReader infile;
            if (File.Exists("userInfo.txt"))
            {
                infile = new StreamReader("userInfo.txt");

                bool success = false;

                while (!infile.EndOfStream)
                {
                    string line = infile.ReadLine();
                    int commaIndex = line.IndexOf(',');
                    string fileUsername = line.Substring(0, commaIndex);
                    string filePassword = line.Substring(commaIndex + 1);

                    if (username == fileUsername && password == filePassword)
                    {
                        success = true;
                    }
        
                }

                if (success == true)
                {
                    MessageBox.Show("Login successful");
                }
                else
                {
                    MessageBox.Show("Login Failed, Please Try Again");
                }
            }
            else
            {
                MessageBox.Show("No accounts found. Please create an account first.");
                
            }




        }
    }
}
