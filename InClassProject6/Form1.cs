using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassProject6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)

        {
            string fullName = fullNmaeTextBox.Text;
            string lastName = lastNameTextBox.Text;
            outputLabel.Text = fullName + "," + " "+ lastName;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            
            outputLabel.Text = "";
            fullNmaeTextBox.Text = "";
            lastNameTextBox.Text = " ";
        }
    }
}
