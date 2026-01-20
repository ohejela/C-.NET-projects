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

namespace Lab_3_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numDice = int.Parse(numberofDiceTextBox.Text);
            int numSides = int.Parse(numberofSidesTextBox.Text);
            int goal = int.Parse(targetSumTextBox.Text);
            int count = 0;
            int numGen = 0;
            Random rand = new Random();

            while (numGen != goal)
            {
                
                numGen = rand.Next(numDice, (numDice * numSides));
                outputListBox.Items.Add(numGen);
                count++;
            }
            outputLabel.Text = "It took " + count + " rolls to get " + goal;

            StreamWriter outfile;
            if (File.Exists("RollData.txt"))
            {
                outfile = File.AppendText("RollData.txt");
                outfile.WriteLine(numDice + "-" + numSides + "-" + goal + "->" + count);
                outfile.Close();
            }
            else
            {
                outfile = File.CreateText("RollData.txt");
                outfile.WriteLine(numDice + "-" + numSides + "-" + goal + "->" + count);
                outfile.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowData showData = new ShowData();
            showData.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numberofDiceTextBox.Clear();
            numberofSidesTextBox.Clear();
            targetSumTextBox.Clear();
            outputListBox.Items.Clear();
            outputLabel.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
