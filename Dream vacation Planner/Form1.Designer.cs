namespace InClassAssignment16
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
            this.destination = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.activities = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numLabel = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.planButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.destination.SuspendLayout();
            this.activities.SuspendLayout();
            this.SuspendLayout();
            // 
            // destination
            // 
            this.destination.Controls.Add(this.radioButton3);
            this.destination.Controls.Add(this.radioButton2);
            this.destination.Controls.Add(this.radioButton1);
            this.destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.destination.Location = new System.Drawing.Point(27, 34);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(283, 140);
            this.destination.TabIndex = 0;
            this.destination.TabStop = false;
            this.destination.Text = "Destination Type";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(11, 105);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(177, 29);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "City Light ($700)";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(11, 70);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(261, 29);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Moutain Adventure ($600)";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 35);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(234, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Beach Paradise ($500)";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // activities
            // 
            this.activities.Controls.Add(this.checkBox4);
            this.activities.Controls.Add(this.checkBox3);
            this.activities.Controls.Add(this.checkBox2);
            this.activities.Controls.Add(this.checkBox1);
            this.activities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.activities.Location = new System.Drawing.Point(27, 224);
            this.activities.Name = "activities";
            this.activities.Size = new System.Drawing.Size(283, 227);
            this.activities.TabIndex = 3;
            this.activities.TabStop = false;
            this.activities.Text = "Activities";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(11, 151);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(219, 29);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Nightlife Tour(+$120)";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(11, 116);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(205, 29);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Hiking Trails (+$80)";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(11, 81);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(185, 29);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Spa Day (+$150)";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 46);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(202, 29);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Snorkeling (+$100)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numLabel.Location = new System.Drawing.Point(22, 494);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(152, 25);
            this.numLabel.TabIndex = 4;
            this.numLabel.Text = "Number of Days";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(211, 498);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(100, 22);
            this.outputTextBox.TabIndex = 5;
            // 
            // planButton
            // 
            this.planButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.planButton.Location = new System.Drawing.Point(30, 532);
            this.planButton.Name = "planButton";
            this.planButton.Size = new System.Drawing.Size(210, 34);
            this.planButton.TabIndex = 6;
            this.planButton.Text = "Plan My Trip!";
            this.planButton.UseVisualStyleBackColor = true;
            this.planButton.Click += new System.EventHandler(this.planButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.totalLabel.Location = new System.Drawing.Point(47, 581);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(151, 25);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "Total Cost: $0.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 707);
            this.Controls.Add(this.numLabel);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.planButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.activities);
            this.Controls.Add(this.destination);
            this.Name = "Form1";
            this.Text = "Form1";
            this.destination.ResumeLayout(false);
            this.destination.PerformLayout();
            this.activities.ResumeLayout(false);
            this.activities.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox destination;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox activities;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button planButton;
        private System.Windows.Forms.Label totalLabel;
    }
}

