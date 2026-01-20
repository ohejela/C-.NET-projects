using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void enterGameButton_Click(object sender, EventArgs e)
        {
            string FirstName = firstNameTextBox.Text;
            string LastName = lastNameTextBox.Text;
            string Difficulty = "";
            if (easyRadioButton.Checked ) 
            {
                Difficulty = "Easy";
            }
            else if (normalRadioButton.Checked)
            {
                Difficulty = "Medium";
            }
            else if (hardRadioButton.Checked)
            {
                Difficulty = "Hard";
            }

            Form1 form = new Form1(FirstName, LastName, Difficulty);
            this.Hide();
            form.ShowDialog();



        }
    }
}
