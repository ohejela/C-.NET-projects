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
    public partial class LeaderBoard : Form
    {
        public LeaderBoard()
        {
            InitializeComponent();
        }

        private void LeaderBoard_Load(object sender, EventArgs e)
        {
            StreamReader infile;
            infile = File.OpenText("scores.txt");
            while (!infile.EndOfStream)
            {
                string line = infile.ReadLine();
                /*string[] parts = line.Split(',');
                string initials = parts[0];
                string score = parts[1];*/
                leaderBoardListBox.Items.Add(line);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
