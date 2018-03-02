// <copyright file="ResetStudentPassword.cs" company="PABT at NWTC">
//     Copyright 2017 PABT (Pao Xiong, Adam Smith, Brian Lueskow, Tim Durkee)
// </copyright>

namespace CoachConnect
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Security;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// A form that allows a user to reset his/her password
    /// </summary>
    public partial class ResetPassword : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResetPassword" /> class.
        /// </summary>
        public ResetPassword()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler to click to save the new password into the database
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnSaveNewPasswordClick(object sender, EventArgs e)
        {
            // Check for valid entries
            if (txtCurrentPassword.Text.Equals(string.Empty))
            {
                MessageBox.Show(
                    "Please enter your current password.");
                txtCurrentPassword.Text = string.Empty;
                txtCurrentPassword.Focus();
                return;
            }

            if (txtNewPassword.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter a new password.");
                txtNewPassword.Text = string.Empty;
                txtConfirmPassword.Text = string.Empty;
                txtNewPassword.Focus();
                return;
            }

            if (txtConfirmPassword.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please confirm your password.");
                txtConfirmPassword.Focus();
                return;
            }

            if (!txtNewPassword.Text.Equals(txtConfirmPassword.Text))
            {
                MessageBox.Show("Sorry, the entered passwords do not match!  Please try again!");
                txtNewPassword.Text = string.Empty;
                txtConfirmPassword.Text = string.Empty;
                txtNewPassword.Focus();
                return;
            }

            // If entries are valid and new passwords match, obtain user data and verify current password.
            using (var context = new db_sft_2172Entities())
            {
                var userQuery = from u in context.Users
                                where u.UserID.Equals(Program.CurrentUser)
                                select u;
                var userResult = userQuery.FirstOrDefault<User>();

                if (!SaltedHash.Verify(userResult.PasswordSalt, userResult.Password, txtCurrentPassword.Text))
                {
                    MessageBox.Show("Sorry, your current password is incorrect.  Please try again or contact your supervisor for assistance.");
                }
                else
                {
                    // Generate salt and salted hash
                    SaltedHash sh = new SaltedHash(txtNewPassword.Text);
                    userResult.Password = sh.Hash;
                    userResult.PasswordSalt = sh.Salt;
                    userResult.ResetPassword = null;
                    context.SaveChanges();
                    txtCurrentPassword.Text = string.Empty;
                    txtNewPassword.Text = string.Empty;
                    txtConfirmPassword.Text = string.Empty;
                    MessageBox.Show("Your passsword has been saved!");
                }
            }

            // If we get this far, the process is complete, so close the window.
            Close();
        }

        /// <summary>
        /// Event handler to cancel the reset new password.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnCancelResetPasswordClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Event handler to validate current password input.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void TxtStdPasswordLeave(object sender, EventArgs e)
        {
            //using (var context = new db_sft_2172Entities())
            //{
            //    var userQuery = from u in context.Users
            //                    where u.UserID.Equals(Program.CurrentUser)
            //                    select u;
            //    var userResult = userQuery.FirstOrDefault<User>();

            //    if (SaltedHash.Verify(userResult.PasswordSalt, userResult.Password, txtCurrentPassword.Text))
            //    {
            //        pwdCorrect.Visible = true;
            //        currentPWDWrong.Visible = false;
            //    }
            //    else
            //    {
            //        currentPWDWrong.Visible = true;
            //        pwdCorrect.Visible = false;
            //    }
            //}
        }

        /// <summary>
        /// Event handler to validate the new password and confirm whether the two entries are identical.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void TxtStdNewConfirmPasswordLeave(object sender, EventArgs e)
        {
            //if (txtNewPassword.Text == txtConfirmPassword.Text && (txtNewPassword.Text != string.Empty || txtConfirmPassword.Text != string.Empty))
            //{
            //    newPWD.Visible = true;
            //    newPWDConfirmCorrect.Visible = true;
            //    newPWDNotMatch.Visible = false;
            //    newPWDConfirmWrong.Visible = false;
            //}
            //else
            //{
            //    newPWDNotMatch.Visible = true;
            //    newPWDConfirmWrong.Visible = true;
            //    newPWD.Visible = false;
            //    newPWDConfirmCorrect.Visible = false;
            //}
        }

        /// <summary>
        /// Event handler to hover the new saved password button.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnSaveNewPasswordMouseHover(object sender, EventArgs e)
        {
            //if (txtCurrentPassword.Text != string.Empty && txtNewPassword.Text == txtConfirmPassword.Text && (txtNewPassword.Text != string.Empty || txtConfirmPassword.Text != string.Empty))
            //{
            //    newPWD.Visible = true;
            //    newPWDConfirmCorrect.Visible = true;
            //    newPWDNotMatch.Visible = false;
            //    newPWDConfirmWrong.Visible = false;
            //    currentPWDWrong.Visible = false;
            //}
            //else
            //{
            //    currentPWDWrong.Visible = true;
            //    newPWDNotMatch.Visible = true;
            //    newPWDConfirmWrong.Visible = true;
            //    newPWD.Visible = false;
            //    newPWDConfirmCorrect.Visible = false;
            //}
        }
    }
}
