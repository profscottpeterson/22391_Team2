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
    public partial class CoachAvailabilityForm : Form
    {
        /// <summary>
        /// Gets or sets a list object that stores the current session roster
        /// </summary>
        private List<GetCoachAvailability> CurrentAvailability { get; set; }


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
        /// A method to update the coach availability data grid
        /// </summary>
        private void PopulateAvailabilityGrid()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    var coachAvailabilityQuery = from coachAvailability in context.GetCoachAvailabilities
                                      where coachAvailability.CoachID.Equals(this.cbxChooseCoach.SelectedValue)
                                      select coachAvailability;

                    this.CurrentAvailability = coachAvailabilityQuery.ToList();

                    this.dataGridViewCourses.DataSource = this.CurrentAvailability;

                    this.dataGridViewCourses.Columns["CoachID"].Visible = false;
                    this.dataGridViewCourses.Columns["Display Name"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
