using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassProject13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(num1TextBox.Text);
            int num2 = int.Parse(num2TextBox.Text);
            int num3 = int.Parse(num3Textbox.Text);

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    outputLabel.Text = num1.ToString();

                }
                else
                {
                    outputLabel.Text = num3.ToString();
                }
            }
            else if(num2 > num1)
            {
                if (num2 > num3)
                {
                    outputLabel.Text = num2.ToString();
                }
                else
                {
                    outputLabel.Text = num3.ToString();
                }
            }
            else
            {
                outputLabel.Text = num3.ToString();
            }
            
        }
    }
}
