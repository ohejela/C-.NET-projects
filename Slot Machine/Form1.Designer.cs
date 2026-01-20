namespace Slot_Machine
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.wheelPictureBox3 = new System.Windows.Forms.PictureBox();
            this.wheelPictureBox2 = new System.Windows.Forms.PictureBox();
            this.wheelPictureBox1 = new System.Windows.Forms.PictureBox();
            this.spinTimer = new System.Windows.Forms.Timer(this.components);
            this.balanceLabel = new System.Windows.Forms.Label();
            this.simulationOutputListBox = new System.Windows.Forms.ListBox();
            this.runSimulationButtton = new System.Windows.Forms.Button();
            this.numSimulationsLabel = new System.Windows.Forms.Label();
            this.numSimulationTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.winningsOutputLabel = new System.Windows.Forms.Label();
            this.beginningBalanceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wheelPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wheelPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wheelPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(68, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(472, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "SPIN!!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // wheelPictureBox3
            // 
            this.wheelPictureBox3.Image = global::Slot_Machine.Properties.Resources.orange;
            this.wheelPictureBox3.Location = new System.Drawing.Point(419, 72);
            this.wheelPictureBox3.Name = "wheelPictureBox3";
            this.wheelPictureBox3.Size = new System.Drawing.Size(150, 222);
            this.wheelPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wheelPictureBox3.TabIndex = 2;
            this.wheelPictureBox3.TabStop = false;
            // 
            // wheelPictureBox2
            // 
            this.wheelPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("wheelPictureBox2.Image")));
            this.wheelPictureBox2.Location = new System.Drawing.Point(229, 72);
            this.wheelPictureBox2.Name = "wheelPictureBox2";
            this.wheelPictureBox2.Size = new System.Drawing.Size(150, 222);
            this.wheelPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wheelPictureBox2.TabIndex = 1;
            this.wheelPictureBox2.TabStop = false;
            // 
            // wheelPictureBox1
            // 
            this.wheelPictureBox1.Image = global::Slot_Machine.Properties.Resources.grapes;
            this.wheelPictureBox1.Location = new System.Drawing.Point(41, 72);
            this.wheelPictureBox1.Name = "wheelPictureBox1";
            this.wheelPictureBox1.Size = new System.Drawing.Size(150, 222);
            this.wheelPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wheelPictureBox1.TabIndex = 0;
            this.wheelPictureBox1.TabStop = false;
            // 
            // spinTimer
            // 
            this.spinTimer.Interval = 50;
            this.spinTimer.Tick += new System.EventHandler(this.spinTimer_Tick);
            // 
            // balanceLabel
            // 
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.balanceLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.balanceLabel.Location = new System.Drawing.Point(128, 401);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(352, 52);
            this.balanceLabel.TabIndex = 4;
            this.balanceLabel.Text = "0";
            this.balanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // simulationOutputListBox
            // 
            this.simulationOutputListBox.BackColor = System.Drawing.Color.Black;
            this.simulationOutputListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.simulationOutputListBox.ForeColor = System.Drawing.Color.White;
            this.simulationOutputListBox.FormattingEnabled = true;
            this.simulationOutputListBox.ItemHeight = 29;
            this.simulationOutputListBox.Location = new System.Drawing.Point(613, 72);
            this.simulationOutputListBox.Name = "simulationOutputListBox";
            this.simulationOutputListBox.Size = new System.Drawing.Size(525, 352);
            this.simulationOutputListBox.TabIndex = 5;
            // 
            // runSimulationButtton
            // 
            this.runSimulationButtton.BackColor = System.Drawing.Color.Black;
            this.runSimulationButtton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.runSimulationButtton.FlatAppearance.BorderSize = 3;
            this.runSimulationButtton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runSimulationButtton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.runSimulationButtton.ForeColor = System.Drawing.SystemColors.Control;
            this.runSimulationButtton.Location = new System.Drawing.Point(694, 440);
            this.runSimulationButtton.Name = "runSimulationButtton";
            this.runSimulationButtton.Size = new System.Drawing.Size(318, 41);
            this.runSimulationButtton.TabIndex = 6;
            this.runSimulationButtton.Text = "Run Simulation";
            this.runSimulationButtton.UseVisualStyleBackColor = false;
            this.runSimulationButtton.Click += new System.EventHandler(this.runSimulationsButton_Click);
            // 
            // numSimulationsLabel
            // 
            this.numSimulationsLabel.AutoSize = true;
            this.numSimulationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.numSimulationsLabel.Location = new System.Drawing.Point(1144, 91);
            this.numSimulationsLabel.Name = "numSimulationsLabel";
            this.numSimulationsLabel.Size = new System.Drawing.Size(278, 29);
            this.numSimulationsLabel.TabIndex = 7;
            this.numSimulationsLabel.Text = "Number of Simulations:";
            // 
            // numSimulationTextBox
            // 
            this.numSimulationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numSimulationTextBox.Location = new System.Drawing.Point(1178, 135);
            this.numSimulationTextBox.Name = "numSimulationTextBox";
            this.numSimulationTextBox.Size = new System.Drawing.Size(100, 34);
            this.numSimulationTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(1159, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Winnings:";
            // 
            // winningsOutputLabel
            // 
            this.winningsOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.winningsOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.winningsOutputLabel.Location = new System.Drawing.Point(1178, 327);
            this.winningsOutputLabel.Name = "winningsOutputLabel";
            this.winningsOutputLabel.Size = new System.Drawing.Size(210, 83);
            this.winningsOutputLabel.TabIndex = 10;
            this.winningsOutputLabel.Text = "0";
            this.winningsOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // beginningBalanceTextBox
            // 
            this.beginningBalanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.beginningBalanceTextBox.Location = new System.Drawing.Point(1178, 242);
            this.beginningBalanceTextBox.Name = "beginningBalanceTextBox";
            this.beginningBalanceTextBox.Size = new System.Drawing.Size(100, 34);
            this.beginningBalanceTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(1144, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Beginning Balance:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1504, 508);
            this.Controls.Add(this.beginningBalanceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.winningsOutputLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numSimulationTextBox);
            this.Controls.Add(this.numSimulationsLabel);
            this.Controls.Add(this.runSimulationButtton);
            this.Controls.Add(this.simulationOutputListBox);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wheelPictureBox3);
            this.Controls.Add(this.wheelPictureBox2);
            this.Controls.Add(this.wheelPictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.wheelPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wheelPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wheelPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox wheelPictureBox1;
        private System.Windows.Forms.PictureBox wheelPictureBox2;
        private System.Windows.Forms.PictureBox wheelPictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer spinTimer;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.ListBox simulationOutputListBox;
        private System.Windows.Forms.Button runSimulationButtton;
        private System.Windows.Forms.Label numSimulationsLabel;
        private System.Windows.Forms.TextBox numSimulationTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label winningsOutputLabel;
        private System.Windows.Forms.TextBox beginningBalanceTextBox;
        private System.Windows.Forms.Label label2;
    }
}

