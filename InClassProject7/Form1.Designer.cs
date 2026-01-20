namespace InClassProject7
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
            this.addButton = new System.Windows.Forms.Button();
            this.subButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.multiButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.addButton.Location = new System.Drawing.Point(223, 184);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(98, 39);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "5 + 4";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subButton
            // 
            this.subButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.subButton.Location = new System.Drawing.Point(442, 184);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(92, 39);
            this.subButton.TabIndex = 1;
            this.subButton.Text = "5 - 4";
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.Click += new System.EventHandler(this.subButton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.divisionButton.Location = new System.Drawing.Point(223, 260);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(98, 42);
            this.divisionButton.TabIndex = 2;
            this.divisionButton.Text = "5 / 4";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.divisionButton_Click);
            // 
            // multiButton
            // 
            this.multiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.multiButton.Location = new System.Drawing.Point(442, 260);
            this.multiButton.Name = "multiButton";
            this.multiButton.Size = new System.Drawing.Size(92, 42);
            this.multiButton.TabIndex = 3;
            this.multiButton.Text = "5 * 4";
            this.multiButton.UseVisualStyleBackColor = true;
            this.multiButton.Click += new System.EventHandler(this.multiButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.outputLabel.Location = new System.Drawing.Point(264, 88);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(229, 39);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textLabel.Location = new System.Drawing.Point(220, 20);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(276, 36);
            this.textLabel.TabIndex = 5;
            this.textLabel.Text = "Simple Calculations";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.multiButton);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button multiButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label textLabel;
    }
}

