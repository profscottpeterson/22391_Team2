// <copyright file="AddSessionStudent.cs" company="PABT at NWTC">
//     Copyright 2017 PABT (Pao Xiong, Adam Smith, Brian Lueskow, Tim Durkee)
// </copyright>
namespace CoachConnect
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.Entity.Infrastructure;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// AddSessionStudent: Allows users to add a student to a session roster
    /// </summary>
    public partial class AddSessionCourse : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddSessionCourse" /> class
        /// </summary>
        /// <param name="currentSession">The session object to be updated</param>
        public AddSessionCourse(CoachSession currentSession)
        {
            this.CurrentSession = currentSession;

            this.InitializeComponent();

            this.GetCurrentSessionCourses();
            this.GetEligibleCourses();
        }

        /// <summary>
        /// Gets or sets a Session object that stores information on the current coaching session
        /// </summary>
        private CoachSession CurrentSession { get; set; }

        /// <summary>
        /// Gets or sets a list of students that are enrolled in the class and eligible to enroll in the coaching session
        /// </summary>
        private List<Course> EligibleCourses { get; set; }

        /// <summary>
        ///  Gets or sets a list of courses that are already added to the coaching session
        /// </summary>
        private List<Course> CurrentCourses { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the student was added successfully
        /// </summary>
        private bool SuccessfulAdd { get; set; }

        /// <summary>
        /// Event handler to call a method and add the selected student to the database when the Add button is clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnAddClick(object sender, EventArgs e)
        {
            if (this.dataGridViewEligibleCourses.SelectedRows.Count > 0)
            {
                this.AddCourseToSession();
            }

            if (this.SuccessfulAdd)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Event handler to close the form when the Close button is clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Event handler to call a method and add the selected student to the database when a data cell is double-clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void DataGridViewEligibleCoursesCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.AddCourseToSession();

            if (this.SuccessfulAdd)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Event handler to call a method and add the selected student to the database when a data row header is double-clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void DataGridViewEligibleCoursesRowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.AddCourseToSession();

            if (this.SuccessfulAdd)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Method to obtain the current session's roster from the database and add results to the data grid view
        /// </summary>
        private void GetCurrentSessionCourses()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    var currentCoursesQuery = from courses in context.Courses
                                                join sessionCourses in context.SessionCourses
                                                    on courses.CourseID equals sessionCourses.CourseID
                                               where sessionCourses.SessionID.Equals(this.CurrentSession.SessionID)
                                               select courses;

                    this.CurrentCourses = currentCoursesQuery.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Method to obtain a list of students that are part of the desired class (and thus eligible to enroll in the coaching session)
        /// </summary>
        private void GetEligibleCourses()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Pull list of all eligible students
                    var courseQuery = from courses in context.Courses
                        join coachCourses in context.CoachCourses
                            on courses.CourseID equals coachCourses.CourseID
                        where coachCourses.SessionID.Equals(this.CurrentSession.SessionID)
                        select courses;

                    if (courseQuery.ToList().Count == 0)
                    { 
                        MessageBox.Show("Sorry, this coach does not have any courses available to add.");
                        this.Close();
                        return;
                    }
                    
                    List<Course> eligibleCourseList = courseQuery.ToList();

                    // Find list of eligible students
                    this.EligibleCourses = eligibleCourseList.ToList();

                    // Add eligible students to the data grid
                    this.dataGridViewEligibleCourses.DataSource = null;
                    this.dataGridViewEligibleCourses.DataSource = this.EligibleCourses;

                    this.dataGridViewEligibleCourses.Columns["CourseID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Method to get data for the selected student, then add a new record to the SessionRoster entity
        /// </summary>
        private void AddCourseToSession()
        {
            this.SuccessfulAdd = false;

            try
            {
                // Get CourseID for the selected row
                string selectedCourseId = this.dataGridViewEligibleCourses.SelectedRows[0].Cells["CourseID"].Value.ToString();

                // Create a new SessionCourse object
                SessionCourse addCourse = new SessionCourse
                {
                    SessionID = this.CurrentSession.SessionID,
                    CourseID = selectedCourseId,
                    Active = true
                };

                using (var context = new db_sft_2172Entities())
                {
                    context.SessionCourses.Add(addCourse);
                    context.SaveChanges();
                }

                // Display confirmation
                MessageBox.Show("Course added successfully!");

                this.Close();
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (DbUpdateException dbUpdateException)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                MessageBox.Show("Course is already added.  Please select a different course.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
