using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slot_Machine
{
    public partial class Form1 : Form
    {
        int spinCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            spinTimer.Start();
        }

        private void SpinWheels(int wheelPic, PictureBox p)
        {
            if (wheelPic == 1)
            {
                p.Image = Properties.Resources.grapes;
                p.Tag = "grapes";
            }
            else if (wheelPic == 2)
            {
                p.Image = Properties.Resources.orange;
                p.Tag = "orange";
            }
            else if (wheelPic == 3)
            {
                p.Image = Properties.Resources.lemon;
                p.Tag = "lemon";
            }

        }

        private void spinTimer_Tick(object sender, EventArgs e)
        {

            if (spinCount < 20)
            {
                spinCount++;
                spinTimer.Interval = 50;
                Random rand = new Random();
                int wheel1 = rand.Next(1, 4);
                int wheel2 = rand.Next(1, 4);
                int wheel3 = rand.Next(1, 4);

                SpinWheels(wheel1, wheelPictureBox1);
                SpinWheels(wheel2, wheelPictureBox2);
                SpinWheels(wheel3, wheelPictureBox3);
            }
            else if (spinCount >= 20 && spinCount < 35)
            {
                spinCount++;
                spinTimer.Interval = 100;
                Random rand = new Random();
                int wheel2 = rand.Next(1, 4);
                int wheel3 = rand.Next(1, 4);
                // First wheel stays the same
                SpinWheels(wheel2, wheelPictureBox2);
                SpinWheels(wheel3, wheelPictureBox3);
            }
            else if (spinCount >= 35 && spinCount < 45)
            {
                spinCount++;
                spinTimer.Interval = 150;
                Random rand = new Random();
                int wheel3 = rand.Next(1, 4);
                // First and second wheels stay the same
                SpinWheels(wheel3, wheelPictureBox3);
            }

            else
            {
                spinTimer.Stop();
                spinCount = 0;

                if (wheelPictureBox1.Tag == wheelPictureBox2.Tag)
                {
                    int balance = int.Parse(balanceLabel.Text);
                    balance += 10;
                    balanceLabel.Text = balance.ToString();
                }
                else if (wheelPictureBox1.Tag == wheelPictureBox2.Tag && wheelPictureBox2.Tag == wheelPictureBox3.Tag)
                {
                    int balance = int.Parse(balanceLabel.Text);
                    balance += 100;
                    balanceLabel.Text = balance.ToString();
                }
            }

        }

        private void runSimulationsButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int numberOfSimulations = int.Parse(numSimulationTextBox.Text);
            StringBuilder simOutput = new StringBuilder();
            int winnings = int.Parse(beginningBalanceTextBox.Text);

            for (int i = 0; i < numberOfSimulations; i++)
            {
                if (winnings >= 10)
                {
                    winnings -= 10;

                    simOutput.Append("Spin " + (i + 1) + ": ");
                    int wheel1 = rand.Next(1, 4);
                    int wheel2 = rand.Next(1, 4);
                    int wheel3 = rand.Next(1, 4);

                    DeteremineImage(wheel1, ref simOutput);
                    DeteremineImage(wheel2, ref simOutput);
                    DeteremineImage(wheel3, ref simOutput);

                    winnings += CalculateWinnings(wheel1, wheel2, wheel3);

                    simOutput.Remove((simOutput.Length - 3), 3); // Remove last " - "

                    simulationOutputListBox.Items.Add(simOutput.ToString());
                    simOutput.Clear();
                }
                else
                {
                    simulationOutputListBox.Items.Add("Spin " + (i + 1) + ": Insufficient funds to spin.");
                    break;
                }
            }
            winningsOutputLabel.Text=winnings.ToString("c");
        }

        private void DeteremineImage(int wheel, ref StringBuilder sb)
        {
            if (wheel == 1)
            {
                sb.Append("grapes - ");
            }
            else if (wheel == 2)
            {
                sb.Append("orange - ");
            }
            else if (wheel == 3)
            {
                sb.Append("lemon - ");
            }
        }

        /*private int DetermineImage(int wheel, ref StringBuilder sb)
        {
            if (wheel == 1)
            {
                return 1; // grapes
            }
            else if (wheel == 2)
            {
                return 2; // orange
            }
            else // wheel == 3
            {
                return 3; // lemon
            }
        }
*/
        private int CalculateWinnings(int wheel1, int wheel2, int wheel3)
        {
            int winnings = 0;
            if (wheel1 == wheel2 && wheel2 == wheel3)
            {
                winnings +=100; // All three match
            }
            else if (wheel1 == wheel2 || wheel1 == wheel3 || wheel2 == wheel3)
            {
                winnings += 10; // Two match
            }
            return winnings;
        }
    }
}
