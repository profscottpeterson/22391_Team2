// <copyright file="UserAdminForm.cs" company="PABT at NWTC">
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
    /// Initializes a new instance of the <see cref="CoachProfileForm"/> class.
    /// </summary>
    public partial class CoachProfileForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the UserAdminForm class.
        /// </summary>
        public CoachProfileForm()
        {
            this.InitializeComponent();
        }
  
        /// <summary>
        /// Maximizes Form and displays the users with load event of the form.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CoachAdminFormLoad(object sender, EventArgs e)
        {
            this.DisplaySupervisors();
            this.DisplayCoaches();
        }

        /// <summary>
        /// Method to display the list of users
        /// </summary>
        private void DisplayCoaches()
        {
            using (var context = new db_sft_2172Entities())
            {
                // Query coach table in database and returns the list of the users in ascending order according to last name
                var coachQuery = from coaches in context.Coaches
                                 orderby coaches.LastName ascending
                                 select coaches;

                // Convert query results to list
                List<Coach> coachList = coachQuery.ToList();

                // Set combo box data sources and update data member settings
                this.cbxChooseCoach.DataSource = coachList;
                this.cbxChooseCoach.ValueMember = "CoachID";
                this.cbxChooseCoach.DisplayMember = "DisplayName";
            }
        }

        private void DisplaySupervisors()
        {
            using (var context = new db_sft_2172Entities())
            {
                // Query user table in database and return the list of supervisors in ascending order according to last name
                var supervisorQuery = from users in context.Users
                                      where users.IsSupervisor
                                      orderby users.LastName ascending
                                      select users;

                List<User> supervisorList = supervisorQuery.ToList();

                // Set combo box data source and update data member listings
                this.cbxSupervisor.DataSource = supervisorList;
                this.cbxSupervisor.ValueMember = "UserID";
                this.cbxSupervisor.DisplayMember = "DisplayName";
            }
        }

        /// <summary>
        /// Clear all data fields
        /// </summary>
        private void ClearAllFields()
        {
           // Clearing check boxes and text boxes.
            this.txtID.Clear();
            this.txtFirstName.Clear();
            this.txtLastName.Clear();
            this.txtMiddleName.Clear();
            this.txtDisplayName.Clear();
            this.txtEmail.Clear();
            this.txtPhone.Clear();
            this.cbxSupervisor.SelectedValue = -1;
            this.chkActive.Checked = false;
        }

        /// <summary>
        /// Enable all data fields
        /// </summary>
        private void EnableAllFields()
        {
            // Clearing check boxes and text boxes.
            this.txtID.Enabled = true;
            this.txtFirstName.Enabled = true;
            this.txtLastName.Enabled = true;
            this.txtMiddleName.Enabled = true;
            this.txtDisplayName.Enabled = true;
            this.txtEmail.Enabled = true;
            this.txtPhone.Enabled = true;
            this.cbxSupervisor.Enabled = true;
            this.chkActive.Enabled = true;

            this.btnApply.Enabled = true;

            this.txtID.Focus();
        }

        /// <summary>
        /// Disable all data fields
        /// </summary>
        private void DisableAllFields()
        {
            // Clearing check boxes and text boxes.
            this.txtID.Enabled = false;
            this.txtFirstName.Enabled = false;
            this.txtLastName.Enabled = false;
            this.txtMiddleName.Enabled = false;
            this.txtDisplayName.Enabled = false;
            this.txtEmail.Enabled = false;
            this.txtPhone.Enabled = false;
            this.cbxSupervisor.Enabled = false;
            this.chkActive.Enabled = false;
        }

        /// <summary>
        /// Populates the check boxes and text boxes.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void cbxChooseCoach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxChooseCoach.SelectedIndex == -1) return;

            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Query is getting the user num from the list box.
                    string coachId = this.cbxChooseCoach.SelectedValue.ToString();

                    // Finds the user in the database.
                    var coachQuery = from coach in context.Coaches
                        where coach.CoachID.Equals(coachId)
                        select coach;

                    // If the result has a user it displays the info in the check boxes and the text boxes.
                    if (coachQuery.Any())
                    {
                        var coachResult = coachQuery.FirstOrDefault<Coach>();

                        if (coachResult != null)
                        {
                            this.txtID.Text = coachResult.CoachID;
                            this.txtFirstName.Text = coachResult.FirstName;
                            this.txtLastName.Text = coachResult.LastName;
                            this.txtMiddleName.Text = coachResult.MiddleName;
                            this.txtDisplayName.Text = coachResult.DisplayName;
                            this.txtEmail.Text = coachResult.Email;
                            this.txtPhone.Text = coachResult.Phone;
                            this.cbxSupervisor.SelectedValue = coachResult.SupervisorID;
                            this.chkActive.Checked = coachResult.IsActive;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            EnableAllFields();
        }

        /// <summary>
        /// Add button clears all text boxes and check boxes allowing new user to be added.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnAddClick(object sender, EventArgs e)
        {
            ClearAllFields();
            EnableAllFields();
        }

        /// <summary>
        /// Submit button which submits the added or updated info to the database.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnSubmitClick(object sender, EventArgs e)
        {
            try
            {
                // Query updates the user in the database
                using (var context = new db_sft_2172Entities())
                {
                    string coachId = txtID.Text;
                    var coachQuery = from coach in context.Coaches
                        where coach.CoachID.Equals(coachId)
                        select coach;

                    if (coachQuery.Any())
                    {
                        var coachResult = coachQuery.FirstOrDefault<Coach>();
                        coachResult.FirstName = txtFirstName.Text;
                        coachResult.MiddleName = txtMiddleName.Text;
                        coachResult.LastName = txtLastName.Text;
                        coachResult.DisplayName = txtDisplayName.Text;
                        coachResult.Phone = txtPhone.Text;
                        coachResult.Email = txtEmail.Text;
                        coachResult.SupervisorID = cbxSupervisor.SelectedValue.ToString();
                        coachResult.IsActive = chkActive.Checked;
                        context.SaveChanges();
                    }
                    else
                    {
                        Coach newCoach = new Coach();
                        newCoach.CoachID = this.txtID.Text;
                        newCoach.FirstName = this.txtFirstName.Text;
                        newCoach.MiddleName = this.txtMiddleName.Text;
                        newCoach.LastName = this.txtLastName.Text;
                        newCoach.DisplayName = this.txtDisplayName.Text;
                        newCoach.Phone = this.txtPhone.Text;
                        newCoach.Email = this.txtEmail.Text;
                        newCoach.IsActive = this.chkActive.Checked;

                        if (cbxSupervisor.SelectedIndex == -1)
                        {
                            newCoach.SupervisorID = "";
                        }
                        else
                        {
                            newCoach.SupervisorID = cbxSupervisor.SelectedValue.ToString();
                        }



                        context.Coaches.Add(newCoach);
                        context.SaveChanges();

                        // TODO: Need to add error handling and ensure update was completed before displaying this message
                        MessageBox.Show("Coach Profile Updated");

                        // If save is successful, update the coach list and display the new coach profile.
                        this.DisplayCoaches();
                        this.cbxChooseCoach.SelectedValue = newCoach.CoachID;


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}