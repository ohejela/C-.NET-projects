using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassProject17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gazeButton_Click(object sender, EventArgs e)
        {
            string check ="";
            Random rand = new Random();
            int number = rand.Next(1, 4);
            if (luckRadioButton.Checked)
            {
                check = "1";
            }
            if(adventureRadioButton.Checked)
            {
                check = "2";
            }
            if(careerRadioButton.Checked)
            {
                check = "3";
            }
            if (healthRadioButton.Checked)
            {
                check = "4";
            }


            switch (check)
            {
                case "1":
                    if (number == 1) 
                    { 
                        outputListBox.Items.Add("Lady Luck smiles upon you-jackpots await!");
                    }
                    else if (number == 2)
                    {
                        outputListBox.Items.Add("Serendipity strikes when you least expect it!");

                    }
                    else
                    {
                        outputListBox.Items.Add("Fortune favors the bold; your turn is coming!");
                    }
                    break;
                case "2":
                    if (number == 1)
                    {
                        outputListBox.Items.Add("Abig promotion is on the horizon");
                    }
                    else if (number == 2)
                    {
                        outputListBox.Items.Add("Your ideas will shine at work!");

                    }
                    else
                    {
                        outputListBox.Items.Add("Success knocks-answer the door!");
                    }
                    break;
                case "3":
                    if (number == 1)
                    {
                        outputListBox.Items.Add("An epic journey calls your name!");
                    }
                    else if (number == 2)
                    {
                        outputListBox.Items.Add("Hidden treasures await your discovery!");

                    }
                    else
                    {
                        outputListBox.Items.Add("Wanderlust will lead to wonder!");
                    }
                    break;
                case "4":
                    if (number == 1)
                    {
                        outputListBox.Items.Add("Vitality flows through you like a river!");
                    }
                    else if (number == 2)
                    {
                        outputListBox.Items.Add("Your body thanks you for the care!");

                    }
                    else
                    {
                        outputListBox.Items.Add("Wellness blooms in unexpected ways!");
                    }
                    break;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
