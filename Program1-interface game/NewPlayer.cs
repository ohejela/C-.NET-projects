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
    public partial class NewPlayer : Form
    {
        public NewPlayer()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            
            
            Player player = new Player();
            player.First = firstNameTextBox.Text;
            player.Last = lastNameTextbox.Text;
            player.Login = logInTextBox.Text;
            player.Password = passwordTextBox.Text;

            

            loginErrorLabel.Text = player.loginError;
            firstErrorLabel.Text = player.firstError;
            lastErrorLabel.Text = player.lastError;
            passwordErrorLabel.Text = player.passwordError;


            if (player.IsValid)
            {
                StreamWriter outfile = new StreamWriter("PlayerData.txt");
                    outfile.WriteLine($"{player.First}, {player.Last}, {player.Login}, {player.Password}, {player.Level}, {player.Wins}");
                outfile.Close();
            }
            new Simon(player).Show();

            this.Close();

        }
    }
}
