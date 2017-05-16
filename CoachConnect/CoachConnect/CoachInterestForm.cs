// <copyright file="CoachInterestForm.cs" company="PABT at NWTC">
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
    /// A form that shows coach search results based on a selected interest
    /// </summary>
    public partial class FrmCoachInterest : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FrmCoachInterest" /> class.
        /// </summary>
        public FrmCoachInterest()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FrmCoachInterest" /> class using provided inputs.
        /// </summary>
        /// <param name="original">The original form where this class was called</param>
        /// <param name="interest">The image representing the current selected interest</param>
        /// <param name="title">The name of the current selected interest</param>
        public FrmCoachInterest(Form original, Image interest, string title)
        {
            this.InitializeComponent();
            this.OriginalForm = original;
            this.PicInterest = interest;
            this.TitleInterest = title;
            this.SetForm();
        }

        /// <summary>
        /// Gets or sets a form object
        /// </summary>
        private Form OriginalForm { get; set; }

        /// <summary>
        /// Gets or sets an image object that corresponds with the current selected interest
        /// </summary>
        private Image PicInterest { get; set; }

        /// <summary>
        /// Gets or sets a string that holds the current selected interest
        /// </summary>
        private string TitleInterest { get; set; }

        /// <summary>
        /// Event handler to show the original form when this form is closed.
        /// </summary>
        /// <param name="e">The parameter is not used.</param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.OriginalForm.Show();
        }

        /// <summary>
        /// An event handler to close this form and show the "original form" when the Back button is clicked.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnInterestExit_Click(object sender, EventArgs e)
        {
            this.OriginalForm.Show();
            this.Close();
        }

        /// <summary>
        /// Updates the form title and image, then calls a method to get all session results based on the selected interest.
        /// </summary>
        private void SetForm()
        {
            this.lblTitle.Text = this.TitleInterest;
            this.picBoxInterest.Image = this.PicInterest;

            this.GetCoachesByInterest();
        }

        /// <summary>
        /// Runs a query to pull available sessions based on the selected interest
        /// </summary>
        private void GetCoachesByInterest()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Access view and pull data
                    var coachInterestQuery =
                        from coachinterests in context.SessionsByInterests
                        where coachinterests.Interest.Equals(this.TitleInterest)
                        select new
                        {
                            CoachID = coachinterests.UserID,
                            Coach = coachinterests.Coach,
                            Day = coachinterests.Day,
                            Time = coachinterests.Time,
                            CourseID = coachinterests.Course,
                            CourseName = coachinterests.CourseName
                        };

                    // Add results to data grid view
                    this.dataGridAvailableSessions.DataSource = coachInterestQuery.ToList();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        /// <summary>
        /// Event handler to enter a row on datagridview.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void DataGridAvailableCoaches_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.btnSelectSession.Enabled = true;
        }

        /// <summary>
        /// Event handler to select a coach.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnSelectCoachClick(object sender, EventArgs e)
        {
            // If a session is not selected, display a message.
            // Otherwise, get data from that row.
            if (this.dataGridAvailableSessions.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a row before continuing");
                return;
            }
            else
            {
                DataGridViewRow selectedRow = this.dataGridAvailableSessions.SelectedRows[0];
                string selectedCoachID = selectedRow.Cells[0].Value.ToString();
                string selectedCoachName = selectedRow.Cells[1].Value.ToString();
                string selectedDay = selectedRow.Cells[2].Value.ToString();
                string selectedTime = selectedRow.Cells[3].Value.ToString();
                string selectedCourseID = selectedRow.Cells[4].Value.ToString();
                string selectedCourse = selectedRow.Cells[5].Value.ToString();

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to create this appointment?\n"
                        + "Coach: " + selectedCoachName + "\n"
                        + "Time: " + selectedTime + "\n"
                        + "Day: " + selectedDay + "\n"
                        + "Course ID: " + selectedCourseID + "\n"
                        + "Selected Course: " + selectedCourse,
                    "Confirmation", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    // Check whether user is enrollled in the current session
                    using (db_sft_2172Entities context = new db_sft_2172Entities())
                    {
                        var userQuery = from s in context.ViewSessions
                                        where s.UserID.Equals(selectedCoachID) && s.Day.Equals(selectedDay) && s.Time.Equals(selectedTime)
                                        select s;
                        var userResult = userQuery.FirstOrDefault<ViewSession>();
                        if (userQuery.Any())
                        {
                            try
                            {
                                var checkSessionRoster = from sessionRoster in context.SessionRosters
                                                         where sessionRoster.UserID.Equals(Program.CurrentUser) && sessionRoster.SessionID.Equals(userResult.SessionID)
                                                         select sessionRoster;

                                // If user is enrolled already, display a messge.
                                // Otherwise, add student to the session's roster
                                if (checkSessionRoster.Any())
                                {
                                    MessageBox.Show("Soory, you are already enrolled in this session.");
                                }
                                else
                                {
                                    SessionRoster sr = new SessionRoster()
                                    {
                                        SessionID = userResult.SessionID,
                                        UserID = Program.CurrentUser,
                                        RoleID = "STUD"
                                    };
                                    context.SessionRosters.Add(sr);
                                    context.SaveChanges();
                                    this.OriginalForm.Show();
                                    this.Close();
                                } 
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("This coach is not assigned into this session!");
                        }
                    }
                }
            }
        }
    }
}
