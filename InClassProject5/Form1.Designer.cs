namespace InClassProject5
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
            this.addSymbolButton = new System.Windows.Forms.Button();
            this.nextLineButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addSymbolButton
            // 
            this.addSymbolButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSymbolButton.Location = new System.Drawing.Point(12, 154);
            this.addSymbolButton.Name = "addSymbolButton";
            this.addSymbolButton.Size = new System.Drawing.Size(187, 48);
            this.addSymbolButton.TabIndex = 0;
            this.addSymbolButton.Text = "Add Symbol";
            this.addSymbolButton.UseVisualStyleBackColor = true;
            this.addSymbolButton.Click += new System.EventHandler(this.addSymbolButton_Click);
            // 
            // nextLineButton
            // 
            this.nextLineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextLineButton.Location = new System.Drawing.Point(233, 154);
            this.nextLineButton.Name = "nextLineButton";
            this.nextLineButton.Size = new System.Drawing.Size(142, 48);
            this.nextLineButton.TabIndex = 1;
            this.nextLineButton.Text = "Next Line";
            this.nextLineButton.UseVisualStyleBackColor = true;
            this.nextLineButton.Click += new System.EventHandler(this.nextLineButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.titleLabel.Location = new System.Drawing.Point(12, 21);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(316, 48);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Pyramid Builder";
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inputLabel.Location = new System.Drawing.Point(17, 87);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(194, 29);
            this.inputLabel.TabIndex = 3;
            this.inputLabel.Text = "Enter a Symbol:";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.outputLabel.Location = new System.Drawing.Point(449, 36);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(134, 31);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Text = "                 ";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inputTextBox.Location = new System.Drawing.Point(217, 80);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 36);
            this.inputTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.nextLineButton);
            this.Controls.Add(this.addSymbolButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addSymbolButton;
        private System.Windows.Forms.Button nextLineButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox inputTextBox;
    }
}

