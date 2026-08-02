namespace Program1_interface_game
{
    partial class NewPlayer
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.logInTextBox = new System.Windows.Forms.TextBox();
            this.firstErrorLabel = new System.Windows.Forms.Label();
            this.lastErrorLabel = new System.Windows.Forms.Label();
            this.loginErrorLabel = new System.Windows.Forms.Label();
            this.passwordErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.infoLabel.Location = new System.Drawing.Point(37, 106);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(259, 31);
            this.infoLabel.TabIndex = 16;
            this.infoLabel.Text = "New Player Account";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(20, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(22, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Last Name:";
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lastNameTextbox.Location = new System.Drawing.Point(25, 296);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(449, 30);
            this.lastNameTextbox.TabIndex = 13;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.OliveDrab;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.createButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createButton.Location = new System.Drawing.Point(23, 547);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(239, 44);
            this.createButton.TabIndex = 12;
            this.createButton.Text = "Create Account";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.firstNameTextBox.Location = new System.Drawing.Point(26, 207);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(444, 30);
            this.firstNameTextBox.TabIndex = 11;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(12, 27);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(209, 63);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "SIMON";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(18, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Login Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(20, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordTextBox.Location = new System.Drawing.Point(23, 484);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(449, 30);
            this.passwordTextBox.TabIndex = 18;
            // 
            // logInTextBox
            // 
            this.logInTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.logInTextBox.Location = new System.Drawing.Point(24, 395);
            this.logInTextBox.Name = "logInTextBox";
            this.logInTextBox.Size = new System.Drawing.Size(444, 30);
            this.logInTextBox.TabIndex = 17;
            // 
            // firstErrorLabel
            // 
            this.firstErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.firstErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.firstErrorLabel.Location = new System.Drawing.Point(498, 212);
            this.firstErrorLabel.Name = "firstErrorLabel";
            this.firstErrorLabel.Size = new System.Drawing.Size(290, 25);
            this.firstErrorLabel.TabIndex = 21;
            // 
            // lastErrorLabel
            // 
            this.lastErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lastErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.lastErrorLabel.Location = new System.Drawing.Point(498, 299);
            this.lastErrorLabel.Name = "lastErrorLabel";
            this.lastErrorLabel.Size = new System.Drawing.Size(290, 25);
            this.lastErrorLabel.TabIndex = 22;
            // 
            // loginErrorLabel
            // 
            this.loginErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.loginErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.loginErrorLabel.Location = new System.Drawing.Point(487, 400);
            this.loginErrorLabel.Name = "loginErrorLabel";
            this.loginErrorLabel.Size = new System.Drawing.Size(301, 25);
            this.loginErrorLabel.TabIndex = 23;
            // 
            // passwordErrorLabel
            // 
            this.passwordErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordErrorLabel.Location = new System.Drawing.Point(498, 489);
            this.passwordErrorLabel.Name = "passwordErrorLabel";
            this.passwordErrorLabel.Size = new System.Drawing.Size(290, 25);
            this.passwordErrorLabel.TabIndex = 24;
            // 
            // NewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 629);
            this.Controls.Add(this.passwordErrorLabel);
            this.Controls.Add(this.loginErrorLabel);
            this.Controls.Add(this.lastErrorLabel);
            this.Controls.Add(this.firstErrorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.logInTextBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastNameTextbox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.titleLabel);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "NewPlayer";
            this.Text = "NewPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox logInTextBox;
        private System.Windows.Forms.Label firstErrorLabel;
        private System.Windows.Forms.Label lastErrorLabel;
        private System.Windows.Forms.Label loginErrorLabel;
        private System.Windows.Forms.Label passwordErrorLabel;
    }
}