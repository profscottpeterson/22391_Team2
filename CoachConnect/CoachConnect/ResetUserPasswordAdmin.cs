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
    /// A form for admin's to reset a password and enter a new temporary access code.
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
        /// Event handler to set temporary access code
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnUpdateClick(object sender, EventArgs e)
        {
            // Verify that the two entered passwords match
            if (!this.txtTempCode.Text.Equals(this.txtConfirmTempCode.Text))
            {
                MessageBox.Show("Sorry, the codes do not match.  Please try again!");

                // Clear the password boxes
                this.txtTempCode.Text = string.Empty;
                this.txtConfirmTempCode.Text = string.Empty;

                this.txtTempCode.Focus();
            }
            else if (this.txtTempCode.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter a code (max 10 characters).");

                // Clear the password boxes
                this.txtTempCode.Text = string.Empty;
                this.txtConfirmTempCode.Text = string.Empty;

                this.txtTempCode.Focus();
            }
            else
            {
                // Find current user, then update temporary code in database
                try
                {
                    using (var context = new db_sft_2172Entities())
                    {
                        // Run query to get user data
                        var userQuery = from users in context.Users
                                        where users.UserID.Equals(this.CurrentUserID)
                                        select users;

                        User currentUser = userQuery.FirstOrDefault();

                        if (currentUser != null)
                        {
                        currentUser.ResetPassword = txtTempCode.Text;
                        context.SaveChanges();

                        // Show confirmation if save is successful
                        MessageBox.Show("Password updated successfully!");
                        }   
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
            if (txtTempCode.Text == txtConfirmTempCode.Text && (txtTempCode.Text != string.Empty || txtConfirmTempCode.Text != string.Empty))
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
