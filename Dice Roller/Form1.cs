using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassProject22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random(); 
            int dice1 = rand.Next(1, 7);
            int dice2 = rand.Next(1, 7);

            showDice(dice1, dice2);

        }

        private void showDice(int dice1, int dice2)
        {
            switch (dice1)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.Dice1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.Dice2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.Dice3;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.Dice4;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.Dice5;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.Dice6;
                    break;
            }

            switch(dice2)
            {
                case 1:
                    pictureBox2.Image = Properties.Resources.Dice1;
                    break;
                case 2:
                    pictureBox2.Image = Properties.Resources.Dice2;
                    break;
                case 3:
                    pictureBox2.Image = Properties.Resources.Dice3;
                    break;
                case 4:
                    pictureBox2.Image = Properties.Resources.Dice4;
                    break;
                case 5:
                    pictureBox2.Image = Properties.Resources.Dice5;
                    break;
                case 6:
                    pictureBox2.Image = Properties.Resources.Dice6;
                    break;
            }

        }  
    }
}
