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

namespace CoachConnect
{
    public partial class AddSessionStudent : Form
    {
        private Session CurrentSession { get; set; }

        private List<StudentByCourse> EligibleStudents { get; set; }
        private List<SessionRoster> CurrentRoster { get; set; }
        private bool SuccessfulAdd { get; set; }

        public AddSessionStudent(Session currentSession)
        {
            CurrentSession = currentSession;

            InitializeComponent();

            GetCurrentSessionRoster();
            GetEligibleStudents();
        }

        /// <summary>
        /// Destructor
        /// </summary>
        ~AddSessionStudent() { }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dataGridViewEligibleStudents.SelectedRows.Count > 0)
            {
                AddStudentToSession();
            }

            if (SuccessfulAdd) Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewEligibleStudents_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddStudentToSession();

            if (SuccessfulAdd) Close();
        }

        private void dataGridViewEligibleStudents_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AddStudentToSession();

            if (SuccessfulAdd) Close();
        }

        private void GetCurrentSessionRoster()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    var currentStudentsQuery = from currentStudents in context.SessionRosters
                                               where currentStudents.SessionID.Equals(CurrentSession.SessionID)
                                               select currentStudents;

                    CurrentRoster = currentStudentsQuery.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void GetEligibleStudents()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Pull list of all eligible students
                    var enrolledStudentQuery = from students in context.StudentByCourses
                        where students.CourseID.Equals(CurrentSession.CourseID)
                        select students;

                    if (enrolledStudentQuery == null || enrolledStudentQuery.ToList().Count == 0)
                    { 
                        MessageBox.Show("Sorry, no students are enrolled in this course.  Please update your session with a different course.");
                        Close();
                        return;
                    }
                    
                    List<StudentByCourse> eligibleStudentList = enrolledStudentQuery.ToList();

                    // Find list of eligible students
                    EligibleStudents = eligibleStudentList.ToList();

                    // Add eligible students to the data grid
                    dataGridViewEligibleStudents.DataSource = null;
                    dataGridViewEligibleStudents.DataSource = EligibleStudents;

                    dataGridViewEligibleStudents.Columns["CourseID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        

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
                    SessionID = CurrentSession.SessionID,
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
