﻿using System;
using System.Windows.Forms;

namespace SecurityDesktopApp
{
    public partial class DecryptForm : Form
    {
        private EncryptForm encryptForm; // Declare a private field to store the EncryptForm instance

        private System.Windows.Forms.Timer timerResetIcon = new System.Windows.Forms.Timer();
        public EncryptForm EncryptForm // Declare a property to set the EncryptForm instance
        {
            set { encryptForm = value; }
        }

        private const string EncryptionKey = "In the eye of the beholder doth lie beauty's true essence, for each gaze doth fashion its own fair visage";
        private readonly byte[] salt = new byte[] { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0a, 0x0b, 0x0c, 0x0d, 0x0e, 0x0f };

        public DecryptForm()
        {
            InitializeComponent();
            timerResetIcon.Interval = 1000; // Set the delay to 1 second (adjust as needed)
            timerResetIcon.Tick += TimerResetIcon_Tick;

        }

        private void TimerResetIcon_Tick(object sender, EventArgs e)
        {
            // Reset the image back to the original form
            pb_CopyEnUser2.Image = Properties.Resources.CopyIcon2; // Replace "OriginalImage" with your original image resource name
            pb_CopyEnPass2.Image = Properties.Resources.CopyIcon2;

            // Stop the Timer
            timerResetIcon.Stop();
        }



        private void btnEncryptionForm_Click(object sender, EventArgs e)
        {
            // Check if the EncryptForm instance has been set
            if (encryptForm != null)
            {
                // Show the EncryptForm and hide the current form
                encryptForm.Show();
                this.Hide();
            }
        }


        private void ResetForm()
        {
            // Clear the values of the textboxes
            txtUserName2.Clear();
            txtPassword2.Clear();
            txtEncryptedUser2.Clear();
            txtEncryptPassword2.Clear();
        }

        private void btnClearValues2_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string encryptedUserName = txtUserName2.Text;
            string encryptedPassword = txtPassword2.Text;

            // Check if the TextBoxes are not empty
            if (!string.IsNullOrWhiteSpace(encryptedUserName) && !string.IsNullOrWhiteSpace(encryptedPassword))
            {
                try
                {
                    // Create an instance of the StringEncryptionService with the same password and salt
                    var encryptionService = new SecurityService(EncryptionKey, salt);

                    // Decrypt the encrypted data
                    string decryptedUserName = encryptionService.Decrypt(encryptedUserName);
                    string decryptedPassword = encryptionService.Decrypt(encryptedPassword);

                    // Display the decrypted data in the respective textboxes
                    txtEncryptedUser2.Text = decryptedUserName;
                    txtEncryptPassword2.Text = decryptedPassword;
                }
                catch (Exception ex)
                {
                    // Check if the exception is "The encrypted data is not in the correct format"
                    if (ex.Message == "The encrypted data is not in the correct format.")
                    {
                        // Display a message box with the error message
                        MessageBox.Show(ex.Message, "Decryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Handle other exceptions as needed
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Display a message box if the TextBoxes are empty
                MessageBox.Show("Please enter encrypted data before decrypting.", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pb_CopyEnUser2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEncryptedUser2.Text))
            {
                // Copy the text to the clipboard
                Clipboard.SetText(txtEncryptedUser2.Text);
                pb_CopyEnUser2.Image = Properties.Resources.CopiedImage; // Replace "CopiedImage" with your temporary image resource name

                // Start the Timer
                timerResetIcon.Start();
            }
        }

        private void pb_CopyEnPass2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEncryptPassword2.Text))
            {
                // Copy the text to the clipboard
                Clipboard.SetText(txtEncryptPassword2.Text);
                pb_CopyEnPass2.Image = Properties.Resources.CopiedImage;

                // Start the Timer
                timerResetIcon.Start();
            }
        }
    }
}