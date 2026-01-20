namespace InClassProject8
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.fahernheitTempLabel = new System.Windows.Forms.Label();
            this.celsiusTempLabel = new System.Windows.Forms.Label();
            this.outputCelsiusTemp = new System.Windows.Forms.Label();
            this.FahrenheitTempTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(75, 204);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(147, 36);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.titleLabel.Location = new System.Drawing.Point(70, 26);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(434, 36);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Fahrenheit to Celsius Converter";
            // 
            // fahernheitTempLabel
            // 
            this.fahernheitTempLabel.AutoSize = true;
            this.fahernheitTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.fahernheitTempLabel.Location = new System.Drawing.Point(70, 96);
            this.fahernheitTempLabel.Name = "fahernheitTempLabel";
            this.fahernheitTempLabel.Size = new System.Drawing.Size(362, 29);
            this.fahernheitTempLabel.TabIndex = 2;
            this.fahernheitTempLabel.Text = "Enter a Fahrenheit Temperature:";
            // 
            // celsiusTempLabel
            // 
            this.celsiusTempLabel.AutoSize = true;
            this.celsiusTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.celsiusTempLabel.Location = new System.Drawing.Point(71, 149);
            this.celsiusTempLabel.Name = "celsiusTempLabel";
            this.celsiusTempLabel.Size = new System.Drawing.Size(245, 29);
            this.celsiusTempLabel.TabIndex = 3;
            this.celsiusTempLabel.Text = "Celsius Temperature:";
            // 
            // outputCelsiusTemp
            // 
            this.outputCelsiusTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputCelsiusTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.outputCelsiusTemp.Location = new System.Drawing.Point(322, 149);
            this.outputCelsiusTemp.Name = "outputCelsiusTemp";
            this.outputCelsiusTemp.Size = new System.Drawing.Size(165, 29);
            this.outputCelsiusTemp.TabIndex = 4;
            // 
            // FahrenheitTempTextBox
            // 
            this.FahrenheitTempTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FahrenheitTempTextBox.Location = new System.Drawing.Point(438, 96);
            this.FahrenheitTempTextBox.Name = "FahrenheitTempTextBox";
            this.FahrenheitTempTextBox.Size = new System.Drawing.Size(125, 34);
            this.FahrenheitTempTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FahrenheitTempTextBox);
            this.Controls.Add(this.outputCelsiusTemp);
            this.Controls.Add(this.celsiusTempLabel);
            this.Controls.Add(this.fahernheitTempLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label fahernheitTempLabel;
        private System.Windows.Forms.Label celsiusTempLabel;
        private System.Windows.Forms.Label outputCelsiusTemp;
        private System.Windows.Forms.TextBox FahrenheitTempTextBox;
    }
}

