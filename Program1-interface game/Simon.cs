using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace Program1_interface_game
{
    public partial class Simon : Form
    {
        Player player;
        int[] pattern = new int[5];
        int round = 0;
        int guessIndex = 0;
        bool playerTurn = false;
        int patternStep = 0;

        Timer patternTimer = new Timer();
        
        

        int[] beepfreq = { 500, 700, 900, 1100 };
        Image[] dark;
        Image[] light;
        PictureBox[] pictureBoxes;
        public Simon(Player player)
        {
            InitializeComponent();
            this.player = player;


            welcomeLabel.Text = $"Welcome: {player.Last}";
            currentLevelLabel.Text = $"Current Player level: {player.Level}";

            pictureBoxes = new PictureBox[]
            {
                pictureBox1 , pictureBox2 , pictureBox3 ,pictureBox4
            };

            dark = new Image[] {
                Properties.Resources.GreenButtonDark,
                Properties.Resources.BlueButtonDark,
                Properties.Resources.YelloButtonDark,
                Properties.Resources.RedButtonDark
            };

            light = new Image[] {
                Properties.Resources.GreenButtonLight,
                Properties.Resources.BlueButtonLight,
                Properties.Resources.YellowButtonLight,
                Properties.Resources.RedButtonLight

            };

            patternTimer.Interval = 1000;
            patternTimer.Tick += PatternTimer_Tick;

            SetPictureBoxes(false);

        }


        private void SetPictureBoxes(bool enabled)
        {
            foreach (PictureBox pb in pictureBoxes)
            {
                pb.Enabled = enabled;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            round = 0;
            guessIndex = 0;
            playerTurn = false;
            patternStep = 0;

            messagelabel.Text = "Watch the pattern!";
            roundlabel.Text = "Round: 1";

            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;

            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                pattern[i] = rand.Next(0,4);
            }
            patternTimer.Start();
        }

        private void PatternTimer_Tick(object sender, EventArgs e)
        {
            if (patternStep > round)
            {
                patternTimer.Stop();
                patternStep = 0;
                playerTurn = true;
                guessIndex = 0;
                SetPictureBoxes(true);
                messagelabel.Text = "Your turn!";
                return;
            }

            FlashPictureBox(pattern[patternStep]);
            patternStep++;
        }

        private void FlashPictureBox(int index)
        {
            pictureBoxes[index].Image = light[index];

            int feq = beepfreq[index];
            Task.Run(() => Console.Beep(feq, 400));

            Timer offTimer = new Timer();
            offTimer.Interval = 600;
            offTimer.Tick += (s, e) =>
            {
                pictureBoxes[index].Image = dark[index];
                offTimer.Stop();
                offTimer.Dispose();
            };
            offTimer.Start();
        }

        private void HandleGuess(int index)
        {
            if (!playerTurn) return;

            
            FlashPictureBox(index);

            
            if (index != pattern[guessIndex])
            {
                playerTurn = false;
                SetPictureBoxes(false);
                messagelabel.Text = "Wrong! Game Over!";
                roundlabel.Text = "";
                button1.Enabled = true;
                return;
            }

            guessIndex++;

            
            if (guessIndex > round)
            {
                if (round == 4)
                {
                    
                    playerTurn = false;
                    SetPictureBoxes(false);
                    messagelabel.Text = "You Won! Congratulations!";
                    roundlabel.Text = "";
                    button1.Enabled = true;
                }
                else
                {
                    
                    round++;
                    guessIndex = 0;
                    playerTurn = false;
                    patternStep = 0;
                    SetPictureBoxes(false);

                    roundlabel.Text = $"Round: {round + 1}";
                    messagelabel.Text = "Watch the pattern!";

                    
                    Timer delayTimer = new Timer();
                    delayTimer.Interval = 1000;
                    delayTimer.Tick += (s, e) =>
                    {
                        delayTimer.Stop();
                        delayTimer.Dispose();
                        patternTimer.Start();
                    };
                    delayTimer.Start();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HandleGuess(0);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HandleGuess(1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            HandleGuess(2);
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            HandleGuess(3);
        }
    }

    
}
