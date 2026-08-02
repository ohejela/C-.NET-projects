using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            bool valid = false;
            User p = new User();

            Random rand = new Random();

            int generateID = rand.Next(1, 100);

            Session.ID = generateID;

            
            p.UserName = userNameTextBox.Text;
            p.Password = passwordTextBox.Text;

            Session.User = p;

            if (Session.ID != 0)
            {
                MessageBox.Show("Valid Session");
                valid = true;
            }
            
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            ValidSession val = new ValidSession();
            val.ShowDialog();
        }
    }
}
