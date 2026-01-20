using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassProject7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int num1 = 5;
            int num2 = 4;
            int sum = num1 + num2;

            outputLabel.Text = sum.ToString();
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            int num1 = 5;
            int num2 = 4;
            int sub = num1 - num2;

            outputLabel.Text = sub.ToString();
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            int num1 = 5;
            int num2 = 4;
            int div = num1 / num2;

            outputLabel.Text = div.ToString();
        }

        private void multiButton_Click(object sender, EventArgs e)
        {
            int num1 = 5;
            int num2 = 4;
            int multi = num1 * num2;

            outputLabel.Text = multi.ToString();
        }
    }
    
}
