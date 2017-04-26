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
    public partial class RoleForm : Form
    {
        public RoleForm()
        {
            InitializeComponent();

            // Check current user roles and generate list items as appropriate
            if (Program.CurrentUser.IsStudent)
                cmbRoleChoice.Items.Add("Student");

            if (Program.CurrentUser.IsCoach)
                cmbRoleChoice.Items.Add("Coach");

            if (Program.CurrentUser.IsAdmin)
                cmbRoleChoice.Items.Add("Admin");

            if (cmbRoleChoice.Items.Count == 0)
                throw new Exception("ERROR: User must be assigned to at least one role.\nPlease contact an administrator for assistance.");
            else
            {
                cmbRoleChoice.SelectedIndex = 0;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Program.loginForm.logout();

            // Close this window
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            // If valid option is selected, call static method to load the correct window
            if (cmbRoleChoice.Text == Program.studentRoleName ||
                cmbRoleChoice.Text == Program.coachRoleName ||
                cmbRoleChoice.Text == Program.adminRoleName)
            {
                Program.openUserHomepage(cmbRoleChoice.Text);
            }
            else
            {
                throw new Exception("Invalid choice...please try again!");
            }

            this.Close();
        }
    }
}
