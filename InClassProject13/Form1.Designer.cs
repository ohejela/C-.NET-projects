namespace InClassProject13
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
            this.num1Label = new System.Windows.Forms.Label();
            this.num2Label = new System.Windows.Forms.Label();
            this.num3Label = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.num1TextBox = new System.Windows.Forms.TextBox();
            this.num2TextBox = new System.Windows.Forms.TextBox();
            this.num3Textbox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1Label
            // 
            this.num1Label.AutoSize = true;
            this.num1Label.BackColor = System.Drawing.Color.Transparent;
            this.num1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.num1Label.Location = new System.Drawing.Point(65, 95);
            this.num1Label.Name = "num1Label";
            this.num1Label.Size = new System.Drawing.Size(118, 25);
            this.num1Label.TabIndex = 0;
            this.num1Label.Text = "1st Number:";
            // 
            // num2Label
            // 
            this.num2Label.AutoSize = true;
            this.num2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.num2Label.Location = new System.Drawing.Point(65, 154);
            this.num2Label.Name = "num2Label";
            this.num2Label.Size = new System.Drawing.Size(125, 25);
            this.num2Label.TabIndex = 1;
            this.num2Label.Text = "2nd Number:";
            // 
            // num3Label
            // 
            this.num3Label.AutoSize = true;
            this.num3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.num3Label.Location = new System.Drawing.Point(65, 210);
            this.num3Label.Name = "num3Label";
            this.num3Label.Size = new System.Drawing.Size(133, 26);
            this.num3Label.TabIndex = 2;
            this.num3Label.Text = "3rd Number:";
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.outputLabel.Location = new System.Drawing.Point(503, 89);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(231, 147);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num1TextBox
            // 
            this.num1TextBox.Location = new System.Drawing.Point(208, 95);
            this.num1TextBox.Name = "num1TextBox";
            this.num1TextBox.Size = new System.Drawing.Size(100, 22);
            this.num1TextBox.TabIndex = 4;
            // 
            // num2TextBox
            // 
            this.num2TextBox.Location = new System.Drawing.Point(208, 154);
            this.num2TextBox.Name = "num2TextBox";
            this.num2TextBox.Size = new System.Drawing.Size(100, 22);
            this.num2TextBox.TabIndex = 5;
            // 
            // num3Textbox
            // 
            this.num3Textbox.Location = new System.Drawing.Point(208, 210);
            this.num3Textbox.Name = "num3Textbox";
            this.num3Textbox.Size = new System.Drawing.Size(100, 22);
            this.num3Textbox.TabIndex = 6;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.calculateButton.Location = new System.Drawing.Point(70, 260);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(626, 43);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate Greatest Value";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.num3Textbox);
            this.Controls.Add(this.num2TextBox);
            this.Controls.Add(this.num1TextBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.num3Label);
            this.Controls.Add(this.num2Label);
            this.Controls.Add(this.num1Label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num1Label;
        private System.Windows.Forms.Label num2Label;
        private System.Windows.Forms.Label num3Label;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox num1TextBox;
        private System.Windows.Forms.TextBox num2TextBox;
        private System.Windows.Forms.TextBox num3Textbox;
        private System.Windows.Forms.Button calculateButton;
    }
}

