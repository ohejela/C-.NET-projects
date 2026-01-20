using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassProject3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void p1Button_Click(object sender, EventArgs e)
        {
            p1Button.BackColor = Color.Blue;
            pictureBox1.Image = Properties.Resources.diamonds_ace_card;
            pictureBox2.Image = Properties.Resources.back_of_a_deck;
            pictureBox3.Image = Properties.Resources.back_of_a_deck;    
            pictureBox4.Image = Properties.Resources.back_of_a_deck;
        }

        private void p2Button_Click(object sender, EventArgs e)
        {
            p2Button.BackColor = Color.Blue;
            pictureBox1.Image = Properties.Resources.back_of_a_deck;
            pictureBox2.Image = Properties.Resources.diamonds_ace_card;
            pictureBox3.Image = Properties.Resources.back_of_a_deck;
            pictureBox4.Image = Properties.Resources.back_of_a_deck;

        }

        private void p3Button_Click(object sender, EventArgs e)
        {
            p3Button.BackColor = Color.Blue;
            pictureBox1.Image = Properties.Resources.back_of_a_deck;
            pictureBox2.Image = Properties.Resources.back_of_a_deck;
            pictureBox3.Image = Properties.Resources.diamonds_ace_card;
            pictureBox4.Image = Properties.Resources.back_of_a_deck;
        }

        private void p4Button_Click(object sender, EventArgs e)
        {
            p4Button.BackColor = Color.Blue;
            pictureBox1.Image = Properties.Resources.back_of_a_deck;
            pictureBox2.Image = Properties.Resources.back_of_a_deck;
            pictureBox3.Image = Properties.Resources.back_of_a_deck;
            pictureBox4.Image = Properties.Resources.diamonds_ace_card;
        }
    }
}
