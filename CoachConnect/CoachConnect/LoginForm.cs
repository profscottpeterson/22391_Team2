using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoachConnect
{
    public partial class LoginForm : Form
    {
        /// <summary>
        /// Constructor to initialize the login form
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler to exit the application when the Exit button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Event handler to obtain the entered username and password, then call the login method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usernameText = txtUsername.Text;
            string passwordText = txtPassword.Text;

            btnLogin.Enabled = false;

            login(usernameText, passwordText);

            btnLogin.Enabled = true;
        }

        /// <summary>
        /// Method to match password with the database (using salted hash), then login and load the role form
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        private void login(string username, string password)
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
                        var userResult = userQuery.FirstOrDefault<User>();

                        // Determine whether user is active.  If not, display a message and logout.
                        if (!userResult.IsActive)
                        {
                            MessageBox.Show("Sorry, this user is inactive.  Please contact an administrator if you need to reactivate your account.");
                            logout();

                            return;
                        }

                        /*************************************************************/
                        /** Applying salted hash technique to verify password       **/
                        /**                                                         **/
                        /** If you wish to use a non-encrypted password, uncomment  **/
                        /** the first "if" statement below                          **/
                        /** Otherwise, uncomment the second "if" to use encryption. **/
                        /*************************************************************/
                       // if (userResult.Password == password) 
                        if (SaltedHash.Verify(userResult.PasswordSalt, userResult.Password, password))
                        {
                            // Update static variable containing User ID
                            Program.CurrentUser = userResult.UserID;

                            // If flag is set to reset password, load the Change Password form.
                            if (userResult.ResetPassword)
                            {
                                MessageBox.Show("Your password is outdated and needs to be changed.  Please reset your password now.");

                                ChangePasswordForm changePassword = new ChangePasswordForm();
                                changePassword.ShowDialog();

                                return;
                            }

                            else
                            {
                                // If any of these three values are true, update static variables
                                if (userResult.IsStudent)
                                    Program.IsStudent = true;

                                if (userResult.IsAdmin)
                                    Program.IsAdmin = true;

                                if (userResult.IsCoach)
                                    Program.IsCoach = true;

                                // Call method from Program class to display Role Page
                                Program.RolePage();

                                // Hide window once Role Form loads (we cannot close this window or the program will close)
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sorry, invalid username or password.  Please try again!");
                            txtUsername.Text = "";
                            txtPassword.Text = "";
                            txtUsername.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sorry, invalid username or password.  Please try again!");
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                        txtUsername.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Method to handle logout process
        /// </summary>
        public void logout()
        {
            // Clear out text boxes and set focus to the username text box
            txtUsername.Text = "";
            txtPassword.Text = "";

            txtUsername.Focus();

            // Clear out all static variables related to user
            Program.CurrentUser = null;
            Program.IsStudent = false;
            Program.IsCoach = false;
            Program.IsAdmin = false;

            // Show hidden login form
            Program.loginForm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
