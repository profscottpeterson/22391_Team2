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
    public partial class CoachScheduleForm : Form
    {
        public CoachScheduleForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Displays the list of available coaches
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CoachScheduleFormLoad(object sender, EventArgs e)
        {
            this.DisplayCoaches();
            cbxChooseCoach.SelectedIndex = 0;
        }

        /// <summary>
        /// Method to display the list of coaches
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

        /// <summary>
        /// A method to populate data in the coach availability data grid
        /// </summary>
        private void PopulateScheduleGrid()
        {
            // Query obtains the coach ID from the combo box.
            string coachId = this.cbxChooseCoach.SelectedValue.ToString();

            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    var coachScheduleQuery = from coachSchedules in context.GetCoachSchedules
                                                 where coachSchedules.CoachID.Equals(coachId)
                                                 select coachSchedules;

                    this.dataGridViewSchedule.DataSource = coachScheduleQuery.ToList();

                    this.dataGridViewSchedule.Columns["SessionID"].Visible = false;
                    this.dataGridViewSchedule.Columns["CoachID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void cbxChooseCoach_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateScheduleGrid();
        }

        private void btnAddToSchedule_Click(object sender, EventArgs e)
        {
            EditSession editCoachSession = new EditSession(this.cbxChooseCoach.SelectedValue.ToString());
            editCoachSession.ShowDialog();

            PopulateScheduleGrid();
        }

        private void dataGridViewSchedule_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the SessionID for the selected row
            int selectedScheduleId = Convert.ToInt32(dataGridViewSchedule.SelectedRows[0].Cells["SessionID"].Value.ToString());

            EditSession editCoachAvailability = new EditSession(selectedScheduleId);
            editCoachAvailability.ShowDialog();

            PopulateScheduleGrid();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Determine which row is selected
            int selectedSessionID = Convert.ToInt32(dataGridViewSchedule.SelectedRows[0].Cells["SessionID"].Value.ToString());

            // Confirm whether user truly wants to remove this scheduled block
            DialogResult confirmRemove = MessageBox.Show("Are you sure you want to remove this scheduled time?", "Confirm delete",
                                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If yes, remove the record
            if (confirmRemove.Equals(DialogResult.Yes))
            {
                var session = new CoachSession { SessionID = selectedSessionID };

                try
                {
                    using (var context = new db_sft_2172Entities())
                    {
                        context.CoachSessions.Attach(session);
                        context.CoachSessions.Remove(session);
                        context.SaveChanges();

                        MessageBox.Show("Delete succesful!");

                        PopulateScheduleGrid();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }
    }
}
