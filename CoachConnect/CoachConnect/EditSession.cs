// <copyright file="EditSession.cs" company="PABT at NWTC">
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
    /// EditSession: A form which allows users to create and edit session data, then save the data to the database.
    /// </summary>
    public partial class EditSession : Form
    {
        /// <summary>
        /// Validator: An object to handle data form validation
        /// </summary>
        private readonly Validation validator = new Validation();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditSession" /> class with no inputs.
        /// The no-input version is used to create a new session
        /// </summary>
        public EditSession()
        {
            this.InitializeComponent();

            // Set session ID to a negative value (indicates a new session)
            this.SessionId = -1;

            // Update header text to show "Create" instead of "Edit"
            this.lblEditSessionHeader.Text = "Create Session";

            // Call method to populate combo boxes
            this.PopulateComboBoxes();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditSession" /> class.
        /// A sessionID is provided to show which session should be updated
        /// </summary>
        /// <param name="sessionID">The ID for the session to be updated</param>
        public EditSession(int sessionID)
        {
            this.SessionId = sessionID;

            this.InitializeComponent();

            // Call method to populate combo boxes
            this.PopulateComboBoxes();

            // Call method to pull current session data from the database
            this.LoadSessionData();

            // Call method to populate session roster
            this.PopulateRoster();
        }

        /// <summary>
        /// Gets or sets the current session to be edited
        /// </summary>
        private int SessionId { get; set; }

        /// <summary>
        /// Gets or sets an object to hold the current session data
        /// </summary>
        private Session CurrentSession { get; set; }

        /// <summary>
        /// Gets or sets a list object that stores the current session roster
        /// </summary>
        private List<ViewSessionRoster> CurrentRoster { get; set; }

        /// <summary>
        /// Event handler to save session data and close form when the Save button is clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnSaveClick(object sender, EventArgs e)
        {
            this.CurrentSession = new Session();

            // Get data from form and insert into current Session object
            this.CurrentSession.CourseID = this.cbxCourse.SelectedValue.ToString();
            this.CurrentSession.RoomID = this.cbxRoom.SelectedValue.ToString();
            this.CurrentSession.DayID = this.cbxDay.SelectedValue.ToString();
            this.CurrentSession.TimePeriodID = this.cbxTime.SelectedValue.ToString();
            this.CurrentSession.CoachID = this.cbxCoach.SelectedValue.ToString();

            if (cbxActive.SelectedIndex == 0)
            {
                this.CurrentSession.Active = true;
            }
            else
            {
                this.CurrentSession.Active = false;
            }

            // Verify that the selected coach has availablility on the desired day/time
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    var availableCoachSessions = from coachAvailability in context.UserAvailabilities
                                                 where
                                                     coachAvailability.UserID.Equals(this.CurrentSession.CoachID)
                                                     && coachAvailability.DayID.Equals(this.CurrentSession.DayID)
                                                     && coachAvailability.TimePeriodID.Equals(
                                                         this.CurrentSession.TimePeriodID)
                                                 select coachAvailability;

                    if (availableCoachSessions.Any())
                    {
                        // Call appropriate method to add or update session data
                        if (this.SessionId == -1)
                        {
                            this.AddNewSession();
                        }
                        else
                        {
                            this.UpdateSession();
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "Sorry, the desired coach is not available for the selected day/time.\nPlease select another combination!");

                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Close form once finished
            this.Close();
        }

        /// <summary>
        /// Event handler to close the current form when the Cancel button is clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Method to query the database and populate the combo boxes with valid items
        /// </summary>
        private void PopulateComboBoxes()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Run queries to get combo box data
                    var courseQuery = from courses in context.Courses
                                      where courses.IsActive
                                      orderby courses.CourseID
                                      select courses;

                    var roomQuery = from rooms in context.Rooms
                                    orderby rooms.RoomID
                                    select rooms;

                    var dayQuery = from days in context.Days
                                   orderby days.SortOrder
                                   select days;

                    var timeQuery = from times in context.TimePeriods
                                    orderby times.SortOrder
                                    select times;

                    var coachQuery = from coaches in context.Users
                                     where coaches.IsCoach
                                     orderby coaches.DisplayName
                                     select coaches;

                    // Convert query results to lists
                    List<Course> courseList = courseQuery.ToList();
                    List<Room> roomList = roomQuery.ToList();
                    List<Day> dayList = dayQuery.ToList();
                    List<TimePeriod> timeList = timeQuery.ToList();
                    List<User> coachList = coachQuery.ToList();

                    // Set combo box data sources and update data member settings
                    this.cbxCourse.DataSource = courseList;
                    this.cbxCourse.ValueMember = "CourseID";
                    this.cbxCourse.DisplayMember = "CourseID";

                    this.cbxRoom.DataSource = roomList;
                    this.cbxRoom.ValueMember = "RoomID";
                    this.cbxRoom.DisplayMember = "RoomID";

                    this.cbxDay.DataSource = dayList;
                    this.cbxDay.ValueMember = "DayID";
                    this.cbxDay.DisplayMember = "DayName";

                    this.cbxTime.DataSource = timeList;
                    this.cbxTime.ValueMember = "TimePeriodID";
                    this.cbxTime.DisplayMember = "TimePeriodName";

                    this.cbxCoach.DataSource = coachList;
                    this.cbxCoach.ValueMember = "UserID";
                    this.cbxCoach.DisplayMember = "DisplayName";

                    this.cbxCourse.SelectedIndex = -1;
                    this.cbxRoom.SelectedIndex = -1;
                    this.cbxDay.SelectedIndex = -1;
                    this.cbxTime.SelectedIndex = -1;
                    this.cbxCoach.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Method to query the database and display data for the desired session
        /// </summary>
        private void LoadSessionData()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    var sessionQuery = from session in context.Sessions
                                       where session.SessionID.Equals(this.SessionId)
                                       select session;

                    if (sessionQuery.Any())
                    {
                        this.CurrentSession = sessionQuery.FirstOrDefault();
                    }
                    else
                    {
                        MessageBox.Show("Sorry, could not load session data from the database.  Please try again later.");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Populate combo boxes with current session data
            this.cbxCoach.SelectedValue = this.CurrentSession.CoachID;
            this.cbxCourse.SelectedValue = this.CurrentSession.CourseID;
            this.cbxDay.SelectedValue = this.CurrentSession.DayID;
            this.cbxRoom.SelectedValue = this.CurrentSession.RoomID;
            this.cbxTime.SelectedValue = this.CurrentSession.TimePeriodID;

            if (this.CurrentSession.Active)
            {
                this.cbxActive.SelectedIndex = 0;
            }
            else
            {
                this.cbxActive.SelectedIndex = 1;
            }
        }

        /// <summary>
        /// A method to update the student roster data grid
        /// </summary>
        private void PopulateRoster()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    var rosterQuery = from studentRoster in context.ViewSessionRosters
                                      where studentRoster.SessionID.Equals(this.CurrentSession.SessionID)
                                      select studentRoster;

                    this.CurrentRoster = rosterQuery.ToList();

                    this.dataGridViewRoster.DataSource = this.CurrentRoster;

                    this.dataGridViewRoster.Columns["SessionID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Method to create a new session in the database
        /// </summary>
        private void AddNewSession()
        {
            // Add new user to the database and save changes
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Run query and save new user data to database
                    context.Sessions.Add(this.CurrentSession);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Save completed...new session created successfully!");
        }

        /// <summary>
        /// Method to update an existing session in the database
        /// </summary>
        private void UpdateSession()
        {
            // Add new user to the database and save changes
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Run query and pull matching session from database
                    var sessionQuery = from session in context.Sessions
                                       where session.SessionID.Equals(this.SessionId)
                                       select session;

                    if (sessionQuery.Any())
                    {
                        Session foundSession = sessionQuery.FirstOrDefault();

                        // Update database records
                        foundSession.CourseID = this.CurrentSession.CourseID;
                        foundSession.RoomID = this.CurrentSession.RoomID;
                        foundSession.DayID = this.CurrentSession.DayID;
                        foundSession.TimePeriodID = this.CurrentSession.TimePeriodID;
                        foundSession.CoachID = this.CurrentSession.CoachID;
                        foundSession.Active = this.CurrentSession.Active;

                        // Save changes to database
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Sorry, a matching session was not found in the database.\nPlease try again or contact an administrator for assistance.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Save completed...Session updated successfully!");
        }

        /// <summary>
        /// Event handler to validate Course combo box when it loses focus
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CbxCourse_Leave(object sender, EventArgs e)
        {
            this.lblInvalidCourse.Visible = !this.validator.ValidateComboBox(cbxCourse.SelectedIndex);

            if (this.lblInvalidCourse.Visible)
            {
                this.cbxCourse.Focus();
            }
        }

        /// <summary>
        /// Event handler to validate Room combo box when it loses focus
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CbxRoom_Leave(object sender, EventArgs e)
        {
            lblInvalidRoom.Visible = !this.validator.ValidateComboBox(this.cbxRoom.SelectedIndex);

            if (this.lblInvalidRoom.Visible)
            {
                this.cbxRoom.Focus();
            }
        }

        /// <summary>
        /// Event handler to validate Day combo box when it loses focus
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CbxDay_Leave(object sender, EventArgs e)
        {
            lblInvalidDay.Visible = !this.validator.ValidateComboBox(this.cbxDay.SelectedIndex);

            if (this.lblInvalidDay.Visible)
            {
                this.cbxDay.Focus();
            }
        }

        /// <summary>
        /// Event handler to validate Time combo box when it loses focus
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CbxTime_Leave(object sender, EventArgs e)
        {
            this.lblInvalidTime.Visible = !this.validator.ValidateComboBox(this.cbxTime.SelectedIndex);

            if (this.lblInvalidTime.Visible)
            {
                this.cbxTime.Focus();
            }
        }

        /// <summary>
        /// Event handler to validate Coach combo box when it loses focus
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CbxCoach_Leave(object sender, EventArgs e)
        {
            this.lblInvalidCoach.Visible = !this.validator.ValidateComboBox(this.cbxCoach.SelectedIndex);

            if (this.lblInvalidCoach.Visible)
            {
                this.cbxCoach.Focus();
            }
        }

        /// <summary>
        /// Event handler to validate Active combo box when it loses focus
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CbxActive_Leave(object sender, EventArgs e)
        {
            lblInvalidActive.Visible = !this.validator.ValidateComboBox(cbxActive.SelectedIndex);

            if (lblInvalidActive.Visible)
            {
                cbxActive.Focus();
            }
        }

        /// <summary>
        /// Event handler to open the AddSessionStudent form when the Add to Roster button is clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnAddToRoster_Click(object sender, EventArgs e)
        {
            AddSessionStudent addStudentForm = new AddSessionStudent(this.CurrentSession);
            addStudentForm.ShowDialog();
            this.PopulateRoster();
        }

        /// <summary>
        /// Event handler to remove the selected student from the roster when the Remove button is clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            string selectedStudentId = this.dataGridViewRoster.SelectedRows[0].Cells["UserID"].Value.ToString();

            // Confirm action
            DialogResult removeConfirmation =
                MessageBox.Show("Are you sure you want to remove this student from the session?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);

            // If user did not click yes, leave the method without doing anything.
            if (!removeConfirmation.Equals(DialogResult.Yes))
            {
                return;
            }

            try
            {
                // Remove the selected record from the database
                SessionRoster selectedStudentEntry = new SessionRoster
                {
                    SessionID = this.CurrentSession.SessionID,
                    UserID = selectedStudentId,
                    RoleID = "STUD"
                };

                using (var context = new db_sft_2172Entities())
                {
                    context.SessionRosters.Attach(selectedStudentEntry);
                    context.SessionRosters.Remove(selectedStudentEntry);
                    context.SaveChanges();
                }

                // Display a confirmation message
                MessageBox.Show("Student removed sucessfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Update the data grid view
            this.PopulateRoster();
        }
    }
}
