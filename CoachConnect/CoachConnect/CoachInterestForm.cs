//-----------------------------------------------------------------------
// <copyright file="CoachInterestForm.cs" company="PABT,Inc">
//     Copyright (c) Pabt, Inc. All rights reserved
// </copyright>
//-----------------------------------------------------------------------

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

    /// <content>
    /// Contains functionalities and features for the frmCoachInterest class.
    /// </content>
    public partial class frmCoachInterest : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="frmCoachInterest"/> class
        /// </summary>
        public frmCoachInterest()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="frmCoachInterest"/> class
        /// </summary>
        /// <param name="original">The original to join.</param>
        /// <param name="interest">The interest to join.</param>
        /// <param name="title">The title to join.</param>
        public frmCoachInterest(Form original, Image interest, string title)
        {
            this.InitializeComponent();
            this.OriginalForm = original;
            this.PicInterest = interest;
            this.TitleInterest = title;
            this.SetForm();
        }

        /// /// <summary>
        /// Gets or sets the Original form.
        /// </summary>
        private Form OriginalForm { get; set; }

        /// /// <summary>
        /// Gets or sets the interested picture.
        /// </summary>
        private Image PicInterest { get; set; }

        /// /// <summary>
        /// Gets or sets the title.
        /// </summary>
        private string TitleInterest { get; set; }

        /// <summary>
        /// Override method event handler to perform when the form is closed.
        /// </summary>
        /// <param name="e">The event e to join</param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.OriginalForm.Show();
        }

        /// <summary>
        /// Event handler to click to exit the current form.
        /// </summary>
        /// <param name="sender">The object sender to join</param>
        /// <param name="e">The event e to join</param>
        private void btnInterestExit_Click(object sender, EventArgs e)
        {
            this.OriginalForm.Show();
            this.Close();
        }

        /// <summary>
        /// Sets Form according to button clicked.
        /// </summary>
        private void SetForm()
        {
            lblTitle.Text = this.TitleInterest;
            pbInterest.Image = this.PicInterest;

            this.GetCoachesByInterest();
        }

        /// <summary>
        /// Addition by Adam Smith: Query to pull coaches by interest
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
                    dataGridAvailableCoaches.DataSource = coachInterestQuery.ToList();
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
        /// <param name="sender">The object sender to join</param>
        /// <param name="e">The event e to join</param>
        private void dataGridAvailableCoaches_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnSelectCoach.Enabled = true;
        }

        /// <summary>
        /// Event handler to select a coach.
        /// </summary>
        /// <param name="sender">The object sender to join</param>
        /// <param name="e">The event e to join</param>
        private void btnSelectCoach_Click(object sender, EventArgs e)
        {
            string selectedCoachID;
            string selectedCoachName;
            string selectedTime;
            string selectedDay;
            string selectedCourseID;
            string selectedCourse;
            if (dataGridAvailableCoaches.SelectedRows == null)
            {
                MessageBox.Show("Please select a row before continuing");
                return;
            }
            else
            {
                DataGridViewRow selectedRow = dataGridAvailableCoaches.SelectedRows[0];
                selectedCoachID = selectedRow.Cells[0].Value.ToString();
                selectedCoachName = selectedRow.Cells[1].Value.ToString();
                selectedDay = selectedRow.Cells[2].Value.ToString();
                selectedTime = selectedRow.Cells[3].Value.ToString();
                selectedCourseID = selectedRow.Cells[4].Value.ToString();
                selectedCourse = selectedRow.Cells[5].Value.ToString();

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to create this appointment?\n"
                        + "Coach: " + selectedCoachName + "\n"
                        + "Time: " + selectedTime + "\n"
                        + "Day: " + selectedDay + "\n"
                        + "Course ID: " + selectedCourseID + "\n"
                        + "Selected Course: " + selectedCourse,
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
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
                                if (checkSessionRoster.Any())
                                {
                                    MessageBox.Show("This sessional coach has been assigned already.");
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
                                ex.ToString();
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
