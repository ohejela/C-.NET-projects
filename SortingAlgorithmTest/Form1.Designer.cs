namespace SortingAlgorithmTest
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
            this.runSortButton = new System.Windows.Forms.Button();
            this.insertionSortLabel = new System.Windows.Forms.Label();
            this.selectionSortLabel = new System.Windows.Forms.Label();
            this.selctionTitleLabel = new System.Windows.Forms.Label();
            this.insertionTitlelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // runSortButton
            // 
            this.runSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.runSortButton.Location = new System.Drawing.Point(194, 179);
            this.runSortButton.Name = "runSortButton";
            this.runSortButton.Size = new System.Drawing.Size(290, 106);
            this.runSortButton.TabIndex = 0;
            this.runSortButton.Text = "Run";
            this.runSortButton.UseVisualStyleBackColor = true;
            this.runSortButton.Click += new System.EventHandler(this.runSortButton_Click);
            // 
            // insertionSortLabel
            // 
            this.insertionSortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.insertionSortLabel.Location = new System.Drawing.Point(385, 31);
            this.insertionSortLabel.Name = "insertionSortLabel";
            this.insertionSortLabel.Size = new System.Drawing.Size(130, 122);
            this.insertionSortLabel.TabIndex = 1;
            this.insertionSortLabel.Text = "200";
            this.insertionSortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectionSortLabel
            // 
            this.selectionSortLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectionSortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.selectionSortLabel.Location = new System.Drawing.Point(174, 31);
            this.selectionSortLabel.Name = "selectionSortLabel";
            this.selectionSortLabel.Size = new System.Drawing.Size(130, 122);
            this.selectionSortLabel.TabIndex = 2;
            this.selectionSortLabel.Text = "200";
            this.selectionSortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selctionTitleLabel
            // 
            this.selctionTitleLabel.AutoSize = true;
            this.selctionTitleLabel.Location = new System.Drawing.Point(182, 39);
            this.selctionTitleLabel.Name = "selctionTitleLabel";
            this.selctionTitleLabel.Size = new System.Drawing.Size(86, 16);
            this.selctionTitleLabel.TabIndex = 3;
            this.selctionTitleLabel.Text = "selection sort";
            // 
            // insertionTitlelabel
            // 
            this.insertionTitlelabel.AutoSize = true;
            this.insertionTitlelabel.Location = new System.Drawing.Point(392, 39);
            this.insertionTitlelabel.Name = "insertionTitlelabel";
            this.insertionTitlelabel.Size = new System.Drawing.Size(82, 16);
            this.insertionTitlelabel.TabIndex = 4;
            this.insertionTitlelabel.Text = "insertion sort";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.insertionTitlelabel);
            this.Controls.Add(this.selctionTitleLabel);
            this.Controls.Add(this.selectionSortLabel);
            this.Controls.Add(this.insertionSortLabel);
            this.Controls.Add(this.runSortButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runSortButton;
        private System.Windows.Forms.Label insertionSortLabel;
        private System.Windows.Forms.Label selectionSortLabel;
        private System.Windows.Forms.Label selctionTitleLabel;
        private System.Windows.Forms.Label insertionTitlelabel;
    }
}

