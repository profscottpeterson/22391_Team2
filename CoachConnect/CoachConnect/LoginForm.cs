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

            login(usernameText, passwordText);
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

                    var userResult = userQuery.FirstOrDefault<User>();

                    if (userResult.UserID == username)
                    {
                        // Check if password is correct.
                        // If not, display message and set focus to password text box.
                        if (userResult.Password == password)
                        {
                            Program.CurrentUser = userResult.UserID;
                            Program.OpenUserHomepage();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid login...please try again!");
                            txtPassword.Focus();
                        }
                    }
                    else
                    {
                        throw new Exception("Login Error: Username not in database");
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

    }
}
