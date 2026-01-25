using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithmTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runSortButton_Click(object sender, EventArgs e)
        {
            const int size = 100000;
            var rng = new Random();

            // Generate a single random dataset and clone it so both algorithms sort identical input.
            int[] original = new int[size];
            for (int i = 0; i < original.Length; i++)
            {
                original[i] = rng.Next(1, 100000);
            }

            int[] arrayForSelection = (int[])original.Clone();
            int[] arrayForInsertion = (int[])original.Clone();

            // Measure times (milliseconds)
            int selectionSortTime = selectionSort(arrayForSelection);
            int insertionSortTime = insertionSort(arrayForInsertion);

            MessageBox.Show(
                $"Selection sort: {selectionSortTime} ms{Environment.NewLine}Insertion sort: {insertionSortTime} ms",
                "Sort timings",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private int selectionSort(int[] array)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            Stopwatch sw = Stopwatch.StartNew();

            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                // Find index of minimum element in the remainder of the array
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Swap if a smaller element was found
                if (minIndex != i)
                {
                    int temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }
            }

            sw.Stop();
            return (int)sw.ElapsedMilliseconds;
        }

        private int insertionSort(int[] array)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            Stopwatch sw = Stopwatch.StartNew();

            int n = array.Length;
            for (int i = 1; i < n; i++)
            {
                int key = array[i];
                int j = i - 1;

                // Move elements of array[0..i-1], that are greater than key,
                // to one position ahead of their current position
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }

            sw.Stop();
            return (int)sw.ElapsedMilliseconds / 1000;
        }
    }
}
