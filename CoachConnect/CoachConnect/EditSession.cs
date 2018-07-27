// <copyright file="EditSession.cs" company="PABT at NWTC">
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
    /// EditSession: A form which allows users to create and edit session data, then save the data to the database.
    /// </summary>
    public partial class EditSession : Form
    {
        /// <summary>
        /// Gets or sets the current session to be edited
        /// </summary>
        private int SessionId { get; }

        /// <summary>
        /// Gets or sets an object to hold the current session data
        /// </summary>
        private CoachSession CurrentSession { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditSession" /> class with no inputs.
        /// The no-input version is used to create a new session and allows the user to select the coach.
        /// </summary>
        public EditSession()
        {
            InitializeComponent();

            // Set session ID to a negative value (indicates a new session)
            SessionId = -1;

            // Update header text to show "Create" instead of "Edit"
            lblEditSessionHeader.Text = @"Create Session";

            // Call method to populate combo boxes
            PopulateComboBoxes();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditSession" /> class with a string input.
        /// This version is used to create a new session for a specified coach.
        /// </summary>
        /// <param name="coachId">The Coach ID to be included in the new session</param>
        public EditSession(string coachId)
        {
            InitializeComponent();

            CurrentSession = new CoachSession {CoachID = coachId};

            // Set session ID to a negative value (indicates a new session)
            SessionId = -1;

            // Update header text to show "Create" instead of "Edit"
            lblEditSessionHeader.Text = @"Create Session";

            // Call method to populate combo boxes
            PopulateComboBoxes();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditSession" /> class.
        /// A sessionID is provided to show which session should be updated
        /// </summary>
        /// <param name="sessionId">The ID for the session to be updated</param>
        public EditSession(int sessionId)
        {
            InitializeComponent();

            // Set sessionID
            CurrentSession = new CoachSession {SessionID = sessionId};

            // Call method to populate combo boxes
            PopulateComboBoxes();

            // Call method to pull current session data from the database
            LoadSessionData();
        }

        /// <summary>
        /// Event handler to save session data and close form when the Save button is clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnSaveClick(object sender, EventArgs e)
        {
            if (CurrentSession == null)
            {
                CurrentSession = new CoachSession();
            }

            // Get data from form and insert into current Session object
            CurrentSession.RoomID = cbxRoom.SelectedValue.ToString();
            CurrentSession.DayID = cbxDay.SelectedValue.ToString();
            CurrentSession.CoachID = cbxCoach.SelectedValue.ToString();

            // Get data from form and insert into current Availability object
            CurrentSession.DayID = cbxDay.SelectedValue.ToString();

            // Get selected start time as a TimeSpan
            Time selectedStartTime = (Time)cbxStartTime.SelectedItem;
            CurrentSession.StartTime = selectedStartTime.Time1;

            // Get selected end time as a TimeSpan
            Time selectedEndTime = (Time)cbxEndTime.SelectedItem;
            CurrentSession.EndTime = selectedEndTime.Time1;

            // Update active status based on selected value
            CurrentSession.Active = cbxActive.SelectedIndex == 0;

            // Verify that the selected coach has availablility on the desired day/time
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    var availableCoachSessions = from coachAvailability in context.CoachAvailabilities
                                                 where
                                                     coachAvailability.CoachID.Equals(CurrentSession.CoachID)
                                                     && coachAvailability.DayID.Equals(CurrentSession.DayID)
                                                     && coachAvailability.StartTime <= CurrentSession.StartTime
                                                     && coachAvailability.EndTime >= CurrentSession.EndTime
                                                 select coachAvailability;

                    if (availableCoachSessions.Any())
                    {
                        // Call appropriate method to add or update session data
                        if (SessionId == -1)
                        {
                            AddNewSession();
                        }
                        else
                        {
                            UpdateSession();
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            @"Sorry, the desired coach is not available for the selected day/time.\nPlease select another combination!");

                        return;
                    }
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

            // Close form once finished
            Close();
        }

        /// <summary>
        /// Event handler to close the current form when the Cancel button is clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnCancelClick(object sender, EventArgs e)
        {
            Close();
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
                    List<Room> roomList = roomQuery.ToList();
                    List<Day> dayList = dayQuery.ToList();
                    List<Time> startTimeList = startTimeQuery.ToList();
                    List<Time> endTimeList = endTimeQuery.ToList();
                    List<Coach> coachList = coachQuery.ToList();

                    // Set combo box data sources and update data member settings
                    cbxCoach.DataSource = coachList;
                    cbxCoach.ValueMember = "CoachID";
                    cbxCoach.DisplayMember = "DisplayName";

                    cbxDay.DataSource = dayList;
                    cbxDay.ValueMember = "DayID";
                    cbxDay.DisplayMember = "DayName";

                    cbxStartTime.DataSource = startTimeList;
                    cbxStartTime.ValueMember = "Time1";
                    cbxStartTime.DisplayMember = "TimeName";

                    cbxEndTime.DataSource = endTimeList;
                    cbxEndTime.ValueMember = "Time1";
                    cbxEndTime.DisplayMember = "TimeName";

                    cbxRoom.DataSource = roomList;
                    cbxRoom.ValueMember = "RoomID";
                    cbxRoom.DisplayMember = "RoomNumber";

                    cbxCoach.SelectedIndex = -1;
                    cbxDay.SelectedIndex = -1;
                    cbxStartTime.SelectedIndex = -1;
                    cbxEndTime.SelectedIndex = -1;
                    cbxRoom.SelectedIndex = -1;
                    cbxActive.SelectedIndex = -1;

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
        /// Method to query the database and display data for the desired session
        /// </summary>
        private void LoadSessionData()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    var sessionQuery = from session in context.CoachSessions
                                       where session.SessionID.Equals(CurrentSession.SessionID)
                                       select session;

                    if (sessionQuery.Any())
                    {
                        CurrentSession = sessionQuery.FirstOrDefault();
                    }
                    else
                    {
                        MessageBox.Show(@"Sorry, could not load session data from the database.  Please try again later.");
                        Close();
                    }
                }
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

            // Populate combo boxes with current session data
            cbxCoach.SelectedValue = CurrentSession.CoachID;
            cbxDay.SelectedValue = CurrentSession.DayID;
            cbxStartTime.SelectedValue = CurrentSession.StartTime;
            cbxEndTime.SelectedValue = CurrentSession.EndTime;
            cbxRoom.SelectedValue = CurrentSession.RoomID;

            cbxActive.SelectedIndex = CurrentSession.Active ? 0 : 1;
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
                    context.CoachSessions.Add(CurrentSession);
                    context.SaveChanges();
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

            MessageBox.Show(@"Save completed...new session created successfully!");
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
                                       where session.SessionID.Equals(CurrentSession.SessionID)
                                       select session;

                    if (sessionQuery.Any())
                    {
                        CoachSession foundSession = sessionQuery.FirstOrDefault();

                        // Update database records
                        foundSession.RoomID = CurrentSession.RoomID;
                        foundSession.DayID = CurrentSession.DayID;
                        foundSession.StartTime = CurrentSession.StartTime;
                        foundSession.EndTime = CurrentSession.EndTime;
                        foundSession.CoachID = CurrentSession.CoachID;
                        foundSession.Active = CurrentSession.Active;

                        // Save changes to database
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show(
                            @"Sorry, a matching session was not found in the database.\nPlease try again or contact an administrator for assistance.");
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

            MessageBox.Show(@"Save completed...Session updated successfully!");
        }
    }
}
