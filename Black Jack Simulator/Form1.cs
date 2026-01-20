using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_Jack_Simulator
{
    public partial class Form1 : Form
    {
        int[] playerHand = new int[6];
        int[] computerHand = new int[6];
        int playerhandcount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            resetGame();
            for (int i = 0; i < 2; i++)
            {
                playerHand[i] = rand.Next(1, 12);
                computerHand[i] = rand.Next(1, 12);
                playerhandcount++;

                if(i == 0)
                {
                    playerHand1.Text = playerHand[i].ToString();
                    computerHand1.Text = "?";
                }
                else
                {
                    playerHand2.Text = playerHand[i].ToString();
                    computerHand2.Text = computerHand[i].ToString();
                }
            }

            playerHandLabel.Text = (playerHand[0] + playerHand[1]).ToString();
            computerHandLabel.Text = computerHand[1].ToString();

        }

        private void hitGameButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int card = rand.Next(1, 12);
            if(playerhandcount < playerHand.Length)
            {
                playerHand[playerhandcount] = card;
                playerhandcount++;

                switch (playerhandcount)
                {
                    case 3:
                        playerHand3.Visible = true;
                        playerHand3.Text = card.ToString();

                        break;
                    case 4:
                        playerHand4.Visible = true;
                        playerHand4.Text = card.ToString();
                        break;
                    case 5:
                        playerHand5.Visible = true;
                        playerHand5.Text = card.ToString();
                        break;
                    case 6:
                        playerHand6.Visible = true;
                        playerHand6.Text = card.ToString();
                        break;
                }
                playerHandLabel.Text = (int.Parse(playerHandLabel.Text) + card).ToString();

                if(int.Parse(playerHandLabel.Text) > 21)
                {
                    MessageBox.Show("You busted! Computer wins!");
                    hitGameButton.Enabled = false;
                }

            }
            else
            {
                hitGameButton.Enabled = false;
                MessageBox.Show("You cannot draw any more cards!");
                return;
               
            }
            
        }

        #region helper Methods
        private void resetGame()
        {
            playerHand3.Visible = false;
            playerHand4.Visible = false;
            playerHand5.Visible = false;
            playerHand6.Visible = false;
            playerHandLabel.Text = " ";
            playerhandcount = 0;

            computerHand3.Visible = false;
            computerHand4.Visible = false;
            computerHand5.Visible = false;
            computerHand6.Visible = false;
            computerHandLabel.Text = " ";
            computerHand1.Text = "??";
            hitGameButton.Enabled = true;
        }
        #endregion

        private void stayButton_Click(object sender, EventArgs e)
        {
            hitGameButton.Enabled = false;
            stayButton.Enabled = false;
            newGameButton.Enabled = false;
            computerTimer.Start();
        }

        private void computerTimer_Tick(object sender, EventArgs e)
        {
            computerHand1.Text = computerHand[0].ToString();
            int computerhandtotal = int.Parse(computerHandLabel.Text);

            if (computerhandtotal < 17)
            {
                //computer hits
            }
            else if (computerhandtotal >= 17 && computerhandtotal <= 21)
            {
                //computer stay
            }
            else
            {
                computerTimer.Stop();
                stayButton.Enabled = true;
                newGameButton.Enabled = true;
                MessageBox.Show("Computer Busted! Player Wins!");
            }
        }
    }
}
