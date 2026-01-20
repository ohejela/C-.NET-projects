namespace Lab_3_Test
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.numberOfDicelabel = new System.Windows.Forms.Label();
            this.numberOfSidesLabel = new System.Windows.Forms.Label();
            this.targetSumLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.targetSumTextBox = new System.Windows.Forms.TextBox();
            this.numberofSidesTextBox = new System.Windows.Forms.TextBox();
            this.numberofDiceTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titleLabel.Location = new System.Drawing.Point(60, 21);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(257, 39);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Rolling the Dice";
            // 
            // numberOfDicelabel
            // 
            this.numberOfDicelabel.AutoSize = true;
            this.numberOfDicelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numberOfDicelabel.Location = new System.Drawing.Point(58, 83);
            this.numberOfDicelabel.Name = "numberOfDicelabel";
            this.numberOfDicelabel.Size = new System.Drawing.Size(152, 25);
            this.numberOfDicelabel.TabIndex = 1;
            this.numberOfDicelabel.Text = "Number of Dice:";
            // 
            // numberOfSidesLabel
            // 
            this.numberOfSidesLabel.AutoSize = true;
            this.numberOfSidesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numberOfSidesLabel.Location = new System.Drawing.Point(58, 135);
            this.numberOfSidesLabel.Name = "numberOfSidesLabel";
            this.numberOfSidesLabel.Size = new System.Drawing.Size(163, 25);
            this.numberOfSidesLabel.TabIndex = 2;
            this.numberOfSidesLabel.Text = "Number of Sides:";
            // 
            // targetSumLabel
            // 
            this.targetSumLabel.AutoSize = true;
            this.targetSumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.targetSumLabel.Location = new System.Drawing.Point(62, 193);
            this.targetSumLabel.Name = "targetSumLabel";
            this.targetSumLabel.Size = new System.Drawing.Size(121, 25);
            this.targetSumLabel.TabIndex = 3;
            this.targetSumLabel.Text = "Target Sum:";
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.outputLabel.Location = new System.Drawing.Point(471, 291);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(302, 42);
            this.outputLabel.TabIndex = 4;
            // 
            // targetSumTextBox
            // 
            this.targetSumTextBox.Location = new System.Drawing.Point(240, 197);
            this.targetSumTextBox.Name = "targetSumTextBox";
            this.targetSumTextBox.Size = new System.Drawing.Size(100, 22);
            this.targetSumTextBox.TabIndex = 5;
            // 
            // numberofSidesTextBox
            // 
            this.numberofSidesTextBox.Location = new System.Drawing.Point(240, 139);
            this.numberofSidesTextBox.Name = "numberofSidesTextBox";
            this.numberofSidesTextBox.Size = new System.Drawing.Size(100, 22);
            this.numberofSidesTextBox.TabIndex = 6;
            // 
            // numberofDiceTextBox
            // 
            this.numberofDiceTextBox.Location = new System.Drawing.Point(240, 83);
            this.numberofDiceTextBox.Name = "numberofDiceTextBox";
            this.numberofDiceTextBox.Size = new System.Drawing.Size(100, 22);
            this.numberofDiceTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(369, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 134);
            this.button1.TabIndex = 8;
            this.button1.Text = "Simulate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(34, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 46);
            this.button2.TabIndex = 9;
            this.button2.Text = "Show Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(183, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 46);
            this.button3.TabIndex = 10;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.Location = new System.Drawing.Point(322, 277);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 46);
            this.button4.TabIndex = 11;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 16;
            this.outputListBox.Location = new System.Drawing.Point(532, 52);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(195, 212);
            this.outputListBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numberofDiceTextBox);
            this.Controls.Add(this.numberofSidesTextBox);
            this.Controls.Add(this.targetSumTextBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.targetSumLabel);
            this.Controls.Add(this.numberOfSidesLabel);
            this.Controls.Add(this.numberOfDicelabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label numberOfDicelabel;
        private System.Windows.Forms.Label numberOfSidesLabel;
        private System.Windows.Forms.Label targetSumLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox targetSumTextBox;
        private System.Windows.Forms.TextBox numberofSidesTextBox;
        private System.Windows.Forms.TextBox numberofDiceTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox outputListBox;
    }
}

