//-----------------------------------------------------------------------
// <copyright file="ResetStudentPassword.cs" company="PABT,Inc">
//     Copyright (c) Pabt, Inc. All rights reserved
// </copyright>
//-----------------------------------------------------------------------

namespace CoachConnect
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class ResetStudentPassword : Form
    {
        Form originalForm { get; set; }

        public ResetStudentPassword()
        {
            InitializeComponent();
        }

        public ResetStudentPassword(Form original)
        {
            InitializeComponent();
            originalForm = original;
        }

        /// <summary>
        /// Event handler to click to save the new password into the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveNewPassword_Click(object sender, EventArgs e)
        {
            using (var context = new db_sft_2172Entities())
            {
                var userQuery = from u in context.Users
                                where u.UserID.Equals(Program.CurrentUser)
                                select u;
                var userResult = userQuery.FirstOrDefault<User>();
                //if (userResult.Password == currentsh.Hash)
                if(SaltedHash.Verify(userResult.PasswordSalt, userResult.Password, txtStdPassword.Text))
                {
                    
                    if (!String.IsNullOrEmpty(txtStdNewPassword.Text) || !String.IsNullOrEmpty(txtStdNewConfirmPassowrd.Text))
                    {
                        if (txtStdNewPassword.Text == txtStdNewConfirmPassowrd.Text)
                        {
                            // Generate salt and salted hash
                            SaltedHash sh = new SaltedHash(txtStdNewPassword.Text);
                            //userResult.Password = txtStdNewPassword.Text;
                            userResult.Password = sh.Hash;
                            userResult.PasswordSalt = sh.Salt;
                            userResult.ResetPassword = false;
                            context.SaveChanges();
                            txtStdPassword.Text = "";
                            txtStdNewPassword.Text = "";
                            txtStdNewConfirmPassowrd.Text = "";
                            MessageBox.Show("Your passsword has been save!");
                            originalForm.Show();
                            this.Close();
                        }
                        else
                        {
                            
                            MessageBox.Show("Both passwords do not match eachother!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("New password or confirm password is empty!");
                    }
                }
                else
                {  
                    MessageBox.Show("Your current password is incorect!");
                }
            }
        }

        /// <summary>
        /// Event handler to cancle the reset new password.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancleResetPassword_Click(object sender, EventArgs e)
        {
            originalForm.Show();
            this.Close();
        }

        /// <summary>
        /// Event handler to validate current password input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtStdPassword_Leave(object sender, EventArgs e)
        {
            using (var context = new db_sft_2172Entities())
            {
                var userQuery = from u in context.Users
                                where u.UserID.Equals(Program.CurrentUser)
                                select u;
                var userResult = userQuery.FirstOrDefault<User>();
                //if (userResult.Password == currentsh.Hash)
                if(SaltedHash.Verify(userResult.PasswordSalt, userResult.Password, txtStdPassword.Text))
                {
                    pwdCorrect.Visible = true;
                    currentPWDWrong.Visible = false;
                }
                else
                {
                    currentPWDWrong.Visible = true;
                    pwdCorrect.Visible = false;
                }
            }
        }

        /// <summary>
        /// Event handler to validate the new password with the confirm weither they are matched.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtStdNewConfirmPassowrd_Leave(object sender, EventArgs e)
        {
            if (txtStdNewPassword.Text == txtStdNewConfirmPassowrd.Text && (txtStdNewPassword.Text != "" || txtStdNewConfirmPassowrd.Text != ""))
            {
                newPWD.Visible = true;
                newPWDConfirmCorrect.Visible = true;
                newPWDNotMatch.Visible = false;
                newPWDConfirmWrong.Visible = false;
            }
            else
            {
                newPWDNotMatch.Visible = true;
                newPWDConfirmWrong.Visible = true;
                newPWD.Visible = false;
                newPWDConfirmCorrect.Visible = false;
            }
        }

        /// <summary>
        /// Event handler to hover the new saved password button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveNewPassword_MouseHover(object sender, EventArgs e)
        {
            if (txtStdPassword.Text != "" && txtStdNewPassword.Text == txtStdNewConfirmPassowrd.Text && (txtStdNewPassword.Text != "" || txtStdNewConfirmPassowrd.Text != ""))
            {
                newPWD.Visible = true;
                newPWDConfirmCorrect.Visible = true;
                newPWDNotMatch.Visible = false;
                newPWDConfirmWrong.Visible = false;
                currentPWDWrong.Visible = false;
            }
            else
            {
                currentPWDWrong.Visible = true;
                newPWDNotMatch.Visible = true;
                newPWDConfirmWrong.Visible = true;
                newPWD.Visible = false;
                newPWDConfirmCorrect.Visible = false;
            }
        }

        /// <summary>
        /// Override method event handler to perform when the form is closed.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            originalForm.Show();
        }
    }
}
