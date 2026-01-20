namespace Lab1
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
            this.helloButton = new System.Windows.Forms.Button();
            this.goodbyeButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.helloLabel = new System.Windows.Forms.Label();
            this.goodbyeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // helloButton
            // 
            this.helloButton.Location = new System.Drawing.Point(174, 176);
            this.helloButton.Name = "helloButton";
            this.helloButton.Size = new System.Drawing.Size(113, 23);
            this.helloButton.TabIndex = 0;
            this.helloButton.Text = "Say Hello";
            this.helloButton.UseVisualStyleBackColor = true;
            this.helloButton.Click += new System.EventHandler(this.helloButton_Click);
            // 
            // goodbyeButton
            // 
            this.goodbyeButton.Location = new System.Drawing.Point(474, 176);
            this.goodbyeButton.Name = "goodbyeButton";
            this.goodbyeButton.Size = new System.Drawing.Size(103, 23);
            this.goodbyeButton.TabIndex = 1;
            this.goodbyeButton.Text = "Say Goodbye";
            this.goodbyeButton.UseVisualStyleBackColor = true;
            this.goodbyeButton.Click += new System.EventHandler(this.goodbyeButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(344, 221);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // helloLabel
            // 
            this.helloLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloLabel.Location = new System.Drawing.Point(162, 76);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(142, 60);
            this.helloLabel.TabIndex = 3;
            this.helloLabel.Text = "Blank";
            this.helloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goodbyeLabel
            // 
            this.goodbyeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.goodbyeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodbyeLabel.Location = new System.Drawing.Point(460, 76);
            this.goodbyeLabel.Name = "goodbyeLabel";
            this.goodbyeLabel.Size = new System.Drawing.Size(137, 60);
            this.goodbyeLabel.TabIndex = 4;
            this.goodbyeLabel.Text = "Blank";
            this.goodbyeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goodbyeLabel);
            this.Controls.Add(this.helloLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.goodbyeButton);
            this.Controls.Add(this.helloButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button helloButton;
        private System.Windows.Forms.Button goodbyeButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.Label goodbyeLabel;
    }
}

