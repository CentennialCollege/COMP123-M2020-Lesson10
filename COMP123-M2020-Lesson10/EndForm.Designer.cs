﻿namespace COMP123_M2020_Lesson10
{
    partial class EndForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.ContactNumberTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.EmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.EmailAddressLabel = new System.Windows.Forms.Label();
            this.ContactGroupBox = new System.Windows.Forms.GroupBox();
            this.OpenButton = new System.Windows.Forms.Button();
            this.ContactInfoOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ContactInfoLabel = new System.Windows.Forms.Label();
            this.ContactGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 379);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(150, 50);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.BackColor = System.Drawing.Color.White;
            this.FirstNameTextBox.Enabled = false;
            this.FirstNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.FirstNameTextBox.Location = new System.Drawing.Point(12, 60);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(365, 35);
            this.FirstNameTextBox.TabIndex = 2;
            // 
            // ContactNumberTextBox
            // 
            this.ContactNumberTextBox.BackColor = System.Drawing.Color.White;
            this.ContactNumberTextBox.Enabled = false;
            this.ContactNumberTextBox.ForeColor = System.Drawing.Color.Black;
            this.ContactNumberTextBox.Location = new System.Drawing.Point(12, 274);
            this.ContactNumberTextBox.Name = "ContactNumberTextBox";
            this.ContactNumberTextBox.Size = new System.Drawing.Size(365, 35);
            this.ContactNumberTextBox.TabIndex = 5;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(12, 26);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(131, 29);
            this.FirstNameLabel.TabIndex = 1;
            this.FirstNameLabel.Text = "First Name";
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Location = new System.Drawing.Point(12, 240);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(187, 29);
            this.ContactLabel.TabIndex = 1;
            this.ContactLabel.Text = "Contact Number";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(12, 98);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(128, 29);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Last Name";
            // 
            // EmailAddressTextBox
            // 
            this.EmailAddressTextBox.BackColor = System.Drawing.Color.White;
            this.EmailAddressTextBox.Enabled = false;
            this.EmailAddressTextBox.ForeColor = System.Drawing.Color.Black;
            this.EmailAddressTextBox.Location = new System.Drawing.Point(12, 204);
            this.EmailAddressTextBox.Name = "EmailAddressTextBox";
            this.EmailAddressTextBox.Size = new System.Drawing.Size(365, 35);
            this.EmailAddressTextBox.TabIndex = 4;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.BackColor = System.Drawing.Color.White;
            this.LastNameTextBox.Enabled = false;
            this.LastNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.LastNameTextBox.Location = new System.Drawing.Point(12, 132);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(365, 35);
            this.LastNameTextBox.TabIndex = 3;
            // 
            // EmailAddressLabel
            // 
            this.EmailAddressLabel.AutoSize = true;
            this.EmailAddressLabel.Location = new System.Drawing.Point(12, 170);
            this.EmailAddressLabel.Name = "EmailAddressLabel";
            this.EmailAddressLabel.Size = new System.Drawing.Size(169, 29);
            this.EmailAddressLabel.TabIndex = 1;
            this.EmailAddressLabel.Text = "Email Address";
            // 
            // ContactGroupBox
            // 
            this.ContactGroupBox.Controls.Add(this.FirstNameTextBox);
            this.ContactGroupBox.Controls.Add(this.ContactNumberTextBox);
            this.ContactGroupBox.Controls.Add(this.FirstNameLabel);
            this.ContactGroupBox.Controls.Add(this.ContactLabel);
            this.ContactGroupBox.Controls.Add(this.LastNameLabel);
            this.ContactGroupBox.Controls.Add(this.EmailAddressTextBox);
            this.ContactGroupBox.Controls.Add(this.LastNameTextBox);
            this.ContactGroupBox.Controls.Add(this.EmailAddressLabel);
            this.ContactGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContactGroupBox.Location = new System.Drawing.Point(12, 49);
            this.ContactGroupBox.Name = "ContactGroupBox";
            this.ContactGroupBox.Size = new System.Drawing.Size(395, 324);
            this.ContactGroupBox.TabIndex = 3;
            this.ContactGroupBox.TabStop = false;
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(462, 64);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(150, 50);
            this.OpenButton.TabIndex = 0;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // ContactInfoOpenFileDialog
            // 
            this.ContactInfoOpenFileDialog.DefaultExt = "txt";
            this.ContactInfoOpenFileDialog.Filter = "Text files|*.txt|All Files|*.*";
            // 
            // ContactInfoLabel
            // 
            this.ContactInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ContactInfoLabel.Location = new System.Drawing.Point(24, 9);
            this.ContactInfoLabel.Name = "ContactInfoLabel";
            this.ContactInfoLabel.Size = new System.Drawing.Size(408, 52);
            this.ContactInfoLabel.TabIndex = 1;
            this.ContactInfoLabel.Text = "Contact Info Loaded";
            // 
            // EndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.ContactInfoLabel);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.ContactGroupBox);
            this.Controls.Add(this.BackButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "EndForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "End Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EndForm_FormClosing);
            this.ContactGroupBox.ResumeLayout(false);
            this.ContactGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox ContactNumberTextBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox EmailAddressTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label EmailAddressLabel;
        private System.Windows.Forms.GroupBox ContactGroupBox;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.OpenFileDialog ContactInfoOpenFileDialog;
        private System.Windows.Forms.Label ContactInfoLabel;
    }
}