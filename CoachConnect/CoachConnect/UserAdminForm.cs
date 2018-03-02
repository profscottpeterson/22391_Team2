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
    /// Initializes a new instance of the <see cref="UserProfileForm"/> class.
    /// </summary>
    public partial class UserProfileForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the UserAdminForm class.
        /// </summary>
        public UserProfileForm()
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
                var userQuery = from users in context.Users
                                orderby users.LastName ascending
                                select users;

                // Convert query results to list
                List<User> userList = userQuery.ToList();

                // Set combo box data source and update data member settings
                this.cbxChooseUser.DataSource = userList;
                this.cbxChooseUser.ValueMember = "UserID";
                this.cbxChooseUser.DisplayMember = "DisplayName";
            }
        }

        /// <summary>
        /// Clear all data fields
        /// </summary>
        private void ClearAllFields()
        {
            // Clearing check boxes and text boxes.
            this.txtID.Clear();
            this.txtFirstName.Clear();
            this.txtLastName.Clear();
            this.txtMiddleName.Clear();
            this.txtDisplayName.Clear();
            this.txtEmail.Clear();
            this.txtPhone.Clear();
            this.chkActive.Checked = false;
            this.chkAdmin.Checked = false;
            this.chkSupervisor.Checked = false;
        }

        /// <summary>
        /// Populates the combo boxes and text boxes with the selected user's information
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void cbxChooseUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxChooseUser.SelectedIndex == -1) return;

            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Query obtains the user ID from the combo box
                    string userId = this.cbxChooseUser.SelectedValue.ToString();

                    // Find the user in the database
                    var userQuery = from user in context.Users
                                    where user.UserID.Equals(userId)
                                    select user;

                    // If the query returns a user, display the corresponding info in the form
                    if (userQuery.Any())
                    {
                        var userResult = userQuery.FirstOrDefault<User>();

                        if (userResult != null)
                        {
                            this.txtID.Text = userResult.UserID;
                            this.txtFirstName.Text = userResult.FirstName;
                            this.txtLastName.Text = userResult.LastName;
                            this.txtMiddleName.Text = userResult.MiddleName;
                            this.txtDisplayName.Text = userResult.DisplayName;
                            this.txtEmail.Text = userResult.Email;
                            this.txtPhone.Text = userResult.Phone;
                            this.chkActive.Checked = userResult.IsActive;
                            this.chkAdmin.Checked = userResult.IsAdmin;
                            this.chkSupervisor.Checked = userResult.IsSupervisor;
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Add button clears all text boxes and check boxes so user can enter new information.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnAddClick(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        /// <summary>
        /// Submit button sends the added or updated info to the database.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnSubmitClick(object sender, EventArgs e)
        {
            try
            {
                // Run query to check for a corresponding user in the database
                using (var context = new db_sft_2172Entities())
                {
                    string userId = txtID.Text;
                    var userQuery = from user in context.Users
                                    where user.UserID.Equals(userId)
                                    select user;

                    if (userQuery.Any())
                    {
                        var userResult = userQuery.FirstOrDefault<User>();
                        userResult.FirstName = txtFirstName.Text;
                        userResult.MiddleName = txtMiddleName.Text;
                        userResult.LastName = txtLastName.Text;
                        userResult.DisplayName = txtDisplayName.Text;
                        userResult.Phone = txtPhone.Text;
                        userResult.Email = txtEmail.Text;
                        userResult.IsActive = chkActive.Checked;
                        userResult.IsAdmin = chkAdmin.Checked;
                        userResult.IsSupervisor = chkSupervisor.Checked;

                    }
                    else
                    {
                        User newUser = new User();
                        newUser.UserID = this.txtID.Text;
                        newUser.FirstName = this.txtFirstName.Text;
                        newUser.MiddleName = this.txtMiddleName.Text;
                        newUser.LastName = this.txtLastName.Text;
                        newUser.DisplayName = this.txtDisplayName.Text;
                        newUser.Phone = this.txtPhone.Text;
                        newUser.Email = this.txtEmail.Text;
                        newUser.IsActive = this.chkActive.Checked;
                        newUser.IsAdmin = this.chkAdmin.Checked;
                        newUser.IsSupervisor = this.chkSupervisor.Checked;

                        context.Users.Add(newUser);
                        context.SaveChanges();

                        // TODO: Need to add error handling and ensure update was completed correctly
                        MessageBox.Show("User Profile Updated");

                        // If save is successful, update the user list and display the new user profile
                        this.DisplayUsers();
                        this.cbxChooseUser.SelectedValue = newUser.UserID;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            

            this.DisplayUsers();
            this.ClearAllFields();
            MessageBox.Show("User Profile Updated");
        }

        /// <summary>
        /// A method to disable a selected user
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnMinusClick(object sender, EventArgs e)
        {
            this.chkAdmin.Checked = false;
            this.chkActive.Checked = false;
            this.chkSupervisor.Checked = false;
        }

        /// <summary>
        /// A button to allow users to reset their password
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnResetPasswordClick(object sender, EventArgs e)
        {
            string username = this.txtID.Text;

            ResetUserPasswordAdmin resetPasswordForm = new ResetUserPasswordAdmin(username);
            resetPasswordForm.ShowDialog();
        }
    }
}