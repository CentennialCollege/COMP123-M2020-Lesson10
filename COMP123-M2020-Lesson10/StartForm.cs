﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_Lesson10
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Next Button Clicked");

            SetContactData();
            ClearFormData();

            Program.mainForm.Show();

            this.Hide();
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FirstNameTextBox_Leave(object sender, EventArgs e)
        {
            if(FirstNameTextBox.TextLength < 2)
            {
                FirstNameTextBox.Focus();
                FirstNameTextBox.SelectAll();
            }
        }

        private void LastNameTextBox_Leave(object sender, EventArgs e)
        {
            if (LastNameTextBox.TextLength < 2)
            {
                LastNameTextBox.Focus();
                LastNameTextBox.SelectAll();
            }
        }

        private void EmailAddressTextBox_Leave(object sender, EventArgs e)
        {
            if (EmailAddressTextBox.TextLength < 8)
            {
                EmailAddressTextBox.Focus();
                EmailAddressTextBox.SelectAll();
            }
        }

        private void ContactNumberTextBox_Leave(object sender, EventArgs e)
        {
            if (ContactNumberTextBox.TextLength < 10)
            {
                ContactNumberTextBox.Focus();
                ContactNumberTextBox.SelectAll();
            }
            else
            {
                NextButton.Enabled = true;
            }
        }

        private void ContactNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ContactNumberTextBox.TextLength > 9)
            {
                NextButton.Enabled = true;
            }
        }

        private void SetContactData()
        {
            Program.contact.FirstName = FirstNameTextBox.Text;
            Program.contact.LastName = LastNameTextBox.Text;
            Program.contact.EmailAddress = EmailAddressTextBox.Text;
            Program.contact.ContactNumber = ContactNumberTextBox.Text;
        }

        private void ClearFormData()
        {
            FirstNameTextBox.Clear();
            LastNameTextBox.Clear();
            EmailAddressTextBox.Clear();
            ContactNumberTextBox.Clear();
        }

        private void StartForm_Activated(object sender, EventArgs e)
        {
            NextButton.Enabled = false;
        }
    }
}
