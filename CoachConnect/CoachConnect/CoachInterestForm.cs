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
    public partial class frmCoachInterest : Form
    {
        Form originalForm { get; set; }
        Image picInterest { get; set; }
        string titleInterest { get; set; }
        
        public frmCoachInterest()
        {
            InitializeComponent();
        }
        public frmCoachInterest(Form original, Image interest, string title)
        {
            InitializeComponent();
            originalForm = original;
            picInterest = interest;
            titleInterest = title;
            SetForm();
        }

        private void btnInterestExit_Click(object sender, EventArgs e)
        {
            originalForm.Show();
            this.Close();
        }

        /// <summary>
        /// Sets Form according to button clicked.
        /// </summary>
        private void SetForm()
        {
            lblTitle.Text = titleInterest;
            pbInterest.Image = picInterest;

            getCoachesByInterest();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            originalForm.Show();
        }

        /// <summary>
        /// Addition by Adam Smith: Query to pull coaches by interest
        /// </summary>
        private void getCoachesByInterest()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Access view and pull data
                    var coachInterestQuery =
                        from coachinterests in context.CoachInterests
                        where coachinterests.Interest.Equals(this.titleInterest)
                        select new
                        {
                            Coach = coachinterests.Coach,
                            Day = coachinterests.Day,
                            Time = coachinterests.Time,
                            Subjects = coachinterests.Subjects
                        };

                    // Add results to data grid view
                    dataGridAvailableCoaches.DataSource = coachInterestQuery.ToList();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void dataGridAvailableCoaches_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnSelectCoach.Enabled = true;
        }
    }
}
