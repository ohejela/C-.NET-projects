using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Test2
{
    public partial class Form1 : Form
    {
        List<Person> people = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Customer")
            {
                purchaseTextBox.Visible = true;
                
            }
            else
            {
                purchaseTextBox.Clear();
                purchaseTextBox.Visible = false;
                
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Person")
            {
                people.Add(new Person
                {
                    FirstName = firstTextBox.Text,
                    LastName = lastTextBox.Text,
                    PhoneNumber = numTextBox.Text
                });
            }
            else
            {
                double purchases;

                if (!double.TryParse(purchaseTextBox.Text, out purchases))
                {
                    outputLabel.Text="Enter a valid purchase amount.";
                    return;
                }
                people.Add(new Customer
                {
                    FirstName = firstTextBox.Text,
                    LastName = lastTextBox.Text,
                    PhoneNumber = numTextBox.Text,
                    Purchases = double.Parse(purchaseTextBox.Text)
                });
            }

            outputLabel.Text = "The person/customer was added successfully";
            Reset();
        }
        private void Reset()
        {
            firstTextBox.Clear();
            lastTextBox.Clear();
            numTextBox.Clear();
            purchaseTextBox.Clear();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            PersonDisplay pd = new PersonDisplay(people);
            pd.Show();
            this.Hide();
        }
    }
}
