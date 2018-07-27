// <copyright file="UserAdminForm.cs" company="PABT at NWTC">
//     Copyright 2017 PABT (Pao Xiong, Adam Smith, Brian Lueskow, Tim Durkee)
// </copyright>
namespace CoachConnect
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure;
    using System.Data.SqlClient;
    using System.Linq;
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
            InitializeComponent();
        }
  
        /// <summary>
        /// Maximizes Form and displays the users with load event of the form.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void UserAdminFormLoad(object sender, EventArgs e)
        {
            DisplayUsers();
        }

        /// <summary>
        /// Method to display the list of users
        /// </summary>
        private void DisplayUsers()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Query user table in database and returns the list of the users in ascending order according to last name
                    var userQuery = from users in context.Users
                        orderby users.LastName
                        select users;

                    // Convert query results to list
                    List<User> userList = userQuery.ToList();

                    // Set combo box data source and update data member settings
                    cbxChooseUser.DataSource = userList;
                    cbxChooseUser.ValueMember = "UserID";
                    cbxChooseUser.DisplayMember = "DisplayName";
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.InnerException != null ? sqlEx.InnerException.Message : sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Clear all data fields
        /// </summary>
        private void ClearAllFields()
        {
            // Clearing check boxes and text boxes.
            txtID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleName.Clear();
            txtDisplayName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            chkActive.Checked = false;
            chkAdmin.Checked = false;
            chkSupervisor.Checked = false;
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
                    string userId = cbxChooseUser.SelectedValue.ToString();

                    // Find the user in the database
                    var userQuery = from user in context.Users
                                    where user.UserID.Equals(userId)
                                    select user;

                    // If the query returns a user, display the corresponding info in the form
                    if (userQuery.Any())
                    {
                        var userResult = userQuery.FirstOrDefault();

                        if (userResult != null)
                        {
                            txtID.Text = userResult.UserID;
                            txtFirstName.Text = userResult.FirstName;
                            txtLastName.Text = userResult.LastName;
                            txtMiddleName.Text = userResult.MiddleName;
                            txtDisplayName.Text = userResult.DisplayName;
                            txtEmail.Text = userResult.Email;
                            txtPhone.Text = userResult.Phone;
                            chkActive.Checked = userResult.IsActive;
                            chkAdmin.Checked = userResult.IsAdmin;
                            chkSupervisor.Checked = userResult.IsSupervisor;
                            
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
                        var userResult = userQuery.FirstOrDefault();
                        userResult.FirstName = txtFirstName.Text;
                        userResult.MiddleName = txtMiddleName.Text;
                        userResult.LastName = txtLastName.Text;
                        userResult.DisplayName = txtDisplayName.Text;
                        userResult.Phone = txtPhone.Text;
                        userResult.Email = txtEmail.Text;
                        userResult.IsActive = chkActive.Checked;
                        userResult.IsAdmin = chkAdmin.Checked;
                        userResult.IsSupervisor = chkSupervisor.Checked;
                        
                        context.SaveChanges();

                        MessageBox.Show(@"User Profile Updated");
                    }
                    else
                    {
                        User newUser = new User
                        {
                            UserID = txtID.Text,
                            FirstName = txtFirstName.Text,
                            MiddleName = txtMiddleName.Text,
                            LastName = txtLastName.Text,
                            DisplayName = txtDisplayName.Text,
                            Phone = txtPhone.Text,
                            Email = txtEmail.Text,
                            IsActive = chkActive.Checked,
                            IsAdmin = chkAdmin.Checked,
                            IsSupervisor = chkSupervisor.Checked
                        };

                        context.Users.Add(newUser);
                        context.SaveChanges();

                        MessageBox.Show(@"User Profile Created");

                        // If save is successful, update the user list and display the new user profile
                        DisplayUsers();
                        cbxChooseUser.SelectedValue = newUser.UserID;
                    }
                }
            }
            catch (DbUpdateException dbUEx)
            {
                MessageBox.Show(dbUEx.InnerException != null ? dbUEx.InnerException.Message : dbUEx.Message);
                return;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.InnerException != null ? sqlEx.InnerException.Message : sqlEx.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            DisplayUsers();
            ClearAllFields();
            MessageBox.Show(@"User Profile Updated");
        }

        /// <summary>
        /// A method to disable a selected user
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnMinusClick(object sender, EventArgs e)
        {
            chkAdmin.Checked = false;
            chkActive.Checked = false;
            chkSupervisor.Checked = false;
        }

        /// <summary>
        /// A button to allow users to reset their password
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnResetPasswordClick(object sender, EventArgs e)
        {
            string username = txtID.Text;

            ResetUserPasswordAdmin resetPasswordForm = new ResetUserPasswordAdmin(username);
            resetPasswordForm.ShowDialog();
        }
    }
}