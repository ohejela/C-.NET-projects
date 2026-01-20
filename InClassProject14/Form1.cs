using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassProject14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(inputTextBox1.Text);
            int num2 = int.Parse(inputTextBox2.Text);

            MessageBox.Show("You entered " + num1 + " and " + num2);

            if (num1 >= 40 && num1 <= 50)
            {
                ouputLabel1.Text = "Good job!!";
            }
            else
            {
                ouputLabel1.Text = "Invalid number :(";
            }

            if (num2 < 40 || num2 > 50)
            {
                outputLabel2.Text = "Good job!!";
            }
            else
            {
                outputLabel2.Text = "Invalid number :(";
            }
        }
    }
}
