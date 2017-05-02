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
    public partial class EditSession : Form
    {
        public EditSession()
        {
            InitializeComponent();
            populateComboBoxes();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /// Stub to save data
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void populateComboBoxes()
        {
            List<Course> courseList = new List<Course>();
            List<Room>   roomList   = new List<Room>();
            List<Day>    dayList    = new List<Day>();
            List<TimePeriod> timeList = new List<TimePeriod>();
            List<User>   coachList  = new List<User>();



            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Run queries to get combo box data
                    var courseQuery = from courses in context.Courses
                                      where courses.IsActive
                                      select courses;

                    var roomQuery = from rooms in context.Rooms
                                    select rooms;

                    var dayQuery = from days in context.Days
                                   select days;

                    var timeQuery = from times in context.TimePeriods
                                    select times;

                    var coachQuery = from coaches in context.Users
                                     where coaches.IsCoach
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
