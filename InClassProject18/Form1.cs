using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassProject18
{
    public partial class Form1 : Form
    {
        int num1, num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear();
            listBox1.Items.Clear();
            outputLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            num1 = rand.Next(1, 7);
            num2 = rand.Next(1, 7);
            int num3 = int.Parse(inputTextBox.Text);
            int count = 0;

            if (!int.TryParse(inputTextBox.Text, out num3) || num3 < 2 || num3 > 12)
            {
                MessageBox.Show("Please enter a valid number between 2 and 12.");
                return;
            }

            while (num1 + num2 != num3)
            {
                count++;
                listBox1.Items.Add("Roll:"+count+" " + " "+ (num1 + num2));
                num1 = rand.Next(1, 7);
                num2 = rand.Next(1, 7);
            }

            outputLabel.Text = "It took " + count + " rolls to get your number ";

        }
    }
}
