using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Test_1
{
    public partial class Form1 : Form
    {
        int length, depth, height;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void volumeButton_Click(object sender, EventArgs e)
        {
            int volume;
            length = int.Parse(lengTextBox.Text);
            height = int.Parse(heigTextBox.Text);
            depth = int.Parse(depTextBox.Text);

            volume = length * height * depth;

            outputLabel.Text = "Volume:" + " "+volume.ToString();
        }

        private void sideAreabutton_Click(object sender, EventArgs e)
        {
            int sideArea;
            length = int.Parse(lengTextBox.Text);
            depth = int.Parse(depTextBox.Text);
            sideArea = length * depth;
            outputLabel.Text = "Side Area:" + " " + sideArea.ToString();
        }

        private void endAreaButton_Click(object sender, EventArgs e)
        {
            int endArea;
            height = int.Parse(heigTextBox.Text);
            depth = int.Parse(depTextBox.Text);
            endArea = height * depth;
            outputLabel.Text = "End Area:" + " " + endArea.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            lengTextBox.Text = "";
            heigTextBox.Text = "";
            depTextBox.Text = "";
            outputLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
