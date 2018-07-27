// <copyright file="UserAdminForm.cs" company="PABT at NWTC">
//     Copyright 2017 PABT (Pao Xiong, Adam Smith, Brian Lueskow, Tim Durkee)
// </copyright>
namespace CoachConnect
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
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
            InitializeComponent();
        }

        /// <summary>
        /// Maximizes Form and displays the users with load event of the form.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CoachAdminFormLoad(object sender, EventArgs e)
        {
            DisplaySupervisors();
            DisplayCoaches();
        }

        /// <summary>
        /// Method to display the list of users
        /// </summary>
        private void DisplayCoaches()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Query coach table in database and returns the list of the users in ascending order according to last name
                    var coachQuery = from coaches in context.Coaches
                        orderby coaches.LastName
                        select coaches;

                    // Convert query results to list
                    List<Coach> coachList = coachQuery.ToList();

                    // Set combo box data sources and update data member settings
                    cbxChooseCoach.DataSource = coachList;
                    cbxChooseCoach.ValueMember = "CoachID";
                    cbxChooseCoach.DisplayMember = "DisplayName";
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.InnerException != null ? sqlEx.InnerException.Message : sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplaySupervisors()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Query user table in database and return the list of supervisors in ascending order according to last name
                    var supervisorQuery = from users in context.Users
                        where users.IsSupervisor
                        orderby users.LastName
                        select users;

                    List<User> supervisorList = supervisorQuery.ToList();

                    // Set combo box data source and update data member listings
                    cbxSupervisor.DataSource = supervisorList;
                    cbxSupervisor.ValueMember = "UserID";
                    cbxSupervisor.DisplayMember = "DisplayName";
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.InnerException != null ? sqlEx.InnerException.Message : sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Clear all data fields
        /// </summary>
        private void ClearAllFields()
        {
            // Clearing check boxes and text boxes.
            txtID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleName.Clear();
            txtDisplayName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            cbxSupervisor.SelectedValue = -1;
            chkActive.Checked = false;
        }

        /// <summary>
        /// Populates the combo boxes and text boxes with the selected coach's information.
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
                    // Query is getting the coach ID from the combo box.
                    string coachId = cbxChooseCoach.SelectedValue.ToString();

                    // Find the coach in the database.
                    var coachQuery = from coach in context.Coaches
                                     where coach.CoachID.Equals(coachId)
                                     select coach;

                    // If the query returns a a user, display the corresponding info in the form
                    if (coachQuery.Any())
                    {
                        var coachResult = coachQuery.FirstOrDefault();

                        if (coachResult != null)
                        {
                            txtID.Text = coachResult.CoachID;
                            txtFirstName.Text = coachResult.FirstName;
                            txtLastName.Text = coachResult.LastName;
                            txtMiddleName.Text = coachResult.MiddleName;
                            txtDisplayName.Text = coachResult.DisplayName;
                            txtEmail.Text = coachResult.Email;
                            txtPhone.Text = coachResult.Phone;
                            cbxSupervisor.SelectedValue = coachResult.SupervisorID;
                            chkActive.Checked = coachResult.IsActive;
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.InnerException != null ? sqlEx.InnerException.Message : sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Add button clears all text boxes and check boxes so user can enter new information.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnAddClick(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        /// <summary>
        /// Submit button sends the added or updated info to the database.
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
                        var coachResult = coachQuery.FirstOrDefault();
                        coachResult.FirstName = txtFirstName.Text;
                        coachResult.MiddleName = txtMiddleName.Text;
                        coachResult.LastName = txtLastName.Text;
                        coachResult.DisplayName = txtDisplayName.Text;
                        coachResult.Phone = txtPhone.Text;
                        coachResult.Email = txtEmail.Text;
                        coachResult.IsActive = chkActive.Checked;

                        coachResult.SupervisorID = cbxSupervisor.SelectedIndex == -1 ? "" : cbxSupervisor.SelectedValue.ToString();

                        context.SaveChanges();
                        MessageBox.Show(@"Coach Profile Updated");
                    }
                    else
                    {
                        Coach newCoach = new Coach
                        {
                            CoachID = txtID.Text,
                            FirstName = txtFirstName.Text,
                            MiddleName = txtMiddleName.Text,
                            LastName = txtLastName.Text,
                            DisplayName = txtDisplayName.Text,
                            Phone = txtPhone.Text,
                            Email = txtEmail.Text,
                            IsActive = chkActive.Checked,
                            SupervisorID =
                                cbxSupervisor.SelectedIndex == -1 ? "" : cbxSupervisor.SelectedValue.ToString()
                        };


                        context.Coaches.Add(newCoach);
                        context.SaveChanges();

                        MessageBox.Show(@"Coach Profile Added");

                        // If save is successful, update the coach list and display the new coach profile
                        DisplayCoaches();
                        cbxChooseCoach.SelectedValue = newCoach.CoachID;
                    }
                }
            }
            catch (DbUpdateException dbUEx)
            {
                MessageBox.Show(dbUEx.InnerException != null ? dbUEx.InnerException.Message : dbUEx.Message);
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.InnerException != null ? sqlEx.InnerException.Message : sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
 