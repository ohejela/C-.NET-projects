using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassProject9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
           double purchase = double.Parse(inputTextBox.Text);
            double stateTax;
            double localTax;
            double total;
            stateTax = (purchase * 0.10);
            localTax = (purchase * 0.04);
            outputStateTaxLabel.Text = stateTax.ToString("c");
            outputLocalTaxLabel.Text = localTax.ToString("c");
            total = purchase + stateTax + localTax;
            outputTotalLabel.Text = total.ToString("c");

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputTotalLabel.Text = "";
            outputLocalTaxLabel.Text = "";
            outputStateTaxLabel.Text = "";
            inputTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
