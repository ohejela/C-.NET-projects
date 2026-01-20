using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassProject4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            card1Back.Image = Properties.Resources.Card_Back;
            card1Front.Image = Properties.Resources.Three_of_Clubs;

            card2Back.Image = Properties.Resources.Card_Back;
            card2Front.Image = Properties.Resources.Three_of_Clubs;

            card3Back.Image = Properties.Resources.Card_Back;
            card3Front.Image = Properties.Resources.Three_of_Clubs;

            card4Back.Image = Properties.Resources.Card_Back;
            card4Front.Image = Properties.Resources.Three_of_Clubs;

            card5Back.Image = Properties.Resources.Card_Back;
            card5Front.Image = Properties.Resources.Three_of_Clubs;

            card6Back.Image = Properties.Resources.Card_Back; 
            card6Front.Image = Properties.Resources.Three_of_Clubs;

            card1Front.Visible = false;
            card2Front.Visible = false;
            card3Front.Visible = false;
            card4Front.Visible = false;
            card5Front.Visible = false;
            card6Front.Visible = false;

            card1Back.Enabled = false;
            card2Back.Enabled = false;
            card3Back.Enabled = false;
            card4Back.Enabled = false;
            card5Back.Enabled = false;
            card6Back.Enabled = false;

        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            card1Back.Enabled = true;
            card2Back.Enabled = true;
            card3Back.Enabled = true;
            card4Back.Enabled = true;
            card5Back.Enabled = true;
            card6Back.Enabled = true;

            card1Front.Image = Properties.Resources.Queen_of_Hearts;
        }

        private void card1Back_Click(object sender, EventArgs e)
        {
            card1Back.Visible = false;
            card1Front.Visible = true;
        }

        private void card2Back_Click(object sender, EventArgs e)
        {
            card2Back.Visible = false;
            card2Front.Visible = true;
        }

        private void card3Back_Click(object sender, EventArgs e)
        {
            card3Back.Visible = false;
            card3Front.Visible = true;
        }

        private void card4Back_Click(object sender, EventArgs e)
        {
            card4Back.Visible = false;
            card4Front.Visible = true;
        }

        private void card5Back_Click(object sender, EventArgs e)
        {
            card5Back.Visible = false;
            card5Front.Visible = true;
        }

        private void card6Back_Click(object sender, EventArgs e)
        {
            card6Back.Visible = false;
            card6Front.Visible = true;
        }

        private void moveQueen1Button_Click(object sender, EventArgs e)
        {
            card1Front.Visible = false;
            card2Front.Visible = false;
            card3Front.Visible = false;
            card4Front.Visible = false;
            card5Front.Visible = false;
            card6Front.Visible = false;

            card1Back.Visible = true;
            card2Back.Visible = true;
            card3Back.Visible = true;
            card4Back.Visible = true;
            card5Back.Visible = true;
            card6Back.Visible = true;

            card6Front.Image = Properties.Resources.Queen_of_Hearts;
        }

        private void moveQueen2Button_Click(object sender, EventArgs e)
        {
            card1Front.Visible = false;
            card2Front.Visible = false;
            card3Front.Visible = false;
            card4Front.Visible = false;
            card5Front.Visible = false;
            card6Front.Visible = false;

            card1Back.Visible = true;
            card2Back.Visible = true;
            card3Back.Visible = true;
            card4Back.Visible = true;
            card5Back.Visible = true;
            card6Back.Visible = true;

            card3Front.Image = Properties.Resources.Queen_of_Hearts;
        }

        private void moveQueen3Button_Click(object sender, EventArgs e)
        {
            card1Front.Visible = false;
            card2Front.Visible = false;
            card3Front.Visible = false;
            card4Front.Visible = false;
            card5Front.Visible = false;
            card6Front.Visible = false;

            card1Back.Visible = true;
            card2Back.Visible = true;
            card3Back.Visible = true;
            card4Back.Visible = true;
            card5Back.Visible = true;
            card6Back.Visible = true;

            card5Front.Image = Properties.Resources.Queen_of_Hearts;
        }
    }
}
