using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_Visualizer
{
    public partial class Form1 : Form
    {
        int[] numbers = new int[8];
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int addnum = int.Parse(addTextBox.Text);
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    numbers[i] = addnum;
                    printArray(i,Color.LightGoldenrodYellow);
                    break;

                }

            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        { 
            int removeNum = int.Parse(removeTextBox.Text);
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == removeNum)
                {
                    numbers[i] = 0;
                    printArray(i, Color.LightPink);
                    break;
                }
                
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            int index = int.Parse(indexTextBox.Text);
            int value = int.Parse(valueTextBox.Text);

            for(int i = 0; i < numbers.Length; i++)
            {
                if(i == index)
                {
                    numbers[index] = value;
                    printArray(index, Color.LightBlue);
                    
                }
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            int findNum = int.Parse(findTextBox.Text);
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] == findNum)
                {
                   printArray(i, Color.LightGreen);
                }
            }
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 100);

                printArray(i, SystemColors.Control);

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            addTextBox.Clear();
            removeTextBox.Clear();
            indexTextBox.Clear();
            valueTextBox.Clear();
            findTextBox.Clear();
            sumLabel.Text = "";
            valueLabel1.Text = "";
            valueLabel2.Text = "";
            valueLabel7.Text = "";
            valueLabel3.Text = "";
            valueLabel4.Text = "";
            valueLabel5.Text = "";
            valueLabel6.Text = "";
            valueLabel8.Text = "";

            clearBackColor();
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach(int num in numbers)
            {
                sum += num;
                sumLabel.Text = sum.ToString();
            }
        }

        private void clearBackColor()
        {
            valueLabel1.BackColor = SystemColors.Control;
            valueLabel2.BackColor = SystemColors.Control;
            valueLabel3.BackColor = SystemColors.Control;
            valueLabel4.BackColor = SystemColors.Control;
            valueLabel5.BackColor = SystemColors.Control;
            valueLabel6.BackColor = SystemColors.Control;
            valueLabel7.BackColor = SystemColors.Control;
            valueLabel8.BackColor = SystemColors.Control;
        }

        private void printArray(int index, Color changeColor)
        {
            clearBackColor();
            switch (index)
            {
                case 0:
                    valueLabel1.Text = numbers[index].ToString();
                    valueLabel1.BackColor = changeColor;
                    break;
                case 1:
                    valueLabel2.Text = numbers[index].ToString();
                    valueLabel2.BackColor = changeColor;
                    break;
                case 2:
                    valueLabel3.Text = numbers[index].ToString();
                    valueLabel3.BackColor = changeColor;
                    break;
                case 3:
                    valueLabel4.Text = numbers[index].ToString();
                    valueLabel4.BackColor = changeColor;
                    break;
                case 4:
                    valueLabel5.Text = numbers[index].ToString();
                    valueLabel5.BackColor = changeColor;
                    break;
                case 5:
                    valueLabel6.Text = numbers[index].ToString();
                    valueLabel6.BackColor = changeColor;
                    break;
                case 6:
                    valueLabel7.Text = numbers[index].ToString();
                    valueLabel7.BackColor = changeColor;
                    break;
                case 7:
                    valueLabel8.Text = numbers[index].ToString();
                    valueLabel8.BackColor = changeColor;
                    break;
            }
        }

    }
}
