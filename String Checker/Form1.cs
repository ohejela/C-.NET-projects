using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string text = inputTextBox.Text;
            int vowel = 0;
            int upperCase = 0;
            string upperCaseLetter = "";
            int index = 0;
            while (index < text.Length)
            {
                char letter = text[index];
                if (char.IsUpper(letter))
                {
                    upperCase++;
                    upperCaseLetter += letter;
                }

                char vowelLetter = char.ToUpper(letter);

                if (vowelLetter == 'A' || vowelLetter == 'E' || vowelLetter == 'I' || vowelLetter == 'O' || vowelLetter == 'U')
                {
                    vowel++;
                }
                index++;
            }

            uppercaseLabel.Text = "Uppercase Letters : " + upperCaseLetter;
            vowelLabel.Text = "Number of Vowels : " + vowel;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear();
            uppercaseLabel.Text = "";
            vowelLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
