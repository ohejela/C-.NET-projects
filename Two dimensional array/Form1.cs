using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Two_dimensional_array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<string> stringList = new List<string>();

            stringList.Add("Some Value");
            stringList.Add("A");
            stringList.Add("B");
            stringList.Add("C");
            stringList.Add("D");
            stringList.Add("E");

           
        }

        private void topandBottomButton_Click(object sender, EventArgs e)
        {
            string[,] values = new string[3, 3];

            loadTextBoxValues(values);
            //process top and bottom rows

            for (int row = 0; row<values.GetLength(0); row ++)
            {
                for (int col = 0; col < values.GetLength(1); col++)
                {
                    if (row != 1)
                    {
                        values[row, col] = "*";
                    }
                }
            }
            loadLabelValues(values);

        }

        private void loadTextBoxValues(string[,] values)
        {
            values[0, 0] = textBox1.Text;
            values[0, 1] = textBox2.Text;
            values[0, 2] = textBox3.Text;
            values[1, 0] = textBox4.Text;
            values[1, 1] = textBox5.Text;
            values[1, 2] = textBox6.Text;
            values[2, 0] = textBox7.Text;
            values[2, 1] = textBox8.Text;
            values[2, 2] = textBox9.Text;
        }

        private void loadLabelValues(string[,] values)
        {
            label1.Text = values[0, 0];
            label2.Text = values[0, 1];
            label3.Text = values[0, 2];
            label4.Text = values[1, 0];
            label5.Text = values[1, 1];
            label6.Text = values[1, 2];
            label7.Text = values[2, 0];
            label8.Text = values[2, 1];
            label9.Text = values[2, 2];
        }

        private void borderButton_Click(object sender, EventArgs e)
        {
            string[,] values = new string[3, 3];

            loadTextBoxValues(values);
            //process top and bottom and sides rows

            for (int row = 0; row < values.GetLength(0); row++)
            {
                for (int col = 0; col < values.GetLength(1); col++)
                {
                    if (!(row == 1 && col == 1))
                    {
                        values[row, col] = "*";
                    }
                }
            }
            loadLabelValues(values);
        }

        private void xButton_Click(object sender, EventArgs e)
        {
            string[,] values = new string[3, 3];

            loadTextBoxValues(values);
            //process top and bottom rows

            for (int row = 0; row < values.GetLength(0); row++)
            {
                for (int col = 0; col < values.GetLength(1); col++)
                {
                    if (row == col || row + col == 2)
                    {
                        values[row, col] = "*";
                    }/*if (!((row == 0 && col == 1) || (row == 1 && col == 0) || (row == 1 && col == 2) || (row == 2 && col == 1)))
                    {
                        values[row, col] = "*";
                    }
                    */
                }
            }
            loadLabelValues(values);
        }

        private void cButton_Click(object sender, EventArgs e)
        {
            string[,] values = new string[3, 3];

            loadTextBoxValues(values);
            //process top and bottom rows

            for (int row = 0; row < values.GetLength(0); row++)
            {
                for (int col = 0; col < values.GetLength(1); col++)
                {
                    if (!((row == 1 && col == 1) || (row == 1 && col == 2)))
                    {
                        values[row, col] = "*";
                    }
                }
            }
            loadLabelValues(values);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

