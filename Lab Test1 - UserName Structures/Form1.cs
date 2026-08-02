using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Test1___UserName_Structures
{
    public partial class Form1 : Form
    {
        struct username
        {
            public string firstName;
            public string lastName;
            public string date;
            public string email;
            public string number;
            public string generatedUsername;
        }
        List<username> usernames = new List<username>();
        public Form1()
        {
            InitializeComponent();
        }

        private void usernameButton_Click(object sender, EventArgs e)
        {
            username user = new username();
            user.firstName = textBox1.Text;
            user.lastName = textBox2.Text;
            user.date = textBox3.Text;
            user.email = textBox4.Text;
            user.number = textBox5.Text;
            // 1. first 3 letters of last name (lowercase)
            string part1 = user.lastName.Substring(0, 3).ToLower();

            // 2. month from date using Split
            string[] dateParts = user.date.Split('-');
            string month = dateParts[0];   // "10" from 10-14-1979

            // 3. last 2 letters of first name (lowercase)
            string part3 = user.firstName.Substring(user.firstName.Length - 2).ToLower();

            // 4. combine to make username
            user.generatedUsername = part1 + month + part3;

            // Add user to List
            usernames.Add(user);

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            listBox1.Items.Add("User Information:");
            foreach (username tempUserInfo in usernames)
            {
                listBox1.Items.Add(String.Format($"User First Name: {tempUserInfo.firstName}"));
                listBox1.Items.Add(String.Format($"User Last Name: {tempUserInfo.lastName}"));
                listBox1.Items.Add(String.Format($"User DOB: {tempUserInfo.date}"));
                listBox1.Items.Add(String.Format($"User Email: {tempUserInfo.email}"));
                listBox1.Items.Add(String.Format($"User Pnone Number: {tempUserInfo.number}"));
                listBox1.Items.Add(String.Format($"UserName: {tempUserInfo.generatedUsername}"));
                listBox1.Items.Add("---------------------------------------");
            }
        }
    }
}
