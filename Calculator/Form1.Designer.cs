namespace Calculator
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
            this.components = new System.ComponentModel.Container();
            this.plusButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.minusButton = new System.Windows.Forms.Button();
            this.productButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.SqrtTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.plusButton.Location = new System.Drawing.Point(34, 105);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(69, 75);
            this.plusButton.TabIndex = 0;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Worst Calculator Ever!!!";
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.outputLabel.Location = new System.Drawing.Point(275, 103);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(262, 170);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox1.Location = new System.Drawing.Point(34, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 34);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox2.Location = new System.Drawing.Point(137, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(69, 34);
            this.textBox2.TabIndex = 4;
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.minusButton.Location = new System.Drawing.Point(137, 105);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(69, 75);
            this.minusButton.TabIndex = 5;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // productButton
            // 
            this.productButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.productButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.productButton.Location = new System.Drawing.Point(34, 198);
            this.productButton.Name = "productButton";
            this.productButton.Size = new System.Drawing.Size(69, 75);
            this.productButton.TabIndex = 6;
            this.productButton.Text = "*";
            this.productButton.UseVisualStyleBackColor = false;
            this.productButton.Click += new System.EventHandler(this.productButton_Click);
            // 
            // divButton
            // 
            this.divButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.divButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.divButton.Location = new System.Drawing.Point(137, 198);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(69, 75);
            this.divButton.TabIndex = 7;
            this.divButton.Text = "/";
            this.divButton.UseVisualStyleBackColor = false;
            this.divButton.Click += new System.EventHandler(this.divButton_Click);
            // 
            // SqrtTimer
            // 
            this.SqrtTimer.Interval = 10000;
            this.SqrtTimer.Tick += new System.EventHandler(this.SqrtTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.productButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plusButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button productButton;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.Timer SqrtTimer;
    }
}

