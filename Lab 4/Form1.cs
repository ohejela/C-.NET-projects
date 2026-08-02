using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        List<employees> employeeList = new List<employees>();
        public Form1()
        {
            InitializeComponent();
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employees newEmployee = new employees();


            foreach (employees emp in employeeList)
            {
                if (emp.ID == newEmployee.ID)
                {
                    lblError.Text = "An employee with this ID already exists!";
                }
            }

            newEmployee.ID = int.Parse(idTextBox.Text);
            newEmployee.First = firstTextBox.Text;
            newEmployee.Last = lastTextBox.Text;
            newEmployee.Email = emailTextBox.Text;
            newEmployee.JobTitle = titleTextBox.Text;

            employeeList.Add(newEmployee);

            idTextBox.Text = "";
            firstTextBox.Text = "";
            lastTextBox.Text = "";
            emailTextBox.Text = "";
            titleTextBox.Text = "";


           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee lookupForm = new Employee(employeeList);
            lookupForm.ShowDialog();
            this.Hide();
        }
    }


}
