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

namespace Program_3
{
    public partial class SaveScore : Form
    {
        public SaveScore(int score)
        {
            InitializeComponent();
            scoreOutputLabel.Text = score.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                string initals = initialsInputTextBox.Text;
                string score = scoreOutputLabel.Text;
                if (initals.Length < 3)
                {
                    label2.Text = "X";
                }
                StreamWriter outfile;
                outfile = File.CreateText("scores.txt");
                outfile.WriteLine(initals + "," + score);
                outfile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
