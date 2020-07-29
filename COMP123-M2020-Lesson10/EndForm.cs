using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace COMP123_M2020_Lesson10
{
    public partial class EndForm : Form
    {
        public EndForm()
        {
            InitializeComponent();
        }

        private void SetContactData(StreamReader streamReader)
        {
            Program.contact.FirstName = streamReader.ReadLine();
            Program.contact.LastName = streamReader.ReadLine();
            Program.contact.EmailAddress = streamReader.ReadLine();
            Program.contact.ContactNumber = streamReader.ReadLine();
        }

        private void ShowContactData()
        {
            FirstNameTextBox.Text = Program.contact.FirstName;
            LastNameTextBox.Text = Program.contact.LastName;
            EmailAddressTextBox.Text = Program.contact.EmailAddress;
            ContactNumberTextBox.Text = Program.contact.ContactNumber;
        }


        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.mainForm.Show();
            this.Hide();
        }

        private void EndForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            // configure the OpenFileDialog
            ContactInfoOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ContactInfoOpenFileDialog.FileName = "ContactInfo";
            ContactInfoOpenFileDialog.Title = "Load a Contact";

            // open the dialog
            DialogResult openFileDialogResult = ContactInfoOpenFileDialog.ShowDialog();

            if(openFileDialogResult != DialogResult.Cancel)
            {
                // create a streamreader object
                StreamReader streamReader = new StreamReader(ContactInfoOpenFileDialog.FileName);

                // read data from the file
                SetContactData(streamReader);

                // show data on the form
                ShowContactData();

                // cleanup
                streamReader.Close();
            }
        }
    }
}
