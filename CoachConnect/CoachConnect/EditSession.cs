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
    /// <summary>
    /// EditSession: A form which allows users to create and edit session data, then save the data to the database.
    /// </summary>
    public partial class EditSession : Form
    {
        /// <summary>
        /// SessionID: Store the current session to be edited
        /// </summary>
        int SessionID { get; set; }

        /// <summary>
        /// CurrentSession: An object to hold the current session data
        /// </summary>
        Session CurrentSession { get; set; }

        /// <summary>
        /// Validator: An object to handle data form validation
        /// </summary>
        Validation Validator = new Validation();

        List<ViewSessionRoster> CurrentRoster { get; set; }


        /// <summary>
        /// Constructor: create a new EditSession form and populate the combo boxes
        /// </summary>
        public EditSession()
        {
            InitializeComponent();

            // Set session ID to a negative value (indicates a new session)
            SessionID = -1;

            // Update header text to show "Create" instead of "Edit"
            lblEditSessionHeader.Text = "Create Session";

            // Call method to populate combo boxes
            populateComboBoxes();
        }

        /// <summary>
        /// Constructor: Create a new EditSession form, populate combo boxes and load data for the desired session
        /// </summary>
        /// <param name="sessionID"></param>
        public EditSession(int sessionID)
        {
            SessionID = sessionID;

            InitializeComponent();

            // Call method to populate combo boxes
            populateComboBoxes();

            // Call method to pull current session data from the database
            loadSessionData();

            // Call method to populate session roster
            populateRoster();
        }

        /// <summary>
        /// Event handler to save session data and close form when the Save button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            CurrentSession = new Session();

            // Get data from form and insert into current Session object
            CurrentSession.CourseID = cbxCourse.SelectedValue.ToString();
            CurrentSession.RoomID = cbxRoom.SelectedValue.ToString();
            CurrentSession.DayID = cbxDay.SelectedValue.ToString();
            CurrentSession.TimePeriodID = cbxTime.SelectedValue.ToString();
            CurrentSession.CoachID = cbxCoach.SelectedValue.ToString();

            if (cbxActive.SelectedIndex == 0)
            {
                CurrentSession.Active = true;
            }
            else
            {
                CurrentSession.Active = false;
            }

            // Call appropriate method to add or update session data
            if (SessionID == -1)
            {
                addNewSession();
            }
            else
            {
                updateSession();
            }

            /// Close form once finished
            Close();
        }

        /// <summary>
        /// Event handler to close the current form when the Cancel button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Method to query the database and populate the combo boxes with valid items
        /// </summary>
        private void populateComboBoxes()
        {
            List<Course> courseList = new List<Course>();
            List<Room> roomList   = new List<Room>();
            List<Day> dayList    = new List<Day>();
            List<TimePeriod> timeList = new List<TimePeriod>();
            List<User> coachList  = new List<User>();

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
                    courseList = courseQuery.ToList();
                    roomList = roomQuery.ToList();
                    dayList = dayQuery.ToList();
                    timeList = timeQuery.ToList();
                    coachList = coachQuery.ToList();

                    // Set combo box data sources and update data member settings
                    cbxCourse.DataSource = courseList;
                    cbxCourse.ValueMember = "CourseID";
                    cbxCourse.DisplayMember = "CourseID";

                    cbxRoom.DataSource = roomList;
                    cbxRoom.ValueMember = "RoomID";
                    cbxRoom.DisplayMember = "RoomID";

                    cbxDay.DataSource = dayList;
                    cbxDay.ValueMember = "DayID";
                    cbxDay.DisplayMember = "DayName";

                    cbxTime.DataSource = timeList;
                    cbxTime.ValueMember = "TimePeriodID";
                    cbxTime.DisplayMember = "TimePeriodName";

                    cbxCoach.DataSource = coachList;
                    cbxCoach.ValueMember = "UserID";
                    cbxCoach.DisplayMember = "DisplayName";

                    cbxCourse.SelectedIndex = -1;
                    cbxRoom.SelectedIndex = -1;
                    cbxDay.SelectedIndex = -1;
                    cbxTime.SelectedIndex = -1;
                    cbxCoach.SelectedIndex = -1;
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
        private void loadSessionData()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    var sessionQuery = from session in context.Sessions
                                       where session.SessionID.Equals(this.SessionID)
                                       select session;

                    if (sessionQuery.Any())
                    {
                        CurrentSession = sessionQuery.FirstOrDefault();
                    }
                    else
                    {
                        MessageBox.Show("Sorry, could not load session data from the database.  Please try again later.");
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Populate combo boxes with current session data
            cbxCoach.SelectedValue = CurrentSession.CoachID;
            cbxCourse.SelectedValue = CurrentSession.CourseID;
            cbxDay.SelectedValue = CurrentSession.DayID;
            cbxRoom.SelectedValue = CurrentSession.RoomID;
            cbxTime.SelectedValue = CurrentSession.TimePeriodID;

            if (CurrentSession.Active)
            {
                cbxActive.SelectedIndex = 0;
            }
            else
            {
                cbxActive.SelectedIndex = 1;
            }
        }

        private void populateRoster()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    var rosterQuery = from studentRoster in context.ViewSessionRosters
                                      where studentRoster.SessionID.Equals(CurrentSession.SessionID)
                                      select studentRoster;

                    CurrentRoster = rosterQuery.ToList();

                    dataGridViewRoster.DataSource = CurrentRoster;

                    dataGridViewRoster.Columns["SessionID"].Visible = false;
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
        private void addNewSession()
        {
            // Add new user to the database and save changes
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Run query and save new user data to database
                    context.Sessions.Add(CurrentSession);
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
        private void updateSession()
        {
            // Add new user to the database and save changes
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Run query and pull matching session from database
                    var sessionQuery = from session in context.Sessions
                                       where session.SessionID.Equals(SessionID)
                                       select session;

                    Session foundSession = sessionQuery.FirstOrDefault();

                    // Update database records
                    foundSession.CourseID = CurrentSession.CourseID;
                    foundSession.RoomID = CurrentSession.RoomID;
                    foundSession.DayID = CurrentSession.DayID;
                    foundSession.TimePeriodID = CurrentSession.TimePeriodID;
                    foundSession.CoachID = CurrentSession.CoachID;
                    foundSession.Active = CurrentSession.Active;

                    // Save changes to database
                    context.SaveChanges();
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxCourse_Leave(object sender, EventArgs e)
        {
            lblInvalidCourse.Visible = !Validator.ValidateComboBox(cbxCourse.SelectedIndex);

            if (lblInvalidCourse.Visible)
            {
                cbxCourse.Focus();
            }
        }

        /// <summary>
        /// Event handler to validate Room combo box when it loses focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxRoom_Leave(object sender, EventArgs e)
        {
            lblInvalidRoom.Visible = !Validator.ValidateComboBox(cbxRoom.SelectedIndex);

            if (lblInvalidRoom.Visible)
            {
                cbxRoom.Focus();
            }
        }

        /// <summary>
        /// Event handler to validate Day combo box when it loses focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxDay_Leave(object sender, EventArgs e)
        {
            lblInvalidDay.Visible = !Validator.ValidateComboBox(cbxDay.SelectedIndex);

            if (lblInvalidDay.Visible)
            {
                cbxDay.Focus();
            }
        }

        /// <summary>
        /// Event handler to validate Time combo box when it loses focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxTime_Leave(object sender, EventArgs e)
        {
            lblInvalidTime.Visible = !Validator.ValidateComboBox(cbxTime.SelectedIndex);

            if (lblInvalidTime.Visible)
            {
                cbxTime.Focus();
            }
        }

        /// <summary>
        /// Event handler to validate Coach combo box when it loses focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxCoach_Leave(object sender, EventArgs e)
        {
            lblInvalidCoach.Visible = !Validator.ValidateComboBox(cbxCoach.SelectedIndex);

            if (lblInvalidCoach.Visible)
            {
                cbxCoach.Focus();
            }
        }

        /// <summary>
        /// Event handler to validate Active combo box when it loses focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxActive_Leave(object sender, EventArgs e)
        {
            lblInvalidActive.Visible = !Validator.ValidateComboBox(cbxActive.SelectedIndex);

            if (lblInvalidActive.Visible)
            {
                cbxActive.Focus();
            }
        }

        private void btnAddToRoster_Click(object sender, EventArgs e)
        {
            AddSessionStudent addStudentForm = new AddSessionStudent(this.CurrentSession);
            addStudentForm.ShowDialog();
            populateRoster();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string selectedStudentId = dataGridViewRoster.SelectedRows[0].Cells["UserID"].Value.ToString();

            // Confirm action
            DialogResult removeConfirmation =
                MessageBox.Show("Are you sure you want to remove this student from the session?", "Confirm Removal",
                    MessageBoxButtons.YesNo,MessageBoxIcon.None, MessageBoxDefaultButton.Button1);

            // If user did not click yes, leave the method without doing anything.
            if (!removeConfirmation.Equals(DialogResult.Yes)) return;

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
            populateRoster();

        }
    }
}
