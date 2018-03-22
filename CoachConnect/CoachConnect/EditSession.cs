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
        /// The no-input version is used to create a new session and allows the user to select the coach.
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
        /// Initializes a new instance of the <see cref="EditSession" /> class with a string input.
        /// This version is used to create a new session for a specified coach.
        /// </summary>
        public EditSession(string coachID)
        {
            this.InitializeComponent();

            this.CurrentSession = new CoachSession();
            CurrentSession.CoachID = coachID;

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
            this.InitializeComponent();

            // Set sessionID
            CurrentSession = new CoachSession();
            CurrentSession.SessionID = sessionID;

            // Call method to populate combo boxes
            this.PopulateComboBoxes();

            // Call method to pull current session data from the database
            this.LoadSessionData();

            // Call method to populate session roster
            //this.PopulateCourseGrid();
        }

        /// <summary>
        /// Gets or sets the current session to be edited
        /// </summary>
        private int SessionId { get; set; }

        /// <summary>
        /// Gets or sets an object to hold the current session data
        /// </summary>
        private CoachSession CurrentSession { get; set; }

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
            this.CurrentSession = new CoachSession();

            // Get data from form and insert into current Session object
            this.CurrentSession.RoomID = this.cbxStartTime.SelectedValue.ToString();
            this.CurrentSession.DayID = this.cbxDay.SelectedValue.ToString();
            this.CurrentSession.CoachID = this.cbxCoach.SelectedValue.ToString();

            // Update start/end times based on selected values
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Get selected start time
                    var selectedStartTime = from startTimes in context.Times
                                            where
                                                startTimes.TimeName.Equals(this.cbxStartTime.SelectedValue.ToString())
                                            select startTimes.Time1;

                    if (selectedStartTime.Any())
                    {
                        this.CurrentSession.StartTime = selectedStartTime.First();
                    }

                    // Get selected end time
                    var selectedEndTime = from times in context.Times
                                            where
                                                times.TimeName.Equals(this.cbxEndTime.SelectedValue.ToString())
                                            select times.Time1;

                    if (selectedEndTime.Any())
                    {
                        this.CurrentSession.EndTime = selectedEndTime.First();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Update active status based on selected value
            if (this.cbxActive.SelectedIndex == 0)
            {
                this.CurrentSession.Active = true;
            }
            else
            {
                this.CurrentSession.Active = false;
            }

            // TODO: Add check to make sure this session does not overlap with another one

            // Verify that the selected coach has availablility on the desired day/time
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    var availableCoachSessions = from coachAvailability in context.CoachAvailabilities
                                                 where
                                                     coachAvailability.CoachID.Equals(this.CurrentSession.CoachID)
                                                     && coachAvailability.DayID.Equals(this.CurrentSession.DayID)
                                                     && coachAvailability.StartTime <= this.CurrentSession.StartTime
                                                     && coachAvailability.EndTime >= this.CurrentSession.EndTime
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
                        }Doubl
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

                    var startTimeQuery = from times in context.Times
                                         orderby times.Time1
                                         select times;

                    var endTimeQuery = from times in context.Times
                                       orderby times.Time1
                                       select times;

                    var coachQuery = from coaches in context.Coaches
                                     orderby coaches.DisplayName
                                     select coaches;

                    // Convert query results to lists
                    List<Course> courseList = courseQuery.ToList();
                    List<Room> roomList = roomQuery.ToList();
                    List<Day> dayList = dayQuery.ToList();
                    List<Time> startTimeList = startTimeQuery.ToList();
                    List<Time> endTimeList = endTimeQuery.ToList();
                    List<Coach> coachList = coachQuery.ToList();

                    // Set combo box data sources and update data member settings
                    this.cbxCoach.DataSource = coachList;
                    this.cbxCoach.ValueMember = "CoachID";
                    this.cbxCoach.DisplayMember = "DisplayName";

                    this.cbxDay.DataSource = dayList;
                    this.cbxDay.ValueMember = "DayID";
                    this.cbxDay.DisplayMember = "DayName";

                    this.cbxStartTime.DataSource = startTimeList;
                    this.cbxStartTime.ValueMember = "Time1";
                    this.cbxStartTime.DisplayMember = "TimeName";

                    this.cbxEndTime.DataSource = endTimeList;
                    this.cbxEndTime.ValueMember = "Time1";
                    this.cbxEndTime.DisplayMember = "TimeName";

                    this.cbxRoom.DataSource = roomList;
                    this.cbxRoom.ValueMember = "RoomID";
                    this.cbxRoom.DisplayMember = "RoomNumber";

                    this.cbxCoach.SelectedIndex = -1;
                    this.cbxDay.SelectedIndex = -1;
                    this.cbxStartTime.SelectedIndex = -1;
                    this.cbxEndTime.SelectedIndex = -1;
                    this.cbxRoom.SelectedIndex = -1;
                    this.cbxActive.SelectedIndex = -1;

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
                    var sessionQuery = from session in context.CoachSessions
                                       where session.SessionID.Equals(this.CurrentSession.SessionID)
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
                return;
            }

            // Populate combo boxes with current session data
            this.cbxCoach.SelectedValue = this.CurrentSession.CoachID;
            this.cbxDay.SelectedValue = this.CurrentSession.DayID;
            this.cbxStartTime.SelectedValue = this.CurrentSession.StartTime;
            this.cbxEndTime.SelectedValue = this.CurrentSession.EndTime;
            this.cbxRoom.SelectedValue = this.CurrentSession.RoomID;

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
                    context.CoachSessions.Add(this.CurrentSession);
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
            // Add new session to the database and save changes
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Run query and pull matching session from database
                    var sessionQuery = from session in context.CoachSessions
                                       where session.SessionID.Equals(this.SessionId)
                                       select session;

                    if (sessionQuery.Any())
                    {
                        CoachSession foundSession = sessionQuery.FirstOrDefault();

                        // Update database records
                        foundSession.RoomID = this.CurrentSession.RoomID;
                        foundSession.DayID = this.CurrentSession.DayID;
                        foundSession.StartTime = this.CurrentSession.StartTime;
                        foundSession.EndTime = this.CurrentSession.EndTime;
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
    }
}
