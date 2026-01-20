using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Test
{
    public partial class Form1 : Form
    {
        int count = 0;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            
            int a = rand.Next(1, 21);
            int b = rand.Next(1, 21);
            int c = rand.Next(1, 21);
            int d = rand.Next(1, 21);

            bool first = false;
            bool second = false;
            bool third = false;
            bool fourth = false;

            

            int num1 = int.Parse(firstNumTextBox.Text);
            int num2 = int.Parse(secondNumTextBox.Text);
            int num3 = int.Parse(thirdNumTextBox.Text);
            int num4 = int.Parse(fourthNumTextBox.Text);
 
                
            if (a == num1 || a == num2 || a == num3 || a == num4)
            {
                 first = true;
                    
            }

            if (b == num1 || b == num2 || b == num3 || b == num4)
            {
                 second = true;
                  
            }

            if (c == num1 || c == num2 || c == num3 || c == num4)
            {
                third = true;
                    
            }

            if (d == num1 || d == num2 || d == num3 || d == num4)
            {
                fourth = true;
            }
            
            count++;

            if (first == true && second == true && third == true && fourth == true)
            {
                    outputLabel.Text = "You are a winner!!! \n\n And it only took" +" "+ count +" " + "sumilations";

                    timer1.Stop();

            }
            else if( count >= 1000000)
            {
                    outputLabel.Text = "Your Combination was never chosen " + count;
                    timer1.Stop();
            }


            

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNumTextBox.Clear();
            secondNumTextBox.Clear();
            thirdNumTextBox.Clear();
            fourthNumTextBox.Clear();
            outputLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
