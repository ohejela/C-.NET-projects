using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassProject10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(intTextBox.Text);
            }
            catch
            {
                intErrorLabel.Visible = true;
                intErrorLabel.Text = "Not an INT";
            }

            try
            {
                double b = double.Parse(decimalTextBox.Text);
            }
            catch
            {
                decimalErrorLabel.Visible = true;
                decimalErrorLabel.Text = "Not a DOUBLE";
            }

            try
            {
                Boolean c = bool.Parse(booleanTextBox.Text);
            }
            catch
            {
                boolErrorLabel.Visible = true;
                boolErrorLabel.Text = "Not a BOOLEAN";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            intTextBox.Text = "";
            decimalTextBox.Text = "";
            booleanTextBox.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
