using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassAssignment16
{
    public partial class Form1 : Form
    {
        double beach = 500, mountain = 600, city = 700;
        double snorkeling = 100, hiking = 80, spa = 150, night = 120;

        
        public Form1()
        {
            InitializeComponent();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
        }

       

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = true;
        }

        private void planButton_Click(object sender, EventArgs e)
        {
            int days;
            double total = 0;
            if (!int.TryParse(outputTextBox.Text, out days) || days < 3 || days >14)
            {
                MessageBox.Show("Please enter a valid number of days between 3 and 14.");
                
            }
            if (radioButton1.Checked)
            {
                total = beach * days;
            }
            else if (radioButton2.Checked)
            {
                total = mountain * days;
            }
            else if (radioButton3.Checked)
            {
                total = city * days;
            }
            else
            {
                MessageBox.Show("Please select a destination.");
                return;
            }

            if (checkBox1.Checked)
            {
                total += snorkeling;
            }
            if (checkBox2.Checked)
            {
                total += hiking;
            }
            if (checkBox3.Checked)
            {
                total += spa;
            }
            if (checkBox4.Checked)
            {
                total += night;
            }
            
            totalLabel.Text = "Total Cost: $" + total.ToString("F2");


        }
    }
}
