// <copyright file="ResetUserPasswordAdmin.designer.cs" company="PABT at NWTC">
//     Copyright 2017 PABT (Pao Xiong, Adam Smith, Brian Lueskow, Tim Durkee)
// </copyright>

namespace CoachConnect
{
    /// <summary>
    /// A form to allow admin to reset a user's password 
    /// </summary>
    public partial class ResetUserPasswordAdmin
    {
        /// <summary>
        /// Text box for the new password
        /// </summary>
        private System.Windows.Forms.TextBox txtPassword;

        /// <summary>
        /// Text box for the password confirmation.
        /// </summary>
        private System.Windows.Forms.TextBox txtConfirmPassword;

        /// <summary>
        /// Label for the new password
        /// </summary>
        private System.Windows.Forms.Label lblPassword;

        /// <summary>
        /// Label for confirming the second bucket
        /// </summary>
        private System.Windows.Forms.Label lblConfirmPassword;

        /// <summary>
        /// Image to show that the passwords are not valid
        /// </summary>
        private System.Windows.Forms.PictureBox imgPasswordNotValid;

        /// <summary>
        /// Image to show that the passwords are valid
        /// </summary>
        private System.Windows.Forms.PictureBox imgPasswordValid;

        /// <summary>
        /// A label for the form header.
        /// </summary>
        private System.Windows.Forms.Label lblAdminForm;

        /// <summary>
        /// A label noting the header of the form.
        /// </summary>
        private System.Windows.Forms.Button btnUpdate;

        /// <summary>
        /// Button allowing users to cancel and ignore all changes.
        /// </summary>
        private System.Windows.Forms.Button btnCancel;

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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetUserPasswordAdmin));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblAdminForm = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.imgPasswordNotValid = new System.Windows.Forms.PictureBox();
            this.imgPasswordValid = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPasswordNotValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPasswordValid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(115, 56);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(133, 20);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Leave += new System.EventHandler(this.TxtStdNewConfirmPasswordLeave);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(115, 86);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(133, 20);
            this.txtConfirmPassword.TabIndex = 1;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.Leave += new System.EventHandler(this.TxtStdNewConfirmPasswordLeave);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(15, 59);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Enter Password";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(15, 89);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(91, 13);
            this.lblConfirmPassword.TabIndex = 3;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblAdminForm
            // 
            this.lblAdminForm.AutoSize = true;
            this.lblAdminForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminForm.Location = new System.Drawing.Point(74, 20);
            this.lblAdminForm.Name = "lblAdminForm";
            this.lblAdminForm.Size = new System.Drawing.Size(125, 20);
            this.lblAdminForm.TabIndex = 8;
            this.lblAdminForm.Text = "Reset Password";
            this.lblAdminForm.UseWaitCursor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(34, 126);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdateClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(153, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // imgPasswordNotValid
            // 
            this.imgPasswordNotValid.Image = global::CoachConnect.Properties.Resources.wrong;
            this.imgPasswordNotValid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgPasswordNotValid.Location = new System.Drawing.Point(256, 69);
            this.imgPasswordNotValid.Name = "imgPasswordNotValid";
            this.imgPasswordNotValid.Size = new System.Drawing.Size(36, 33);
            this.imgPasswordNotValid.TabIndex = 38;
            this.imgPasswordNotValid.TabStop = false;
            this.imgPasswordNotValid.Visible = false;
            // 
            // imgPasswordValid
            // 
            this.imgPasswordValid.Image = global::CoachConnect.Properties.Resources.correct1;
            this.imgPasswordValid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgPasswordValid.Location = new System.Drawing.Point(256, 64);
            this.imgPasswordValid.Name = "imgPasswordValid";
            this.imgPasswordValid.Size = new System.Drawing.Size(36, 33);
            this.imgPasswordValid.TabIndex = 37;
            this.imgPasswordValid.TabStop = false;
            this.imgPasswordValid.Visible = false;
            // 
            // ResetUserPasswordAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 169);
            this.Controls.Add(this.imgPasswordNotValid);
            this.Controls.Add(this.imgPasswordValid);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblAdminForm);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResetUserPasswordAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Password (Admin)";
            ((System.ComponentModel.ISupportInitialize)(this.imgPasswordNotValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPasswordValid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}