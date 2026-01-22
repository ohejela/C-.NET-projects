using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InclassAssignment15
{
    public partial class Form1 : Form
    {
        int num;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;

            Random rand = new Random();
            num = rand.Next(1, 4);
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                label1.Visible = true;
                label1.Text = "It's a TIE!";
            }
            else if (num == 2)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                label1.Visible = true;
                label1.Text = "You LOSE!";
            }
            else
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                label1.Visible = true;
                label1.Text = "You WIN!";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                pictureBox1.Visible = true;
                pictureBox3.Visible = false;
                label1.Visible = true;
                label1.Text = "You  WIN!";
            }
            else if (num == 2)
            {
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                label1.Visible = true;
                label1.Text = "It's a TIE!";
            }
            else
            {
                pictureBox1.Visible = false;
                pictureBox3.Visible = true;
                label1.Visible = true;
                label1.Text = "You LOSE!";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                label1.Visible = true;
                label1.Text = "You LOSE!";
            }
            else if (num == 2)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                label1.Visible = true;
                label1.Text = "You WIN!";
            }
            else
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                label1.Visible = true;
                label1.Text = "It's a TIE!";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
