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
    public partial class AddSessionStudent : Form
    {
        private Session CurrentSession { get; set; }

        private List<User> EligibleStudents { get; set; }
        private List<string> CurrentRosterIDs { get; set; }

        public AddSessionStudent(Session currentSession)
        {
            CurrentSession = currentSession;

            InitializeComponent();

            getCurrentSessionRoster();
            getEligibleStudents();

            cbxName.DataSource = EligibleStudents;
            
                
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getCurrentSessionRoster()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    var currentStudentsQuery = from currentStudents in context.SessionRosters
                                               where currentStudents.SessionID.Equals(CurrentSession.SessionID)
                                               select currentStudents.UserID;

                    CurrentRosterIDs = currentStudentsQuery.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void getEligibleStudents()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Pull list of all eligible students
                    var eligibleStudentIDsQuery = from eligibleStudents in context.StudentByCourses
                                                where eligibleStudents.CourseID.Equals(CurrentSession.CourseID) 
                                                select eligibleStudents.UserID;

                    // Remove students that are already enrolled (no need to list them again)
                    var nonEnrolledEligibleStudents = eligibleStudentIDsQuery.Where(s => CurrentRosterIDs.All(s2 => s2 != s));

                    List<string> eligibleStudentIDs = nonEnrolledEligibleStudents.ToList();

                    // Run another query to get student records
                    var studentsQuery = from students in context.Users
                                        select students;
                    studentsQuery = studentsQuery.Where(s => eligibleStudentIDs.All(s2 => s2.Equals(s)));

                    EligibleStudents = studentsQuery.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
