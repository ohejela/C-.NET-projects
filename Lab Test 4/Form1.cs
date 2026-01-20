using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Test_4
{
    public partial class Form1 : Form
    {
        int [] arr = new int[40000];
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int num = int.Parse(inputTextBox.Text);
            if (num >= 1 && num <= 1000)
            {
                Random rand = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rand.Next(1, 1001);

                }
                count = Checkarray(arr, num);
                outputLabel.Text = count.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a number between 1 and 1000.");
            }
        }

        private int Checkarray(int[] arr, int num)
        {
            count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    count++;
                }
            }

            return count;

        }
    }
}
