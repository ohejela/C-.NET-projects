namespace Parking_Lot_Management
{
    partial class ParkingForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblAvailable = new System.Windows.Forms.Label();
            this.listBoxSlots = new System.Windows.Forms.ListBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.comboBoxSlots = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblAvailable
            this.lblAvailable.AutoSize = false;
            this.lblAvailable.Text = "Available Parking Slots:";
            this.lblAvailable.Font = new System.Drawing.Font("Segoe UI", 10F,
                                         System.Drawing.FontStyle.Bold);
            this.lblAvailable.Location = new System.Drawing.Point(12, 12);
            this.lblAvailable.Size = new System.Drawing.Size(360, 22);

            // listBoxSlots
            this.listBoxSlots.Location = new System.Drawing.Point(12, 40);
            this.listBoxSlots.Size = new System.Drawing.Size(360, 180);
            this.listBoxSlots.Font = new System.Drawing.Font("Segoe UI", 9F);

            // lblSelect
            this.lblSelect.AutoSize = false;
            this.lblSelect.Text = "Select a slot to park:";
            this.lblSelect.Font = new System.Drawing.Font("Segoe UI", 10F,
                                      System.Drawing.FontStyle.Bold);
            this.lblSelect.Location = new System.Drawing.Point(12, 235);
            this.lblSelect.Size = new System.Drawing.Size(360, 22);

            // comboBoxSlots
            this.comboBoxSlots.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSlots.Location = new System.Drawing.Point(12, 262);
            this.comboBoxSlots.Size = new System.Drawing.Size(360, 28);
            this.comboBoxSlots.Font = new System.Drawing.Font("Segoe UI", 9F);

            // btnConfirm
            this.btnConfirm.Text = "Confirm Spot";
            this.btnConfirm.Location = new System.Drawing.Point(12, 308);
            this.btnConfirm.Size = new System.Drawing.Size(170, 35);
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9F,
                                        System.Drawing.FontStyle.Bold);
            this.btnConfirm.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);

            // btnCancel
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(202, 308);
            this.btnCancel.Size = new System.Drawing.Size(170, 35);
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F,
                                       System.Drawing.FontStyle.Bold);
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // ParkingForm
            this.ClientSize = new System.Drawing.Size(392, 362);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find a Parking Slot";
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblAvailable,
                this.listBoxSlots,
                this.lblSelect,
                this.comboBoxSlots,
                this.btnConfirm,
                this.btnCancel
            });
            this.ResumeLayout(false);
        }

        // Control declarations
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.ListBox listBoxSlots;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.ComboBox comboBoxSlots;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}