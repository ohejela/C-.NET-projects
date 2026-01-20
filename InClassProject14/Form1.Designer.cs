namespace InClassProject14
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
            this.checkButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.inputNum1Label = new System.Windows.Forms.Label();
            this.inputNum2Label = new System.Windows.Forms.Label();
            this.inputTextBox2 = new System.Windows.Forms.TextBox();
            this.inputTextBox1 = new System.Windows.Forms.TextBox();
            this.outputLabel2 = new System.Windows.Forms.Label();
            this.ouputLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.LimeGreen;
            this.checkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkButton.Location = new System.Drawing.Point(15, 192);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(188, 49);
            this.checkButton.TabIndex = 0;
            this.checkButton.Text = "Check Numbers";
            this.checkButton.UseVisualStyleBackColor = false;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titleLabel.Location = new System.Drawing.Point(8, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(330, 39);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Number Checker 2.0";
            // 
            // inputNum1Label
            // 
            this.inputNum1Label.AutoSize = true;
            this.inputNum1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputNum1Label.Location = new System.Drawing.Point(12, 74);
            this.inputNum1Label.Name = "inputNum1Label";
            this.inputNum1Label.Size = new System.Drawing.Size(291, 25);
            this.inputNum1Label.TabIndex = 2;
            this.inputNum1Label.Text = "Enter a Number Between 40-50:";
            // 
            // inputNum2Label
            // 
            this.inputNum2Label.AutoSize = true;
            this.inputNum2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputNum2Label.Location = new System.Drawing.Point(12, 134);
            this.inputNum2Label.Name = "inputNum2Label";
            this.inputNum2Label.Size = new System.Drawing.Size(449, 25);
            this.inputNum2Label.TabIndex = 3;
            this.inputNum2Label.Text = "Enter a Number Less Than 40 or Greater Than 50:";
            // 
            // inputTextBox2
            // 
            this.inputTextBox2.Location = new System.Drawing.Point(492, 138);
            this.inputTextBox2.Name = "inputTextBox2";
            this.inputTextBox2.Size = new System.Drawing.Size(100, 22);
            this.inputTextBox2.TabIndex = 4;
            // 
            // inputTextBox1
            // 
            this.inputTextBox1.Location = new System.Drawing.Point(330, 80);
            this.inputTextBox1.Name = "inputTextBox1";
            this.inputTextBox1.Size = new System.Drawing.Size(100, 22);
            this.inputTextBox1.TabIndex = 5;
            // 
            // outputLabel2
            // 
            this.outputLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.outputLabel2.ForeColor = System.Drawing.Color.Red;
            this.outputLabel2.Location = new System.Drawing.Point(598, 133);
            this.outputLabel2.Name = "outputLabel2";
            this.outputLabel2.Size = new System.Drawing.Size(190, 33);
            this.outputLabel2.TabIndex = 6;
            // 
            // ouputLabel1
            // 
            this.ouputLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ouputLabel1.ForeColor = System.Drawing.Color.Red;
            this.ouputLabel1.Location = new System.Drawing.Point(497, 76);
            this.ouputLabel1.Name = "ouputLabel1";
            this.ouputLabel1.Size = new System.Drawing.Size(153, 23);
            this.ouputLabel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ouputLabel1);
            this.Controls.Add(this.outputLabel2);
            this.Controls.Add(this.inputTextBox1);
            this.Controls.Add(this.inputTextBox2);
            this.Controls.Add(this.inputNum2Label);
            this.Controls.Add(this.inputNum1Label);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.checkButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label inputNum1Label;
        private System.Windows.Forms.Label inputNum2Label;
        private System.Windows.Forms.TextBox inputTextBox2;
        private System.Windows.Forms.TextBox inputTextBox1;
        private System.Windows.Forms.Label outputLabel2;
        private System.Windows.Forms.Label ouputLabel1;
    }
}

