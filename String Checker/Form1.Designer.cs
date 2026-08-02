namespace String_Checker
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
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uppercaseLabel = new System.Windows.Forms.Label();
            this.vowelLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.submitButton.Location = new System.Drawing.Point(27, 171);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(108, 38);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.clearButton.Location = new System.Drawing.Point(153, 171);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(95, 38);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.exitButton.ForeColor = System.Drawing.Color.Firebrick;
            this.exitButton.Location = new System.Drawing.Point(581, 171);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(95, 38);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "String Checker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(24, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(652, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter something in the box below, and then click the submit button";
            // 
            // uppercaseLabel
            // 
            this.uppercaseLabel.AutoSize = true;
            this.uppercaseLabel.BackColor = System.Drawing.SystemColors.Control;
            this.uppercaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.uppercaseLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.uppercaseLabel.Location = new System.Drawing.Point(24, 223);
            this.uppercaseLabel.Name = "uppercaseLabel";
            this.uppercaseLabel.Size = new System.Drawing.Size(0, 29);
            this.uppercaseLabel.TabIndex = 5;
            // 
            // vowelLabel
            // 
            this.vowelLabel.AutoSize = true;
            this.vowelLabel.BackColor = System.Drawing.SystemColors.Control;
            this.vowelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.vowelLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.vowelLabel.Location = new System.Drawing.Point(24, 314);
            this.vowelLabel.Name = "vowelLabel";
            this.vowelLabel.Size = new System.Drawing.Size(0, 29);
            this.vowelLabel.TabIndex = 6;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.inputTextBox.Location = new System.Drawing.Point(27, 133);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(649, 32);
            this.inputTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.vowelLabel);
            this.Controls.Add(this.uppercaseLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label uppercaseLabel;
        private System.Windows.Forms.Label vowelLabel;
        private System.Windows.Forms.TextBox inputTextBox;
    }
}

