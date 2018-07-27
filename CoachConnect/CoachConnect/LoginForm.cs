// <copyright file="LoginForm.cs" company="Adam Smith at NWTC">
//     Copyright 2017 Smithbucks Computing (Adam Smith)
// </copyright>

using System.Data.SqlClient;

namespace CoachConnect
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// A class to display a login form for the user
    /// </summary>
    public partial class LoginForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginForm" /> class.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler to exit the application when the Exit button is clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Event handler to obtain the entered username and password, then call the login method
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnLoginClick(object sender, EventArgs e)
        {
            string usernameText = txtUsername.Text;
            string passwordText = txtPassword.Text;

            btnLogin.Enabled = false;

            Login(usernameText, passwordText);

            btnLogin.Enabled = true;
        }

        /// <summary>
        /// Method to match password with the database (using salted hash), then login and load the role form
        /// </summary>
        /// <param name="username">The username string entered by the user</param>
        /// <param name="password">The password string entered by the user</param>
        private void Login(string username, string password)
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    var userQuery = from u in context.Users
                        where u.UserID.Equals(username)
                        select u;

                    if (userQuery.Any())
                    {
                        var userResult = userQuery.FirstOrDefault();

                        // Determine whether user is active.  If not, display a message and Logout.
                        if (!userResult.IsActive)
                        {
                            MessageBox.Show(
                                @"Sorry, this user is inactive.  Please contact an administrator if you need to reactivate your account.");
                            Program.Logout();

                            return;
                        }

                        /*************************************************************/
                        /** Applying salted hash technique to verify password       **/
                        /**                                                         **/
                        /** If you wish to use a non-encrypted password, uncomment  **/
                        /** the first "if" statement below                          **/
                        /** Otherwise, uncomment the second "if" to use encryption. **/
                        /*************************************************************/
                        if (SaltedHash.Verify(userResult.PasswordSalt, userResult.Password, password))
                        {
                            // Update static variable containing User ID
                            Program.CurrentUser = userResult.UserID;

                            // If flag is set to reset password, load the Change Password form.
                            if (userResult.ResetPassword != null)
                            {
                                MessageBox.Show(
                                    @"Your password is outdated and needs to be changed.  Please reset your password now.");

                                ResetMyPassword changePassword = new ResetMyPassword();
                                changePassword.ShowDialog();
                            }
                            else
                            {
                                // If any of these three values are true, update static variables
                                if (userResult.IsSupervisor)
                                {
                                    Program.IsSupervisor = true;
                                }

                                if (userResult.IsAdmin)
                                {
                                    Program.IsAdmin = true;
                                }

                                // Call method to update menu options
                                Program.UpdateMenus();

                                // Close window once finished
                                Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show(@"Sorry, invalid username or password.  Please try again!");
                            txtUsername.Text = string.Empty;
                            txtPassword.Text = string.Empty;
                            txtUsername.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Sorry, invalid username or password.  Please try again!");
                        txtUsername.Text = string.Empty;
                        txtPassword.Text = string.Empty;
                        txtUsername.Focus();
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.InnerException != null ? sqlEx.InnerException.Message : sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
