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
            }
        }

        //Display phone number in the phone format
        //private string displayPhoneFormat(string phone)
        //{
        //    string p = phone;
        //    string formatedPhoneNumber = string.Format("({0}) {1}-{2}", p.Substring(0, 3), p.Substring(3, 3), p.Substring(6, 4));
        //    return formatedPhoneNumber;
        //}
        //Display all available coaches on the combobox
        private void displayCoachList()
        {
            using (var context = new db_sft_2172Entities())
            {
                var userQuery = (from u in context.Users
                                 where u.IsCoach.Equals(true)
                                 select u.FirstName).ToList();

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
            seachForCoach(selectedCoach);
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
                                where u.IsCoach.Equals(true) && u.FirstName.Equals(coach)
                                select u;
                var userResult = userQuery.FirstOrDefault<User>();
                try
                {
                    if (!String.IsNullOrEmpty(userResult.FirstName))
                    {
                        panelCoach.Visible = true;
                        var request = System.Net.WebRequest.Create(userResult.ProfilePic);

                        using (var response = request.GetResponse())
                        using (var stream = response.GetResponseStream())
                        {
                            pictureBoxCoachProfile.Image = Bitmap.FromStream(stream);
                        }
                        lblCoachName.Text = userResult.FirstName + " " + userResult.LastName;
                        lblActiveCoach.Text = userResult.ActiveCoachSince.ToString();
                        lblEmail.Text = userResult.Email;
                        lblPhone.Text = userResult.Phone;

                        //display the day 
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
            using (var context = new db_sft_2172Entities())
            {
                var userQuery = from vs in context.ViewSessions
                                where vs.Coach.Equals(coach)
                                select vs;
                // var userResult = userQuery.FirstOrDefault<Session>();
                try
                {
                    if (userQuery.Any())
                    {
                        lblMessage.Text = "To make an appointment, Please select a day period bellow.";
                        var userResult = userQuery.FirstOrDefault<ViewSession>();
                        
                        if (userResult.Day.Equals("Monday"))
                        {
                            Monday.Enabled = true;
                        }
                        else
                        {
                            Monday.Enabled = false;
                        }
                        if (userResult.Day.Equals("Tuesday"))
                        {
                            Tuesday.Enabled = true;
                        }
                        else
                        {
                            Tuesday.Enabled = false;
                        }
                        if (userResult.Day.Equals("Wednesday"))
                        {
                            Wednesday.Enabled = true;
                        }
                        else
                        {
                            Wednesday.Enabled = false;
                        }
                        if (userResult.Day.Equals("Thursday"))
                        {
                            Thursday.Enabled = true;
                        }
                        else
                        {
                            Thursday.Enabled = false;
                        }
                        if (userResult.Day.Equals("Friday"))
                        {
                            Friday.Enabled = true;
                        }
                        else
                        {
                            Friday.Enabled = false;
                        }
                        if (userResult.Day.Equals("Saturday"))
                        {
                            Saturday.Enabled = true;
                        }
                        else
                        {
                            Saturday.Enabled = false;
                        }
                        if (userResult.Day.Equals("Sunday"))
                        {
                            Sunday.Enabled = true;
                        }
                        else
                        {
                            Sunday.Enabled = false;
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

        //Display the appointments for that student in datagridview
        private void displayAppointment()
        {
            using (var context = new db_sft_2172Entities())
            {
                List<CoachByTime> appointment = new List<CoachByTime>();
                var userQuery = from u in context.CoachByTimes
                                where u.UserID.Equals(Program.CurrentUser)
                                select u;
                var userResult = userQuery.ToList();
                foreach (var u in userResult)
                {
                    appointment.Add(u);
                }
                if (appointment.Count() > 0)
                {
                    dgrShowAppointments.Visible = true;
                    dgrShowAppointments.DataSource = appointment;
                    appointmentMessage.Visible = false;
                }
                else
                {
                    dgrShowAppointments.Visible = false;
                    appointmentMessage.Visible = true;
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

        private void btnSearchByTime_Click(object sender, EventArgs e)
        {
            coachTimeQuery();
        }

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
                    /////TODO: Stub to handle saving data to database (add linq query)
                    SessionRoster sr = new SessionRoster();
                    ////{
                    ////    SessionID = "WEB10152154MonAM",
                    ////    UserID = selectedCoachID,
                    ////    RoleID = "STUD"
                    ////};

                    using (db_sft_2172Entities context = new db_sft_2172Entities())
                    {
                        try
                        {
                            context.SessionRosters.Add(sr);
                            context.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                }
            }

            return;
        }

        private void btnScheduleApptName_Click(object sender, EventArgs e)
        {
            /*
            string selectedCoachID;
            string selectedCoachName;
            string selectedTime;
            string selectedDay;
            string selectedCourseID;
            string selectedCourse;

            try
            {

                if (dataGridCoachesByTime.SelectedRows == null)
                {
                    MessageBox.Show("Please select a row before continuing");
                    return;
                }
                else
                {
                    DataGridViewRow selectedRow = dataGridCoachAvailability.SelectedRows[0];
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
                        ///TODO: Stub to handle saving data to database (add linq query)
                        SessionRoster sr = new SessionRoster()
                        {
                            SessionID = "WEB10152154MonAM",
                            UserID = selectedCoachID,
                            RoleID = "Student"
                        };

                        using (var context = new db_sft_2172Entities())
                        {
                            try
                            {
                                context.SessionRosters.Add(sr);
                                context.SaveChanges();
                            }
                            catch (Exception ex)
                            {
                                ex.ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return;
            */
        }

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

        private void FindCoachForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.loginForm.logout();
        }
    }
}