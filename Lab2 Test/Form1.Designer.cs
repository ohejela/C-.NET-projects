namespace Lab2_Test
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
            this.startButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.firstNumLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.secondNumLabel = new System.Windows.Forms.Label();
            this.thirdNumLabel = new System.Windows.Forms.Label();
            this.fourthNumLabel = new System.Windows.Forms.Label();
            this.firstNumTextBox = new System.Windows.Forms.TextBox();
            this.secondNumTextBox = new System.Windows.Forms.TextBox();
            this.thirdNumTextBox = new System.Windows.Forms.TextBox();
            this.fourthNumTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.startButton.Location = new System.Drawing.Point(148, 276);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 34);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clearButton.Location = new System.Drawing.Point(264, 276);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 34);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(378, 276);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 34);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(145, 19);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(280, 38);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Lottery Simulator";
            // 
            // firstNumLabel
            // 
            this.firstNumLabel.AutoSize = true;
            this.firstNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.firstNumLabel.Location = new System.Drawing.Point(145, 90);
            this.firstNumLabel.Name = "firstNumLabel";
            this.firstNumLabel.Size = new System.Drawing.Size(103, 25);
            this.firstNumLabel.TabIndex = 4;
            this.firstNumLabel.Text = "Number 1:";
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.outputLabel.Location = new System.Drawing.Point(145, 337);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(434, 146);
            this.outputLabel.TabIndex = 5;
            // 
            // secondNumLabel
            // 
            this.secondNumLabel.AutoSize = true;
            this.secondNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.secondNumLabel.Location = new System.Drawing.Point(145, 133);
            this.secondNumLabel.Name = "secondNumLabel";
            this.secondNumLabel.Size = new System.Drawing.Size(103, 25);
            this.secondNumLabel.TabIndex = 6;
            this.secondNumLabel.Text = "Number 2:";
            // 
            // thirdNumLabel
            // 
            this.thirdNumLabel.AutoSize = true;
            this.thirdNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.thirdNumLabel.Location = new System.Drawing.Point(145, 176);
            this.thirdNumLabel.Name = "thirdNumLabel";
            this.thirdNumLabel.Size = new System.Drawing.Size(103, 25);
            this.thirdNumLabel.TabIndex = 7;
            this.thirdNumLabel.Text = "Number 3:";
            // 
            // fourthNumLabel
            // 
            this.fourthNumLabel.AutoSize = true;
            this.fourthNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fourthNumLabel.Location = new System.Drawing.Point(145, 219);
            this.fourthNumLabel.Name = "fourthNumLabel";
            this.fourthNumLabel.Size = new System.Drawing.Size(103, 25);
            this.fourthNumLabel.TabIndex = 8;
            this.fourthNumLabel.Text = "Number 4:";
            // 
            // firstNumTextBox
            // 
            this.firstNumTextBox.Location = new System.Drawing.Point(248, 84);
            this.firstNumTextBox.Name = "firstNumTextBox";
            this.firstNumTextBox.Size = new System.Drawing.Size(100, 22);
            this.firstNumTextBox.TabIndex = 9;
            // 
            // secondNumTextBox
            // 
            this.secondNumTextBox.Location = new System.Drawing.Point(248, 130);
            this.secondNumTextBox.Name = "secondNumTextBox";
            this.secondNumTextBox.Size = new System.Drawing.Size(100, 22);
            this.secondNumTextBox.TabIndex = 10;
            // 
            // thirdNumTextBox
            // 
            this.thirdNumTextBox.Location = new System.Drawing.Point(248, 170);
            this.thirdNumTextBox.Name = "thirdNumTextBox";
            this.thirdNumTextBox.Size = new System.Drawing.Size(100, 22);
            this.thirdNumTextBox.TabIndex = 11;
            // 
            // fourthNumTextBox
            // 
            this.fourthNumTextBox.Location = new System.Drawing.Point(248, 219);
            this.fourthNumTextBox.Name = "fourthNumTextBox";
            this.fourthNumTextBox.Size = new System.Drawing.Size(100, 22);
            this.fourthNumTextBox.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.fourthNumTextBox);
            this.Controls.Add(this.thirdNumTextBox);
            this.Controls.Add(this.secondNumTextBox);
            this.Controls.Add(this.firstNumTextBox);
            this.Controls.Add(this.fourthNumLabel);
            this.Controls.Add(this.thirdNumLabel);
            this.Controls.Add(this.secondNumLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.firstNumLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label firstNumLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label secondNumLabel;
        private System.Windows.Forms.Label thirdNumLabel;
        private System.Windows.Forms.Label fourthNumLabel;
        private System.Windows.Forms.TextBox firstNumTextBox;
        private System.Windows.Forms.TextBox secondNumTextBox;
        private System.Windows.Forms.TextBox thirdNumTextBox;
        private System.Windows.Forms.TextBox fourthNumTextBox;
        private System.Windows.Forms.Timer timer1;
    }
}

