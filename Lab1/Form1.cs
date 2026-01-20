using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void helloButton_Click(object sender, EventArgs e)
        {
            helloLabel.Text = "Hello";
        }

        private void goodbyeButton_Click(object sender, EventArgs e)
        {
            goodbyeLabel.Text = "Goodbye";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            helloLabel.Text="Blank";
            goodbyeLabel.Text="Blank";
            MessageBox.Show("Labels have been reset");
        }
    }
}
