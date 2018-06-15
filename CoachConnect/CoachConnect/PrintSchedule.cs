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
    public partial class PrintSchedule : Form
    {
        public PrintSchedule()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Displays the list of available interests
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void PrintScheduleFormLoad(object sender, EventArgs e)
        {
            this.DisplayInterests();
            cbxChooseDepartment.SelectedIndex = 0;
        }

        /// <summary>
        /// Method to display the list of coaches
        /// </summary>
        private void DisplayInterests()
        {
            using (var context = new db_sft_2172Entities())
            {
                // Query interest table in database and returns the list of the interests in ascending order
                var interestQuery = from interests in context.Interests
                    orderby interests.InterestName ascending
                    select interests;

                // Convert query results to list
                List<Interest> interestList = interestQuery.ToList();

                // Set combo box data sources and update data member settings
                this.cbxChooseDepartment.DataSource = interestList;
                this.cbxChooseDepartment.ValueMember = "InterestID";
                this.cbxChooseDepartment.DisplayMember = "InterestName";
            }




        }


}
}
