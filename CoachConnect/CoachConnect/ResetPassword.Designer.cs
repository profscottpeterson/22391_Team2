// <copyright file="ResetStudentPassword.Designer.cs" company="PABT at NWTC">
//     Copyright 2017 PABT (Pao Xiong, Adam Smith, Brian Lueskow, Tim Durkee)
// </copyright>
namespace CoachConnect
{
    /// <summary>
    /// A form that allows a user to reset his/her password
    /// </summary>
    public partial class ResetPassword
    {

        /// <summary>
        /// A picture box to validate matching passwords
        /// </summary>
        private System.Windows.Forms.PictureBox newPWD;

        /// <summary>
        /// A picture box to confirm that the passwords were correct.
        /// </summary>
        private System.Windows.Forms.PictureBox newPWDConfirmCorrect;

        /// <summary>
        /// Icon for "correct"
        /// </summary>
        private System.Windows.Forms.PictureBox pwdCorrect;

        /// <summary>
        /// A label
        /// </summary>
        private System.Windows.Forms.Label lblCurrentPassword;

        /// <summary>
        /// Text box to enter the confirmation password
        /// </summary>
        private System.Windows.Forms.TextBox txtConfirmPassword;

        /// <summary>
        /// A text box to enter the password function.
        /// </summary>
        private System.Windows.Forms.TextBox txtNewPassword;

        /// <summary>
        /// A label
        /// </summary>
        private System.Windows.Forms.Label lblConfirmPassword;

        /// <summary>
        /// A label
        /// </summary>
        private System.Windows.Forms.Label lblNewPassword;

        /// <summary>
        /// Button to save new password
        /// </summary>
        private System.Windows.Forms.Button btnSaveNewPassword;

        /// <summary>
        /// Button to cancel the password reset
        /// </summary>
        private System.Windows.Forms.Button btnCancleResetPassword;

        /// <summary>
        /// A group box
        /// </summary>
        private System.Windows.Forms.GroupBox groupBox1;

        /// <summary>
        /// An icon to show when password entries do not match
        /// </summary>
        private System.Windows.Forms.PictureBox newPWDNotMatch;

