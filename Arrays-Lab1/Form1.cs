using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays_Lab1
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int[] array = new int[40000];
          
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 1001);
            }
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == int.Parse(inputTextBox.Text))
                {
                    count++;
                }
            }
            outputLabel.Text = count.ToString();



        }
    }
}
