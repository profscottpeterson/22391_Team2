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
    public partial class UserAdminFormAdam : Form
    {
        /****************/
        /** Properties **/
        /****************/
        private User CurrentUser { get; set; }

        private int CurrentUserIndex { get; set; }

        /*****************/
        /** Constructor **/
        /*****************/
        public UserAdminFormAdam()
        {
            InitializeComponent();

            // Update the user list
            this.CurrentUserIndex = 0;
            updateUserList();

            // Manually select the first user
            lstBoxUsers.SelectedIndex = -1;
            lstBoxUsers.SelectedIndex = 0;
        }

        /*********************/
        /** Button handlers **/
        /*********************/
        private void btnLogOff_Click(object sender, EventArgs e)
        {
            // TODO: Confirm changes before closing form //

            // Open login form and clear out active user
            Program.loginForm.logout();

            // Close this window
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /*******************/
        /** Data handlers **/
        /*******************/
        private void updateUserList()
        {
            // Query the database and pull the list of users
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Run query to get user data
                    var userQuery = from users in context.Users
                                    select users;

                    // Bind the data list to the combo box
                    lstBoxUsers.DataSource = userQuery.ToList();
                    lstBoxUsers.DisplayMember = "DisplayName";
                    lstBoxUsers.ValueMember = "UserID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="userID"></param>
        /// <returns>currentUser</returns>
        private User displayUserDetails(string userID)
        {
            User selectedUser;

            // Run query to pull selected user
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Run query to get user data
                    var userQuery = from users in context.Users
                                    where users.UserID.Equals(userID)
                                    select users;

                    // Save user as variable
                    selectedUser = userQuery.FirstOrDefault<User>();

                    // Update current user property for form
                    this.CurrentUser = selectedUser;

                    // Update User Details section
                    txtUserID.Text = selectedUser.UserID;
                    txtFirstName.Text = selectedUser.FirstName;
                    txtMiddleName.Text = selectedUser.MiddleName;
                    txtLastName.Text = selectedUser.LastName;
                    txtDisplayName.Text = selectedUser.DisplayName;
                    txtPhone.Text = selectedUser.Phone;
                    txtEmail.Text = selectedUser.Email;
                    txtProfilePic.Text = selectedUser.ProfilePic;

                    chkBoxAdmin.Checked = selectedUser.IsAdmin;
                    chkBoxStudent.Checked = selectedUser.IsStudent;
                    chkBoxCoach.Checked = selectedUser.IsCoach;
                    chkBoxActive.Checked = selectedUser.IsActive;
                    chkBoxResetPassword.Checked = selectedUser.ResetPassword;
                }

                // Update current user index for form
                this.CurrentUserIndex = lstBoxUsers.SelectedIndex;

                return selectedUser;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        //private bool isUserDataDifferent()
        //{
        //    if (txtFirstName.Equals(CurrentUser.FirstName) &&
        //        txtLastName.Equals(CurrentUser.LastName) &&
        //        txtMiddleName.Equals(CurrentUser.MiddleName) &&
        //        txtDisplayName.Equals(CurrentUser.DisplayName))
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

        //private string confirmUserChanges()
        //{
        //    string resultString = CANCEL_STRING;

        //    // Display dialog box to confirm changes
        //    DialogResult confirmChoice = MessageBox.Show("Do you want to save these changes?", "Confirmation", MessageBoxButtons.YesNoCancel);

        //    if (confirmChoice.Equals(DialogResult.Cancel))
        //    {
        //        resultString = CANCEL_STRING;
        //    }
        //    else if (confirmChoice.Equals(DialogResult.No))
        //    {
        //        resultString = NO_STRING;
        //    }
        //    else if (confirmChoice.Equals(DialogResult.Yes))
        //    {
        //        resultString = YES_STRING;

        //        // Update changes in database
                
        //    }

        //    return resultString;
        //}

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Create new User objet and save entries for the DB update
            User userChanges = new User();

            userChanges.UserID = txtUserID.Text;
            userChanges.FirstName = txtFirstName.Text;
            userChanges.MiddleName = txtMiddleName.Text;
            userChanges.LastName = txtLastName.Text;
            userChanges.DisplayName = txtDisplayName.Text;
            userChanges.Phone = txtPhone.Text;
            userChanges.Email = txtEmail.Text;
            userChanges.ProfilePic = txtProfilePic.Text;

            userChanges.IsStudent = chkBoxStudent.Checked;
            userChanges.IsCoach = chkBoxCoach.Checked;
            userChanges.IsAdmin = chkBoxAdmin.Checked;
            userChanges.IsActive = chkBoxActive.Checked;
            userChanges.ResetPassword = chkBoxResetPassword.Checked;

            // Update "Active Coach Since" field
            if (userChanges.IsCoach &&
                (txtUserID.Enabled || !CurrentUser.IsCoach))
            {
                userChanges.ActiveCoachSince = DateTime.Now;
            }
            else if (!userChanges.IsCoach)
            {
                userChanges.ActiveCoachSince = null;
            }
            else
            {
                userChanges.ActiveCoachSince = CurrentUser.ActiveCoachSince;
            }

            // Set new password if new user
            if (txtUserID.Enabled)
            {
                userChanges.Password = "BAPT&" + userChanges.UserID;
            }

            // Add new user or apply updates
            if (txtUserID.Enabled)
            {
                addNewUser(userChanges);
            }

            else
            {
                updateExistingUser(userChanges);
            }

            txtUserID.Enabled = false;
            lstBoxUsers.Enabled = true;
        }

        private void lstBoxUsers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.CurrentUserIndex == lstBoxUsers.SelectedIndex)
                return;

            // Call method to display user details
            if (lstBoxUsers.SelectedIndex == -1)
            {
                this.CurrentUser = null;
            }
            else
            {
                this.CurrentUser = displayUserDetails(lstBoxUsers.SelectedValue.ToString());
            }

            this.CurrentUserIndex = lstBoxUsers.SelectedIndex;
            txtUserID.Enabled = false;
            txtUserID.ReadOnly = true;
        }

        private void disableListBox()
        {
            if (lstBoxUsers.Enabled)
            {
                lstBoxUsers.Enabled = false;
            }
        }

        private void enableListBox()
        {
            if (!lstBoxUsers.Enabled)
            {
                lstBoxUsers.Enabled = true;
            }
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            if (txtUserID.Enabled)
            {
                // If new user, reset all fields to blank values
                txtUserID.Text = "";
                txtFirstName.Text = "";
                txtMiddleName.Text = "";
                txtLastName.Text = "";
                txtDisplayName.Text = "";
                txtPhone.Text = "";
                txtEmail.Text = "";
                txtProfilePic.Text = "";

                chkBoxStudent.Checked = false;
                chkBoxCoach.Checked = false;
                chkBoxAdmin.Checked = false;
                chkBoxActive.Checked = false;

                chkBoxResetPassword.Checked = false;
                chkBoxResetPassword.Enabled = true;
            }
            else
            {
                // If existing user, reset all fields to previous values
                txtUserID.Text = CurrentUser.UserID;
                txtFirstName.Text = CurrentUser.FirstName;
                txtMiddleName.Text = CurrentUser.MiddleName;
                txtLastName.Text = CurrentUser.LastName;
                txtDisplayName.Text = CurrentUser.DisplayName;
                txtPhone.Text = CurrentUser.Phone;
                txtEmail.Text = CurrentUser.Email;
                txtProfilePic.Text = CurrentUser.ProfilePic;

                chkBoxStudent.Checked = CurrentUser.IsStudent;
                chkBoxCoach.Checked = CurrentUser.IsCoach;
                chkBoxAdmin.Checked = CurrentUser.IsAdmin;
                chkBoxActive.Checked = CurrentUser.IsActive;
                chkBoxResetPassword.Checked = CurrentUser.ResetPassword;
            }

            enableListBox();
        }

        private void addNewUser(User newUser)
        {
            // Always set the "reset password" field to TRUE for new users
            newUser.ResetPassword = true;

            // Add new user to the database and save changes
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Run query to get user data
                    context.Users.Add(newUser);
                    context.SaveChanges();

                    // Update text box and check box settings now that save is complete
                    txtUserID.Enabled = false;
                    txtUserID.ReadOnly = true;

                    chkBoxResetPassword.Enabled = true;

                    // Update current user property for form
                    this.CurrentUser = newUser;

                    // Re-enable list box
                    enableListBox();

                    // Refresh User list
                    updateUserList();

                    // Select last item in user list
                    lstBoxUsers.SelectedIndex = lstBoxUsers.Items.Count - 1;

                    // Display success message
                    MessageBox.Show("New user added successfully!", "User Added");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                txtUserID.Enabled = true;
            }


        }

        private void updateExistingUser(User currentUser)
        {
            // Find existing user in the database and update record
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Run query to find existing user
                    var userQuery = from existingUser in context.Users
                                    where existingUser.UserID == currentUser.UserID
                                    select existingUser;

                    User foundUser = userQuery.FirstOrDefault();

                    // Update database records
                    foundUser.FirstName = currentUser.FirstName;
                    foundUser.MiddleName = currentUser.MiddleName;
                    foundUser.LastName = currentUser.LastName;
                    foundUser.DisplayName = currentUser.DisplayName;
                    foundUser.Phone = currentUser.Phone;
                    foundUser.Email = currentUser.Email;
                    foundUser.ProfilePic = currentUser.ProfilePic;

                    foundUser.IsStudent = currentUser.IsStudent;
                    foundUser.IsCoach = currentUser.IsCoach;
                    foundUser.IsAdmin = currentUser.IsAdmin;
                    foundUser.IsActive = currentUser.IsActive;
                    foundUser.ResetPassword = currentUser.ResetPassword;

                    foundUser.ActiveCoachSince = currentUser.ActiveCoachSince;

                    // If changing from inactive to active, set new "Active Since" date
                    if (!foundUser.IsActive && currentUser.IsActive && currentUser.IsCoach)
                    {
                        foundUser.ActiveCoachSince = DateTime.Now;
                    }

                    // Save updates to database
                    context.SaveChanges();
                    this.CurrentUser = foundUser;
                    MessageBox.Show("Save completed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtUserID.Enabled = true;
            txtUserID.ReadOnly = false;

            btnRevert.PerformClick();

            chkBoxResetPassword.Checked = true;
            chkBoxResetPassword.Enabled = false;
        }
    }
}
