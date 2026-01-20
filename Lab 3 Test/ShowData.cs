using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_Test
{
    public partial class ShowData : Form
    {
        public ShowData()
        {
            InitializeComponent();
            StreamReader infile;
            infile = File.OpenText("RollData.txt");
            while (!infile.EndOfStream)
            {
                string line = infile.ReadLine();
                listBox1.Items.Add(line);
            }
            infile.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
