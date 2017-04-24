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
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usernameText = txtUsername.Text;
            string passwordText = txtPassword.Text;

            btnLogin.Enabled = false;

            login(usernameText, passwordText);

            btnLogin.Enabled = true;
        }

        private void login(string username, string password)
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    var userQuery = from u in context.Users
                                    where u.UserID.Equals(username)
                                    select u;

                    if (userQuery.Count<User>() > 0)
                    {
                        var userResult = userQuery.FirstOrDefault<User>();

                        // Check if password is correct.
                        // If not, display message and set focus to password text box.
                        if (userResult.Password == password)
                        {
                            // Update static variable containing User ID
                            Program.CurrentUser = userResult.UserID;

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

                        //throw new Exception("Login Error: Username not in database");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void logout()
        {
            // Clear out all static variables related to user
            Program.CurrentUser = null;
            Program.IsStudent = false;
            Program.IsCoach = false;
            Program.IsAdmin = false;

            // Show hidden login form
            Program.loginForm.Show();
        }

    }
}
