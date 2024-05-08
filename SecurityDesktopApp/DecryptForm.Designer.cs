namespace SecurityDesktopApp
{
    partial class DecryptForm
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
            this.btnEncryptionForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEncryptedUser2 = new System.Windows.Forms.TextBox();
            this.btnClearValues2 = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lbl_Encryted = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtEncryptPassword2 = new System.Windows.Forms.TextBox();
            this.txtUserName2 = new System.Windows.Forms.TextBox();
            this.pb_CopyEnUser2 = new System.Windows.Forms.PictureBox();
            this.pb_CopyEnPass2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CopyEnUser2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CopyEnPass2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEncryptionForm
            // 
            this.btnEncryptionForm.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryptionForm.Location = new System.Drawing.Point(26, 241);
            this.btnEncryptionForm.Name = "btnEncryptionForm";
            this.btnEncryptionForm.Size = new System.Drawing.Size(154, 31);
            this.btnEncryptionForm.TabIndex = 27;
            this.btnEncryptionForm.Text = "ENCRYPT?";
            this.btnEncryptionForm.UseVisualStyleBackColor = true;
            this.btnEncryptionForm.Click += new System.EventHandler(this.btnEncryptionForm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 28);
            this.label2.TabIndex = 26;
            this.label2.Text = "Decrypt Your Credentials Here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Encrypted User:";
            // 
            // txtEncryptedUser2
            // 
            this.txtEncryptedUser2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptedUser2.Location = new System.Drawing.Point(531, 84);
            this.txtEncryptedUser2.Name = "txtEncryptedUser2";
            this.txtEncryptedUser2.Size = new System.Drawing.Size(202, 27);
            this.txtEncryptedUser2.TabIndex = 2;
            // 
            // btnClearValues2
            // 
            this.btnClearValues2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearValues2.Location = new System.Drawing.Point(561, 241);
            this.btnClearValues2.Name = "btnClearValues2";
            this.btnClearValues2.Size = new System.Drawing.Size(154, 31);
            this.btnClearValues2.TabIndex = 23;
            this.btnClearValues2.Text = "CLEAR VALUES";
            this.btnClearValues2.UseVisualStyleBackColor = true;
            this.btnClearValues2.Click += new System.EventHandler(this.btnClearValues2_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.White;
            this.btnDecrypt.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(259, 168);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(253, 40);
            this.btnDecrypt.TabIndex = 22;
            this.btnDecrypt.Text = "DECRYPT ";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lbl_Encryted
            // 
            this.lbl_Encryted.AutoSize = true;
            this.lbl_Encryted.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Encryted.Location = new System.Drawing.Point(331, 126);
            this.lbl_Encryted.Name = "lbl_Encryted";
            this.lbl_Encryted.Size = new System.Drawing.Size(176, 23);
            this.lbl_Encryted.TabIndex = 21;
            this.lbl_Encryted.Text = "Encrypted Password:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(22, 126);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(89, 23);
            this.lbl_Password.TabIndex = 20;
            this.lbl_Password.Text = "Password:";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(22, 90);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(52, 23);
            this.lbl_UserName.TabIndex = 19;
            this.lbl_UserName.Text = "User:";
            // 
            // txtPassword2
            // 
            this.txtPassword2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword2.Location = new System.Drawing.Point(126, 123);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(178, 27);
            this.txtPassword2.TabIndex = 1;
            // 
            // txtEncryptPassword2
            // 
            this.txtEncryptPassword2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptPassword2.Location = new System.Drawing.Point(531, 126);
            this.txtEncryptPassword2.Name = "txtEncryptPassword2";
            this.txtEncryptPassword2.Size = new System.Drawing.Size(202, 27);
            this.txtEncryptPassword2.TabIndex = 3;
            // 
            // txtUserName2
            // 
            this.txtUserName2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName2.Location = new System.Drawing.Point(126, 84);
            this.txtUserName2.Name = "txtUserName2";
            this.txtUserName2.Size = new System.Drawing.Size(178, 27);
            this.txtUserName2.TabIndex = 0;
            // 
            // pb_CopyEnUser2
            // 
            this.pb_CopyEnUser2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_CopyEnUser2.Image = global::SecurityDesktopApp.Properties.Resources.CopyIcon2;
            this.pb_CopyEnUser2.Location = new System.Drawing.Point(737, 80);
            this.pb_CopyEnUser2.Name = "pb_CopyEnUser2";
            this.pb_CopyEnUser2.Size = new System.Drawing.Size(36, 30);
            this.pb_CopyEnUser2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_CopyEnUser2.TabIndex = 29;
            this.pb_CopyEnUser2.TabStop = false;
            this.pb_CopyEnUser2.Click += new System.EventHandler(this.pb_CopyEnUser2_Click);
            // 
            // pb_CopyEnPass2
            // 
            this.pb_CopyEnPass2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_CopyEnPass2.Image = global::SecurityDesktopApp.Properties.Resources.CopyIcon2;
            this.pb_CopyEnPass2.Location = new System.Drawing.Point(737, 124);
            this.pb_CopyEnPass2.Name = "pb_CopyEnPass2";
            this.pb_CopyEnPass2.Size = new System.Drawing.Size(36, 30);
            this.pb_CopyEnPass2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_CopyEnPass2.TabIndex = 28;
            this.pb_CopyEnPass2.TabStop = false;
            this.pb_CopyEnPass2.Click += new System.EventHandler(this.pb_CopyEnPass2_Click);
            // 
            // DecryptForm
            // 
            this.AcceptButton = this.btnDecrypt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 297);
            this.Controls.Add(this.pb_CopyEnUser2);
            this.Controls.Add(this.pb_CopyEnPass2);
            this.Controls.Add(this.btnEncryptionForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEncryptedUser2);
            this.Controls.Add(this.btnClearValues2);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.lbl_Encryted);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.txtEncryptPassword2);
            this.Controls.Add(this.txtUserName2);
            this.Name = "DecryptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DecryptionForm";
            ((System.ComponentModel.ISupportInitialize)(this.pb_CopyEnUser2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CopyEnPass2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncryptionForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEncryptedUser2;
        private System.Windows.Forms.Button btnClearValues2;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lbl_Encryted;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.TextBox txtEncryptPassword2;
        private System.Windows.Forms.TextBox txtUserName2;
        private System.Windows.Forms.PictureBox pb_CopyEnUser2;
        private System.Windows.Forms.PictureBox pb_CopyEnPass2;
    }
}