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
    public partial class AdminForm : Form
    {
        /// <summary>
        /// Constructor to initialize form and set up subforms on individual tabs
        /// </summary>
        public AdminForm()
        {
            InitializeComponent();

            // Set up Users tab
            UserAdminFormAdam userForm = new UserAdminFormAdam();
            userForm.TopLevel = false;
            userForm.AutoScroll = true;
            //userForm.FormBorderStyle = FormBorderStyle.None;

            UsersTabPage.Controls.Add(userForm);
            userForm.Show();


            // Set up Session tab
            SessionAdminForm sessionForm = new SessionAdminForm();
            sessionForm.TopLevel = false;
            sessionForm.AutoScroll = true;
            //sessionForm.FormBorderStyle = FormBorderStyle.None;

            SessionsTabPage.Controls.Add(sessionForm);
            sessionForm.Show();
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
        /// Event handler to logoff and return to the login form when the Logoff button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Event handler to exit the application when the Form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.loginForm.logout();
        }

        /// <summary>
        /// Event handler to load the Change Password form when the Change Password button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePassword = new ChangePasswordForm();
            changePassword.ShowDialog();
        }
    }
}
