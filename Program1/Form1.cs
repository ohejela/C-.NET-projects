using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class Form1 : Form
    {
        int timeLeft = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeLeft = 10;
            timerLabel.Text = timeLeft.ToString();
            timer1.Start();
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            timerLabel.Text = timeLeft.ToString();

            if (timeLeft <= 0)
            {
                timer1.Stop();
                MessageBox.Show("Time's up! Turn passed to the other player.");
                if (playerLabel.Text == "Player 1's Turn")
                {
                    playerLabel.Text = "Player 2's Turn";
                }
                else
                {
                    playerLabel.Text = "Player 1's Turn";
                }
                timeLeft = 10;
                timer1.Start();
            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(playerLabel.Text == "Player 1's Turn")
            {
                pictureBox1.Image = Properties.Resources.x;
                pictureBox1.Enabled= false;
                playerLabel.Text = "Player 2's Turn";
                pictureBox1.Tag= "X";
            }
            else
            {
                pictureBox1.Image = Properties.Resources.o;
                pictureBox1.Enabled = false;
                playerLabel.Text = "Player 1's Turn";
                pictureBox1.Tag = "O";
            }

            timer1.Stop();
            timeLeft = 10;
            timerLabel.Text = timeLeft.ToString();
            timer1.Start();

            if (CheckForWinner("X"))
            {
                timer1.Stop();
                MessageBox.Show("Player 1 Wins!");
                clearButton.PerformClick();
            }
            else if (CheckForWinner("O"))
            {
                timer1.Stop();
                MessageBox.Show("Player 2 Wins!");
                clearButton.PerformClick();
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (playerLabel.Text == "Player 1's Turn")
            {
                pictureBox2.Image = Properties.Resources.x;
                pictureBox2.Enabled = false;
                pictureBox2.Tag = "X";
                playerLabel.Text = "Player 2's Turn";
            }
            else
            {
                pictureBox2.Image = Properties.Resources.o;
                pictureBox2.Enabled = false;
                pictureBox2.Tag = "O";
                playerLabel.Text = "Player 1's Turn";
            }

            timer1.Stop();
            timeLeft = 10;
            timerLabel.Text = timeLeft.ToString();
            timer1.Start();

            if (CheckForWinner("X"))
            {
                timer1.Stop();
                MessageBox.Show("Player 1 Wins!");
                clearButton.PerformClick();
            }
            else if (CheckForWinner("O"))
            {
                timer1.Stop();
                MessageBox.Show("Player 2 Wins!");
                clearButton.PerformClick();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (playerLabel.Text == "Player 1's Turn")
            {
                pictureBox3.Image = Properties.Resources.x;
                pictureBox3.Enabled = false;
                pictureBox3.Tag = "X";
                playerLabel.Text = "Player 2's Turn";
            }
            else
            {
                pictureBox3.Image = Properties.Resources.o;
                pictureBox3.Enabled = false;
                pictureBox3.Tag = "O";
                playerLabel.Text = "Player 1's Turn";
            }

            timer1.Stop();
            timeLeft = 10;
            timerLabel.Text = timeLeft.ToString();
            timer1.Start();

            if (CheckForWinner("X"))
            {
                timer1.Stop();
                MessageBox.Show("Player 1 Wins!");
                clearButton.PerformClick();
            }
            else if (CheckForWinner("O"))
            {
                timer1.Stop();
                MessageBox.Show("Player 2 Wins!");
                clearButton.PerformClick();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (playerLabel.Text == "Player 1's Turn")
            {
                pictureBox4.Image = Properties.Resources.x;
                pictureBox4.Enabled = false;
                pictureBox4.Tag = "X";
                playerLabel.Text = "Player 2's Turn";
            }
            else
            {
                pictureBox4.Image = Properties.Resources.o;
                pictureBox4.Enabled = false;
                pictureBox4.Tag = "O";
                playerLabel.Text = "Player 1's Turn";
            }

            timer1.Stop();
            timeLeft = 10;
            timerLabel.Text = timeLeft.ToString();
            timer1.Start();

            if (CheckForWinner("X"))
            {
                timer1.Stop();
                MessageBox.Show("Player 1 Wins!");
                clearButton.PerformClick();
            }
            else if (CheckForWinner("O"))
            {
                timer1.Stop();
                MessageBox.Show("Player 2 Wins!");
                clearButton.PerformClick();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (playerLabel.Text == "Player 1's Turn")
            {
                pictureBox5.Image = Properties.Resources.x;
                pictureBox5.Enabled = false;
                pictureBox5.Tag = "X";
                playerLabel.Text = "Player 2's Turn";
            }
            else
            {
                pictureBox5.Image = Properties.Resources.o;
                pictureBox5.Enabled = false;
                pictureBox5.Tag = "O";
                playerLabel.Text = "Player 1's Turn";
            }

            timer1.Stop();
            timeLeft = 10;
            timerLabel.Text = timeLeft.ToString();
            timer1.Start();

            if (CheckForWinner("X"))
            {
                timer1.Stop();
                MessageBox.Show("Player 1 Wins!");
                clearButton.PerformClick();
            }
            else if (CheckForWinner("O"))
            {
                timer1.Stop();
                MessageBox.Show("Player 2 Wins!");
                clearButton.PerformClick();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (playerLabel.Text == "Player 1's Turn")
            {
                pictureBox6.Image = Properties.Resources.x;
                pictureBox6.Enabled = false;
                pictureBox6.Tag = "X";
                playerLabel.Text = "Player 2's Turn";
            }
            else
            {
                pictureBox6.Image = Properties.Resources.o;
                pictureBox6.Enabled = false;
                pictureBox6.Tag = "O";  
                playerLabel.Text = "Player 1's Turn";
            }

            timer1.Stop();
            timeLeft = 10;
            timerLabel.Text = timeLeft.ToString();
            timer1.Start();

            if (CheckForWinner("X"))
            {
                timer1.Stop();
                MessageBox.Show("Player 1 Wins!");
                clearButton.PerformClick();
            }
            else if (CheckForWinner("O"))
            {
                timer1.Stop();
                MessageBox.Show("Player 2 Wins!");
                clearButton.PerformClick();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (playerLabel.Text == "Player 1's Turn")
            {
                pictureBox7.Image = Properties.Resources.x;
                pictureBox7.Enabled = false;
                pictureBox7.Tag = "X";
                playerLabel.Text = "Player 2's Turn";
            }
            else
            {
                pictureBox7.Image = Properties.Resources.o;
                pictureBox7.Tag = "O";
                pictureBox7.Enabled = false;
                playerLabel.Text = "Player 1's Turn";
            }

            timer1.Stop();
            timeLeft = 10;
            timerLabel.Text = timeLeft.ToString();
            timer1.Start();

            if (CheckForWinner("X"))
            {
                timer1.Stop();
                MessageBox.Show("Player 1 Wins!");
                clearButton.PerformClick();
            }
            else if (CheckForWinner("O"))
            {
                timer1.Stop();
                MessageBox.Show("Player 2 Wins!");
                clearButton.PerformClick();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (playerLabel.Text == "Player 1's Turn")
            {
                pictureBox8.Image = Properties.Resources.x;
                pictureBox8.Enabled = false;
                pictureBox8.Tag = "X";
                playerLabel.Text = "Player 2's Turn";
            }
            else
            {
                pictureBox8.Image = Properties.Resources.o;
                pictureBox8.Enabled = false;
                pictureBox8.Tag = "O";
                playerLabel.Text = "Player 1's Turn";
            }

            timer1.Stop();
            timeLeft = 10;
            timerLabel.Text = timeLeft.ToString();
            timer1.Start();

            if (CheckForWinner("X"))
            {
                timer1.Stop();
                MessageBox.Show("Player 1 Wins!");
                clearButton.PerformClick();
            }
            else if (CheckForWinner("O"))
            {
                timer1.Stop();
                MessageBox.Show("Player 2 Wins!");
                clearButton.PerformClick();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (playerLabel.Text == "Player 1's Turn")
            {
                pictureBox9.Image = Properties.Resources.x;
                pictureBox9.Enabled = false;
                pictureBox9.Tag = "X";
                playerLabel.Text = "Player 2's Turn";
            }
            else
            {
                pictureBox9.Image = Properties.Resources.o;
                pictureBox9.Enabled = false;
                pictureBox9.Tag = "O";
                playerLabel.Text = "Player 1's Turn";
            }

            timer1.Stop();
            timeLeft = 10;
            timerLabel.Text = timeLeft.ToString();
            timer1.Start();

            if (CheckForWinner("X"))
            {
                timer1.Stop();
                MessageBox.Show("Player 1 Wins!");
                clearButton.PerformClick();
            }
            else if (CheckForWinner("O"))
            {
                timer1.Stop();
                MessageBox.Show("Player 2 Wins!");
                clearButton.PerformClick();
            }

        }

        private bool CheckForWinner(string mark)
        {
            // Row 1
    if (pictureBox1.Tag == mark && pictureBox2.Tag == mark && pictureBox3.Tag == mark)
            {
                HighlightWinner(pictureBox1, pictureBox2, pictureBox3);
                return true;
            }
            // Row 2
            if (pictureBox4.Tag == mark && pictureBox5.Tag == mark && pictureBox6.Tag == mark)
            {
                HighlightWinner(pictureBox4, pictureBox5, pictureBox6);
                return true;
            }
            // Row 3
            if (pictureBox7.Tag == mark && pictureBox8.Tag == mark && pictureBox9.Tag == mark)
            {
                HighlightWinner(pictureBox7, pictureBox8, pictureBox9);
                return true;
            }
            // Column 1
            if (pictureBox1.Tag == mark && pictureBox4.Tag == mark && pictureBox7.Tag == mark)
            {
                HighlightWinner(pictureBox1, pictureBox4, pictureBox7);
                return true;
            }
            // Column 2
            if (pictureBox2.Tag == mark && pictureBox5.Tag == mark && pictureBox8.Tag == mark)
            {
                HighlightWinner(pictureBox2, pictureBox5, pictureBox8);
                return true;
            }
            // Column 3
            if (pictureBox3.Tag == mark && pictureBox6.Tag == mark && pictureBox9.Tag == mark)
            {
                HighlightWinner(pictureBox3, pictureBox6, pictureBox9);
                return true;
            }
            // Diagonal (top-left to bottom-right)
            if (pictureBox1.Tag == mark && pictureBox5.Tag == mark && pictureBox9.Tag == mark)
            {
                HighlightWinner(pictureBox1, pictureBox5, pictureBox9);
                return true;
            }
            // Diagonal (top-right to bottom-left)
            if (pictureBox3.Tag == mark && pictureBox5.Tag == mark && pictureBox7.Tag == mark)
            {
                HighlightWinner(pictureBox3, pictureBox5, pictureBox7);
                return true;
            }

            return false;
        
        }
        private void HighlightWinner(PictureBox a, PictureBox b, PictureBox c)
        {
            a.BackColor = Color.LightGreen;
            b.BackColor = Color.LightGreen;
            c.BackColor = Color.LightGreen;
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;

            pictureBox1.Tag = null;
            pictureBox2.Tag = null;
            pictureBox3.Tag = null;
            pictureBox4.Tag = null;
            pictureBox5.Tag = null;
            pictureBox6.Tag = null;
            pictureBox7.Tag = null;
            pictureBox8.Tag = null;
            pictureBox9.Tag = null;

            pictureBox1.BackColor = DefaultBackColor;
            pictureBox2.BackColor = DefaultBackColor;
            pictureBox3.BackColor = DefaultBackColor;
            pictureBox4.BackColor = DefaultBackColor;
            pictureBox5.BackColor = DefaultBackColor;
            pictureBox6.BackColor = DefaultBackColor;
            pictureBox7.BackColor = DefaultBackColor;
            pictureBox8.BackColor = DefaultBackColor;
            pictureBox9.BackColor = DefaultBackColor;

            timer1.Stop();
            timeLeft = 10;
            timerLabel.Text = timeLeft.ToString();
            playerLabel.Text = "Player 1's Turn";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        

        
    }
}
    
