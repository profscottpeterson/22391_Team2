// <copyright file="FindCoachForm.cs" company="PABT at NWTC">
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
    /// A form that allows student users to search for coaching sessions and enroll in them.
    /// </summary>
    public partial class FindCoachForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FindCoachForm"/> class.
        /// </summary>
        public FindCoachForm()
        {
            this.InitializeComponent();
            this.DisplayInfo();
            this.DisplayCoachList();
            this.DisplayAppointment();
            this.panelCoach.Visible = false;
        }

        /// <summary>
        /// Display the appointments for that current student in data grid view on the home tab
        /// </summary>
        public void DisplayAppointment()
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
                    try
                    {
                        var session = from s in context.ViewSessions
                                      where s.SessionID.Equals(u.SessionID)
                                      select s;

                        var sessionResult = session.ToList();

                        foreach (var s in sessionResult)
                        {
                            appointment.Add(s);
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }

                if (appointment.Any())
                {
                    try
                    {
                        this.dgrShowAppointments.Visible = true;
                        this.dgrShowAppointments.DataSource = appointment;
                        this.appointmentMessage.Visible = false;
                        this.btnCancelSession.Enabled = true;
                        this.dgrShowAppointments.Columns["SessionID"].Visible = false;
                        this.dgrShowAppointments.Columns["Room"].Visible = false;
                        this.dgrShowAppointments.Columns["UserID"].Visible = false;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
                else
                {
                    this.dgrShowAppointments.Visible = false;
                    this.appointmentMessage.Visible = true;
                    this.btnCancelSession.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Select a coach from interested dropdown list.
        /// </summary>
        /// <param name="interest">The interest to join.</param>
        /// <param name="title">The title to join.</param>
        private void SelectedInterest(Image interest, string title)
        {
            this.Hide();
            FrmCoachInterest frm2 = new FrmCoachInterest(this, interest, title);
            frm2.Location = this.Location;
            frm2.ShowDialog();
            this.DisplayAppointment();
        }

        /// <summary>
        /// Event handler to select coaches belonging to the Agriculture.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnAgriClick(object sender, EventArgs e)
        {
            this.SelectedInterest(this.btnAgri.BackgroundImage, this.lblAgri.Text);
        }

        /// <summary>
        /// Event handler to select coaches belonging to the Architecture.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnArchClick(object sender, EventArgs e)
        {
            this.SelectedInterest(this.btnArch.BackgroundImage, this.lblArch.Text);
        }

        /// <summary>
        /// Event handler to select coaches belonging to the Business.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnBusinessClick(object sender, EventArgs e)
        {
            this.SelectedInterest(this.btnBusiness.BackgroundImage, this.lblBusiness.Text);
        }

        /// <summary>
        /// Event handler to select coaches belonging to the Digital.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnDigitalClick(object sender, EventArgs e)
        {
            this.SelectedInterest(this.btnDigital.BackgroundImage, this.lblDigital.Text);
        }

        /// <summary>
        /// Event handler to select coaches belonging to the Energy.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnEnergyClick(object sender, EventArgs e)
        {
            this.SelectedInterest(this.btnEnergy.BackgroundImage, this.lblEnergy.Text);
        }

        /// <summary>
        /// Event handler to select coaches belonging to the General.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnGeneralClick(object sender, EventArgs e)
        {
            this.SelectedInterest(this.btnGeneral.BackgroundImage, this.lblGeneral.Text);
        }

        /// <summary>
        /// Event handler to select coaches belonging to the Health.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BthHealthClick(object sender, EventArgs e)
        {
            this.SelectedInterest(this.btnHealth.BackgroundImage, this.lblHealth.Text);
        }

        /// <summary>
        /// Event handler to select coaches belonging to the Human Resource.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnHumanClick(object sender, EventArgs e)
        {
            this.SelectedInterest(this.btnHuman.BackgroundImage, this.lblHuman.Text);
        }

        /// <summary>
        /// Event handler to select coaches belonging to the IT.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnITClick(object sender, EventArgs e)
        {
            this.SelectedInterest(this.btnIT.BackgroundImage, this.lblIT.Text);
        }

        /// <summary>
        /// Event handler to select coaches belonging to the Law.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnLawClick(object sender, EventArgs e)
        {
            this.SelectedInterest(this.btnLaw.BackgroundImage, this.lblLaw.Text);
        }

        /// <summary>
        /// Event handler to select coaches belonging to the Menu.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnManuClick(object sender, EventArgs e)
        {
            this.SelectedInterest(this.btnManu.BackgroundImage, this.lblManu.Text);
        }

        /// <summary>
        /// Event handler to select coaches belonging to the Science.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnScienceClick(object sender, EventArgs e)
        {
            this.SelectedInterest(this.btnScience.BackgroundImage, this.lblScience.Text);
        }

        /// <summary>
        /// Event handler to select coaches belonging to the Transport.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnTransportClick(object sender, EventArgs e)
        {
            this.SelectedInterest(this.btnTransport.BackgroundImage, this.lblTransport.Text);
        }

        /// <summary>
        /// Disiplay student info to the home tab
        /// </summary>
        private void DisplayInfo()
        {
            using (var context = new db_sft_2172Entities())
            {
                var userQuery = from u in context.Users
                                where u.UserID.Equals(Program.CurrentUser)
                                select u; 
                var userResult = userQuery.FirstOrDefault<User>();
                this.lblStdID.Text = userResult.UserID;
                this.lblStdName.Text = userResult.DisplayName;
                this.lblStdEmail.Text = userResult.Email;
                this.lblStdPhone.Text = userResult.Phone;
                var request = System.Net.WebRequest.Create(userResult.ProfilePic);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    this.pictureBoxStdProfile.Image = Bitmap.FromStream(stream);
                }

                var userCourse = from c in context.Courses
                                 join uc in context.UserCourses on c.CourseID equals uc.CourseID
                                 where uc.UserID.Equals(userResult.UserID)
                                 select c.CourseName;
                if (!userCourse.Any())
                {
                    this.lblRegisterStatusMessage.Visible = true;
                    this.listBoxCourse.Visible = false;
                }
                else
                {
                    this.lblRegisterStatusMessage.Visible = false;
                    this.listBoxCourse.Visible = true;

                    foreach (var c in userCourse.ToList())
                    {
                        this.listBoxCourse.Items.Add(c);
                    }
                }
            }
        }
        
        /// <summary>
        /// Display coaches in the dropdown comboBox
        /// </summary>
        private void DisplayCoachList()
        {
            using (var context = new db_sft_2172Entities())
            {
                var userQuery = (from u in context.Users
                                 join s in context.Sessions on u.UserID equals s.CoachID
                                 where u.IsCoach.Equals(true)
                                 orderby u.DisplayName 
                                 select u.DisplayName).ToList().Distinct();

                foreach (var c in userQuery)
                {
                    this.comboBoxCoaches.Items.Add(c);
                }
            }
        }

        /// <summary>
        /// Event handler to search for specific coach from the database.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnSearchByNameClick(object sender, EventArgs e)
        {
            string selectedCoach = this.comboBoxCoaches.SelectedItem.ToString();
            this.UnCheckedDayPeriods();
            this.DisableChkPeriod();
            this.SearchForCoach(selectedCoach);
        }

        /// <summary>
        /// To disable checkboxes on the Coach by Name tab.
        /// </summary>
        private void DisableChkPeriod()
        {
            this.chkMonMorning.Enabled = false;
            this.chkMonMidday.Enabled = false;
            this.chkMonAfternoon.Enabled = false;
            this.chkMonEvening.Enabled = false;

            this.chkTueMorning.Enabled = false;
            this.chkTueMidday.Enabled = false;
            this.chkTueAfternoon.Enabled = false;
            this.chkTueEvening.Enabled = false;

            this.chkWedMorning.Enabled = false;
            this.chkWedMidday.Enabled = false;
            this.chkWedAfternoon.Enabled = false;
            this.chkWedEvening.Enabled = false;

            this.chkThuMorning.Enabled = false;
            this.chkThuMidday.Enabled = false;
            this.chkThuAfternoon.Enabled = false;
            this.chkThuEvening.Enabled = false;

            this.chkFriMorning.Enabled = false;
            this.chkFriMidday.Enabled = false;
            this.chkFriAfternoon.Enabled = false;
            this.chkFriEvening.Enabled = false;

            this.chkSatMorning.Enabled = false;
            this.chkSatMidday.Enabled = false;
            this.chkSatAfternoon.Enabled = false;
            this.chkSatEvening.Enabled = false;

            this.chkSunMorning.Enabled = false;
            this.chkSunMidday.Enabled = false;
            this.chkSunAfternoon.Enabled = false;
            this.chkSunEvening.Enabled = false;
        }

        /// <summary>
        /// Called in the unchecked day period method to clear the check boxes first.
        /// </summary>
        private void UnCheckedDayPeriods()
        {
            this.chkMonMorning.Checked = false;
            this.chkMonMidday.Checked = false;
            this.chkMonAfternoon.Checked = false;
            this.chkMonEvening.Checked = false;

            this.chkTueMorning.Checked = false;
            this.chkTueMidday.Checked = false;
            this.chkTueAfternoon.Checked = false;
            this.chkTueEvening.Checked = false;

            this.chkWedMorning.Checked = false;
            this.chkWedMidday.Checked = false;
            this.chkWedAfternoon.Checked = false;
            this.chkWedEvening.Checked = false;

            this.chkThuMorning.Checked = false;
            this.chkThuMidday.Checked = false;
            this.chkThuAfternoon.Checked = false;
            this.chkThuEvening.Checked = false;

            this.chkFriMorning.Checked = false;
            this.chkFriMidday.Checked = false;
            this.chkFriAfternoon.Checked = false;
            this.chkFriEvening.Checked = false;

            this.chkSatMorning.Checked = false;
            this.chkSatMidday.Checked = false;
            this.chkSatAfternoon.Checked = false;
            this.chkSatEvening.Checked = false;

            this.chkSunMorning.Checked = false;
            this.chkSunMidday.Checked = false;
            this.chkSunAfternoon.Checked = false;
            this.chkSunEvening.Checked = false;

            // Disable buttons when search a new coach
            btnScheduleApptName.Enabled = false;
            btnClear.Enabled = false;
        }

        /// <summary>
        /// Called in the btnSearchByName to find a specific coach's sessions .
        /// </summary>
        /// <param name="coach">The name of the selected coach</param>
        private void SearchForCoach(string coach)
        {
            using (var context = new db_sft_2172Entities())
            {
                var userQuery = from u in context.Users
                                where u.IsCoach.Equals(true) && u.DisplayName.Equals(coach)
                                select u;
                var userResult = userQuery.FirstOrDefault<User>();

                try
                {
                    if (!string.IsNullOrEmpty(userResult.DisplayName))
                    {
                        this.panelCoach.Visible = true;
                        var request = System.Net.WebRequest.Create(userResult.ProfilePic);

                        using (var response = request.GetResponse())
                        using (var stream = response.GetResponseStream())
                        {
                            pictureBoxCoachProfile.Image = Bitmap.FromStream(stream);
                        }

                        this.lblCoachName.Text = userResult.DisplayName;
                        this.lblActiveCoach.Text = userResult.ActiveCoachSince.ToString();
                        this.lblEmail.Text = userResult.Email;
                        this.lblPhone.Text = userResult.Phone;

                        // Display the day period by coach
                        this.SearchCoachOnSession(userResult.DisplayName);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        /// <summary>
        /// Search for available coach by session.
        /// </summary>
        /// <param name="coach">The name of the current selected coach.</param>
        private void SearchCoachOnSession(string coach)
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

                        foreach (var userResult in userR)
                        {
                            listBoxDisplayCoachSubject.Items.Add(userResult.Course);
                            if (userResult.Day.Equals("monday"))
                            {
                                this.monday.Enabled = true;
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
                            else if (userResult.Day.Equals("tuesday"))
                            {
                                this.tuesday.Enabled = true;
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
                            else if (userResult.Day.Equals("wednesday"))
                            {
                                this.wednesday.Enabled = true;
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
                            else if (userResult.Day.Equals("thursday"))
                            {
                                this.thursday.Enabled = true;
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
                            else if (userResult.Day.Equals("friday"))
                            {
                                this.friday.Enabled = true;
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
                            else if (userResult.Day.Equals("saturday"))
                            {
                                this.saturday.Enabled = true;
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
                            else if (userResult.Day.Equals("sunday"))
                            {
                                this.sunday.Enabled = true;
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
                                this.monday.Enabled = false;
                                this.tuesday.Enabled = false;
                                this.wednesday.Enabled = false;
                                this.thursday.Enabled = false;
                                this.friday.Enabled = false;
                                this.saturday.Enabled = false;
                                this.sunday.Enabled = false;
                            }
                        }  
                    }
                    else
                    {
                        this.monday.Enabled = false;
                        this.tuesday.Enabled = false;
                        this.wednesday.Enabled = false;
                        this.thursday.Enabled = false;
                        this.friday.Enabled = false;
                        this.saturday.Enabled = false;
                        this.sunday.Enabled = false;
                        lblMessage.Text = "This coach is not available in this session, Please choose another coach.";
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        /// <summary>
        /// Method used to Enable buttons.
        /// </summary>
        private void EnableButtons()
        {
            if (chkMonMorning.Checked || chkMonMidday.Checked || chkMonAfternoon.Checked || chkMonEvening.Checked ||
                chkTueMorning.Checked || chkTueMidday.Checked || chkTueAfternoon.Checked || chkTueEvening.Checked ||
                chkWedMorning.Checked || chkWedMidday.Checked || chkWedAfternoon.Checked || chkWedEvening.Checked ||
                chkThuMorning.Checked || chkThuMidday.Checked || chkThuAfternoon.Checked || chkThuEvening.Checked ||
                chkFriMorning.Checked || chkFriMidday.Checked || chkFriAfternoon.Checked || chkFriEvening.Checked ||
                chkSatMorning.Checked || chkSatMidday.Checked || chkSatAfternoon.Checked || chkSatEvening.Checked ||
                chkSunMorning.Checked || chkSunMidday.Checked || chkSunAfternoon.Checked || chkSunEvening.Checked)
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

        /// <summary>
        /// Event handler to reset password button click.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnResetPasswordClick(object sender, EventArgs e)
        {
            ResetStudentPassword resetForm = new ResetStudentPassword(this);
            resetForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Event handler to edit profile button click.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnEditProfileClick(object sender, EventArgs e)
        {
            this.Hide();
            EditStudentProfileForm editForm = new EditStudentProfileForm(this);
            editForm.Location = this.Location;
            editForm.ShowDialog();
            this.DisplayInfo();
        }

        /// <summary>
        /// Event handler to earch by time clicked button.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnSearchByTimeClick(object sender, EventArgs e)
        {
            this.CoachTimeQuery();
        }

        /// <summary>
        /// Method to query the search after cliking the Search by Time button.
        /// </summary>
        private void CoachTimeQuery()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Access view and pull data
                    var coachByTimeQuery =
                        from coachTimes in context.ViewSessions
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
                        dayQuery = dayQuery.Union(coachByTimeQuery.Where(t => t.Day == "monday"));
                    }

                    if (this.chkTue.Checked)
                    {
                        dayQuery = dayQuery.Union(coachByTimeQuery.Where(t => t.Day == "tuesday"));
                    }

                    if (this.chkWed.Checked)
                    {
                        dayQuery = dayQuery.Union(coachByTimeQuery.Where(t => t.Day == "wednesday"));
                    }

                    if (this.chkThu.Checked)
                    {
                        dayQuery = dayQuery.Union(coachByTimeQuery.Where(d => d.Day == "thursday"));
                    }

                    if (this.chkFri.Checked)
                    {
                        dayQuery = dayQuery.Union(coachByTimeQuery.Where(d => d.Day == "friday"));
                    }

                    if (this.chkSat.Checked)
                    {
                        dayQuery = dayQuery.Union(coachByTimeQuery.Where(d => d.Day == "saturday"));
                    }

                    if (this.chkSun.Checked)
                    {
                        dayQuery = dayQuery.Union(coachByTimeQuery.Where(d => d.Day == "sunday"));
                    }

                    // Add results to data grid view.
                    if ((this.chkSun.Checked || this.chkMon.Checked || this.chkTue.Checked ||
                         this.chkWed.Checked || this.chkThu.Checked || this.chkFri.Checked || this.chkSat.Checked) &&
                        (this.chkMorning.Checked || this.chkMidday.Checked || this.chkAfternoon.Checked || this.chkEvening.Checked))
                    {
                        this.dataGridSessionsByTime.DataSource = dayQuery.Intersect(timeQuery).ToList();
                    }
                    else if (this.chkSun.Checked || this.chkMon.Checked || this.chkTue.Checked ||
                             this.chkWed.Checked || this.chkThu.Checked || this.chkFri.Checked || this.chkSat.Checked)
                    {
                        this.dataGridSessionsByTime.DataSource = dayQuery.ToList();
                    }
                    else if (this.chkMorning.Checked || this.chkMidday.Checked || this.chkAfternoon.Checked || this.chkEvening.Checked)
                    {
                        this.dataGridSessionsByTime.DataSource = timeQuery.ToList();
                    }
                    else
                    {
                        this.dataGridSessionsByTime.DataSource = coachByTimeQuery.ToList();
                    }

                    this.dataGridSessionsByTime.Columns["UserID"].Visible = false;
                    this.dataGridSessionsByTime.Columns["Room"].Visible = false;
                    this.dataGridSessionsByTime.Columns["UserID"].DisplayIndex = 0;
                    this.dataGridSessionsByTime.Columns["Coach"].DisplayIndex = 1;
                    this.dataGridSessionsByTime.Columns["Time"].DisplayIndex = 2;
                    this.dataGridSessionsByTime.Columns["Day"].DisplayIndex = 3;
                    this.dataGridSessionsByTime.Columns["CourseName"].DisplayIndex = 4;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return;
        }

        /// <summary>
        /// Event handler to assign a coach clicked button on the Search by Time tab.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnScheduleAppointmentClick(object sender, EventArgs e)
        {
            if (this.dataGridSessionsByTime.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a row before continuing");
                return;
            }

            DataGridViewRow selectedRow = this.dataGridSessionsByTime.SelectedRows[0];
            string selectedCoachID = selectedRow.Cells[7].Value.ToString();
            string selectedCoachName = selectedRow.Cells[2].Value.ToString();
            string selectedTime = selectedRow.Cells[6].Value.ToString();
            string selectedDay = selectedRow.Cells[5].Value.ToString();
            string selectedCourseID = selectedRow.Cells[0].Value.ToString();
            string selectedCourse = selectedRow.Cells[8].Value.ToString();

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
                                this.DisplayAppointment();
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

        /// <summary>
        /// Event handler to assign a coach clicked button on the Search by Name tab.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnScheduleApptNameClick(object sender, EventArgs e)
        {
            string selectedTime;
            string selectedDay;

            string selectedCoachID;
            string selectedCoachName;

            string selectedCourseID;
            string selectedCourseName;

            selectedCoachName = lblCoachName.Text;

            if (this.chkMonMorning.Checked == true)
            {
                selectedDay = "monday";
                selectedTime = "Morning";
            }
            else if (this.chkMonMidday.Checked == true)
            {
                selectedDay = "monday";
                selectedTime = "Midday";
            }
            else if (this.chkMonAfternoon.Checked == true)
            {
                selectedDay = "monday";
                selectedTime = "Afternoon";
            }
            else if (this.chkMonEvening.Checked == true)
            {
                selectedDay = "monday";
                selectedTime = "Evening";
            }
            else if (this.chkTueMorning.Checked == true)
            {
                selectedDay = "tuesday";
                selectedTime = "Morning";
            }
            else if (this.chkTueMidday.Checked == true)
            {
                selectedDay = "tuesday";
                selectedTime = "Midday";
            }
            else if (this.chkTueAfternoon.Checked == true)
            {
                selectedDay = "tuesday";
                selectedTime = "Afternoon";
            }
            else if (this.chkTueEvening.Checked == true)
            {
                selectedDay = "tuesday";
                selectedTime = "Evening";
            }
            else if (chkWedMorning.Checked == true)
            {
                selectedDay = "wednesday";
                selectedTime = "Morning";
            }
            else if (this.chkWedMidday.Checked == true)
            {
                selectedDay = "wednesday";
                selectedTime = "Midday";
            }
            else if (this.chkWedAfternoon.Checked == true)
            {
                selectedDay = "wednesday";
                selectedTime = "Afternoon";
            }
            else if (this.chkWedEvening.Checked == true)
            {
                selectedDay = "wednesday";
                selectedTime = "Evening";
            }
            else if (this.chkThuMorning.Checked == true)
            {
                selectedDay = "thursday";
                selectedTime = "Morning";
            }
            else if (this.chkThuMidday.Checked == true)
            {
                selectedDay = "thursday";
                selectedTime = "Midday";
            }
            else if (this.chkThuAfternoon.Checked == true)
            {
                selectedDay = "thursday";
                selectedTime = "Afternoon";
            }
            else if (this.chkThuEvening.Checked == true)
            {
                selectedDay = "thursday";
                selectedTime = "Evening";
            }
            else if (this.chkFriMorning.Checked == true)
            {
                selectedDay = "friday";
                selectedTime = "Morning";
            }
            else if (this.chkFriMidday.Checked == true)
            {
                selectedDay = "friday";
                selectedTime = "Midday";
            }
            else if (this.chkFriAfternoon.Checked == true)
            {
                selectedDay = "friday";
                selectedTime = "Afternoon";
            }
            else if (this.chkFriEvening.Checked == true)
            {
                selectedDay = "friday";
                selectedTime = "Evening";
            }
            else if (this.chkSatMorning.Checked == true)
            {
                selectedDay = "saturday";
                selectedTime = "Morning";
            }
            else if (this.chkSatMidday.Checked == true)
            {
                selectedDay = "saturday";
                selectedTime = "Midday";
            }
            else if (this.chkSatAfternoon.Checked == true)
            {
                selectedDay = "saturday";
                selectedTime = "Afternoon";
            }
            else if (this.chkSatEvening.Checked == true)
            {
                selectedDay = "saturday";
                selectedTime = "Evening";
            }
            else if (this.chkSunMorning.Checked == true)
            {
                selectedDay = "sunday";
                selectedTime = "Morning";
            }
            else if (this.chkSunMidday.Checked == true)
            {
                selectedDay = "sunday";
                selectedTime = "Midday";
            }
            else if (this.chkSunAfternoon.Checked == true)
            {
                selectedDay = "sunday";
                selectedTime = "Afternoon";
            }
            else if (this.chkSunEvening.Checked == true)
            {
                selectedDay = "sunday";
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
                   "Confirmation", 
                   MessageBoxButtons.YesNo, 
                   MessageBoxIcon.Question);

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
                            MessageBox.Show("Sorry, you are already enrolled in this session.");
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
                            this.DisplayAppointment();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Event handler to logout clicked button on the stutend home tab.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnStdLogoutClick(object sender, EventArgs e)
        {
            Program.LoginForm.Logout();

            // Close this window
            this.Close();
        }

        /// <summary>
        /// Event handler to enable buttons.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void TabPage2Click(object sender, EventArgs e)
        {
            this.EnableButtons();
        }

        /// <summary>
        /// Event handler to clear button on the Search by Name tab to clear all checkboxes.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnClearClick(object sender, EventArgs e)
        {
            this.UnCheckedDayPeriods();
        }

        /// <summary>
        /// Event handler to coaches by time.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnClearByTimeClick(object sender, EventArgs e)
        {
            this.chkMon.Checked = false;
            this.chkTue.Checked = false;
            this.chkThu.Checked = false;
            this.chkWed.Checked = false;
            this.chkSat.Checked = false;
            this.chkSun.Checked = false;
            this.chkMorning.Checked = false;
            this.chkMidday.Checked = false;
            this.chkAfternoon.Checked = false;
            this.chkEvening.Checked = false;
        }

        /// <summary>
        /// Event handler to logout the program event if the main form is closed.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void FindCoachFormFormClosed(object sender, FormClosedEventArgs e)
        {
            Program.LoginForm.Logout();
        }

        /// <summary>
        /// Event handler to cancel the sessional coach.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnCancelCoachClick(object sender, EventArgs e)
        {
            string selectedCoachID;
            string selectedSessionID;
            string selectedTime;
            string selectedDay;
            string selectedCourseID;

            if (this.dgrShowAppointments.SelectedRows == null)
            {
                MessageBox.Show("Please select a row before continuing");
                return;
            }
            else
            {
                DataGridViewRow selectedRow = dgrShowAppointments.SelectedRows[0];
                selectedSessionID = selectedRow.Cells[4].Value.ToString();
                selectedCourseID = selectedRow.Cells[0].Value.ToString();
                selectedDay = selectedRow.Cells[5].Value.ToString();
                selectedTime = selectedRow.Cells[6].Value.ToString();
                selectedCoachID = selectedRow.Cells[7].Value.ToString();

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to cancel the this coach?\n\n"
                        + "Coach ID: " + selectedCoachID + "\n"
                        + "Session ID: " + selectedSessionID + "\n"
                        + "Time: " + selectedTime + "\n"
                        + "Day: " + selectedDay + "\n"
                        + "Course ID: " + selectedCourseID,
                    "Confirmation", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question);

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
                            this.DisplayAppointment();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }  
                    }  
                }
            }
        }

        /// <summary>
        /// Event handler to exit the application when the Exit button is clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}