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
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Verify that the two entered passwords match
            if (!txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                MessageBox.Show("Sorry, the passwords do not match.  Please try again!");

                // Clear the password boxes
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";

                txtPassword.Focus();
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

                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
