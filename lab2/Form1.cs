using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace lab2
{
    public partial class Form1 : Form
    {
        SoundPlayer player;
        public Form1(string Firstname, string Lastname, string Difficulty)
        {

            InitializeComponent();

            
            fullNameLabel.Text = "Welcome," + " " + Firstname + " " + Lastname;

            switch(Difficulty)
            {
                case "Easy":
                    timer1.Interval = 1500;
                    break;
                case "Medium":
                    timer1.Interval = 1000;
                    break;
                case "Hard":
                    timer1.Interval = 700;
                    break;
                default:
                    timer1.Interval = 1000;
                    break;
            }


            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            whackPic1.Image = Properties.Resources.whack_a_mole_hole;
            whackPic2.Image = Properties.Resources.whack_a_mole_hole;
            whackPic3.Image = Properties.Resources.whack_a_mole_hole;
            whackPic4.Image = Properties.Resources.whack_a_mole_hole;
            whackPic5.Image = Properties.Resources.whack_a_mole_hole;
            whackPic6.Image = Properties.Resources.whack_a_mole_hole;
            whackPic7.Image = Properties.Resources.whack_a_mole_hole;
            whackPic8.Image = Properties.Resources.whack_a_mole_hole;
            whackPic9.Image = Properties.Resources.whack_a_mole_hole;



            whackPic1.Enabled = false;
            whackPic2.Enabled = false;
            whackPic3.Enabled = false;
            whackPic4.Enabled = false;
            whackPic5.Enabled = false;
            whackPic6.Enabled = false;
            whackPic7.Enabled = false;
            whackPic8.Enabled = false;
            whackPic9.Enabled = false;

        }
        private void startGameButton_Click(object sender, EventArgs e)
        {
            /*StreamWriter outfile;
            outfile = File.CreateText("playerInfo.txt");
            //outfile.WriteLine(firstNameTextBox.Text);
            //outfile.WriteLine(lastNameTextBox.Text);
            outfile.Close();
            */
            whackPic1.Enabled = true;
            whackPic2.Enabled = true;
            whackPic3.Enabled = true;
            whackPic4.Enabled = true;
            whackPic5.Enabled = true;
            whackPic6.Enabled = true;
            whackPic7.Enabled = true;
            whackPic8.Enabled = true;
            whackPic9.Enabled = true;

            /*StreamReader infile = null;
            string firstname = "";
            string lastname = "";
            if (File.Exists("playerInfo.txt"))
            {
                infile = new StreamReader("playerInfo.txt");
                if (!infile.EndOfStream)
                {
                    firstname = infile.ReadLine();
                }
                if (!infile.EndOfStream)
                {
                    lastname = infile.ReadLine();
                }
                infile.Close();
            }
            */

            timer1.Start();
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void whackPic_Click(object sender, EventArgs e)
        {
            int score = 0;
            PictureBox pic = (PictureBox)sender;
            if (pic.Tag.ToString() == "mole")
            {
                player = new SoundPlayer(Properties.Resources.Hit);
                scoreBoxLabel.Text = (int.Parse(scoreBoxLabel.Text) + 10).ToString();
                score += int.Parse(scoreBoxLabel.Text);

            }
            else
            {
                player = new SoundPlayer(Properties.Resources.Miss);
 
            }
            player.Play();


            if (score == 50)
            {
                timer1.Stop();
                timer1.Enabled = false;
                MessageBox.Show("Congratulations! You have won !!!!");
                
            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            whackPic1.Image = Properties.Resources.whack_a_mole_hole;
            whackPic1.Tag = "hole";
            whackPic2.Image = Properties.Resources.whack_a_mole_hole;
            whackPic2.Tag = "hole";
            whackPic3.Image = Properties.Resources.whack_a_mole_hole;
            whackPic3.Tag = "hole";
            whackPic4.Image = Properties.Resources.whack_a_mole_hole;
            whackPic4.Tag = "hole";
            whackPic5.Image = Properties.Resources.whack_a_mole_hole;
            whackPic5.Tag = "hole";
            whackPic6.Image = Properties.Resources.whack_a_mole_hole;
            whackPic6.Tag = "hole";
            whackPic7.Image = Properties.Resources.whack_a_mole_hole;
            whackPic7.Tag = "hole";
            whackPic8.Image = Properties.Resources.whack_a_mole_hole;
            whackPic8.Tag = "hole";
            whackPic9.Image = Properties.Resources.whack_a_mole_hole;
            whackPic9.Tag = "hole";


            Random rand = new Random();
            int num = rand.Next(1, 10);

            switch (num)
            {
                case 1:
                    whackPic1.Image = Properties.Resources.whack_a_mole_mole;
                    whackPic1.Tag = "mole";
                    break;
                case 2:
                    whackPic2.Image = Properties.Resources.whack_a_mole_mole;
                    whackPic2.Tag = "mole";
                    break;
                case 3:
                    whackPic3.Image = Properties.Resources.whack_a_mole_mole;
                    whackPic3.Tag = "mole";
                    break;
                case 4:
                    whackPic4.Image = Properties.Resources.whack_a_mole_mole;
                    whackPic4.Tag = "mole";
                    break;
                case 5:
                    whackPic5.Image = Properties.Resources.whack_a_mole_mole;
                    whackPic5.Tag = "mole";
                    break;
                case 6:
                    whackPic6.Image = Properties.Resources.whack_a_mole_mole;
                    whackPic6.Tag = "mole";
                    break;
                case 7:
                    whackPic7.Image = Properties.Resources.whack_a_mole_mole;
                    whackPic7.Tag = "mole";
                    break;
                case 8:
                    whackPic8.Image = Properties.Resources.whack_a_mole_mole;
                    whackPic8.Tag = "mole";
                    break;
                case 9:
                    whackPic9.Image = Properties.Resources.whack_a_mole_mole;
                    whackPic9.Tag = "mole";
                    break;
            }

        }
    }
}
