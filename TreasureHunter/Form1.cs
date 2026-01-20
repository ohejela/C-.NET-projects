using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreasureHunter
{
    public partial class Form1 : Form
    {
        int number = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            number = random.Next(1, 6);
        }

        private void ground1PictureBox_Click(object sender, EventArgs e)
        {
            if(int.Parse(ground1PictureBox.Tag.ToString()) == number)
            {
                ground1PictureBox.Image = Properties.Resources.treasure;
            }

            if (int.Parse(ground1PictureBox.Tag.ToString()) != number) 
            {
                ground1PictureBox.Image = Properties.Resources.red_x;
            }

        }

        private void ground2PictureBox_Click(object sender, EventArgs e)
        {
            if (int.Parse(ground2PictureBox.Tag.ToString() = number)
            {
                ground2PictureBox.Image = Properties.Resources.treasure;
            }

            if ((int)ground2PictureBox.Tag != number) 
            {
                ground2PictureBox.Image = Properties.Resources.red_x;
            }
        }

        private void ground3PictureBox_Click(object sender, EventArgs e)
        {
            if ((int)ground3PictureBox.Tag == number)
            {
                ground3PictureBox.Image = Properties.Resources.treasure;
            }

            if ((int)ground3PictureBox.Tag != number) ;
            {
                ground3PictureBox.Image = Properties.Resources.red_x;
            }
        }

        private void ground4PictureBox_Click(object sender, EventArgs e)
        {
            if ((int)ground4PictureBox.Tag == number)
            {
                ground4PictureBox.Image = Properties.Resources.treasure;
            }

            if ((int)ground4PictureBox.Tag != number) ;
            {
                ground4PictureBox.Image = Properties.Resources.red_x;
            }
        }

        private void ground5PictureBox_Click(object sender, EventArgs e)
        {
            if ((int)ground5PictureBox.Tag == number)
            {
                ground5PictureBox.Image = Properties.Resources.treasure;
            }

            if ((int)ground5PictureBox.Tag != number) ;
            {
                ground5PictureBox.Image = Properties.Resources.red_x;
            }
        }
    }
}
