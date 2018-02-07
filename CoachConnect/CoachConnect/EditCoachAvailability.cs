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
    public partial class EditCoachAvailability : Form
    {
        /// <summary>
        /// Validator: An object to handle data form validation
        /// </summary>
        private readonly Validation validator = new Validation();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditCoachAvailability" /> class with no inputs.
        /// The no-input version is used to create a new session
        /// </summary>
        public EditCoachAvailability()
        {
            this.InitializeComponent();

            // Set session ID to a negative value (indicates a new session)
            this.CoachAvailabilityId = -1;

            // Update header text to show "Add" instead of "Edit"
            this.lblEditSessionHeader.Text = "Add Coach Availability";

            // Call method to populate combo boxes
            this.PopulateComboBoxes();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditCoachAvailability" /> class.
        /// A sessionID is provided to show which session should be updated
        /// </summary>
        /// <param name="sessionID">The ID for the session to be updated</param>
        public EditCoachAvailability(int coachAvailabilityID)
        {
            this.CoachAvailabilityId = coachAvailabilityID;

            this.InitializeComponent();

            // Call method to populate combo boxes
            this.PopulateComboBoxes();

            // Call method to pull current availability data from the database
            this.LoadSessionData();
        }

        /// <summary>
        /// Gets or sets the current session to be edited
        /// </summary>
        private int CoachAvailabilityId { get; set; }

        /// <summary>
        /// Gets or sets an object to hold the current session data
        /// </summary>
        private CoachAvailability CurrentAvailability { get; set; }

        /// <summary>
        /// Event handler to save session data and close form when the Save button is clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnSaveClick(object sender, EventArgs e)
        {
            this.CurrentAvailability = new CoachAvailability();

            // Get data from form and insert into current Availability object
            this.CurrentAvailability.DayID = this.cbxDay.SelectedValue.ToString();

            // Update start/end times based on selected values
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Get selected start time
                    var selectedStartTime = from startTimes in context.Times
                                            where
                                                startTimes.TimeName.Equals(this.cbxStartTime.SelectedText.ToString())
                                            select startTimes.Time1;

                    if (selectedStartTime.Any())
                    {
                        this.CurrentAvailability.StartTime = selectedStartTime.First();
                    }

                    // Get selected end time
                    var selectedEndTime = from endTimes in context.Times
                                          where
                                              endTimes.TimeName.Equals(this.cbxEndTime.SelectedText.ToString())
                                          select endTimes.Time1;

                    if (selectedEndTime.Any())
                    {
                        this.CurrentAvailability.EndTime = selectedEndTime.First();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // If end time is before the start time, display an error message, then cancel the save action. 
            if (this.CurrentAvailability.StartTime >= this.CurrentAvailability.EndTime)
            {
                MessageBox.Show("Error: Start time must be earlier than the end time.");
                return;
            }

            // Verify that the current availablility block does not overlap another block on the same day
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    var sameDayCoachAvailability = from coachAvailability in context.CoachAvailabilities
                                                   where
                                                       coachAvailability.CoachID.Equals(this.CurrentAvailability.CoachID)
                                                       && coachAvailability.DayID.Equals(this.CurrentAvailability.DayID)
                                                   select coachAvailability;

                    if (sameDayCoachAvailability.Any())
                    {
                        var overlappingCoachAvailability = from overlapping in sameDayCoachAvailability
                                                           where (this.CurrentAvailability.EndTime > overlapping.StartTime || this.CurrentAvailability.StartTime < overlapping.EndTime)
                                                           select overlapping;


                        if (overlappingCoachAvailability.Any())
                            MessageBox.Show(
                            "Sorry, the desired coach is already booked for part or all of this time block.\nPlease select another combination or modify an existing block!");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Call appropriate method to add or update session data
            if (this.CoachAvailabilityId == -1)
            {
                this.AddNewAvailability();
            }
            else
            {
                this.UpdateAvailability();
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
                    var dayQuery = from days in context.Days
                                   orderby days.SortOrder
                                   select days;

                    var timeQuery = from times in context.Times
                                    orderby times.Time1
                                    select times;

                    // Convert query results to lists
                    List<Day> dayList = dayQuery.ToList();
                    List<Time> timeList = timeQuery.ToList();

                    // Set combo box data sources and update data member settings
                    this.cbxStartTime.DataSource = timeList;
                    this.cbxStartTime.ValueMember = "RoomID";
                    this.cbxStartTime.DisplayMember = "RoomID";

                    this.cbxStartTime.DataSource = timeList;
                    this.cbxStartTime.ValueMember = "Time";
                    this.cbxStartTime.DisplayMember = "TimeName";

                    this.cbxEndTime.DataSource = timeList;
                    this.cbxEndTime.ValueMember = "Time";
                    this.cbxEndTime.DisplayMember = "TimeName";

                    this.cbxDay.SelectedIndex = -1;
                    this.cbxStartTime.SelectedIndex = -1;
                    this.cbxEndTime.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Method to query the database and display data for the desired availability block
        /// </summary>
        private void LoadSessionData()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    var availabilityQuery = from availability in context.CoachAvailabilities
                                       where availability.CoachAvailabilityID.Equals(this.CoachAvailabilityId)
                                       select availability;

                    if (availabilityQuery.Any())
                    {
                        this.CurrentAvailability = availabilityQuery.FirstOrDefault();
                    }
                    else
                    {
                        MessageBox.Show("Sorry, could not load availability data from the database.  Please try again later.");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Populate combo boxes with current session data
            this.cbxDay.SelectedValue = this.CurrentAvailability.DayID;


            this.cbxStartTime.SelectedValue = this.CurrentAvailability.StartTime;
            this.cbxEndTime.SelectedValue = this.CurrentAvailability.EndTime;
        }

        /// <summary>
        /// Method to create a new session in the database
        /// </summary>
        private void AddNewAvailability()
        {
            // Add new user to the database and save changes
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Run query and save new user data to database
                    context.CoachAvailabilities.Add(this.CurrentAvailability);
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
        private void UpdateAvailability()
        {
            // Add new user to the database and save changes
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Run query and pull matching session from database
                    var availabilityQuery = from availability in context.CoachAvailabilities
                                       where availability.CoachAvailabilityID.Equals(this.CoachAvailabilityId)
                                       select availability;

                    if (availabilityQuery.Any())
                    {
                        CoachAvailability foundAvailability= availabilityQuery.FirstOrDefault();

                        // Update database records
                        foundAvailability.CoachID = this.CurrentAvailability.CoachID;
                        foundAvailability.DayID = this.CurrentAvailability.DayID;
                        foundAvailability.StartTime = this.CurrentAvailability.StartTime;
                        foundAvailability.EndTime = this.CurrentAvailability.EndTime;

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
        /// Event handler to validate Room combo box when it loses focus
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CbxRoom_Leave(object sender, EventArgs e)
        {
            this.lblInvalidStartTime.Visible = !this.validator.ValidateComboBox(this.cbxStartTime.SelectedIndex);

            if (this.lblInvalidStartTime.Visible)
            {
                this.cbxStartTime.Focus();
            }
        }

        /// <summary>
        /// Event handler to validate Day combo box when it loses focus
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CbxDay_Leave(object sender, EventArgs e)
        {
            this.lblInvalidDay.Visible = !this.validator.ValidateComboBox(this.cbxDay.SelectedIndex);

            if (this.lblInvalidDay.Visible)
            {
                this.cbxDay.Focus();
            }
        }

        /// <summary>
        /// Event handler to validate Start Time combo box when it loses focus
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CbxStartTime_Leave(object sender, EventArgs e)
        {
            this.lblInvalidStartTime.Visible = !this.validator.ValidateComboBox(this.cbxStartTime.SelectedIndex);

            if (this.lblInvalidStartTime.Visible)
            {
                this.cbxStartTime.Focus();
            }
        }

        /// <summary>
        /// Event handler to validate End Time combo box when it loses focus
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CbxEndTime_Leave(object sender, EventArgs e)
        {
            this.lblInvalidEndTime.Visible = !this.validator.ValidateComboBox(this.cbxEndTime.SelectedIndex);

            if (this.lblInvalidEndTime.Visible)
            {
                this.cbxEndTime.Focus();
            }
        }
    }
}
