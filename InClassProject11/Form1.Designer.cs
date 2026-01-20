namespace InClassProject11
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.inputCookieTextBox = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.boxLabel = new System.Windows.Forms.Label();
            this.containerLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ouputBoxLabel = new System.Windows.Forms.Label();
            this.outputContainerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::InClassProject11.Properties.Resources.cookie;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 87);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Segoe Print", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(234, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(354, 65);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Cookie Calculator";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::InClassProject11.Properties.Resources.cookie_divider2;
            this.pictureBox2.Location = new System.Drawing.Point(0, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(765, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // inputCookieTextBox
            // 
            this.inputCookieTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputCookieTextBox.Location = new System.Drawing.Point(350, 164);
            this.inputCookieTextBox.Name = "inputCookieTextBox";
            this.inputCookieTextBox.Size = new System.Drawing.Size(248, 30);
            this.inputCookieTextBox.TabIndex = 3;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.BackColor = System.Drawing.Color.Transparent;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputLabel.Location = new System.Drawing.Point(7, 167);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(313, 25);
            this.inputLabel.TabIndex = 4;
            this.inputLabel.Text = "Number of Cookies to Be Shipped:";
            // 
            // boxLabel
            // 
            this.boxLabel.AutoSize = true;
            this.boxLabel.BackColor = System.Drawing.Color.Transparent;
            this.boxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.boxLabel.Location = new System.Drawing.Point(7, 226);
            this.boxLabel.Name = "boxLabel";
            this.boxLabel.Size = new System.Drawing.Size(251, 25);
            this.boxLabel.TabIndex = 5;
            this.boxLabel.Text = "Number of Boxes Required:";
            // 
            // containerLabel
            // 
            this.containerLabel.AutoSize = true;
            this.containerLabel.BackColor = System.Drawing.Color.Transparent;
            this.containerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.containerLabel.Location = new System.Drawing.Point(7, 278);
            this.containerLabel.Name = "containerLabel";
            this.containerLabel.Size = new System.Drawing.Size(297, 25);
            this.containerLabel.TabIndex = 6;
            this.containerLabel.Text = "Number of Containerrs Required:";
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.calculateButton.Location = new System.Drawing.Point(622, 164);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(127, 31);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(665, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ouputBoxLabel
            // 
            this.ouputBoxLabel.BackColor = System.Drawing.Color.Transparent;
            this.ouputBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ouputBoxLabel.Location = new System.Drawing.Point(331, 226);
            this.ouputBoxLabel.Name = "ouputBoxLabel";
            this.ouputBoxLabel.Size = new System.Drawing.Size(100, 23);
            this.ouputBoxLabel.TabIndex = 9;
            // 
            // outputContainerLabel
            // 
            this.outputContainerLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputContainerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.outputContainerLabel.Location = new System.Drawing.Point(328, 285);
            this.outputContainerLabel.Name = "outputContainerLabel";
            this.outputContainerLabel.Size = new System.Drawing.Size(100, 23);
            this.outputContainerLabel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InClassProject11.Properties.Resources.cookie_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(761, 472);
            this.Controls.Add(this.outputContainerLabel);
            this.Controls.Add(this.ouputBoxLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.containerLabel);
            this.Controls.Add(this.boxLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.inputCookieTextBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox inputCookieTextBox;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label boxLabel;
        private System.Windows.Forms.Label containerLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ouputBoxLabel;
        private System.Windows.Forms.Label outputContainerLabel;
    }
}

