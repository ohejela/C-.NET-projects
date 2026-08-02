using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Structures
{
    public partial class Form1 : Form
    {
        struct Book
        {
            public string authorLastName;
            public string title;
            public string genre;
        }
        List<Book> Inventorylist = new List<Book>();
        public Form1()
        {
            InitializeComponent();


        }

        private void saveBookButton_Click(object sender, EventArgs e)
        {
            Book tempbook = new Book();
            tempbook.authorLastName = lastNameTextBox.Text;
            tempbook.title = titleTextBox.Text;
            tempbook.genre = genreTextBox.Text;

            Inventorylist.Add(tempbook);
            MessageBox.Show("Book saved Correctlly");
            lastNameTextBox.Clear();
            titleTextBox.Clear();
            genreTextBox.Clear();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Inventory List:");
            foreach (Book tempbook in Inventorylist)
            {
                listBox1.Items.Add(String.Format($"Book Title: {tempbook.title}"));
                listBox1.Items.Add(String.Format($"Author Last Name: {tempbook.authorLastName}"));
                listBox1.Items.Add(String.Format($"Genre: {tempbook.genre}"));
                listBox1.Items.Add("---------------------------------------");
            }
        }
    }
}
