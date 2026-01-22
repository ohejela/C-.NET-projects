using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_3
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        private PictureBox firstCard = null;
        private PictureBox secondCard = null;
        int score = 0;
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.back_of_a_deck;
            pictureBox2.Image = Properties.Resources.back_of_a_deck;
            pictureBox3.Image = Properties.Resources.back_of_a_deck;
            pictureBox4.Image = Properties.Resources.back_of_a_deck;
            pictureBox5.Image = Properties.Resources.back_of_a_deck;
            pictureBox6.Image = Properties.Resources.back_of_a_deck;

            pictureBox1.Tag = 1;
            pictureBox2.Tag = 2;
            pictureBox3.Tag = 3;
            pictureBox4.Tag = 1;
            pictureBox5.Tag = 2;
            pictureBox6.Tag = 3;

            flipTimer.Start();
        }

        private void pictureBox(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;

            int Tag = (int)p.Tag;

            switch (Tag)
            {
                case 1:
                    p.Image = Properties.Resources.orange;
                    break;
                case 2:
                   p.Image = Properties.Resources.grapes;
                    break;
                case 3:
                    p.Image = Properties.Resources.lemon;
                    break;
            }

            if(p== firstCard)
            {
                return;
            }
            if(firstCard == null)
            {
                firstCard = p;
                return;
            }
            if(secondCard == null)
            {
                secondCard = p;
                flipTimer.Start();
                return;
            }

        }

        private void flipTimer_Tick(object sender, EventArgs e)
        {
            
            if (firstCard == null || secondCard == null)
                return;

            
            if (firstCard.Tag.ToString() == secondCard.Tag.ToString())
            {
              
                firstCard = null;
                secondCard = null;
                score+=1;
                scoreInputLabel.Text = score.ToString();
                count++;
               
            }
            else
            {
                flipTimer.Stop();
              
                firstCard.Image = Properties.Resources.back_of_a_deck;
                secondCard.Image = Properties.Resources.back_of_a_deck;

                
                firstCard = null;
                secondCard = null;
                score-=1;
                scoreInputLabel.Text = score.ToString();
            }
            flipTimer.Start();

            if (count == 3)
            {
                MessageBox.Show("Congratulations! You matched all the cards!.\n Click the Reset Button to restart.");

            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.back_of_a_deck;
            pictureBox2.Image = Properties.Resources.back_of_a_deck;
            pictureBox3.Image = Properties.Resources.back_of_a_deck;
            pictureBox4.Image = Properties.Resources.back_of_a_deck;
            pictureBox5.Image = Properties.Resources.back_of_a_deck;
            pictureBox6.Image = Properties.Resources.back_of_a_deck;
            scoreInputLabel.Text = "";
        
            int Tag1 = rand.Next(1, 6);
            shuffle(Tag1);
            count = 0;

        }

        private void shuffle(int Tag1)
        {
            switch (Tag1)
            {
                case 1:
                    pictureBox1.Tag = 2;
                    pictureBox2.Tag = 3;
                    pictureBox3.Tag = 1;
                    pictureBox4.Tag = 2;
                    pictureBox5.Tag = 3;
                    pictureBox6.Tag = 1;
                    break;
                case 2:
                    pictureBox1.Tag = 3;
                    pictureBox2.Tag = 1;
                    pictureBox3.Tag = 2;
                    pictureBox4.Tag = 3;
                    pictureBox5.Tag = 1;
                    pictureBox6.Tag = 2;
                    break;
                case 3:
                    pictureBox1.Tag = 1;
                    pictureBox2.Tag = 1;
                    pictureBox3.Tag = 3;
                    pictureBox4.Tag = 3;
                    pictureBox5.Tag = 2;
                    pictureBox6.Tag = 2;
                    break;
                case 4:
                    pictureBox1.Tag = 1;
                    pictureBox2.Tag = 3;
                    pictureBox3.Tag = 1;
                    pictureBox4.Tag = 2;
                    pictureBox5.Tag = 3;
                    pictureBox6.Tag = 2;
                    break;
                case 5:
                    pictureBox1.Tag = 2;
                    pictureBox2.Tag = 2;
                    pictureBox3.Tag = 3;
                    pictureBox4.Tag = 3;
                    pictureBox5.Tag = 1;
                    pictureBox6.Tag = 1;
                    break;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveScore saveScore = new SaveScore(score);
            
            saveScore.ShowDialog();

        }

        private void leadButton_Click(object sender, EventArgs e)
        {
            LeaderBoard leaderBoard = new LeaderBoard();
            leaderBoard.ShowDialog();
        }
    }
}
