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
    public partial class CoachAvailabilityForm : Form
    {
        public CoachAvailabilityForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Maximizes Form and displays the users with load event of the form.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CoachAvailabilityFormLoad(object sender, EventArgs e)
        {
            this.DisplayCoaches();
            cbxChooseCoach.SelectedIndex = 0;
        }

        /// <summary>
        /// Method to display the list of coaches
        /// </summary>
        private void DisplayCoaches()
        {
            try
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
            catch (SqlException sqlEx)
            {
                if (sqlEx.InnerException != null)
                    MessageBox.Show(sqlEx.InnerException.Message);
                else
                {
                    MessageBox.Show(sqlEx.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// A method to populate data in the coach availability data grid
        /// </summary>
        private void PopulateAvailabilityGrid()
        {
            // Query obtains the coach ID from the combo box.
            string coachId = this.cbxChooseCoach.SelectedValue.ToString();

            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    var coachAvailabilityQuery = from coachAvailability in context.GetCoachAvailabilities
                                                 where coachAvailability.CoachID.Equals(coachId)
                                                 select coachAvailability;

                    this.dataGridViewAvailability.DataSource = coachAvailabilityQuery.ToList();

                    //this.dataGridViewAvailability.Columns["CoachAvailabilityID"].Visible = false;
                    this.dataGridViewAvailability.Columns["CoachID"].Visible = false;
                    this.dataGridViewAvailability.Columns["CoachAvailabilityID"].Visible = false;
                }
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.InnerException != null)
                    MessageBox.Show(sqlEx.InnerException.Message);
                else
                {
                    MessageBox.Show(sqlEx.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxChooseCoach_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateAvailabilityGrid();
        }

        private void btnAddToCourseList_Click(object sender, EventArgs e)
        {
            EditCoachAvailability editCoachAvailability = new EditCoachAvailability(this.cbxChooseCoach.SelectedValue.ToString());
            editCoachAvailability.ShowDialog();

            PopulateAvailabilityGrid();
        }

        private void dataGridViewAvailability_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the AvailabilityID for the selected row
            int selectedAvailabilityID = Convert.ToInt32(dataGridViewAvailability.SelectedRows[0].Cells["CoachAvailabilityID"].Value.ToString());

            EditCoachAvailability editCoachAvailability = new EditCoachAvailability(selectedAvailabilityID);
            editCoachAvailability.ShowDialog();

            PopulateAvailabilityGrid();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Determine which row is selected
            int selectedAvailabilityID = Convert.ToInt32(dataGridViewAvailability.SelectedRows[0].Cells["CoachAvailabilityID"].Value.ToString());

            // Confirm whether user truly wants to remove this availability record
            DialogResult confirmRemove = MessageBox.Show("Are you sure you want to remove this record?", "Confirm delete",
                                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If yes, remove the record
            if (confirmRemove.Equals(DialogResult.Yes))
            {
                var availability = new CoachAvailability {CoachAvailabilityID = selectedAvailabilityID};

                try
                {
                    using (var context = new db_sft_2172Entities())
                    {
                        context.CoachAvailabilities.Attach(availability);
                        context.CoachAvailabilities.Remove(availability);
                        context.SaveChanges();

                        MessageBox.Show("Delete succesful!");

                        PopulateAvailabilityGrid();
                    }
                }
                catch (DbUpdateException dbUEx)
                {
                    if (dbUEx.InnerException != null)
                    {
                        MessageBox.Show(dbUEx.InnerException.Message);
                    }
                    else
                    {
                        MessageBox.Show(dbUEx.Message);
                    }
                }
                catch (SqlException sqlEx)
                {
                    if (sqlEx.InnerException != null)
                        MessageBox.Show(sqlEx.InnerException.Message);
                    else
                    {
                        MessageBox.Show(sqlEx.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
