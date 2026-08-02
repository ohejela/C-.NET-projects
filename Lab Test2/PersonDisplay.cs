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
    public partial class PersonDisplay : Form
    {
        List<Person> people;
        public PersonDisplay(List<Person> list)
        {
            InitializeComponent();
            people = list;
        }

        private void PersonDisplay_Load(object sender, EventArgs e)
        {
            foreach (Person p in people)
            {
                string type = p is Customer ? "Customer" : "Person";

                listBox1.Items.Add($"{p.GetInfo()}: {type}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
    }
}
