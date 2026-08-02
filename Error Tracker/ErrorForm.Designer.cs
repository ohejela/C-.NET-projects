namespace Error_Tracker
{
    partial class ErrorForm
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
            this.classLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.messageOutputLabel = new System.Windows.Forms.Label();
            this.timestampOutputLabel = new System.Windows.Forms.Label();
            this.methodOutputLabel = new System.Windows.Forms.Label();
            this.classOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.classLabel.Location = new System.Drawing.Point(12, 19);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(84, 29);
            this.classLabel.TabIndex = 0;
            this.classLabel.Text = "Class:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Timestamp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(12, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Method:";
            // 
            // messageOutputLabel
            // 
            this.messageOutputLabel.AutoSize = true;
            this.messageOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.messageOutputLabel.ForeColor = System.Drawing.Color.PowderBlue;
            this.messageOutputLabel.Location = new System.Drawing.Point(12, 226);
            this.messageOutputLabel.Name = "messageOutputLabel";
            this.messageOutputLabel.Size = new System.Drawing.Size(0, 29);
            this.messageOutputLabel.TabIndex = 4;
            // 
            // timestampOutputLabel
            // 
            this.timestampOutputLabel.AutoSize = true;
            this.timestampOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.timestampOutputLabel.ForeColor = System.Drawing.Color.PowderBlue;
            this.timestampOutputLabel.Location = new System.Drawing.Point(165, 141);
            this.timestampOutputLabel.Name = "timestampOutputLabel";
            this.timestampOutputLabel.Size = new System.Drawing.Size(0, 29);
            this.timestampOutputLabel.TabIndex = 5;
            // 
            // methodOutputLabel
            // 
            this.methodOutputLabel.AutoSize = true;
            this.methodOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.methodOutputLabel.ForeColor = System.Drawing.Color.PowderBlue;
            this.methodOutputLabel.Location = new System.Drawing.Point(122, 77);
            this.methodOutputLabel.Name = "methodOutputLabel";
            this.methodOutputLabel.Size = new System.Drawing.Size(0, 29);
            this.methodOutputLabel.TabIndex = 6;
            // 
            // classOutputLabel
            // 
            this.classOutputLabel.AutoSize = true;
            this.classOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.classOutputLabel.ForeColor = System.Drawing.Color.PowderBlue;
            this.classOutputLabel.Location = new System.Drawing.Point(110, 19);
            this.classOutputLabel.Name = "classOutputLabel";
            this.classOutputLabel.Size = new System.Drawing.Size(0, 29);
            this.classOutputLabel.TabIndex = 7;
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(496, 321);
            this.Controls.Add(this.classOutputLabel);
            this.Controls.Add(this.methodOutputLabel);
            this.Controls.Add(this.timestampOutputLabel);
            this.Controls.Add(this.messageOutputLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.classLabel);
            this.Name = "ErrorForm";
            this.Text = "ErrorForm";
            this.Load += new System.EventHandler(this.ErrorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label messageOutputLabel;
        private System.Windows.Forms.Label timestampOutputLabel;
        private System.Windows.Forms.Label methodOutputLabel;
        private System.Windows.Forms.Label classOutputLabel;
    }
}