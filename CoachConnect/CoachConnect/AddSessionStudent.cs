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
    public partial class AddSessionStudent : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddSessionStudent" /> class
        /// </summary>
        /// <param name="currentSession">The session object to be updated</param>
        public AddSessionStudent(Session currentSession)
        {
            this.CurrentSession = currentSession;

            this.InitializeComponent();

            this.GetCurrentSessionRoster();
            this.GetEligibleStudents();
        }

        /// <summary>
        /// Gets or sets a Session object that stores information on the current coaching session
        /// </summary>
        private Session CurrentSession { get; set; }

        /// <summary>
        /// Gets or sets a list of students that are enrolled in the class and eligible to enroll in the coaching session
        /// </summary>
        private List<StudentByCourse> EligibleStudents { get; set; }

        /// <summary>
        ///  Gets or sets a list of students that are already enrolled in the coaching session
        /// </summary>
        private List<SessionRoster> CurrentRoster { get; set; }

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
            if (dataGridViewEligibleStudents.SelectedRows.Count > 0)
            {
                this.AddStudentToSession();
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
        private void DataGridViewEligibleStudentsCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.AddStudentToSession();

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
        private void DataGridViewEligibleStudentsRowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.AddStudentToSession();

            if (this.SuccessfulAdd)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Method to obtain the current session's roster from the database and add results to the data grid view
        /// </summary>
        private void GetCurrentSessionRoster()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    var currentStudentsQuery = from currentStudents in context.SessionRosters
                                               where currentStudents.SessionID.Equals(this.CurrentSession.SessionID)
                                               select currentStudents;

                    this.CurrentRoster = currentStudentsQuery.ToList();
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
        private void GetEligibleStudents()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Pull list of all eligible students
                    var enrolledStudentQuery = from students in context.StudentByCourses
                        where students.CourseID.Equals(this.CurrentSession.CourseID)
                        select students;

                    if (enrolledStudentQuery == null || enrolledStudentQuery.ToList().Count == 0)
                    { 
                        MessageBox.Show("Sorry, no students are enrolled in this course.  Please update your session with a different course.");
                        this.Close();
                        return;
                    }
                    
                    List<StudentByCourse> eligibleStudentList = enrolledStudentQuery.ToList();

                    // Find list of eligible students
                    this.EligibleStudents = eligibleStudentList.ToList();

                    // Add eligible students to the data grid
                    this.dataGridViewEligibleStudents.DataSource = null;
                    this.dataGridViewEligibleStudents.DataSource = this.EligibleStudents;

                    this.dataGridViewEligibleStudents.Columns["CourseID"].Visible = false;
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
        private void AddStudentToSession()
        {
            this.SuccessfulAdd = false;

            try
            {
                // Get UserID for the selected row
                string selectedUserId = dataGridViewEligibleStudents.SelectedRows[0].Cells["UserID"].Value.ToString();

                // Create a new SessionRoster object
                SessionRoster addStudent = new SessionRoster
                {
                    SessionID = this.CurrentSession.SessionID,
                    UserID = selectedUserId,
                    RoleID = "STUD"
                };

                using (var context = new db_sft_2172Entities())
                {
                    context.SessionRosters.Add(addStudent);
                    context.SaveChanges();
                }

                // Display confirmation
                MessageBox.Show("Student added successfully!");

                this.Close();
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (DbUpdateException dbUpdateException)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                MessageBox.Show("Student is already enrolled.  Please select a different student.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
