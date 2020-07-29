namespace COMP123_M2020_Lesson10
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NextButton = new System.Windows.Forms.Button();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.EmailAddressLabel = new System.Windows.Forms.Label();
            this.EmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.ContactNumberLabel = new System.Windows.Forms.Label();
            this.ContactNumberTextBox = new System.Windows.Forms.TextBox();
            this.ContactGroupBox = new System.Windows.Forms.GroupBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ContactGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(462, 379);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(150, 50);
            this.NextButton.TabIndex = 6;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(15, 34);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(147, 31);
            this.FirstNameLabel.TabIndex = 1;
            this.FirstNameLabel.Text = "First Name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(15, 68);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(365, 38);
            this.FirstNameTextBox.TabIndex = 2;
            this.FirstNameTextBox.Leave += new System.EventHandler(this.FirstNameTextBox_Leave);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(15, 111);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(145, 31);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Last Name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(15, 145);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(365, 38);
            this.LastNameTextBox.TabIndex = 3;
            this.LastNameTextBox.Leave += new System.EventHandler(this.LastNameTextBox_Leave);
            // 
            // EmailAddressLabel
            // 
            this.EmailAddressLabel.AutoSize = true;
            this.EmailAddressLabel.Location = new System.Drawing.Point(15, 190);
            this.EmailAddressLabel.Name = "EmailAddressLabel";
            this.EmailAddressLabel.Size = new System.Drawing.Size(188, 31);
            this.EmailAddressLabel.TabIndex = 1;
            this.EmailAddressLabel.Text = "Email Address";
            // 
            // EmailAddressTextBox
            // 
            this.EmailAddressTextBox.Location = new System.Drawing.Point(15, 224);
            this.EmailAddressTextBox.Name = "EmailAddressTextBox";
            this.EmailAddressTextBox.Size = new System.Drawing.Size(365, 38);
            this.EmailAddressTextBox.TabIndex = 4;
            this.EmailAddressTextBox.Leave += new System.EventHandler(this.EmailAddressTextBox_Leave);
            // 
            // ContactNumberLabel
            // 
            this.ContactNumberLabel.AutoSize = true;
            this.ContactNumberLabel.Location = new System.Drawing.Point(15, 273);
            this.ContactNumberLabel.Name = "ContactNumberLabel";
            this.ContactNumberLabel.Size = new System.Drawing.Size(212, 31);
            this.ContactNumberLabel.TabIndex = 1;
            this.ContactNumberLabel.Text = "Contact Number";
            // 
            // ContactNumberTextBox
            // 
            this.ContactNumberTextBox.Location = new System.Drawing.Point(15, 307);
            this.ContactNumberTextBox.Name = "ContactNumberTextBox";
            this.ContactNumberTextBox.Size = new System.Drawing.Size(365, 38);
            this.ContactNumberTextBox.TabIndex = 5;
            this.ContactNumberTextBox.TextChanged += new System.EventHandler(this.ContactNumberTextBox_TextChanged);
            this.ContactNumberTextBox.Leave += new System.EventHandler(this.ContactNumberTextBox_Leave);
            // 
            // ContactGroupBox
            // 
            this.ContactGroupBox.Controls.Add(this.FirstNameTextBox);
            this.ContactGroupBox.Controls.Add(this.ContactNumberTextBox);
            this.ContactGroupBox.Controls.Add(this.FirstNameLabel);
            this.ContactGroupBox.Controls.Add(this.ContactNumberLabel);
            this.ContactGroupBox.Controls.Add(this.LastNameLabel);
            this.ContactGroupBox.Controls.Add(this.EmailAddressTextBox);
            this.ContactGroupBox.Controls.Add(this.LastNameTextBox);
            this.ContactGroupBox.Controls.Add(this.EmailAddressLabel);
            this.ContactGroupBox.Location = new System.Drawing.Point(48, 71);
            this.ContactGroupBox.Name = "ContactGroupBox";
            this.ContactGroupBox.Size = new System.Drawing.Size(408, 358);
            this.ContactGroupBox.TabIndex = 3;
            this.ContactGroupBox.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(48, 25);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(408, 52);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Enter Contact Information";
            // 
            // StartForm
            // 
            this.AcceptButton = this.NextButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.ContactGroupBox);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Form";
            this.Activated += new System.EventHandler(this.StartForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartForm_FormClosing);
            this.ContactGroupBox.ResumeLayout(false);
            this.ContactGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label EmailAddressLabel;
        private System.Windows.Forms.TextBox EmailAddressTextBox;
        private System.Windows.Forms.Label ContactNumberLabel;
        private System.Windows.Forms.TextBox ContactNumberTextBox;
        private System.Windows.Forms.GroupBox ContactGroupBox;
        private System.Windows.Forms.Label TitleLabel;
    }
}

