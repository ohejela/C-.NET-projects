namespace InClassProject2
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
            this.helloLabel = new System.Windows.Forms.Label();
            this.goodByeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Location = new System.Drawing.Point(250, 123);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(39, 16);
            this.helloLabel.TabIndex = 0;
            this.helloLabel.Text = "Hello";
            this.helloLabel.Click += new System.EventHandler(this.helloLabel_Click);
            // 
            // goodByeLabel
            // 
            this.goodByeLabel.AutoSize = true;
            this.goodByeLabel.Location = new System.Drawing.Point(504, 123);
            this.goodByeLabel.Name = "goodByeLabel";
            this.goodByeLabel.Size = new System.Drawing.Size(64, 16);
            this.goodByeLabel.TabIndex = 1;
            this.goodByeLabel.Text = "Goodbye";
            this.goodByeLabel.Click += new System.EventHandler(this.goodByeLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goodByeLabel);
            this.Controls.Add(this.helloLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.Label goodByeLabel;
    }
}

