namespace InClassProject10
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.integerLabel = new System.Windows.Forms.Label();
            this.decimalLabel = new System.Windows.Forms.Label();
            this.booleanLabel = new System.Windows.Forms.Label();
            this.intTextBox = new System.Windows.Forms.TextBox();
            this.decimalTextBox = new System.Windows.Forms.TextBox();
            this.booleanTextBox = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.intErrorLabel = new System.Windows.Forms.Label();
            this.decimalErrorLabel = new System.Windows.Forms.Label();
            this.boolErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titleLabel.Location = new System.Drawing.Point(119, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(274, 39);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Number Checker";
            // 
            // integerLabel
            // 
            this.integerLabel.AutoSize = true;
            this.integerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.integerLabel.Location = new System.Drawing.Point(121, 99);
            this.integerLabel.Name = "integerLabel";
            this.integerLabel.Size = new System.Drawing.Size(212, 25);
            this.integerLabel.TabIndex = 1;
            this.integerLabel.Text = "Enter an Integer Value:";
            // 
            // decimalLabel
            // 
            this.decimalLabel.AutoSize = true;
            this.decimalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.decimalLabel.Location = new System.Drawing.Point(121, 145);
            this.decimalLabel.Name = "decimalLabel";
            this.decimalLabel.Size = new System.Drawing.Size(211, 25);
            this.decimalLabel.TabIndex = 2;
            this.decimalLabel.Text = "Enter a Decimal Value:";
            // 
            // booleanLabel
            // 
            this.booleanLabel.AutoSize = true;
            this.booleanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.booleanLabel.Location = new System.Drawing.Point(121, 197);
            this.booleanLabel.Name = "booleanLabel";
            this.booleanLabel.Size = new System.Drawing.Size(213, 25);
            this.booleanLabel.TabIndex = 3;
            this.booleanLabel.Text = "Enter a Boolean Value:";
            // 
            // intTextBox
            // 
            this.intTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.intTextBox.Location = new System.Drawing.Point(350, 90);
            this.intTextBox.Name = "intTextBox";
            this.intTextBox.Size = new System.Drawing.Size(100, 34);
            this.intTextBox.TabIndex = 4;
            // 
            // decimalTextBox
            // 
            this.decimalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.decimalTextBox.Location = new System.Drawing.Point(350, 139);
            this.decimalTextBox.Name = "decimalTextBox";
            this.decimalTextBox.Size = new System.Drawing.Size(100, 34);
            this.decimalTextBox.TabIndex = 5;
            // 
            // booleanTextBox
            // 
            this.booleanTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.booleanTextBox.Location = new System.Drawing.Point(350, 191);
            this.booleanTextBox.Name = "booleanTextBox";
            this.booleanTextBox.Size = new System.Drawing.Size(100, 34);
            this.booleanTextBox.TabIndex = 6;
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.PaleGreen;
            this.checkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.checkButton.Location = new System.Drawing.Point(126, 256);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(128, 79);
            this.checkButton.TabIndex = 7;
            this.checkButton.Text = "Check Numbers";
            this.checkButton.UseVisualStyleBackColor = false;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.PeachPuff;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.clearButton.Location = new System.Drawing.Point(274, 256);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(116, 79);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(409, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 79);
            this.button3.TabIndex = 9;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // intErrorLabel
            // 
            this.intErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.intErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.intErrorLabel.Location = new System.Drawing.Point(483, 95);
            this.intErrorLabel.Name = "intErrorLabel";
            this.intErrorLabel.Size = new System.Drawing.Size(164, 29);
            this.intErrorLabel.TabIndex = 10;
            // 
            // decimalErrorLabel
            // 
            this.decimalErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.decimalErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.decimalErrorLabel.Location = new System.Drawing.Point(483, 141);
            this.decimalErrorLabel.Name = "decimalErrorLabel";
            this.decimalErrorLabel.Size = new System.Drawing.Size(274, 31);
            this.decimalErrorLabel.TabIndex = 11;
            // 
            // boolErrorLabel
            // 
            this.boolErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.boolErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.boolErrorLabel.Location = new System.Drawing.Point(483, 191);
            this.boolErrorLabel.Name = "boolErrorLabel";
            this.boolErrorLabel.Size = new System.Drawing.Size(274, 31);
            this.boolErrorLabel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boolErrorLabel);
            this.Controls.Add(this.decimalErrorLabel);
            this.Controls.Add(this.intErrorLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.booleanTextBox);
            this.Controls.Add(this.decimalTextBox);
            this.Controls.Add(this.intTextBox);
            this.Controls.Add(this.booleanLabel);
            this.Controls.Add(this.decimalLabel);
            this.Controls.Add(this.integerLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label integerLabel;
        private System.Windows.Forms.Label decimalLabel;
        private System.Windows.Forms.Label booleanLabel;
        private System.Windows.Forms.TextBox intTextBox;
        private System.Windows.Forms.TextBox decimalTextBox;
        private System.Windows.Forms.TextBox booleanTextBox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label intErrorLabel;
        private System.Windows.Forms.Label decimalErrorLabel;
        private System.Windows.Forms.Label boolErrorLabel;
    }
}

