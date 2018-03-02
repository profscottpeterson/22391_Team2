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
        /// <param name="userID">The userID whose password needs to be updated</param>
        public ResetUserPasswordAdmin(string userID)
        {
            this.CurrentUserID = userID;
            this.InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the current UserID whose password needs to be updated
        /// </summary>
        private string CurrentUserID { get; set; }

        /// <summary>
        /// Event handler to validate password and apply salted hash when the Update button is clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnUpdateClick(object sender, EventArgs e)
        {
            // Verify that the two entered passwords match
            if (!this.txtAccessKey.Text.Equals(this.txtConfirmKey.Text))
            {
                MessageBox.Show("Sorry, the access keys do not match.  Please try again!");

                // Clear the password boxes
                this.txtAccessKey.Text = string.Empty;
                this.txtConfirmKey.Text = string.Empty;

                this.txtAccessKey.Focus();
            }
            else if (this.txtAccessKey.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter a new access key.");

                // Clear the password boxes
                this.txtAccessKey.Text = string.Empty;
                this.txtConfirmKey.Text = string.Empty;

                this.txtAccessKey.Focus();
            }
            else
            {
                // Find current user, then update password hash and salt in database
                try
                {
                    using (var context = new db_sft_2172Entities())
                    {
                        // Run query to get user data
                        var userQuery = from users in context.Users
                                        where users.UserID.Equals(this.CurrentUserID)
                                        select users;

                        User currentUser = userQuery.FirstOrDefault();

                        currentUser.ResetPassword = txtAccessKey.Text;

                        context.SaveChanges();

                        // Show confirmation if save is successful
                        MessageBox.Show("Access key updated successfully!\n Please provide this value to the user: " + txtAccessKey.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                // Close the form when finished
                this.Close();
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

        /// <summary>
        /// Event handler to validate the new password and confirm the entries are identical.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void TxtStdNewConfirmPasswordLeave(object sender, EventArgs e)
        {
            if (txtAccessKey.Text == txtConfirmKey.Text && (txtAccessKey.Text != string.Empty || txtConfirmKey.Text != string.Empty))
            {
                imgPasswordValid.Visible = true;
                imgPasswordNotValid.Visible = false;
            }
            else
            {
                imgPasswordNotValid.Visible = true;
                imgPasswordValid.Visible = false;
            }
        }
    }
}
