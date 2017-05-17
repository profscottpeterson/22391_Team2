// <copyright file="AdminForm.cs" company="PABT at NWTC">
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
    /// AdminForm: A class which is used to create a placeholder form to hold "admin tool" sub-forms
    /// </summary>
    public partial class AdminForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminForm"/> class
        /// </summary>
        public AdminForm()
        {
            this.InitializeComponent();

            // Set up Users tab
            UserAdminForm userForm = new UserAdminForm();
            userForm.TopLevel = false;
            userForm.AutoScroll = true;
            userForm.FormBorderStyle = FormBorderStyle.None;

            this.usersTabPage.Controls.Add(userForm);
            userForm.Show();

            // Set up Session tab
            SessionAdminForm sessionForm = new SessionAdminForm();
            sessionForm.TopLevel = false;
            sessionForm.AutoScroll = true;
            sessionForm.FormBorderStyle = FormBorderStyle.None;

            this.sessionsTabPage.Controls.Add(sessionForm);
            sessionForm.Show();
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
        /// Event handler to logoff and return to the login form when the Logoff button is clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnLogOffClick(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Event handler to exit the application when the Form is closed
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void AdminFormFormClosed(object sender, FormClosedEventArgs e)
        {
            Program.LoginForm.Logout();
        }

        /// <summary>
        /// Event handler to load the Change Password form when the Change Password button is clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnChangePasswordClick(object sender, EventArgs e)
        {
            ResetStudentPassword changePassword = new ResetStudentPassword(this);
            changePassword.Show();
            this.Hide();
        }
    }
}
