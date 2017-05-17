//-----------------------------------------------------------------------
// <copyright file="CoachViewForm.cs" company="PABT,Inc">
//     Copyright (c) Pabt, Inc. All rights reserved
// </copyright>
//-----------------------------------------------------------------------

namespace CoachConnect
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// Form for the Coach's view. Here the coach can see current sessions,
    /// change availability, or edit their profile.
    /// </summary>
    public partial class FrmCoachView : Form
    {
        /// <summary>
        /// Flag to validate if the user is in edit mode
        /// </summary>
        private bool editMode = false;

        /// <summary>
        /// Instantiate object to allow for proper validation of text boxes
        /// </summary>
        private Validation validator = new Validation();

        /// <summary>
        /// Create coach object to use to populate the forms later
        /// </summary>
        private User coach;

        /// <summary>
        /// Initializes a new instance of the <see cref="FrmCoachView"/> class
        /// </summary>
        public FrmCoachView()
        {
            this.InitializeComponent();
            this.coach = new User();
            this.coach = this.GetCoach();
            this.Text = this.coach.FirstName + " " + this.coach.LastName + " - " + this.coach.UserID;
            this.pbProfile.ImageLocation = this.coach.ProfilePic;
            this.LoadEditProfile(this.coach);
            this.lblCoachName.Text = this.coach.DisplayName;
            this.lblCoachUser.Text = this.coach.UserID;
            this.lblAvailCoachName.Text = this.coach.DisplayName;
            this.lblAvailCoachUsername.Text = this.coach.UserID;
            this.pbAvailProfilePic.ImageLocation = this.coach.ProfilePic;
            this.GetSessionData();
            this.LoadAvailability();
        }

        /// <summary>
        /// Logs user out instead of closing application
        /// </summary>
        /// <param name="e"> event on close</param>
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Program.LoginForm.Logout();
        }

        /// <summary>
        /// Edit the profile Pic
        /// </summary>
        /// <param name="sender">object sent</param>
        /// <param name="e">event on click</param>
        private void Button1_Click(object sender, EventArgs e)
        {
            this.EditModePrep();
            this.grpProfilePic.Enabled = true;
            this.btnEditPic.Hide();
            this.btnPreview.Show();
            this.btnPicSubmit.Show();
            this.btnCancel.Show();
            foreach (Control c in this.grpProfilePic.Controls)
            {
                c.Enabled = true;
            }

            this.txtPicURL.SelectionStart = 0;
            this.txtPicURL.Text = "URL link";
            this.txtPicURL.ForeColor = Color.Gray;
            this.txtPicURL.SelectionLength = this.txtPicURL.Text.Length;
            this.txtPicURL.Focus();
            this.AcceptButton = this.btnPreview;
        }

        /// <summary>
        /// Cancel Profile Pic update
        /// </summary>
        /// <param name="sender">object sent</param>
        /// <param name="e">event on click</param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.grpProfilePic.Enabled = false;
            this.EditModePrep();
            this.LoadEditProfile(this.coach);
        }

        /// <summary>
        /// Preview new Profile Pic
        /// </summary>
        /// <param name="sender">object sent</param>
        /// <param name="e">event on click</param>
        private void BtnPreview_Click(object sender, EventArgs e)
        {
            this.pbEditPic.ImageLocation = this.txtPicURL.Text;
            this.btnPreview.Hide();
            this.btnPicSubmit.Show();
        }

        /// <summary>
        /// commit to new profile pic
        /// </summary>
        /// <param name="sender">object sent</param>
        /// <param name="e">event on click</param>
        private void BtnPicSubmit_Click(object sender, EventArgs e)
        {
            using (var context = new db_sft_2172Entities())
            {
                var result = context.Users.SingleOrDefault(b => b.UserID == Program.CurrentUser);
                result.ProfilePic = this.txtPicURL.Text;
                context.SaveChanges();
            }

            this.grpProfilePic.Enabled = false;
            this.EditModePrep();
            this.LoadEditProfile(this.coach);
        }

        /// <summary>
        /// Edit Coach Info
        /// </summary>
        /// <param name="sender">object sent</param>
        /// <param name="e">event on click</param>
        private void BtnEditInfo_Click(object sender, EventArgs e)
        {
            this.EditModePrep();
            this.grpPersonalInfo.Enabled = true;
            foreach (Control c in this.grpPersonalInfo.Controls)
            {
                c.Enabled = true;
            }

            this.btnEditInfo.Visible = false;
            this.btnSubmitInfo.Visible = true;
            this.btnCancelInfo.Visible = true;
            this.AcceptButton = this.btnSubmitInfo;
        }

        /// <summary>
        /// Logout current user
        /// </summary>
        /// <param name="sender">object sent</param>
        /// <param name="e">event on click</param>
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Program.LoginForm.Logout();

            // Close this window
            this.Close();
        }

        /// <summary>
        /// Cancel any changes of user profile
        /// </summary>
        /// <param name="sender">object sent</param>
        /// <param name="e">event on click</param>
        private void BtnCancelInfo_Click(object sender, EventArgs e)
        {
            this.EditModePrep();
            this.grpPersonalInfo.Enabled = true;
            this.LoadEditProfile(this.coach);
        }

        /// <summary>
        /// Submit updated user info
        /// </summary>
        /// <param name="sender">object sent</param>
        /// <param name="e">event on click</param>
        private void BtnSubmitInfo_Click(object sender, EventArgs e)
        {
            if (!this.lblFNameError.Visible && !this.lblMiddleError.Visible && !this.lblPhoneError.Visible && !this.lblLastName.Visible && !this.lblEmailError.Visible)
            {
                this.UpdatePersonalInfo();
                this.btnCancelInfo.PerformClick();
                this.editMode = false;
                User coach = new User();
                coach = this.GetCoach();
                this.Text = coach.FirstName + " " + coach.LastName + " - " + coach.UserID;
            }
        }

        /// <summary>
        /// Don't allow any tabs to be selected while in Edit mode
        /// </summary>
        /// <param name="sender">object sent</param>
        /// <param name="e">event on click</param>
        private void TbForm_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            if (this.editMode)
            {
                MessageBox.Show("Please submit your edit or cancel before moving to other Tab");
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Validate textbox after losing focus
        /// </summary>
        /// <param name="sender">object sent</param>
        /// <param name="e">event on click</param>
        private void TxtFName_Leave(object sender, EventArgs e)
        {
            this.lblFNameError.Visible = !this.validator.ValidateTextBox(this.txtFName.Text);
            if (this.lblFNameError.Visible)
            {
                this.txtFName.Focus();
            }
            else
            {
                this.txtFName.Text = this.validator.CleanString(this.txtFName.Text);
            }
        }

        /// <summary>
        /// Validate textbox after losing focus
        /// </summary>
        /// <param name="sender">object sent</param>
        /// <param name="e">event on click</param>
        private void TxtMiddle_Leave(object sender, EventArgs e)
        {
            this.lblMiddleError.Visible = !this.validator.ValidateTextBox(this.txtMiddle.Text);
            if (this.lblMiddleError.Visible)
            {
                this.txtMiddle.Focus();
            }
            else
            {
                this.txtMiddle.Text = this.validator.CleanString(this.txtMiddle.Text);
            }
        }

        /// <summary>
        /// Validate textbox after losing focus
        /// </summary>
        /// <param name="sender">object sent</param>
        /// <param name="e">event on click</param>
        private void TxtLName_Leave(object sender, EventArgs e)
        {
            this.lblLastName.Visible = !this.validator.ValidateTextBox(this.txtLName.Text);
            if (this.lblLastName.Visible)
            {
                this.txtLName.Focus();
            }
            else
            {
                this.txtLName.Text = this.validator.CleanString(this.txtLName.Text);
            }
        }

        /// <summary>
        /// Validate textbox after losing focus
        /// </summary>
        /// <param name="sender">object sent</param>
        /// <param name="e">event on click</param>
        private void TxtPhone_Leave(object sender, EventArgs e)
        {
            string sanitizedNum = this.validator.CleanNumber(this.txtPhone.Text);
            this.lblPhoneError.Visible = !this.validator.ValidatePhone(sanitizedNum);
            if (!this.validator.ValidatePhone(sanitizedNum))
            {
                this.txtPhone.Focus();
            }
            else
            {
                this.txtPhone.Text = this.validator.FormatPhone(sanitizedNum);
            }
        }

        /// <summary>
        /// Validate textbox after losing focus
        /// </summary>
        /// <param name="sender">object sent</param>
        /// <param name="e">event on click</param>
        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            this.lblEmailError.Visible = !this.validator.ValidateEmail(this.txtEmail.Text);
            if (!this.validator.ValidateEmail(this.txtEmail.Text))
            {
                this.txtEmail.Focus();
            }
        }

        /// <summary>
        /// update the database after all of the validation. 
        /// also remove any weird formatting.
        /// </summary>
        private void UpdatePersonalInfo()
        {
            string phoneNoFormat = string.Empty;
            foreach (char num in this.txtPhone.Text)
            {
                if (char.IsDigit(num))
                {
                    phoneNoFormat += num;
                }
            }

            using (var context = new db_sft_2172Entities())
            {
                var result = context.Users.SingleOrDefault(b => b.UserID == Program.CurrentUser);
                result.FirstName = this.txtFName.Text;
                result.LastName = this.txtLName.Text;
                result.MiddleName = this.txtMiddle.Text;
                result.Phone = phoneNoFormat;
                result.Email = this.txtEmail.Text;
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Method to load all coach information on the form
        /// this includes all the tabs
        /// </summary>
        /// <param name="coach"> Load the logged in coach's profile</param>
        private void LoadEditProfile(User coach)
        {
            // Edit profile area
            coach = this.GetCoach();
            this.txtEmail.Text = coach.Email;
            this.txtFName.Text = coach.FirstName;
            this.txtLName.Text = coach.LastName;
            this.txtMiddle.Text = coach.MiddleName;
            this.txtPhone.Text = this.validator.FormatPhone(coach.Phone);
            this.pbEditPic.ImageLocation = coach.ProfilePic;
            this.pbAvailProfilePic.ImageLocation = coach.ProfilePic;
            this.pbProfile.ImageLocation = coach.ProfilePic;
            int endDate = coach.ActiveCoachSince.ToString().IndexOf(" ");
            this.lblMemberSince.Text = "Active Coach Since: " + coach.ActiveCoachSince.ToString().Substring(0, endDate);
            this.txtPicURL.Clear();
            this.btnPreview.Hide();
            this.btnPicSubmit.Hide();
            this.btnCancel.Hide();
            this.DisableAreas();
            this.EnableEditBtns();
        }

        /// <summary>
        /// Get the currently logged in coach's information
        /// </summary>
        /// <returns>Coach is returned</returns>
        private User GetCoach()
        {
            using (var context = new db_sft_2172Entities())
            {
                var coach = from c in context.Users
                            where c.UserID.Equals(Program.CurrentUser)
                            select c;
                return coach.First<User>();
            }
        }

        /// <summary>
        /// Disable all areas except the one being edited
        /// </summary>
        private void DisableAreas()
        {
            foreach (Control c in this.grpPersonalInfo.Controls)
            {
                c.Enabled = false;
            }

            foreach (Control c in this.grpPass.Controls)
            {
                c.Enabled = false;
            }

            foreach (Control c in this.grpProfilePic.Controls)
            {
                c.Enabled = false;
            }
        }

        /// <summary>
        /// Enable the edit buttons
        /// </summary>
        private void EnableEditBtns()
        {
            this.btnEditInfo.Visible = true;
            this.btnEditInfo.Enabled = true;
            this.btnEditPic.Visible = true;
            this.btnEditPic.Enabled = true;
            this.btnCancelInfo.Visible = false;
            this.btnSubmitInfo.Visible = false;
            this.btnPass.Enabled = true;
        }

        /// <summary>
        /// prep the group boxes for editing and non editing
        /// </summary>
        private void EditModePrep()
        {
            this.grpPass.Enabled = !this.grpPass.Enabled;
            this.grpPersonalInfo.Enabled = !this.grpPersonalInfo.Enabled;
            this.grpProfilePic.Enabled = !this.grpProfilePic.Enabled;
            this.editMode = !this.editMode;
        }

        /// <summary>
        /// button that will open secondary form to edit password
        /// </summary>
        /// <param name="sender">object sent</param>
        /// <param name="e">event on click</param>
        private void BtnPass_Click(object sender, EventArgs e)
        {
            ResetStudentPassword frm = new ResetStudentPassword();
            frm.ShowDialog();
        }

        /// <summary>
        /// button to exit application
        /// </summary>
        /// <param name="sender">object sent</param>
        /// <param name="e">event on click</param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        /// <summary>
        /// Allows the editing of the availability checkboxes.
        /// </summary>
        /// <param name="sender">object sent</param>
        /// <param name="e">event on click</param>
        private void BtnEditAvailability_Click(object sender, EventArgs e)
        {
            this.FlipGrpBoxes();
        }

        /// <summary>
        /// Enable/disable on the fly. one method will turn on /off
        /// </summary>
        private void FlipGrpBoxes()
        {
            this.grpMon.Enabled = !this.grpMon.Enabled;
            this.grpTues.Enabled = !this.grpTues.Enabled;
            this.grpWed.Enabled = !this.grpWed.Enabled;
            this.grpThu.Enabled = !this.grpThu.Enabled;
            this.grpFri.Enabled = !this.grpFri.Enabled;
            this.grpSat.Enabled = !this.grpSat.Enabled;
            this.grpSun.Enabled = !this.grpSun.Enabled;
            this.btnCancelAvailability.Visible = !this.btnCancelAvailability.Visible;
            this.btnSubmitAvailability.Visible = !this.btnSubmitAvailability.Visible;
            this.btnEditAvailability.Visible = !this.btnSubmitAvailability.Visible;
            this.btnCheckAll.Visible = !this.btnCheckAll.Visible;
            this.btnCheckNone.Visible = !this.btnCheckNone.Visible;
            this.LoadAvailability();
        }

        /// <summary>
        /// Cancel any commits
        /// </summary>
        /// <param name="sender">object sent</param>
        /// <param name="e">event on click</param>
        private void BtnCancelAvailability_Click(object sender, EventArgs e)
        {
            this.ClearAvailbleErrors();
            this.FlipGrpBoxes();
        }

        /// <summary>
        /// commit to availability changes
        /// </summary>
        /// <param name="sender">object sent</param>
        /// <param name="e">event on click</param>
        private void BtnSubmitAvailability_Click(object sender, EventArgs e)
        {
            var newEntry = new UserAvailability();
            var removeOld = new db_sft_2172Entities();
            if (this.CheckSessionAvailbility())
            {
                removeOld.UserAvailabilities.RemoveRange(
                    removeOld.UserAvailabilities.Where(u => u.UserID == Program.CurrentUser));
                removeOld.SaveChanges();
                foreach (Control c in this.grpAvailability.Controls)
                {
                    foreach (Control ca in c.Controls)
                    {
                        if (ca is CheckBox)
                        {
                            CheckBox chkbox = (CheckBox)ca;

                            if (chkbox.Checked)
                            {
                                newEntry.UserID = Program.CurrentUser;
                                newEntry.DayID = chkbox.Name.Substring(0, 3);
                                newEntry.TimePeriodID = chkbox.Name.Substring(3, 3);

                                using (var context = new db_sft_2172Entities())
                                {
                                    context.UserAvailabilities.Add(newEntry);
                                    context.SaveChanges();
                                }
                            }
                        }
                    }
                }
                
                this.FlipGrpBoxes();
            }
        }

        /// <summary>
        /// load the current availability of the coach that is logged in.
        /// </summary>
        private void LoadAvailability()
        {
            List<CoachConnect.Availability> coachAvailability = new List<CoachConnect.Availability>();
            using (var context = new db_sft_2172Entities())
            {
                var result = from Availability in context.Availabilities
                             where Availability.UserID.Equals(Program.CurrentUser)
                             select Availability;
                coachAvailability = result.ToList();

                this.ClearCheckboxes();
                
                    foreach (Control c in this.grpAvailability.Controls)
                    {
                        foreach (Control ca in c.Controls)
                        {
                            foreach (Availability a in coachAvailability)
                            {
                                if (ca is CheckBox)
                            {
                                CheckBox chk = (CheckBox)ca;
                                if (chk.Name == (a.DayID + a.TimePeriodID))
                                {
                                    chk.Checked = true;
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// clear all check boxes (Initialization and prep)
        /// </summary>
        private void ClearCheckboxes()
        {
            this.ClearAvailbleErrors();
            foreach (Control c in this.grpAvailability.Controls)
            {
                foreach (Control ca in c.Controls)
                {
                    if (ca is CheckBox)
                    {
                        CheckBox chk = (CheckBox)ca;
                        chk.Checked = false;
                    }
                }
            }
        }

        /// <summary>
        /// Allows simple check all
        /// </summary>
        private void CheckCheckboxes()
        {
            this.ClearAvailbleErrors();
            foreach (Control c in this.grpAvailability.Controls)
            {
                foreach (Control ca in c.Controls)
                {
                    if (ca is CheckBox)
                    {
                        CheckBox chk = (CheckBox)ca;
                        chk.Checked = true;
                    }
                }
            }
        }

        /// <summary>
        /// button to call the check checkboxes method
        /// </summary>
        /// <param name="sender">object sent</param>
        /// <param name="e">event on click</param>
        private void BtnCheckAll_Click(object sender, EventArgs e)
        {
            this.CheckCheckboxes();
        }

        /// <summary>
        /// button to call method to clear checkboxes
        /// </summary>
        /// <param name="sender">object sent</param>
        /// <param name="e">event on click</param>
        private void BtnCheckNone_Click(object sender, EventArgs e)
        {
            this.ClearCheckboxes();
        }

        /// <summary>
        /// get the currently logged in coach's session list
        /// </summary>
        private void GetSessionData()
        {
            // Generate query to pull all sessions from the database
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    var sessionQuery = from sessions in context.ViewSessions
                                       where sessions.UserID.Equals(Program.CurrentUser)
                                       select sessions;

                    this.dgvAvailable.DataSource = sessionQuery.ToList();

                    // Hide SessionID...field is needed for EditSession form, but user doesn't need to see it
                    this.dgvAvailable.Columns["SessionID"].Visible = false;
                    this.dgvAvailable.Columns["UserID"].Visible = false;
                    this.dgvAvailable.Columns["Coach"].Visible = false;
                    this.dgvAvailable.Columns["active"].Visible = false;
                    this.dgvAvailable.Columns["CourseName"].DisplayIndex = 1;
                    this.dgvAvailable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    this.dgvAvailable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Checks to see if they coach has an active session before adjusting the availability
        /// </summary>
        /// <returns>Returns boolean value if valid available edit</returns>
        private bool CheckSessionAvailbility()
        {
            bool validChange = true;
            List<CoachConnect.Session> sessquery = new List<CoachConnect.Session>();
            using (var context = new db_sft_2172Entities())
            {
                var coachSession = from sessions in context.Sessions
                    where sessions.CoachID.Equals(Program.CurrentUser)
                    select sessions;
                sessquery = coachSession.ToList();

                foreach (Control c in this.grpAvailability.Controls)
                {
                    foreach (Control ca in c.Controls)
                    {
                        foreach (Session a in sessquery)
                        {
                            if (ca is CheckBox)
                            {
                                CheckBox chk = (CheckBox)ca;
                                if (!chk.Checked && a.DayID + a.TimePeriodID == chk.Name && a.Active)
                                {
                                    chk.Text = "X";
                                    chk.ForeColor = Color.White;
                                    chk.BackColor = Color.Red;
                                    validChange = false;
                                    chk.Checked = true;
                                }
                            }
                        }
                    }
                }

                if (!validChange)
                {
                    MessageBox.Show("You are assigned to existing Session in red. Can't change availability!");
                }

                return validChange;
            }
        }

        /// <summary>
        /// Clean up the GUI
        /// </summary>
        private void ClearAvailbleErrors()
        {
            {
                foreach (Control c in this.grpAvailability.Controls)
                {
                    foreach (Control ca in c.Controls)
                    {
                        if (ca is CheckBox)
                        {
                            CheckBox chk = (CheckBox)ca;
                            chk.BackColor = SystemColors.Control;
                            chk.Text = string.Empty;
                        }
                    }
                }
            }
        }

       /// <summary>
       /// Method called when some one clicks on cell in the data grid view
       /// </summary>
       /// <param name="sender">Double clicked cell</param>
       /// <param name="e">Data Grid View is the argument</param>
        private void DgvAvailable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int sessionIDfromGrid = (int)dgvAvailable[4, e.RowIndex].Value;
            List<CoachConnect.ViewSessionRoster> sessRoster = new List<CoachConnect.ViewSessionRoster>();
            ViewSessionRoster oneperson = new ViewSessionRoster();
            
            string message = string.Empty;
            string header = "The following students are \nscheduled for this Session:\n";

            using (var context = new db_sft_2172Entities())
            {
                var rosterList = from people in context.ViewSessionRosters
                    where people.SessionID.Equals(sessionIDfromGrid)
                    select people;
                
                sessRoster = rosterList.ToList();
                
                foreach (ViewSessionRoster vsr in sessRoster)
                {
                    message += "\n" + vsr.Name;
                }

                if (message == string.Empty)
                {
                    MessageBox.Show("Sorry, no one has signed up yet");
                }
                else
                {
                    MessageBox.Show(header + message);
                }
            }
        }
    }
}