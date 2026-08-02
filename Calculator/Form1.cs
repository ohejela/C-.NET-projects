using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        calc calculator = new calc();
        Timer timer = new Timer();
        public Form1()
        {
            timer.Tick += SqrtTimer_Tick;
            InitializeComponent();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {

            calculator.Number1 = double.Parse(textBox1.Text);
            calculator.Number2 = double.Parse(textBox2.Text);
            calculator.Add();
            outputLabel.Text = calculator.Result.ToString();

            timer.Start();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {

            calculator.Number1 = double.Parse(textBox1.Text);
            calculator.Number2 = double.Parse(textBox2.Text);
            calculator.Subtract();
            outputLabel.Text = calculator.Result.ToString();
            timer.Start();

        }

        private void productButton_Click(object sender, EventArgs e)
        {
            calculator.Number1 = double.Parse(textBox1.Text);
            calculator.Number2 = double.Parse(textBox2.Text);
            calculator.Multiply();
            outputLabel.Text = calculator.Result.ToString();
            timer.Start();
        }

        private void divButton_Click(object sender, EventArgs e)
        {

            calculator.Number1 = double.Parse(textBox1.Text);
            calculator.Number2 = double.Parse(textBox2.Text);
            calculator.Divide();
            outputLabel.Text = calculator.Result.ToString("F1");
            timer.Start();
        }

        private void SqrtTimer_Tick(object sender, EventArgs e)
        {


            if (calculator.Result < 0)
            {
                MessageBox.Show("Cannot take square root of a negative number!");
                timer.Stop();
                return;
            }
            

            calculator.sqrt();
            outputLabel.Text = calculator.Result.ToString("f1");
        }

    }
}
