using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student S = new Student();
            {
                S.FirstName = "Flourish";
                S.LastName = "Ola";
                S.Address = "234 Orange Valley";
                S.Balance = 84562;
                S.ID = "STU2344";
                S.Scholarship = 1345;
                S.Classification = "Junior";
            }

            Professor pr = new Professor();
            {
                pr.EmployeeID = "HSU234";
                pr.ID = "HSU234";
                pr.Salary = 50567;

            }

            MessageBox.Show($@"{S.ID} : {S.GenerateCheck()}");
            MessageBox.Show($@"{pr.ID}:{pr.GenerateCheck()}");
        }
    }
}
