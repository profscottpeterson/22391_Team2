// <copyright file="UserAdminForm.cs" company="PABT at NWTC">
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
    /// Initializes a new instance of the <see cref="UserAdminForm"/> class.
    /// </summary>
    public partial class UserAdminForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the UserAdminForm class.
        /// </summary>
        public UserAdminForm()
        {
            this.InitializeComponent();
        }
  
        /// <summary>
        /// Maximizes Form and displays the users with load event of the form.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void UserAdminFormLoad(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.DisplayUsers();
        }

        /// <summary>
        /// Method to display the list of users
        /// </summary>
        private void DisplayUsers()
        {
            using (var context = new db_sft_2172Entities())
            {
                // Query user table in database and returns the list of the users in ascending order according to last name
                var userQuery = from u in context.Users
                                orderby u.LastName ascending
                                select u;

                // Clearing the list box for new entries.
                this.lstBoxUsers.Items.Clear();
                foreach (var item in userQuery)
                {
                    // adding to the listbox
                    string username = item.UserID + " " + item.DisplayName;
                    this.lstBoxUsers.Items.Add(username);
                }
            }
        }

        /// <summary>
        /// Clear all checkboxes
        /// </summary>
        private void ChkBoxClear()
        {
           // Clearing check boxes and text boxes.
            this.chkBoxAdmin.Checked = false;
            this.chkBoxActive.Checked = false;
            this.chkBoxSupervisor.Checked = false;
            this.txtBoxFirstName.Clear();
            this.txtBoxLastName.Clear();
            this.txtBoxMiddleName.Clear();
            this.txtBoxPassword.Clear();
            this.txtBoxUserID.Clear();
        }

        /// <summary>
        /// Populates the check boxes and text boxes.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void LstBoxUsersSelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new db_sft_2172Entities())
            {
                // Query is getting the user num from the list box.
                string username = this.lstBoxUsers.SelectedItem.ToString();
                string[] userNameSplit = username.Split(' ');
                string usernum = userNameSplit[0];

                // Finds the user in the database.
                var userQuery = from u in context.Users
                                where u.UserID.Equals(usernum)
                                select u;

                // If the result has a user it displays the info in the check boxes and the text boxes.
                if (userQuery.Any())
                {
                    var userResult = userQuery.FirstOrDefault<User>();
                    this.txtBoxFirstName.Text = userResult.FirstName;
                    this.txtBoxLastName.Text = userResult.LastName;
                    this.txtBoxMiddleName.Text = userResult.MiddleName;
                    this.txtBoxUserID.Text = userResult.UserID;
                    this.txtBoxPassword.Text = userResult.Password;

                    this.chkBoxAdmin.Checked = userResult.IsAdmin;
                    this.chkBoxActive.Checked = userResult.IsActive;
                    this.chkBoxSupervisor.Checked = userResult.IsSupervisor;
                }
            }
        }

        /// <summary>
        /// Add button clearing all text boxes and check boxes allowing user to populate.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnAddClick(object sender, EventArgs e)
        {
            this.txtBoxFirstName.Text = string.Empty;
            this.txtBoxLastName.Text = string.Empty;
            this.txtBoxMiddleName.Text = string.Empty;
            this.txtBoxUserID.Text = string.Empty;
            this.txtBoxPassword.Text = string.Empty;
            this.chkBoxActive.Checked = false;
            this.chkBoxAdmin.Checked = false;
            this.chkBoxSupervisor.Checked = false;
            this.lstBoxUsers.Items.Add("First Name Middle Name Last Name");
            this.lstBoxUsers.SelectedIndex = this.lstBoxUsers.Items.Count - 1;

            this.txtBoxUserID.ReadOnly = false;
        }

        /// <summary>
        /// Submit button which submits the added or updated info to the database.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnSubmitClick(object sender, EventArgs e)
        {
            if (this.lstBoxUsers.SelectedItem.Equals("First Name Middle Name Last Name"))
            {
                // adding user to the database.
                using (var context = new db_sft_2172Entities())
                {
                    User user = new User();
                    user.FirstName = this.txtBoxFirstName.Text;
                    user.MiddleName = this.txtBoxMiddleName.Text;
                    user.LastName = this.txtBoxLastName.Text;
                    user.UserID = this.txtBoxUserID.Text;
                    user.Password = this.txtBoxPassword.Text;
                    user.IsAdmin = this.chkBoxAdmin.Checked;
                    user.IsActive = this.chkBoxActive.Checked;
                    user.IsSupervisor = this.chkBoxSupervisor.Checked;
                    user.DisplayName = this.txtBoxFirstName.Text + " " + this.txtBoxMiddleName.Text + " " + this.txtBoxLastName.Text;

                    var userQuery = context.Users.Add(user);
                    context.SaveChanges();
                }
            }
            else
            {
                // Query updates the user in the database
                using (var context = new db_sft_2172Entities())
                {
                    string username = lstBoxUsers.SelectedItem.ToString();
                    string[] userNameSplit = username.Split(' ');
                    string usernum = userNameSplit[0];
                    var userQuery = from u in context.Users
                                    where u.UserID.Equals(usernum)
                                    select u;

                    if (userQuery.Any())
                    {
                        var userResult = userQuery.FirstOrDefault<User>();

                        User user = new User();
                        userResult.FirstName = txtBoxFirstName.Text;
                        userResult.MiddleName = txtBoxMiddleName.Text;
                        userResult.LastName = txtBoxLastName.Text;
                        userResult.UserID = txtBoxUserID.Text;
                        userResult.Password = txtBoxPassword.Text;
                        userResult.IsAdmin = chkBoxAdmin.Checked;
                        userResult.IsActive = chkBoxActive.Checked;
                        userResult.IsSupervisor = chkBoxSupervisor.Checked;
                        userResult.DisplayName = txtBoxFirstName.Text + " " + txtBoxMiddleName.Text + " " + txtBoxLastName.Text;
                        context.SaveChanges();
                    }
                }
            }

            this.DisplayUsers();
            this.ChkBoxClear();
            this.txtBoxUserID.ReadOnly = true;
            MessageBox.Show("User Profile Updated");
        }

        /// <summary>
        /// A method to disable a selected user
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnMinusClick(object sender, EventArgs e)
        {
            this.chkBoxAdmin.Checked = false;
            this.chkBoxActive.Checked = false;
            this.chkBoxSupervisor.Checked = false;
        }

        /// <summary>
        /// A button to allow users to reset their password
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnResetPasswordClick(object sender, EventArgs e)
        {
            string username = this.txtBoxUserID.Text;

            ResetUserPasswordAdmin resetPasswordForm = new ResetUserPasswordAdmin(username);
            resetPasswordForm.ShowDialog();
        }
    }
}