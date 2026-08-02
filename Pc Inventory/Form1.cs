using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pc_Inventory
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            string model = modelTextBox.Text;
            string manu = manufacturerTextBox.Text;
            string descp = descriptionTextBox.Text;
            double p = double.Parse(priceTextBox.Text);

            inventory Pc = new inventory(id, manu, model);
            if (!double.TryParse(priceTextBox.Text, out p))
            {
                priceErrorLabel.Text = "Invalid Price";
            }
            else
            {
                priceErrorLabel.Text = "";
            }
            if (Pc.ID == "0000-000000")
            {
                idErrorlabel.Text = "Invalid id";
            }
            else
            {
                idErrorlabel.Text = " ";
            }
            if(Pc.Model == "0")
            {
                modelErrorLabel.Text = "Invalid Model";
            }
            else
            {
                modelErrorLabel.Text = " ";
            }
        }
    }
}
