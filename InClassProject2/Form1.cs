using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassProject2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void helloLabel_Click(object sender, EventArgs e)
        {
            helloLabel.Text = " ";
            goodByeLabel.Text = "Goodbye";
        }

        private void goodByeLabel_Click(object sender, EventArgs e)
        {
            goodByeLabel.Text = " ";
            helloLabel.Text = "Hello";
        }
    }
}
