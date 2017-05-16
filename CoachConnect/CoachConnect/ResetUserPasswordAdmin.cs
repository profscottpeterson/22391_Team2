// <copyright file="ResetUserPasswordAdmin.cs" company="PABT at NWTC">
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
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// A form for admin's to reset a password and enter a new initial login password.
    /// </summary>
    public partial class ResetUserPasswordAdmin : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResetUserPasswordAdmin" /> class.
        /// </summary>
        public ResetUserPasswordAdmin()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Event handler to validate password and apply salted hash when the Update button is clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnUpdateClick(object sender, EventArgs e)
        {
            // Verify that the two entered passwords match
            if (!this.txtPassword.Text.Equals(this.txtConfirmPassword.Text))
            {
                MessageBox.Show("Sorry, the passwords do not match.  Please try again!");

                // Clear the password boxes
                this.txtPassword.Text = string.Empty;
                this.txtConfirmPassword.Text = string.Empty;

                this.txtPassword.Focus();
            }
            else
            {
                // Generate salt and salted hash
                SaltedHash sh = new SaltedHash(txtPassword.Text);

                // Find current user, then update password hash and salt in database
                try
                {
                    using (var context = new db_sft_2172Entities())
                    {
                        // Run query to get user data
                        var userQuery = from users in context.Users
                                        where users.UserID.Equals(Program.CurrentUser)
                                        select users;

                        User currentUser = userQuery.FirstOrDefault();

                        currentUser.Password = sh.Hash;
                        currentUser.PasswordSalt = sh.Salt;
                        currentUser.ResetPassword = false;

                        context.SaveChanges();

                        // Show confirmation if save is successful
                        MessageBox.Show("Password updated successfully!  Please login again with your new password.");

                        // Force user to Logout and login with new password
                        Program.LoginForm.Logout();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        /// <summary>
        /// Event handler to close the form when the Cancel button is clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">     The parameter is not used.</param>
        private void BtnCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
