// <copyright file="RoleForm.cs" company="PABT at NWTC">
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
    /// A form that allows the user to navigate to a desired start page based on the role they choose.
    /// Roles are available only if they are set to "active" in the User Admin tool.
    /// </summary>
    public partial class RoleForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleForm" /> class.
        /// </summary>
        public RoleForm()
        {
            this.InitializeComponent();

            // Check current user roles and generate list items as appropriate
            if (Program.IsStudent)
            {
                this.cmbRoleChoice.Items.Add("Student");
            }

            if (Program.IsCoach)
            {
                this.cmbRoleChoice.Items.Add("Coach");
            }

            if (Program.IsAdmin)
            {
                this.cmbRoleChoice.Items.Add("Admin");
            }

            if (this.cmbRoleChoice.Items.Count == 0)
            {
                throw new Exception("ERROR: User must be assigned to at least one role.");
            }
            else
            {
                this.cmbRoleChoice.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Event handler to exit the application button when the exit button is clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnExitClick(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }

        /// <summary>
        /// Event handler that calls the logout method when the Logout button is clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnLogoutClick(object sender, EventArgs e)
        {
            Program.LoginForm.Logout();

            // Close this window
            this.Close();
        }

        /// <summary>
        /// Event handler that closes the role window and opens the desired role start page when the Accept button is clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnAcceptClick(object sender, EventArgs e)
        {
            // If valid option is selected, call static method to load the correct window
            if (this.cmbRoleChoice.Text == Program.StudentRoleName ||
                this.cmbRoleChoice.Text == Program.CoachRoleName ||
                this.cmbRoleChoice.Text == Program.AdminRoleName)
            {
                Program.OpenUserHomepage(this.cmbRoleChoice.Text);
            }
            else
            {
                MessageBox.Show("Invalid choice...please try again!");
                this.cmbRoleChoice.Focus();
            }

            this.Close();
        }
    }
}
