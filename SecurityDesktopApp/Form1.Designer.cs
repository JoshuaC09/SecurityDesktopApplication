namespace SecurityDesktopApp
{
    partial class EncryptForm
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtEncryptPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Encryted = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnClearValues = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEncryptedUser = new System.Windows.Forms.TextBox();
            this.btnDecryptionForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_CopyEnPass = new System.Windows.Forms.PictureBox();
            this.pb_CopyEnUser = new System.Windows.Forms.PictureBox();
            this.SecretKeyUserInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CopyEnPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CopyEnUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(124, 76);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(178, 27);
            this.txtUserName.TabIndex = 0;
            // 
            // txtEncryptPassword
            // 
            this.txtEncryptPassword.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptPassword.Location = new System.Drawing.Point(529, 118);
            this.txtEncryptPassword.Name = "txtEncryptPassword";
            this.txtEncryptPassword.Size = new System.Drawing.Size(202, 27);
            this.txtEncryptPassword.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(124, 115);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(178, 27);
            this.txtPassword.TabIndex = 1;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(20, 82);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(52, 23);
            this.lbl_UserName.TabIndex = 4;
            this.lbl_UserName.Text = "User:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(20, 118);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(89, 23);
            this.lbl_Password.TabIndex = 5;
            this.lbl_Password.Text = "Password:";
            // 
            // lbl_Encryted
            // 
            this.lbl_Encryted.AutoSize = true;
            this.lbl_Encryted.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Encryted.Location = new System.Drawing.Point(329, 118);
            this.lbl_Encryted.Name = "lbl_Encryted";
            this.lbl_Encryted.Size = new System.Drawing.Size(176, 23);
            this.lbl_Encryted.TabIndex = 7;
            this.lbl_Encryted.Text = "Encrypted Password:";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.White;
            this.btnEncrypt.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(257, 160);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(253, 40);
            this.btnEncrypt.TabIndex = 9;
            this.btnEncrypt.Text = "ENCRYPT ";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click_1);
            // 
            // btnClearValues
            // 
            this.btnClearValues.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearValues.Location = new System.Drawing.Point(559, 233);
            this.btnClearValues.Name = "btnClearValues";
            this.btnClearValues.Size = new System.Drawing.Size(154, 31);
            this.btnClearValues.TabIndex = 11;
            this.btnClearValues.Text = "CLEAR VALUES";
            this.btnClearValues.UseVisualStyleBackColor = true;
            this.btnClearValues.Click += new System.EventHandler(this.btnClearValues_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Encrypted User:";
            // 
            // txtEncryptedUser
            // 
            this.txtEncryptedUser.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptedUser.Location = new System.Drawing.Point(529, 76);
            this.txtEncryptedUser.Name = "txtEncryptedUser";
            this.txtEncryptedUser.Size = new System.Drawing.Size(202, 27);
            this.txtEncryptedUser.TabIndex = 2;
            // 
            // btnDecryptionForm
            // 
            this.btnDecryptionForm.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecryptionForm.Location = new System.Drawing.Point(24, 233);
            this.btnDecryptionForm.Name = "btnDecryptionForm";
            this.btnDecryptionForm.Size = new System.Drawing.Size(154, 31);
            this.btnDecryptionForm.TabIndex = 15;
            this.btnDecryptionForm.Text = "DECRYPT?";
            this.btnDecryptionForm.UseVisualStyleBackColor = true;
            this.btnDecryptionForm.Click += new System.EventHandler(this.btnDecryptionForm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "Encrypt Your Credentials Here";
            // 
            // pb_CopyEnPass
            // 
            this.pb_CopyEnPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_CopyEnPass.Image = global::SecurityDesktopApp.Properties.Resources.CopyIcon2;
            this.pb_CopyEnPass.Location = new System.Drawing.Point(735, 117);
            this.pb_CopyEnPass.Name = "pb_CopyEnPass";
            this.pb_CopyEnPass.Size = new System.Drawing.Size(36, 30);
            this.pb_CopyEnPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_CopyEnPass.TabIndex = 17;
            this.pb_CopyEnPass.TabStop = false;
            this.pb_CopyEnPass.Click += new System.EventHandler(this.pb_CopyEnPass_Click);
            // 
            // pb_CopyEnUser
            // 
            this.pb_CopyEnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_CopyEnUser.Image = global::SecurityDesktopApp.Properties.Resources.CopyIcon2;
            this.pb_CopyEnUser.Location = new System.Drawing.Point(735, 73);
            this.pb_CopyEnUser.Name = "pb_CopyEnUser";
            this.pb_CopyEnUser.Size = new System.Drawing.Size(36, 30);
            this.pb_CopyEnUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_CopyEnUser.TabIndex = 18;
            this.pb_CopyEnUser.TabStop = false;
            this.pb_CopyEnUser.Click += new System.EventHandler(this.pb_CopyEnUser_Click);
            // 
            // SecretKeyUserInput
            // 
            this.SecretKeyUserInput.Location = new System.Drawing.Point(24, 30);
            this.SecretKeyUserInput.Name = "SecretKeyUserInput";
            this.SecretKeyUserInput.Size = new System.Drawing.Size(100, 22);
            this.SecretKeyUserInput.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Change Key?";
            // 
            // EncryptForm
            // 
            this.AcceptButton = this.btnEncrypt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 297);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SecretKeyUserInput);
            this.Controls.Add(this.pb_CopyEnUser);
            this.Controls.Add(this.pb_CopyEnPass);
            this.Controls.Add(this.btnDecryptionForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEncryptedUser);
            this.Controls.Add(this.btnClearValues);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.lbl_Encryted);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEncryptPassword);
            this.Controls.Add(this.txtUserName);
            this.Name = "EncryptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EncryptionForm";
            ((System.ComponentModel.ISupportInitialize)(this.pb_CopyEnPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CopyEnUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtEncryptPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Encryted;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnClearValues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEncryptedUser;
        private System.Windows.Forms.Button btnDecryptionForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_CopyEnPass;
        private System.Windows.Forms.PictureBox pb_CopyEnUser;
        private System.Windows.Forms.TextBox SecretKeyUserInput;
        private System.Windows.Forms.Label label3;
    }
}

