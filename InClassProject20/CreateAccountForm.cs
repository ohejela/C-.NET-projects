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
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            try
            {
                StreamWriter outfile;

                if (File.Exists("userInfo.txt"))
                {
                    outfile = File.AppendText("userInfo.txt");
                    outfile.WriteLine(userName +"," + password);
                 

                }
                else
                {
                    outfile = File.CreateText("userInfo.txt");
                }

                outfile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            userNameTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
