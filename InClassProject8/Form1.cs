using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassProject8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            String Fahrenheit = FahrenheitTempTextBox.Text;
            double Celsius = (double.Parse(Fahrenheit) - 32) * 5 / 9;
            outputCelsiusTemp.Text = Celsius.ToString();
        }
    }
}
