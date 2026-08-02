using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker1.Value;
        }

        private void monthsButton_Click(object sender, EventArgs e)
        {
            DateTime datetime = dateTimePicker1.Value;
            // DateTime.AddMonths returns a new DateTime; assign the result.
            datetime = datetime.AddMonths(6);
            newDateLabel.Text = datetime.ToString("F");
        }

        private void yearsButton_Click(object sender, EventArgs e)
        {
            DateTime datetime = dateTimePicker1.Value;
            // To subtract 4 years, use AddYears with a negative value.
            datetime = datetime.AddYears(-4);
            newDateLabel.Text = datetime.ToString("F");
        }

        private void daysButton_Click(object sender, EventArgs e)
        {
            TimeSpan days = new TimeSpan(726, 0, 0, 0);
            // AddDays expects a double number of days. Use days.TotalDays to convert TimeSpan -> double.
            DateTime datetime = dateTimePicker1.Value.AddDays(days.TotalDays);
            newDateLabel.Text = datetime.ToString("F");
        }

        private void millisecondsButton_Click(object sender, EventArgs e)
        {
            TimeSpan milliseconda = new TimeSpan(0,0,0,0,726900);
            DateTime datetime = dateTimePicker1.Value.Subtract(milliseconda);
            newDateLabel.Text = datetime.ToString("F");
        }
    }
}
