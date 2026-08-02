using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_4
{
    public partial class Employee : Form
    {
        List<employees> employeeList;
        public Employee(List<employees> list)
        {
            InitializeComponent();
           
            employeeList = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(textBox1.Text, out id))
            {
                label3.ForeColor = Color.Red;
                label3.Text = "ID must be a number!";
                return;
            }

            bool found = false;
            foreach (employees emp in employeeList)
            {
                if (emp.ID == id)
                {
                    

                    label3.ForeColor = Color.Black;
                    label3.Text = emp.GetEmployeeInfo();
                    found = true;
                    break;
                }
            }
            if (!found)  
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Employee not found!";
            }
        }
    }
}