        /// <summary>
        /// An icon that will appear when signing passwords that were "confirmed" but the password does not match the current string.
        /// </summary>
        private System.Windows.Forms.PictureBox newPWDConfirmWrong;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newPWDNotMatch = new System.Windows.Forms.PictureBox();
            this.newPWDConfirmWrong = new System.Windows.Forms.PictureBox();
            this.newPWD = new System.Windows.Forms.PictureBox();
            this.newPWDConfirmCorrect = new System.Windows.Forms.PictureBox();
            this.pwdCorrect = new System.Windows.Forms.PictureBox();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.btnSaveNewPassword = new System.Windows.Forms.Button();
            this.btnCancleResetPassword = new System.Windows.Forms.Button();
            this.currentPWDWrong = new System.Windows.Forms.PictureBox();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newPWDNotMatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPWDConfirmWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPWD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPWDConfirmCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pwdCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPWDWrong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newPWDNotMatch);
            this.groupBox1.Controls.Add(this.newPWDConfirmWrong);
            this.groupBox1.Controls.Add(this.currentPWDWrong);
            this.groupBox1.Controls.Add(this.newPWD);
            this.groupBox1.Controls.Add(this.newPWDConfirmCorrect);
            this.groupBox1.Controls.Add(this.pwdCorrect);
            this.groupBox1.Controls.Add(this.txtCurrentPassword);
            this.groupBox1.Controls.Add(this.lblCurrentPassword);
            this.groupBox1.Controls.Add(this.txtConfirmPassword);
            this.groupBox1.Controls.Add(this.txtNewPassword);
            this.groupBox1.Controls.Add(this.lblConfirmPassword);
            this.groupBox1.Controls.Add(this.lblNewPassword);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // newPWDNotMatch
            // 
            this.newPWDNotMatch.Image = global::CoachConnect.Properties.Resources.wrong;
            resources.ApplyResources(this.newPWDNotMatch, "newPWDNotMatch");
            this.newPWDNotMatch.Name = "newPWDNotMatch";
            this.newPWDNotMatch.TabStop = false;
            // 
            // newPWDConfirmWrong
            // 
            this.newPWDConfirmWrong.Image = global::CoachConnect.Properties.Resources.wrong;
            resources.ApplyResources(this.newPWDConfirmWrong, "newPWDConfirmWrong");
            this.newPWDConfirmWrong.Name = "newPWDConfirmWrong";
            this.newPWDConfirmWrong.TabStop = false;
            // 
            // newPWD
            // 
            this.newPWD.Image = global::CoachConnect.Properties.Resources.correct1;
            resources.ApplyResources(this.newPWD, "newPWD");
            this.newPWD.Name = "newPWD";
            this.newPWD.TabStop = false;
            // 
            // newPWDConfirmCorrect
            // 
            this.newPWDConfirmCorrect.Image = global::CoachConnect.Properties.Resources.correct1;
            resources.ApplyResources(this.newPWDConfirmCorrect, "newPWDConfirmCorrect");
            this.newPWDConfirmCorrect.Name = "newPWDConfirmCorrect";
            this.newPWDConfirmCorrect.TabStop = false;
            // 
            // pwdCorrect
            // 
            this.pwdCorrect.Image = global::CoachConnect.Properties.Resources.correct1;
            resources.ApplyResources(this.pwdCorrect, "pwdCorrect");
            this.pwdCorrect.Name = "pwdCorrect";
            this.pwdCorrect.TabStop = false;
            // 
            // lblCurrentPassword
            // 
            resources.ApplyResources(this.lblCurrentPassword, "lblCurrentPassword");
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            // 
            // txtConfirmPassword
            // 
            resources.ApplyResources(this.txtConfirmPassword, "txtConfirmPassword");
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Leave += new System.EventHandler(this.TxtStdNewConfirmPasswordLeave);
            // 
            // txtNewPassword
            // 
            resources.ApplyResources(this.txtNewPassword, "txtNewPassword");
            this.txtNewPassword.Name = "txtNewPassword";
            // 
            // lblConfirmPassword
            // 
            resources.ApplyResources(this.lblConfirmPassword, "lblConfirmPassword");
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            // 
            // lblNewPassword
            // 
            resources.ApplyResources(this.lblNewPassword, "lblNewPassword");
            this.lblNewPassword.Name = "lblNewPassword";
            // 
            // btnSaveNewPassword
            // 
            resources.ApplyResources(this.btnSaveNewPassword, "btnSaveNewPassword");
            this.btnSaveNewPassword.Name = "btnSaveNewPassword";
            this.btnSaveNewPassword.UseVisualStyleBackColor = true;
            this.btnSaveNewPassword.Click += new System.EventHandler(this.BtnSaveNewPasswordClick);
            this.btnSaveNewPassword.MouseHover += new System.EventHandler(this.BtnSaveNewPasswordMouseHover);
            // 
            // btnCancleResetPassword
            // 
            resources.ApplyResources(this.btnCancleResetPassword, "btnCancleResetPassword");
            this.btnCancleResetPassword.Name = "btnCancleResetPassword";
            this.btnCancleResetPassword.UseVisualStyleBackColor = true;
            this.btnCancleResetPassword.Click += new System.EventHandler(this.BtnCancelResetPasswordClick);
            // 
            // currentPWDWrong
            // 
            this.currentPWDWrong.Image = global::CoachConnect.Properties.Resources.wrong;
            resources.ApplyResources(this.currentPWDWrong, "currentPWDWrong");
            this.currentPWDWrong.Name = "currentPWDWrong";
            this.currentPWDWrong.TabStop = false;
            // 
            // txtCurrentPassword
            // 
            resources.ApplyResources(this.txtCurrentPassword, "txtCurrentPassword");
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Leave += new System.EventHandler(this.TxtStdPasswordLeave);
            // 
            // ResetPassword
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSaveNewPassword);
            this.Controls.Add(this.btnCancleResetPassword);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResetPassword";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newPWDNotMatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPWDConfirmWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPWD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPWDConfirmCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pwdCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPWDWrong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox currentPWDWrong;
        private System.Windows.Forms.TextBox txtCurrentPassword;
    }
}