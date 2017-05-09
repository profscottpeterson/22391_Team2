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
    public partial class FindCoachForm : Form
    {
        public FindCoachForm()
        {
            InitializeComponent();
            displayInfo();
            displayCoachList();
            displayAppointment();
            panelCoach.Visible = false;
        }

        private void SelectedInterest(Image interest, string title)
        {
            this.Hide();
            frmCoachInterest frm2 = new frmCoachInterest(this, interest, title);
            frm2.Show();
            frm2.Location = this.Location;
        }

        private void btnAgri_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnAgri.BackgroundImage, lblAgri.Text);
        }

        private void btnArch_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnArch.BackgroundImage, lblArch.Text);
        }

        private void btnBusiness_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnBusiness.BackgroundImage, lblBusiness.Text);
        }

        private void btnDigital_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnDigital.BackgroundImage, lblDigital.Text);
        }

        private void btnEnergy_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnEnergy.BackgroundImage, lblEnergy.Text);
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnGeneral.BackgroundImage, lblGeneral.Text);
        }

        private void bthHealth_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnHealth.BackgroundImage, lblHealth.Text);
        }

        private void btnHuman_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnHuman.BackgroundImage, lblHuman.Text);
        }

        private void btnIT_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnIT.BackgroundImage, lblIT.Text);
        }

        private void btnLaw_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnLaw.BackgroundImage, lblLaw.Text);
        }

        private void btnManu_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnManu.BackgroundImage, lblManu.Text);
        }

        private void btnScience_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnScience.BackgroundImage, lblScience.Text);
        }

        private void btnTransport_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnTransport.BackgroundImage, lblTransport.Text);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Disipaly student info to the home tab
        private void displayInfo()
        {
            using (var context = new db_sft_2172Entities())
            {
                var userQuery = from u in context.Users
                                where u.UserID.Equals(Program.CurrentUser)
                                select u; 
                var userResult = userQuery.FirstOrDefault<User>();
                lblStdID.Text = userResult.UserID;
                lblStdName.Text = userResult.FirstName + " " + userResult.LastName;
                lblStdEmail.Text = userResult.Email;
                lblStdPhone.Text = userResult.Phone;
                var request = System.Net.WebRequest.Create(userResult.ProfilePic);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    pictureBoxStdProfile.Image = Bitmap.FromStream(stream);
                }

                var userCourse = from c in context.Courses
                                 join uc in context.UserCourses on c.CourseID equals uc.CourseID
                                 where uc.UserID.Equals(userResult.UserID)
                                 select c.CourseName;
                if (!userCourse.Any())
                {
                    lblRegisterStatusMessage.Visible = true;
                    listBoxCourse.Visible = false;
                }
                else
                {
                    lblRegisterStatusMessage.Visible = false;
                    listBoxCourse.Visible = true;
                    foreach(var c in userCourse.ToList())
                    {
                        listBoxCourse.Items.Add(c);
                    }
                }
               
            }
        }

        //Display coaches in the dropdown comboBox
        private void displayCoachList()
        {
            using (var context = new db_sft_2172Entities())
            {
                var userQuery = (from u in context.Users
                                 join s in context.Sessions on u.UserID equals s.CoachID
                                 where u.IsCoach.Equals(true)
                                 select u.DisplayName).ToList().Distinct();

                foreach (var c in userQuery)
                {

                    comboBoxCoaches.Items.Add(c);
                }
            }
        }

        //Button click to search for specific coach from the database
        private void button2_Click(object sender, EventArgs e)
        {
            string selectedCoach = (string)comboBoxCoaches.SelectedItem;
            unCheckedDayPeriods();
            disableChkPeriod();
            seachForCoach(selectedCoach);
        }

        //To disable checkboxes on the Coach by Name tab
        private void disableChkPeriod()
        {
            chkMonMorning.Enabled = false;
            chkMonMidday.Enabled = false;
            chkMonAfternoon.Enabled = false;
            chkMonEvening.Enabled = false;

            chkTueMorning.Enabled = false;
            chkTueMidday.Enabled = false;
            chkTueAfternoon.Enabled = false;
            chkTueEvening.Enabled = false;

            chkWedMorning.Enabled = false;
            chkWedMidday.Enabled = false;
            chkWedAfternoon.Enabled = false;
            chkWedEvening.Enabled = false;

            chkThuMorning.Enabled = false;
            chkThuMidday.Enabled = false;
            chkThuAfternoon.Enabled = false;
            chkThuEvening.Enabled = false;

            chkFriMorning.Enabled = false;
            chkFriMidday.Enabled = false;
            chkFriAfternoon.Enabled = false;
            chkFriEvening.Enabled = false;

            chkSatMorning.Enabled = false;
            chkSatMidday.Enabled = false;
            chkSatAfternoon.Enabled = false;
            chkSatEvening.Enabled = false;

            chkSunMorning.Enabled = false;
            chkSunMidday.Enabled = false;
            chkSunAfternoon.Enabled = false;
            chkSunEvening.Enabled = false;
        }

        //Called in the unchecked day period method to clear the check boxes first 
        private void unCheckedDayPeriods()
        {
            chkMonMorning.Checked = false;
            chkMonMidday.Checked = false;
            chkMonAfternoon.Checked = false;
            chkMonEvening.Checked = false;

            chkTueMorning.Checked = false;
            chkTueMidday.Checked = false;
            chkTueAfternoon.Checked = false;
            chkTueEvening.Checked = false;

            chkWedMorning.Checked = false;
            chkWedMidday.Checked = false;
            chkWedAfternoon.Checked = false;
            chkWedEvening.Checked = false;

            chkThuMorning.Checked = false;
            chkThuMidday.Checked = false;
            chkThuAfternoon.Checked = false;
            chkThuEvening.Checked = false;

            chkFriMorning.Checked = false;
            chkFriMidday.Checked = false;
            chkFriAfternoon.Checked = false;
            chkFriEvening.Checked = false;

            chkSatMorning.Checked = false;
            chkSatMidday.Checked = false;
            chkSatAfternoon.Checked = false;
            chkSatEvening.Checked = false;

            chkSunMorning.Checked = false;
            chkSunMidday.Checked = false;
            chkSunAfternoon.Checked = false;
            chkSunEvening.Checked = false;

            //Disable buttons when search a new coach
            btnScheduleApptName.Enabled = false;
            btnClear.Enabled = false;
        }

        //Called in the button2 to search a coach
        private void seachForCoach(string coach)
        {
            using (var context = new db_sft_2172Entities())
            {
                var userQuery = from u in context.Users
                                where u.IsCoach.Equals(true) && u.DisplayName.Equals(coach)
                                select u;
                var userResult = userQuery.FirstOrDefault<User>();
                try
                {
                    if (!String.IsNullOrEmpty(userResult.DisplayName))
                    {
                        panelCoach.Visible = true;
                        var request = System.Net.WebRequest.Create(userResult.ProfilePic);

                        using (var response = request.GetResponse())
                        using (var stream = response.GetResponseStream())
                        {
                            pictureBoxCoachProfile.Image = Bitmap.FromStream(stream);
                        }
                        lblCoachName.Text = userResult.DisplayName;
                        lblActiveCoach.Text = userResult.ActiveCoachSince.ToString();
                        lblEmail.Text = userResult.Email;
                        lblPhone.Text = userResult.Phone;

                        //display the day period by coach
                        seachCoachOnSession(userResult.DisplayName);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        //Search for available coach by session
        private void seachCoachOnSession(string coach)
        {
            listBoxDisplayCoachSubject.Items.Clear();
            using (var context = new db_sft_2172Entities())
            {
                var userQuery = from vs in context.ViewSessions
                                where vs.Coach.Equals(coach)
                                select vs;
                try
                {
                    if (userQuery.Any())
                    {
                        lblMessage.Text = "To assign the coach, Please select a day period bellow.";
                        var userR = userQuery.ToList();

                        foreach(var userResult in userR)
                        {
                            listBoxDisplayCoachSubject.Items.Add(userResult.Course);
                            if (userResult.Day.Equals("Monday"))
                            {
                                Monday.Enabled = true;
                                if (userResult.Time.Equals("Morning"))
                                {
                                    chkMonMorning.Enabled = true;
                                }
                                else if (userResult.Time.Equals("Midday"))
                                {
                                    chkMonMidday.Enabled = true;
                                }
                                else if (userResult.Time.Equals("Afternoon"))
                                {
                                    chkMonAfternoon.Enabled = true;
                                }
                                else if (userResult.Time.Equals("Evening"))
                                {
                                    chkMonEvening.Enabled = true;
                                }
                                else
                                {
                                    chkMonMorning.Enabled = false;
                                    chkMonMidday.Enabled = false;
                                    chkMonAfternoon.Enabled = false;
                                    chkMonEvening.Enabled = false;
                                }
                            }
                            else if (userResult.Day.Equals("Tuesday"))
                            {
                                Tuesday.Enabled = true;
                                if (userResult.Time.Equals("Morning"))
                                {
                                    chkTueMorning.Enabled = true;
                                }
                                else if (userResult.Time.Equals("Midday"))
                                {
                                    chkTueMidday.Enabled = true;
                                }
                                else if (userResult.Time.Equals("Afternoon"))
                                {
                                    chkTueAfternoon.Enabled = true;
                                }
                                else if (userResult.Time.Equals("Evening"))
                                {
                                    chkTueEvening.Enabled = true;
                                }
                                else
                                {
                                    chkTueMorning.Enabled = false;
                                    chkTueMidday.Enabled = false;
                                    chkTueAfternoon.Enabled = false;
                                    chkTueEvening.Enabled = false;
                                }
                            }
                            else if (userResult.Day.Equals("Wednesday"))
                            {
                                Wednesday.Enabled = true;
                                if (userResult.Time.Equals("Morning"))
                                {
                                    chkWedMorning.Enabled = true;
                                }
                                else if (userResult.Time.Equals("Midday"))
                                {
                                    chkWedMidday.Enabled = true;
                                }
                                else if (userResult.Time.Equals("Afternoon"))
                                {
                                    chkWedAfternoon.Enabled = true;
                                }
                                else if (userResult.Time.Equals("Evening"))
                                {
                                    chkWedEvening.Enabled = true;
                                }
                                else
                                {
                                    chkWedMorning.Enabled = false;
                                    chkWedMidday.Enabled = false;
                                    chkWedAfternoon.Enabled = false;
                                    chkWedEvening.Enabled = false;
                                }
                            }
                            else if (userResult.Day.Equals("Thursday"))
                            {
                                Thursday.Enabled = true;
                                if (userResult.Time.Equals("Morning"))
                                {
                                    chkThuMorning.Enabled = true;
                                }
                                else if (userResult.Time.Equals("Midday"))
                                {
                                    chkThuMidday.Enabled = true;
                                }
                                else if (userResult.Time.Equals("Afternoon"))
                                {
                                    chkThuAfternoon.Enabled = true;
                                }
                                else if (userResult.Time.Equals("Evening"))
                                {
                                    chkThuEvening.Enabled = true;
                                }
                                else
                                {
                                    chkThuMorning.Enabled = false;
                                    chkThuMidday.Enabled = false;
                                    chkThuAfternoon.Enabled = false;
                                    chkThuEvening.Enabled = false;
                                }
                            }
                            else if (userResult.Day.Equals("Friday"))
                            {
                                Friday.Enabled = true;
                                if (userResult.Time.Equals("Morning"))
                                {
                                    chkFriMorning.Enabled = true;
                                }
                                else if (userResult.Time.Equals("Midday"))
                                {
                                    chkFriMidday.Enabled = true;
                                }
                                else if (userResult.Time.Equals("Afternoon"))
                                {
                                    chkFriAfternoon.Enabled = true;
                                }
                                else if (userResult.Time.Equals("Evening"))
                                {
                                    chkFriEvening.Enabled = true;
                                }
                                else
                                {
                                    chkFriMorning.Enabled = false;
                                    chkFriMidday.Enabled = false;
                                    chkFriAfternoon.Enabled = false;
                                    chkFriEvening.Enabled = false;
                                }
                            }
                            else if (userResult.Day.Equals("Saturday"))
                            {
                                Saturday.Enabled = true;
                                if (userResult.Time.Equals("Morning"))
                                {
                                    chkSatMorning.Enabled = true;
                                }
                                else if (userResult.Time.Equals("Midday"))
                                {
                                    chkSatMidday.Enabled = true;
                                }
                                else if (userResult.Time.Equals("Afternoon"))
                                {
                                    chkSatAfternoon.Enabled = true;
                                }
                                else if (userResult.Time.Equals("Evening"))
                                {
                                    chkSatEvening.Enabled = true;
                                }
                                else
                                {
                                    chkSatMorning.Enabled = false;
                                    chkSatMidday.Enabled = false;
                                    chkSatAfternoon.Enabled = false;
                                    chkSatEvening.Enabled = false;
                                }
                            }
                            else if (userResult.Day.Equals("Sunday"))
                            {
                                Sunday.Enabled = true;
                                if (userResult.Time.Equals("Morning"))
                                {
                                    chkSunMorning.Enabled = true;
                                }
                                else if (userResult.Time.Equals("Midday"))
                                {
                                    chkSunMidday.Enabled = true;
                                }
                                else if (userResult.Time.Equals("Afternoon"))
                                {
                                    chkSunAfternoon.Enabled = true;
                                }
                                else if (userResult.Time.Equals("Evening"))
                                {
                                    chkSunEvening.Enabled = true;
                                }
                                else
                                {
                                    chkSunMorning.Enabled = false;
                                    chkSunMidday.Enabled = false;
                                    chkSunAfternoon.Enabled = false;
                                    chkSunEvening.Enabled = false;
                                }
                            }
                            else
                            {
                                Monday.Enabled = false;
                                Tuesday.Enabled = false;
                                Wednesday.Enabled = false;
                                Thursday.Enabled = false;
                                Friday.Enabled = false;
                                Saturday.Enabled = false;
                                Sunday.Enabled = false;
                            }
                        }  
                    }
                    else
                    {
                        Monday.Enabled = false;
                        Tuesday.Enabled = false;
                        Wednesday.Enabled = false;
                        Thursday.Enabled = false;
                        Friday.Enabled = false;
                        Saturday.Enabled = false;
                        Sunday.Enabled = false;
                        lblMessage.Text = "This coach is not available in this session, Please choose another coach.";
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        //Enable buttons 
        private void enableButtons()
        {
            if (chkMonMorning.Checked == true || chkMonMidday.Checked == true || chkMonAfternoon.Checked == true || chkMonEvening.Checked == true ||
                chkTueMorning.Checked == true || chkTueMidday.Checked == true || chkTueAfternoon.Checked == true || chkTueEvening.Checked == true ||
                chkWedMorning.Checked == true || chkWedMidday.Checked == true || chkWedAfternoon.Checked == true || chkWedEvening.Checked == true ||
                chkThuMorning.Checked == true || chkThuMidday.Checked == true || chkThuAfternoon.Checked == true || chkThuEvening.Checked == true ||
                chkFriMorning.Checked == true || chkFriMidday.Checked == true || chkFriAfternoon.Checked == true || chkFriEvening.Checked == true ||
                chkSatMorning.Checked == true || chkSatMidday.Checked == true || chkSatAfternoon.Checked == true || chkSatEvening.Checked == true ||
                chkSunMorning.Checked == true || chkSunMidday.Checked == true || chkSunAfternoon.Checked == true || chkSunEvening.Checked == true)
            {
                btnScheduleApptName.Enabled = true;
                btnClear.Enabled = true;
            }
            else
            {
                btnScheduleApptName.Enabled = false;
                btnClear.Enabled = false;
            }
        }

        //Display the appointments for that current student in datagridview on the home tab
        public void displayAppointment()
        {
            using (var context = new db_sft_2172Entities())
            {
                List<ViewSession> appointment = new List<ViewSession>();
                var userQuery = from sr in context.SessionRosters
                                where sr.UserID.Equals(Program.CurrentUser)
                                select sr;
                var userResult = userQuery.ToList();
                foreach (var u in userResult)
                {
                    //appointment.Add(u);
                    var session = from s in context.ViewSessions
                                  where s.SessionID.Equals(u.SessionID)
                                  select s;
                                  
                    var sessionResult = session.ToList();
                    foreach (var s in sessionResult)
                    {
                        appointment.Add(s);
                    }
                }
                if (appointment.Count() > 0)
                {
                    try
                    {
                        dgrShowAppointments.Visible = true;
                        dgrShowAppointments.DataSource = appointment;
                        appointmentMessage.Visible = false;
                        btnCancelCoach.Enabled = true;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
                else
                {
                    dgrShowAppointments.Visible = false;
                    appointmentMessage.Visible = true;
                    btnCancelCoach.Enabled = false;
                }
            }
        }

        //Reset password button click
        private void btnResetPassowrd_Click(object sender, EventArgs e)
        {
            ResetStudentPassword resetForm = new ResetStudentPassword(this);
            resetForm.Show();
            this.Hide();
        }

        //Edit profile button click
        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            EditStudentProfileForm editForm = new EditStudentProfileForm(this);
            editForm.Show();
            this.Hide();
        }

        //Search by time clicked button
        private void btnSearchByTime_Click(object sender, EventArgs e)
        {
            coachTimeQuery();
        }

        //To query the search after cliking the Search by Time button
        private void coachTimeQuery()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Access view and pull data
                    var coachByTimeQuery =
                        from coachTimes in context.CoachByTimes
                        select coachTimes;

                    var timeQuery = coachByTimeQuery.Where(t => t.Time == "None");

                    if (this.chkMorning.Checked)
                    {
                        timeQuery = timeQuery.Union(coachByTimeQuery.Where(t => t.Time == "Morning"));
                    }

                    if (this.chkMidday.Checked)
                    {
                        timeQuery = timeQuery.Union(coachByTimeQuery.Where(t => t.Time == "Midday"));
                    }

                    if (this.chkAfternoon.Checked)
                    {
                        timeQuery = timeQuery.Union(coachByTimeQuery.Where(t => t.Time == "Afternoon"));
                    }

                    if (this.chkEvening.Checked)
                    {
                        timeQuery = timeQuery.Union(coachByTimeQuery.Where(t => t.Time == "Evening"));
                    }

                    // Work through "day" query
                    var dayQuery = coachByTimeQuery.Where(t => t.Day == "None");


                    if (this.chkMon.Checked)
                    {
                        dayQuery = dayQuery.Union(coachByTimeQuery.Where(t => t.Day == "Monday"));
                    }

                    if (this.chkTue.Checked)
                    {
                        dayQuery = dayQuery.Union(coachByTimeQuery.Where(t => t.Day == "Tuesday"));
                    }

                    if (this.chkWed.Checked)
                    {
                        dayQuery = dayQuery.Union(coachByTimeQuery.Where(t => t.Day == "Wednesday"));
                    }

                    if (this.chkThu.Checked)
                    {
                        dayQuery = dayQuery.Union(coachByTimeQuery.Where(d => d.Day == "Thursday"));
                    }

                    if (this.chkFri.Checked)
                    {
                        dayQuery = dayQuery.Union(coachByTimeQuery.Where(d => d.Day == "Friday"));
                    }

                    if (this.chkSat.Checked)
                    {
                        dayQuery = dayQuery.Union(coachByTimeQuery.Where(d => d.Day == "Saturday"));
                    }

                    if (this.chkSun.Checked)
                    {
                        dayQuery = dayQuery.Union(coachByTimeQuery.Where(d => d.Day == "Sunday"));
                    }


                    // Add results to data grid view
                    if ((this.chkSun.Checked || this.chkMon.Checked || this.chkTue.Checked ||
                         this.chkWed.Checked || this.chkThu.Checked || this.chkFri.Checked || this.chkSat.Checked) &&
                        (this.chkMorning.Checked || this.chkMidday.Checked || this.chkAfternoon.Checked || this.chkEvening.Checked))
                    {
                        dataGridCoachesByTime.DataSource = dayQuery.Intersect(timeQuery).ToList();
                    }
                    else if (this.chkSun.Checked || this.chkMon.Checked || this.chkTue.Checked ||
                             this.chkWed.Checked || this.chkThu.Checked || this.chkFri.Checked || this.chkSat.Checked)
                    {
                        dataGridCoachesByTime.DataSource = dayQuery.ToList();
                    }
                    else if (this.chkMorning.Checked || this.chkMidday.Checked || this.chkAfternoon.Checked || this.chkEvening.Checked)
                    {
                        dataGridCoachesByTime.DataSource = timeQuery.ToList();
                    }
                    else // nothing should be selected
                    {
                        dataGridCoachesByTime.DataSource = coachByTimeQuery.ToList();
                    }

                    dataGridCoachesByTime.Columns["UserID"].Visible = false;
                    dataGridCoachesByTime.Columns["UserID"].DisplayIndex = 0;
                    dataGridCoachesByTime.Columns["Coach"].DisplayIndex = 1;
                    dataGridCoachesByTime.Columns["Time"].DisplayIndex = 2;
                    dataGridCoachesByTime.Columns["Day"].DisplayIndex = 3;
                    dataGridCoachesByTime.Columns["Subject"].DisplayIndex = 4;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return;
        }


        //Assign a coach clicked button on the Search by Time tab
        private void btnScheduleAppointment_Click(object sender, EventArgs e)
        {
            string selectedCoachID;
            string selectedCoachName;
            string selectedTime;
            string selectedDay;
            string selectedCourseID;
            string selectedCourse;


            if (dataGridCoachesByTime.SelectedRows == null)
            {
                MessageBox.Show("Please select a row before continuing");
                return;
            }
            else
            {
                DataGridViewRow selectedRow = dataGridCoachesByTime.SelectedRows[0];
                selectedCoachID = selectedRow.Cells[0].Value.ToString();
                selectedCoachName = selectedRow.Cells[1].Value.ToString();
                selectedTime = selectedRow.Cells[2].Value.ToString();
                selectedDay = selectedRow.Cells[3].Value.ToString();
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
                                /////TODO: Stub to handle saving data to database (add linq query)
                                SessionRoster sr = new SessionRoster()
                                {
                                    SessionID = userResult.SessionID,
                                    UserID = Program.CurrentUser,
                                    RoleID = "STUD"
                                };
                                context.SessionRosters.Add(sr);
                                context.SaveChanges();
                                displayAppointment();
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

            return;
        }

        //Assign a coach clicked button on the Search by Name tab
        private void btnScheduleApptName_Click(object sender, EventArgs e)
        {
            string selectedCoachID;
            string selectedCoachName;
            string selectedTime;
            string selectedDay;
            string selectedCourseID;
            string selectedCourseName;

            selectedCoachName = lblCoachName.Text;
            if (chkMonMorning.Checked == true)
            {
                selectedDay = "Monday";
                selectedTime = "Morning";
            }
            else if(chkMonMidday.Checked == true)
            {
                selectedDay = "Monday";
                selectedTime = "Midday";
            }
            else if (chkMonAfternoon.Checked == true)
            {
                selectedDay = "Monday";
                selectedTime = "Afternoon";
            }
            else if (chkMonEvening.Checked == true)
            {
                selectedDay = "Monday";
                selectedTime = "Evening";
            }
            else if (chkTueMorning.Checked == true)
            {
                selectedDay = "Tuesday";
                selectedTime = "Morning";
            }
            else if (chkTueMidday.Checked == true)
            {
                selectedDay = "Tuesday";
                selectedTime = "Midday";
            }
            else if (chkTueAfternoon.Checked == true)
            {
                selectedDay = "Tuesday";
                selectedTime = "Afternoon";
            }
            else if (chkTueEvening.Checked == true)
            {
                selectedDay = "Tuesday";
                selectedTime = "Evening";
            }
            else if (chkWedMorning.Checked == true)
            {
                selectedDay = "Wednesday";
                selectedTime = "Morning";
            }
            else if (chkWedMidday.Checked == true)
            {
                selectedDay = "Wednesday";
                selectedTime = "Midday";
            }
            else if (chkWedAfternoon.Checked == true)
            {
                selectedDay = "Wednesday";
                selectedTime = "Afternoon";
            }
            else if (chkWedEvening.Checked == true)
            {
                selectedDay = "Wednesday";
                selectedTime = "Evening";
            }
            else if (chkThuMorning.Checked == true)
            {
                selectedDay = "Thursday";
                selectedTime = "Morning";
            }
            else if (chkThuMidday.Checked == true)
            {
                selectedDay = "Thursday";
                selectedTime = "Midday";
            }
            else if (chkThuAfternoon.Checked == true)
            {
                selectedDay = "Thursday";
                selectedTime = "Afternoon";
            }
            else if (chkThuEvening.Checked == true)
            {
                selectedDay = "Thursday";
                selectedTime = "Evening";
            }
            else if (chkFriMorning.Checked == true)
            {
                selectedDay = "Friday";
                selectedTime = "Morning";
            }
            else if (chkFriMidday.Checked == true)
            {
                selectedDay = "Friday";
                selectedTime = "Midday";
            }
            else if (chkFriAfternoon.Checked == true)
            {
                selectedDay = "Friday";
                selectedTime = "Afternoon";
            }
            else if (chkFriEvening.Checked == true)
            {
                selectedDay = "Friday";
                selectedTime = "Evening";
            }
            else if (chkSatMorning.Checked == true)
            {
                selectedDay = "Saturday";
                selectedTime = "Morning";
            }
            else if (chkSatMidday.Checked == true)
            {
                selectedDay = "Saturday";
                selectedTime = "Midday";
            }
            else if (chkSatAfternoon.Checked == true)
            {
                selectedDay = "Saturday";
                selectedTime = "Afternoon";
            }
            else if (chkSatEvening.Checked == true)
            {
                selectedDay = "Saturday";
                selectedTime = "Evening";
            }
            else if (chkSunMorning.Checked == true)
            {
                selectedDay = "Sunday";
                selectedTime = "Morning";
            }
            else if (chkSunMidday.Checked == true)
            {
                selectedDay = "Sunday";
                selectedTime = "Midday";
            }
            else if (chkSunAfternoon.Checked == true)
            {
                selectedDay = "Sunday";
                selectedTime = "Afternoon";
            }
            else if (chkSunEvening.Checked == true)
            {
                selectedDay = "Sunday";
                selectedTime = "Evening";
            }
            else
            {
                MessageBox.Show("Please choose a time period!");
                return;
            }
            using (db_sft_2172Entities context = new db_sft_2172Entities())
            {
                var coach = from c in context.ViewSessions
                            where c.Coach.Equals(selectedCoachName) && c.Day.Equals(selectedDay) && c.Time.Equals(selectedTime)
                            select c;
                var result = coach.FirstOrDefault<ViewSession>();
                selectedCoachID = result.UserID;
                selectedCourseID = result.Course;
                selectedCourseName = result.CourseName;

                DialogResult resultBox = MessageBox.Show(
                   "Are you sure you want to assign with this coach?\n"
                       + "Coach: " + selectedCoachName + "\n"
                       + "Time: " + selectedTime + "\n"
                       + "Day: " + selectedDay + "\n"
                       + "Course ID: " + selectedCourseID + "\n"
                       + "Selected Course: " + selectedCourseName,
                   "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultBox == DialogResult.No)
                {
                    return;
                }
                else
                {
                    try
                    {
                        var checkSessionRoster = from sessionRoster in context.SessionRosters
                                                 where sessionRoster.UserID.Equals(Program.CurrentUser) && sessionRoster.SessionID.Equals(result.SessionID)
                                                 select sessionRoster;
                        if (checkSessionRoster.Any())
                        {
                            MessageBox.Show("This sessional coach has been assigned already.");
                        }
                        else
                        {
                            SessionRoster sr = new SessionRoster()
                            {
                                SessionID = result.SessionID,
                                UserID = Program.CurrentUser,
                                RoleID = "STUD"
                            };
                            context.SessionRosters.Add(sr);
                            context.SaveChanges();
                            displayAppointment();
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                    }
                }
            }
        }
        
        //Logout clicked button on the stutend home tab
        private void btnStdLogout_Click(object sender, EventArgs e)
        {
            Program.loginForm.logout();

            // Close this window
            this.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            enableButtons();
        }

        //Clear button on the Search by Name tab to clear all checkboxes
        private void btnClear_Click(object sender, EventArgs e)
        {
            unCheckedDayPeriods();
        }

        private void btnClearByTime_Click(object sender, EventArgs e)
        {
            chkMon.Checked = false;
            chkTue.Checked = false;
            chkThu.Checked = false;
            chkWed.Checked = false;
            chkSat.Checked = false;
            chkSun.Checked = false;
            chkMorning.Checked = false;
            chkMidday.Checked = false;
            chkAfternoon.Checked = false;
            chkEvening.Checked = false;
        }

        //Event handler to logout the program event if the main form is closed
        private void FindCoachForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.loginForm.logout();
        }

        //Cancel the sessional coach
        private void btnCancelCoach_Click(object sender, EventArgs e)
        {
            string selectedCoachID;
            string selectedSessionID;
            string selectedTime;
            string selectedDay;
            string selectedCourseID;

            if (dgrShowAppointments.SelectedRows == null)
            {
                MessageBox.Show("Please select a row before continuing");
                return;
            }
            else
            {
                DataGridViewRow selectedRow = dgrShowAppointments.SelectedRows[0];
                selectedSessionID = selectedRow.Cells[0].Value.ToString();
                selectedCourseID = selectedRow.Cells[1].Value.ToString();
                selectedDay = selectedRow.Cells[3].Value.ToString();
                selectedTime = selectedRow.Cells[4].Value.ToString();
                selectedCoachID = selectedRow.Cells[5].Value.ToString();

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to cancel the this coach?\n\n"
                        + "Coach ID: " + selectedCoachID + "\n"
                        + "Session ID: " + selectedSessionID + "\n"
                        + "Time: " + selectedTime + "\n"
                        + "Day: " + selectedDay + "\n"
                        + "Course ID: " + selectedCourseID,
                        
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    using (db_sft_2172Entities context = new db_sft_2172Entities())
                    {
                        int sessionID = int.Parse(selectedSessionID);

                        try
                        {
                            var sr = (from srt in context.SessionRosters
                                      where srt.SessionID.Equals(sessionID) && srt.UserID.Equals(Program.CurrentUser)
                                      select srt).SingleOrDefault();
                            context.SessionRosters.Remove(sr);
                            context.SaveChanges();
                            displayAppointment();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }  
                    }  
                }
            }
            return;
        }
    }
}