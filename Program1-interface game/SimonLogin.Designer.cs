namespace Program1_interface_game
{
    partial class SimonLogin
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
            this.logInTextBox = new System.Windows.Forms.TextBox();
            this.logButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.newPlayerButton = new System.Windows.Forms.Button();
            this.passwordErrorLabel = new System.Windows.Forms.Label();
            this.loginErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(18, 26);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(209, 63);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "SIMON";
            // 
            // logInTextBox
            // 
            this.logInTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.logInTextBox.Location = new System.Drawing.Point(32, 206);
            this.logInTextBox.Name = "logInTextBox";
            this.logInTextBox.Size = new System.Drawing.Size(444, 30);
            this.logInTextBox.TabIndex = 1;
            // 
            // logButton
            // 
            this.logButton.BackColor = System.Drawing.Color.OliveDrab;
            this.logButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.logButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logButton.Location = new System.Drawing.Point(29, 356);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(103, 44);
            this.logButton.TabIndex = 2;
            this.logButton.Text = "Log In";
            this.logButton.UseVisualStyleBackColor = false;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordTextBox.Location = new System.Drawing.Point(31, 295);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(449, 30);
            this.passwordTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(28, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(26, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Login Name:";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.infoLabel.Location = new System.Drawing.Point(43, 105);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(179, 31);
            this.infoLabel.TabIndex = 7;
            this.infoLabel.Text = "Please Log In";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(375, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // newPlayerButton
            // 
            this.newPlayerButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.newPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.newPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newPlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.newPlayerButton.ForeColor = System.Drawing.SystemColors.Control;
            this.newPlayerButton.Location = new System.Drawing.Point(164, 356);
            this.newPlayerButton.Name = "newPlayerButton";
            this.newPlayerButton.Size = new System.Drawing.Size(176, 44);
            this.newPlayerButton.TabIndex = 9;
            this.newPlayerButton.Text = "New Player";
            this.newPlayerButton.UseVisualStyleBackColor = false;
            this.newPlayerButton.Click += new System.EventHandler(this.newPlayerButton_Click);
            // 
            // passwordErrorLabel
            // 
            this.passwordErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordErrorLabel.Location = new System.Drawing.Point(498, 295);
            this.passwordErrorLabel.Name = "passwordErrorLabel";
            this.passwordErrorLabel.Size = new System.Drawing.Size(411, 25);
            this.passwordErrorLabel.TabIndex = 26;
            // 
            // loginErrorLabel
            // 
            this.loginErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.loginErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.loginErrorLabel.Location = new System.Drawing.Point(487, 206);
            this.loginErrorLabel.Name = "loginErrorLabel";
            this.loginErrorLabel.Size = new System.Drawing.Size(301, 25);
            this.loginErrorLabel.TabIndex = 25;
            // 
            // SimonLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1004, 450);
            this.Controls.Add(this.passwordErrorLabel);
            this.Controls.Add(this.loginErrorLabel);
            this.Controls.Add(this.newPlayerButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.logInTextBox);
            this.Controls.Add(this.titleLabel);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "SimonLogin";
            this.Text = "SimonLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox logInTextBox;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button newPlayerButton;
        private System.Windows.Forms.Label passwordErrorLabel;
        private System.Windows.Forms.Label loginErrorLabel;
    }
}