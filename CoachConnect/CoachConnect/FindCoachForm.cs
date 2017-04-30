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
        }

        private void SelectedInterest(Image interest, string title)
        {
            this.Hide();
            frmCoachInterest frm2 = new frmCoachInterest(this, interest,title);
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
            SelectedInterest(btnBusiness.BackgroundImage,lblBusiness.Text);
        }

        private void btnDigital_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnDigital.BackgroundImage,lblDigital.Text);
        }

        private void btnEnergy_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnEnergy.BackgroundImage,lblEnergy.Text);
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnGeneral.BackgroundImage,lblGeneral.Text);
        }

        private void bthHealth_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnHealth.BackgroundImage,lblHealth.Text);
        }

        private void btnHuman_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnHuman.BackgroundImage,lblHuman.Text);
        }

        private void btnIT_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnIT.BackgroundImage, lblIT.Text);
        }

        private void btnLaw_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnLaw.BackgroundImage,lblLaw.Text);
        }

        private void btnManu_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnManu.BackgroundImage, lblManu.Text);
        }

        private void btnScience_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnScience.BackgroundImage,lblScience.Text);
        }

        private void btnTransport_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnTransport.BackgroundImage,lblTransport.Text);
        }

        private void FindCoachForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.loginForm.logout();
        }

        private void btnSearchTime_Click(object sender, EventArgs e)
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
                    ///TODO: Stub to handle saving data to database (add linq query)
                    SessionRoster sr = new SessionRoster()
                    {
                        SessionID = 1,
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

            return;
        }

        public void GetCoachData()
        {
            var dataSource = new List<CoachItem>();

            // Query the database and pull the list of coaches
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Run query to get coach data
                    var coachQuery = from coachResults in context.CoachByNames
                                     select coachResults;

                    // Find users where desired criteria are met
                    var coachList = coachQuery.Where(t => t.IsCoach == true);

                    foreach (CoachByName coach in coachList)
                    {
                        dataSource.Add(new CoachItem() { Name = coach.FirstName + " " + coach.LastName, Value = coach.UserID });
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            // Bind the data list to the combo box
            cbxCoachNames.DataSource = dataSource;
            cbxCoachNames.DisplayMember = "Name";
            cbxCoachNames.ValueMember = "Value";

            cbxCoachNames.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /**
         *  Event handler: Form Load
         *  **/
        private void FindCoachForm_Load(object sender, EventArgs e)
        {
            GetCoachData();
        }

        /**
         * Event handler: update dropdown choice in Find Coach by Name tab
         **/
        private void cbxCoachNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cbxCoachNames.SelectedValue.ToString();

            // Query the database and pull info for the selected coach
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Run query to get coach data
                    var coachQuery = from coachResult in context.CoachByNames
                                     where coachResult.UserID.Equals(selectedValue)
                                     select coachResult;

                    var foundCoach = coachQuery.FirstOrDefault<CoachByName>();

                    // Update form based on query data
                    txtCoachName.Text = foundCoach.FirstName + " " + foundCoach.LastName;
                    txtActiveCoachSince.Text = foundCoach.ActiveCoachSince.Value.ToString("MM/dd/yyyy");

                    imgCoachPic.Load(foundCoach.ProfilePic);

                    
                    // Run another query to get available sessions for the selected coach
                    var coachAvailabilityQuery = from coachAvailability in context.CoachByTimes
                                                 where coachAvailability.UserID.Equals(selectedValue)
                                                 select coachAvailability;

                    dataGridCoachAvailability.DataSource = coachAvailabilityQuery.ToList();

                    dataGridCoachAvailability.Columns["UserID"].Visible = false;
                    dataGridCoachAvailability.Columns["UserID"].DisplayIndex = 0;
                    dataGridCoachAvailability.Columns["Coach"].Visible = false;
                    dataGridCoachAvailability.Columns["Coach"].DisplayIndex = 1;
                    dataGridCoachAvailability.Columns["Time"].DisplayIndex = 2;
                    dataGridCoachAvailability.Columns["Day"].DisplayIndex = 3;
                    dataGridCoachAvailability.Columns["Subject"].DisplayIndex = 4;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

        }

        private void btnScheduleApptName_Click(object sender, EventArgs e)
        {
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
                            SessionID = 1,
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
        }
    }

    public class CoachItem
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
