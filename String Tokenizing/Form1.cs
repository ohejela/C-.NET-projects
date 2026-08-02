using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Tokenizing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            string[] token = input.Split(';');

            foreach (string s in token)
            {
                string[] token2 = s.Split(' ');

                string firstinitial = token2[0].Substring(0, 1);
                string lastinitial = token2[1].Substring(0, 1);
                listBox1.Items.Add(firstinitial + lastinitial + String.Format("{0,20:C}", float.Parse(token2[2])));

            }
        }

    }
}
