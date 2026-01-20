namespace InClassProject9
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
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.inputLabel = new System.Windows.Forms.Label();
            this.stateTaxLabel = new System.Windows.Forms.Label();
            this.localTaxLabel = new System.Windows.Forms.Label();
            this.outputStateTaxLabel = new System.Windows.Forms.Label();
            this.outputLocalTaxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.outputTotalLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.calculateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.calculateButton.Location = new System.Drawing.Point(95, 293);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(194, 42);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.clearButton.Location = new System.Drawing.Point(318, 293);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(194, 42);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Pink;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.exitButton.Location = new System.Drawing.Point(576, 293);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(194, 42);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.titleLabel.Location = new System.Drawing.Point(120, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(531, 44);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Sales Tax and Total Calculator";
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.inputLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.inputLabel.Location = new System.Drawing.Point(114, 67);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(322, 31);
            this.inputLabel.TabIndex = 4;
            this.inputLabel.Text = "Enter a Puchase Amount:";
            // 
            // stateTaxLabel
            // 
            this.stateTaxLabel.AutoSize = true;
            this.stateTaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.stateTaxLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.stateTaxLabel.Location = new System.Drawing.Point(155, 183);
            this.stateTaxLabel.Name = "stateTaxLabel";
            this.stateTaxLabel.Size = new System.Drawing.Size(148, 25);
            this.stateTaxLabel.TabIndex = 5;
            this.stateTaxLabel.Text = "State Tax 10%:";
            // 
            // localTaxLabel
            // 
            this.localTaxLabel.AutoSize = true;
            this.localTaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.localTaxLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.localTaxLabel.Location = new System.Drawing.Point(157, 226);
            this.localTaxLabel.Name = "localTaxLabel";
            this.localTaxLabel.Size = new System.Drawing.Size(138, 25);
            this.localTaxLabel.TabIndex = 6;
            this.localTaxLabel.Text = "Local Tax 4%:";
            // 
            // outputStateTaxLabel
            // 
            this.outputStateTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputStateTaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.outputStateTaxLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.outputStateTaxLabel.Location = new System.Drawing.Point(309, 183);
            this.outputStateTaxLabel.Name = "outputStateTaxLabel";
            this.outputStateTaxLabel.Size = new System.Drawing.Size(97, 25);
            this.outputStateTaxLabel.TabIndex = 7;
            this.outputStateTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputLocalTaxLabel
            // 
            this.outputLocalTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLocalTaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.outputLocalTaxLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.outputLocalTaxLabel.Location = new System.Drawing.Point(309, 226);
            this.outputLocalTaxLabel.Name = "outputLocalTaxLabel";
            this.outputLocalTaxLabel.Size = new System.Drawing.Size(97, 25);
            this.outputLocalTaxLabel.TabIndex = 8;
            this.outputLocalTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.totalLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.totalLabel.Location = new System.Drawing.Point(467, 127);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(74, 29);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total:";
            // 
            // outputTotalLabel
            // 
            this.outputTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.outputTotalLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.outputTotalLabel.Location = new System.Drawing.Point(472, 165);
            this.outputTotalLabel.Name = "outputTotalLabel";
            this.outputTotalLabel.Size = new System.Drawing.Size(245, 86);
            this.outputTotalLabel.TabIndex = 10;
            this.outputTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.inputTextBox.Location = new System.Drawing.Point(452, 64);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(159, 38);
            this.inputTextBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.outputTotalLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.outputLocalTaxLabel);
            this.Controls.Add(this.outputStateTaxLabel);
            this.Controls.Add(this.localTaxLabel);
            this.Controls.Add(this.stateTaxLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label stateTaxLabel;
        private System.Windows.Forms.Label localTaxLabel;
        private System.Windows.Forms.Label outputStateTaxLabel;
        private System.Windows.Forms.Label outputLocalTaxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label outputTotalLabel;
        private System.Windows.Forms.TextBox inputTextBox;
    }
}

