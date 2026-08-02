using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1_interface_game
{
    public partial class SimonLogin : Form
    {
        public SimonLogin()
        {
            InitializeComponent();
        }

        private void newPlayerButton_Click(object sender, EventArgs e)
        {
            NewPlayer player = new NewPlayer();
            player.ShowDialog();
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            Player player = new Player();   
            bool matchFound = false;
            if (!File.Exists("PlayerData.txt"))
            {
               loginErrorLabel.ForeColor = Color.Red;
                loginErrorLabel.Text = "No accounts found. Please create an account first!";
                return;  // stop here
            }
            StreamReader infile = new StreamReader("PlayerData.txt");
            while (!infile.EndOfStream)
            {
                string line = infile.ReadLine();
                string[] parts = line.Split(',');



                if (parts[2].Trim() == logInTextBox.Text.Trim() &&
                    parts[3].Trim() == passwordTextBox.Text.Trim())
                {
                    player.First = parts[0].Trim();
                    player.Last = parts[1].Trim();
                    player.Login = parts[2].Trim();
                    player.Password = parts[3].Trim();
                    player.Level = int.Parse(parts[4].Trim());
                    player.Wins = int.Parse(parts[5].Trim());
                    matchFound = true;
                    break;
                }
            }
            infile.Close();

            
            if (matchFound)
            {
                loginErrorLabel.ForeColor = Color.Green;
                loginErrorLabel.Text = "Login Successful!";
                Simon gameForm = new Simon(player);
                gameForm.Show();
                this.Hide();
            }
            else
            {
                passwordErrorLabel.ForeColor = Color.Red;
                passwordErrorLabel.Text = "Invalid login name or password!";
                logInTextBox.Clear();
                passwordTextBox.Clear();
            }
        }
    }

    

}
