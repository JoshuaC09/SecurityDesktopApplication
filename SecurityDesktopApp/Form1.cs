﻿using System;
using System.Windows.Forms;

namespace SecurityDesktopApp
{
    public partial class EncryptForm : Form
    {
        private DecryptForm decryptForm;
        private System.Windows.Forms.Timer timerResetIcon = new System.Windows.Forms.Timer();

        private const string DefaultEncryptionKey = "In the eye of the beholder doth lie beauty's true essence, for each gaze doth fashion its own fair visage";
        private readonly byte[] salt = new byte[] { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0a, 0x0b, 0x0c, 0x0d, 0x0e, 0x0f };

        public EncryptForm()
        {
            InitializeComponent();
            this.AcceptButton = btnEncrypt;
            timerResetIcon.Interval = 1000; // Set the delay to 1 second (adjust as needed)
            timerResetIcon.Tick += TimerResetIcon_Tick;
        }

        private void TimerResetIcon_Tick(object sender, EventArgs e)
        {
            // Reset the image back to the original form
            pb_CopyEnUser.Image = Properties.Resources.CopyIcon2; // Replace "OriginalImage" with your original image resource name
            pb_CopyEnPass.Image = Properties.Resources.CopyIcon2;

            // Stop the Timer
            timerResetIcon.Stop();
        }

        private void btnEncrypt_Click_1(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            string secretKey = SecretKeyUserInput.Text;

            // Use the user-provided key if available, otherwise use the default key
            string encryptionKey = !string.IsNullOrWhiteSpace(secretKey) ? secretKey : DefaultEncryptionKey;

            // Check if the TextBoxes are not empty
            if (!string.IsNullOrWhiteSpace(userName) && !string.IsNullOrWhiteSpace(password))
            {
                try
                {
                    // Create an instance of the StringEncryptionService with the chosen key and salt
                    var encryptionService = new SecurityService(encryptionKey, salt);

                    // Encrypt the plaintext
                    string encryptedUserName = encryptionService.Encrypt(userName);
                    string encryptedPassword = encryptionService.Encrypt(password);

                    // Display the encrypted data in the respective textboxes
                    txtEncryptedUser.Text = encryptedUserName;
                    txtEncryptPassword.Text = encryptedPassword;
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during encryption
                    MessageBox.Show($"An error occurred during encryption: {ex.Message}", "Encryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Display a message box if the TextBoxes are empty
                MessageBox.Show("Please enter a username and password before encrypting.", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearValues_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            // Clear the values of the textboxes
            txtUserName.Clear();
            txtPassword.Clear();
            txtEncryptedUser.Clear();
            txtEncryptPassword.Clear();
            SecretKeyUserInput.Clear();
        }

        private void btnDecryptionForm_Click(object sender, EventArgs e)
        {
            // Get the user-provided secret key
            string secretKey = SecretKeyUserInput.Text;

            // Check if the DecryptForm instance has been created
            if (decryptForm == null || decryptForm.IsDisposed)
            {
                decryptForm = new DecryptForm(secretKey); // Pass the user encryption key
                decryptForm.EncryptForm = this; // Set the EncryptForm reference
            }
            else
            {
                // Update the key if the form already exists
                decryptForm.UserEncryptionKey = secretKey;
            }

            // Show the DecryptForm and hide the current form
            decryptForm.Show();
            this.Hide();
        }

        private void pb_CopyEnUser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEncryptedUser.Text))
            {
                // Copy the text to the clipboard
                Clipboard.SetText(txtEncryptedUser.Text);
                pb_CopyEnUser.Image = Properties.Resources.CopiedImage; // Replace "CopiedImage" with your temporary image resource name

                // Start the Timer
                timerResetIcon.Start();
            }
        }

        private void pb_CopyEnPass_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEncryptPassword.Text))
            {
                // Copy the text to the clipboard
                Clipboard.SetText(txtEncryptPassword.Text);
                pb_CopyEnPass.Image = Properties.Resources.CopiedImage;

                // Start the Timer
                timerResetIcon.Start();
            }
        }
    }
}
