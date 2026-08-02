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
    public partial class ParkingForm : Form
    {
        public string SelectedSlot { get; private set; }
        private List<string> availableSlots;

        public ParkingForm(List<string> slots)
        {
            InitializeComponent();
            availableSlots = slots;
            PopulateControls();
        }

        private void PopulateControls()
        {
            listBoxSlots.Items.Clear();
            comboBoxSlots.Items.Clear();

            foreach (string slot in availableSlots)
            {
                listBoxSlots.Items.Add(slot);
                comboBoxSlots.Items.Add(slot);
            }

            comboBoxSlots.SelectedIndex = -1;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (comboBoxSlots.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a parking slot from the dropdown.",
                    "No Slot Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SelectedSlot = comboBoxSlots.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
