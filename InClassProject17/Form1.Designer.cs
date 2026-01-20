namespace InClassProject17
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
            this.label1 = new System.Windows.Forms.Label();
            this.luckRadioButton = new System.Windows.Forms.RadioButton();
            this.adventureRadioButton = new System.Windows.Forms.RadioButton();
            this.careerRadioButton = new System.Windows.Forms.RadioButton();
            this.healthRadioButton = new System.Windows.Forms.RadioButton();
            this.inputLabel = new System.Windows.Forms.Label();
            this.gazeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fortune Teller App";
            // 
            // luckRadioButton
            // 
            this.luckRadioButton.AutoSize = true;
            this.luckRadioButton.Font = new System.Drawing.Font("MV Boli", 12F);
            this.luckRadioButton.Location = new System.Drawing.Point(28, 176);
            this.luckRadioButton.Name = "luckRadioButton";
            this.luckRadioButton.Size = new System.Drawing.Size(75, 30);
            this.luckRadioButton.TabIndex = 2;
            this.luckRadioButton.TabStop = true;
            this.luckRadioButton.Text = "Luck";
            this.luckRadioButton.UseVisualStyleBackColor = true;
            // 
            // adventureRadioButton
            // 
            this.adventureRadioButton.AutoSize = true;
            this.adventureRadioButton.Font = new System.Drawing.Font("MV Boli", 12F);
            this.adventureRadioButton.Location = new System.Drawing.Point(203, 176);
            this.adventureRadioButton.Name = "adventureRadioButton";
            this.adventureRadioButton.Size = new System.Drawing.Size(130, 30);
            this.adventureRadioButton.TabIndex = 3;
            this.adventureRadioButton.TabStop = true;
            this.adventureRadioButton.Text = "Adventure";
            this.adventureRadioButton.UseVisualStyleBackColor = true;
            // 
            // careerRadioButton
            // 
            this.careerRadioButton.AutoSize = true;
            this.careerRadioButton.Font = new System.Drawing.Font("MV Boli", 12F);
            this.careerRadioButton.Location = new System.Drawing.Point(28, 231);
            this.careerRadioButton.Name = "careerRadioButton";
            this.careerRadioButton.Size = new System.Drawing.Size(93, 30);
            this.careerRadioButton.TabIndex = 4;
            this.careerRadioButton.TabStop = true;
            this.careerRadioButton.Text = "Career";
            this.careerRadioButton.UseVisualStyleBackColor = true;
            // 
            // healthRadioButton
            // 
            this.healthRadioButton.AutoSize = true;
            this.healthRadioButton.Font = new System.Drawing.Font("MV Boli", 12F);
            this.healthRadioButton.Location = new System.Drawing.Point(203, 231);
            this.healthRadioButton.Name = "healthRadioButton";
            this.healthRadioButton.Size = new System.Drawing.Size(95, 30);
            this.healthRadioButton.TabIndex = 5;
            this.healthRadioButton.TabStop = true;
            this.healthRadioButton.Text = "Health";
            this.healthRadioButton.UseVisualStyleBackColor = true;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("MV Boli", 12F);
            this.inputLabel.Location = new System.Drawing.Point(25, 121);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(214, 26);
            this.inputLabel.TabIndex = 6;
            this.inputLabel.Text = "Choose Your Fortune";
            // 
            // gazeButton
            // 
            this.gazeButton.BackColor = System.Drawing.Color.SteelBlue;
            this.gazeButton.Font = new System.Drawing.Font("MV Boli", 12F);
            this.gazeButton.Location = new System.Drawing.Point(3, 307);
            this.gazeButton.Name = "gazeButton";
            this.gazeButton.Size = new System.Drawing.Size(330, 45);
            this.gazeButton.TabIndex = 7;
            this.gazeButton.Text = "Gaze into the Crystal Ball";
            this.gazeButton.UseVisualStyleBackColor = false;
            this.gazeButton.Click += new System.EventHandler(this.gazeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.clearButton.Font = new System.Drawing.Font("MV Boli", 12F);
            this.clearButton.Location = new System.Drawing.Point(30, 369);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(110, 38);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.LightCoral;
            this.closeButton.Font = new System.Drawing.Font("MV Boli", 12F);
            this.closeButton.Location = new System.Drawing.Point(223, 369);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 38);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // outputListBox
            // 
            this.outputListBox.BackColor = System.Drawing.Color.Aquamarine;
            this.outputListBox.Font = new System.Drawing.Font("MV Boli", 11.5F);
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 25;
            this.outputListBox.Location = new System.Drawing.Point(369, 121);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(454, 179);
            this.outputListBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.gazeButton);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.healthRadioButton);
            this.Controls.Add(this.careerRadioButton);
            this.Controls.Add(this.adventureRadioButton);
            this.Controls.Add(this.luckRadioButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton luckRadioButton;
        private System.Windows.Forms.RadioButton adventureRadioButton;
        private System.Windows.Forms.RadioButton careerRadioButton;
        private System.Windows.Forms.RadioButton healthRadioButton;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Button gazeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ListBox outputListBox;
    }
}

