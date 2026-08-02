using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void storeButton_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            List<Product> productType = new List<Product>();
            product.Name = nameTextbox.Text;
            product.Description = descriptionTextbox.Text;
            product.Price = double.Parse(priceTextbox.Text);
            product.Quantity = int.Parse(quantityTextbox.Text);

            productType.Add(product);

            foreach (Product info in productType)
            {

                listBox1.Items.Add("Product Information");
                listBox1.Items.Add($"Product Name: {info.Name} ");
                listBox1.Items.Add($"Product Description: {info.Description} ");
                listBox1.Items.Add($"Product Price: {info.Price.ToString("C")} ");
                listBox1.Items.Add($"Product Quantity: {info.Quantity} ");
                listBox1.Items.Add("______________________________________________");

            }

            nameTextbox.Clear();
            descriptionTextbox.Clear();
            priceTextbox.Clear();
            quantityTextbox.Clear();
        }
    }
}
