namespace DateTimePicker
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.monthsButton = new System.Windows.Forms.Button();
            this.yearsButton = new System.Windows.Forms.Button();
            this.daysButton = new System.Windows.Forms.Button();
            this.millisecondsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.newDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(365, 108);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(493, 30);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(161, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Date:";
            // 
            // monthsButton
            // 
            this.monthsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.monthsButton.Location = new System.Drawing.Point(208, 183);
            this.monthsButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.monthsButton.Name = "monthsButton";
            this.monthsButton.Size = new System.Drawing.Size(151, 37);
            this.monthsButton.TabIndex = 2;
            this.monthsButton.Text = "Add Months";
            this.monthsButton.UseVisualStyleBackColor = true;
            this.monthsButton.Click += new System.EventHandler(this.monthsButton_Click);
            // 
            // yearsButton
            // 
            this.yearsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.yearsButton.Location = new System.Drawing.Point(396, 183);
            this.yearsButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.yearsButton.Name = "yearsButton";
            this.yearsButton.Size = new System.Drawing.Size(164, 37);
            this.yearsButton.TabIndex = 3;
            this.yearsButton.Text = "Subtract Years";
            this.yearsButton.UseVisualStyleBackColor = true;
            this.yearsButton.Click += new System.EventHandler(this.yearsButton_Click);
            // 
            // daysButton
            // 
            this.daysButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.daysButton.Location = new System.Drawing.Point(593, 183);
            this.daysButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.daysButton.Name = "daysButton";
            this.daysButton.Size = new System.Drawing.Size(113, 37);
            this.daysButton.TabIndex = 4;
            this.daysButton.Text = "Add days";
            this.daysButton.UseVisualStyleBackColor = true;
            this.daysButton.Click += new System.EventHandler(this.daysButton_Click);
            // 
            // millisecondsButton
            // 
            this.millisecondsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.millisecondsButton.Location = new System.Drawing.Point(732, 181);
            this.millisecondsButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.millisecondsButton.Name = "millisecondsButton";
            this.millisecondsButton.Size = new System.Drawing.Size(205, 39);
            this.millisecondsButton.TabIndex = 5;
            this.millisecondsButton.Text = "Subtract milliseconds";
            this.millisecondsButton.UseVisualStyleBackColor = true;
            this.millisecondsButton.Click += new System.EventHandler(this.millisecondsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(283, 294);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "New Date:";
            // 
            // newDateLabel
            // 
            this.newDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.newDateLabel.Location = new System.Drawing.Point(396, 285);
            this.newDateLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.newDateLabel.Name = "newDateLabel";
            this.newDateLabel.Size = new System.Drawing.Size(469, 34);
            this.newDateLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.newDateLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.millisecondsButton);
            this.Controls.Add(this.daysButton);
            this.Controls.Add(this.yearsButton);
            this.Controls.Add(this.monthsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button monthsButton;
        private System.Windows.Forms.Button yearsButton;
        private System.Windows.Forms.Button daysButton;
        private System.Windows.Forms.Button millisecondsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label newDateLabel;
    }
}

