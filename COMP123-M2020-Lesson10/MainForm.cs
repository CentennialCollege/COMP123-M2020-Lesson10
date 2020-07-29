using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace COMP123_M2020_Lesson10
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.startForm.Show();
            this.Hide();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.endForm.Show();
            this.Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();     
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FirstNameTextBox.Text = Program.contact.FirstName;
            LastNameTextBox.Text = Program.contact.LastName;
            EmailAddressTextBox.Text = Program.contact.EmailAddress;
            ContactNumberTextBox.Text = Program.contact.ContactNumber;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // configure the dialog
            ContactInfoSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();

            if((Program.contact.FirstName != String.Empty) && (Program.contact.LastName != String.Empty))
            {
                ContactInfoSaveFileDialog.FileName = Program.contact.FirstName + Program.contact.LastName;
            }
            else
            {
                ContactInfoSaveFileDialog.FileName = "ContactInfo";
            }
            

            // open the dialog
            DialogResult saveFileDialogResult = ContactInfoSaveFileDialog.ShowDialog();

            // wait for a positive result
            if(saveFileDialogResult != DialogResult.Cancel)
            {
                // open a stream to write
                StreamWriter streamWriter = new StreamWriter(ContactInfoSaveFileDialog.FileName);

                // write data
                streamWriter.WriteLine(Program.contact.FirstName);
                streamWriter.WriteLine(Program.contact.LastName);
                streamWriter.WriteLine(Program.contact.EmailAddress);
                streamWriter.WriteLine(Program.contact.ContactNumber);

                // cleanup
                streamWriter.Flush();
                streamWriter.Close();
            }
        }
    }
}
