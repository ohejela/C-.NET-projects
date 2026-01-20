using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassAssignment12
{
    public partial class Form1 : Form
    {
        int number;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inputTextBox.Enabled = false;
            outputLabel.Enabled = false;
            checkButton.Enabled = false;
            resetButton.Enabled = false;

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Enabled = true;
            outputLabel.Enabled = true;
            checkButton.Enabled = true;
            resetButton.Enabled = true;

            Random random = new Random();
            number = random.Next(1, 101);
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            
            int userInput = int.Parse(inputTextBox.Text);

            if (userInput < number)
            {
                outputLabel.Text = "Too small. Try Again";
            }
            else if (userInput > number)
            {
                outputLabel.Text = "Too High. Try again";
            }
            else
            {
                outputLabel.Text = "Correct!";
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            inputTextBox.Text = "";
            inputTextBox.Enabled = false;
            outputLabel.Enabled = false;
            checkButton.Enabled = false;
            resetButton.Enabled = false;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
