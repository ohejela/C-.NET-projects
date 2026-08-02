using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Parking_Lot_Management
{
    public partial class Form1 : Form
    {
        // 3 rows (A, B, C), 4 columns each
        // Naming: pbA1, pbA2, pbA3, pbA4, pbB1... etc.
        // We'll reference them via a 2D array built from the designer controls

        private PictureBox[,] slots = new PictureBox[3, 8];
        private string[] rowNames = { "A", "B", "C" };

        // Your 3 car images (set these to your actual resource names)
        private Bitmap[] carImages;

        public Form1()
        {
            InitializeComponent();
            InitializeSlotArray();
            LoadCarImages();
            PlaceCarsRandomly();
        }

        private void InitializeSlotArray()
        {
            // Map your designer PictureBoxes into the 2D array
            // Row 0 = Row A, Row 1 = Row B, Row 2 = Row C
            // You must match these names to what's in your designer!
            slots[0, 0] = pictureRowA1; slots[0, 1] = pictureRowA2; slots[0, 2] = pictureRowA3; slots[0, 3] = pictureRowA4; slots[0, 4] = pictureRowA5; slots[0, 5] = pictureRowA6; slots[0, 6] = pictureRowA7; slots[0, 7] = pictureRowA8;
            slots[1, 0] = pictureRowB1; slots[1, 1] = pictureRowB2; slots[1, 2] = pictureRowB3; slots[1, 3] = pictureRowB4; slots[1, 4] = pictureRowB5; slots[1, 5] = pictureRowB6; slots[1, 6] = pictureRowB7; slots[1, 7] = pictureRowB8;
            slots[2, 0] = pictureRowC1; slots[2, 1] = pictureRowC2; slots[2, 2] = pictureRowC3; slots[2, 3] = pictureRowC4; slots[2, 4] = pictureRowC5; slots[2, 5] = pictureRowC6; slots[2, 6] = pictureRowC7; slots[2, 7] = pictureRowC8;

            // Set all tags to 0 (unoccupied) initially
            foreach (PictureBox pb in slots)
            {
                pb.Tag = 0;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.BackColor = Color.Transparent;
                pb.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void LoadCarImages()
        {
            Bitmap green = RemoveBackground(new Bitmap(Properties.Resources.car), Color.White, 40);
            Bitmap blue = RemoveBackground(new Bitmap(Properties.Resources.bluecar), Color.White, 40);
            Bitmap yellow = RemoveBackground(new Bitmap(Properties.Resources.caryellow), Color.White, 40);

            carImages = new Bitmap[] { green, blue, yellow };
        }

        private void PlaceCarsRandomly()
        {
            Random rand = new Random();

            // How many cars to place per row (randomized between 2 and 5 out of 8 slots)
            for (int row = 0; row < 3; row++)
            {
                int carsToPlace = rand.Next(2, 6); // 2 to 5 cars per row
                List<int> usedCols = new List<int>();

                for (int i = 0; i < carsToPlace; i++)
                {
                    int col;
                    do
                    {
                        col = rand.Next(0, 8);
                    }
                    while (usedCols.Contains(col));

                    usedCols.Add(col);

                    // Pick a random car image
                    int carIndex = rand.Next(0, 3);
                    PictureBox pb = slots[row, col];
                    pb.Image = carImages[carIndex];
                    pb.Tag = 1;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Build the list of available slots
            List<string> availableSlots = new List<string>();
            Dictionary<string, (int row, int col)> slotMap = new Dictionary<string, (int, int)>();

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if ((int)slots[row, col].Tag == 0)
                    {
                        int subRow = (col < 4) ? 1 : 2;
                        int displayCol = (col % 4) + 1;
                        string slotLabel = $"Row {rowNames[row]}, Sub-row {subRow}, Column {displayCol}";

                        availableSlots.Add(slotLabel);
                        slotMap[slotLabel] = (row, col);
                    }
                }
            }

            if (availableSlots.Count == 0)
            {
                MessageBox.Show("The parking lot is full!", "Parking Lot Full",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Open the ParkingForm
            using (ParkingForm parkingForm = new ParkingForm(availableSlots))
            {
                if (parkingForm.ShowDialog() == DialogResult.OK)
                {
                    string selected = parkingForm.SelectedSlot;

                    if (slotMap.ContainsKey(selected))
                    {
                        var (row, col) = slotMap[selected];
                        ParkSlotFromSelection(row, col, selected);
                    }
                }
            }
        }

        // Add this new method to Form1:
        private void ParkSlotFromSelection(int row, int col, string slotLabel)
        {
            Random rand = new Random();
            int carIndex = rand.Next(0, 3); // randomly pick green, blue, or yellow

            string[] carNames = { "Green", "Blue", "Yellow" };

            PictureBox pb = slots[row, col];
            pb.Image = carImages[carIndex];
            pb.Tag = 1; // Mark as occupied

            MessageBox.Show(
                $"Your spot has been saved!\n\n" +
                $"Location : {slotLabel}\n" +
                $"Car Color : {carNames[carIndex]}",
                "Spot Confirmed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        private Bitmap RemoveBackground(Bitmap bmp, Color bgColor, int tolerance = 30)
        {
            Bitmap result = new Bitmap(bmp.Width, bmp.Height,
                            System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixel = bmp.GetPixel(x, y);
                    int diff = Math.Abs(pixel.R - bgColor.R) +
                               Math.Abs(pixel.G - bgColor.G) +
                               Math.Abs(pixel.B - bgColor.B);

                    result.SetPixel(x, y, diff < tolerance ? Color.Transparent : pixel);
                }
            }
            return result;
        }
    }
}