namespace Lab_Test_1
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
            this.sideAreabutton = new System.Windows.Forms.Button();
            this.volumeButton = new System.Windows.Forms.Button();
            this.endAreaButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.titlelLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.lengTextBox = new System.Windows.Forms.TextBox();
            this.heigTextBox = new System.Windows.Forms.TextBox();
            this.depTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sideAreabutton
            // 
            this.sideAreabutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sideAreabutton.Location = new System.Drawing.Point(180, 289);
            this.sideAreabutton.Name = "sideAreabutton";
            this.sideAreabutton.Size = new System.Drawing.Size(131, 88);
            this.sideAreabutton.TabIndex = 0;
            this.sideAreabutton.Text = "Calculate Side Area";
            this.sideAreabutton.UseVisualStyleBackColor = true;
            this.sideAreabutton.Click += new System.EventHandler(this.sideAreabutton_Click);
            // 
            // volumeButton
            // 
            this.volumeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.volumeButton.Location = new System.Drawing.Point(43, 289);
            this.volumeButton.Name = "volumeButton";
            this.volumeButton.Size = new System.Drawing.Size(131, 88);
            this.volumeButton.TabIndex = 1;
            this.volumeButton.Text = "Calculate Volume";
            this.volumeButton.UseVisualStyleBackColor = true;
            this.volumeButton.Click += new System.EventHandler(this.volumeButton_Click);
            // 
            // endAreaButton
            // 
            this.endAreaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.endAreaButton.Location = new System.Drawing.Point(317, 289);
            this.endAreaButton.Name = "endAreaButton";
            this.endAreaButton.Size = new System.Drawing.Size(131, 88);
            this.endAreaButton.TabIndex = 2;
            this.endAreaButton.Text = "Calculate End Area";
            this.endAreaButton.UseVisualStyleBackColor = true;
            this.endAreaButton.Click += new System.EventHandler(this.endAreaButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clearButton.Location = new System.Drawing.Point(454, 289);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(131, 88);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.exitButton.Location = new System.Drawing.Point(591, 289);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(131, 88);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // titlelLabel
            // 
            this.titlelLabel.AutoSize = true;
            this.titlelLabel.BackColor = System.Drawing.Color.Transparent;
            this.titlelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titlelLabel.Location = new System.Drawing.Point(38, 22);
            this.titlelLabel.Name = "titlelLabel";
            this.titlelLabel.Size = new System.Drawing.Size(460, 39);
            this.titlelLabel.TabIndex = 5;
            this.titlelLabel.Text = "Rectangular Prism Calculator";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lengthLabel.Location = new System.Drawing.Point(40, 91);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(78, 25);
            this.lengthLabel.TabIndex = 6;
            this.lengthLabel.Text = "Length:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.heightLabel.Location = new System.Drawing.Point(40, 144);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(74, 25);
            this.heightLabel.TabIndex = 7;
            this.heightLabel.Text = "Height:";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.depthLabel.Location = new System.Drawing.Point(40, 199);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(70, 25);
            this.depthLabel.TabIndex = 8;
            this.depthLabel.Text = "Depth:";
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.outputLabel.Location = new System.Drawing.Point(400, 91);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(282, 133);
            this.outputLabel.TabIndex = 9;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lengTextBox
            // 
            this.lengTextBox.Location = new System.Drawing.Point(124, 91);
            this.lengTextBox.Name = "lengTextBox";
            this.lengTextBox.Size = new System.Drawing.Size(100, 22);
            this.lengTextBox.TabIndex = 10;
            // 
            // heigTextBox
            // 
            this.heigTextBox.Location = new System.Drawing.Point(124, 144);
            this.heigTextBox.Name = "heigTextBox";
            this.heigTextBox.Size = new System.Drawing.Size(100, 22);
            this.heigTextBox.TabIndex = 11;
            // 
            // depTextBox
            // 
            this.depTextBox.Location = new System.Drawing.Point(124, 199);
            this.depTextBox.Name = "depTextBox";
            this.depTextBox.Size = new System.Drawing.Size(100, 22);
            this.depTextBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.depTextBox);
            this.Controls.Add(this.heigTextBox);
            this.Controls.Add(this.lengTextBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.titlelLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.endAreaButton);
            this.Controls.Add(this.volumeButton);
            this.Controls.Add(this.sideAreabutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sideAreabutton;
        private System.Windows.Forms.Button volumeButton;
        private System.Windows.Forms.Button endAreaButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label titlelLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox lengTextBox;
        private System.Windows.Forms.TextBox heigTextBox;
        private System.Windows.Forms.TextBox depTextBox;
    }
}

