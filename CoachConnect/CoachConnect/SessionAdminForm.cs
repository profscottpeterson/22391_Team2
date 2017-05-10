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
    public partial class SessionAdminForm : Form
    {
        /// <summary>
        /// Constructor for new SessionAdminForm
        /// </summary>
        public SessionAdminForm()
        {
            InitializeComponent();
            getSessionData();
        }

        /// <summary>
        /// Method to get session data from the database
        /// </summary>
        private void getSessionData()
        {
            // Generate query to pull all sessions from the database
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    var sessionQuery = from sessions in context.ViewSessions
                                       select sessions;

                    dataGridViewSessions.DataSource = sessionQuery.ToList();

                    // Hide SessionID...field is needed for EditSession form, but user doesn't need to see it
                    dataGridViewSessions.Columns["SessionID"].Visible = false;
                    dataGridViewSessions.Columns["SessionID"].DisplayIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Event handler exits the application when the form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SessionAdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Event handler that opens the EditSession form and displays selected session data when a datagrid cell is double-clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewSessions_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get SessionID for the selected row
            int selectedSessionId = Convert.ToInt32(dataGridViewSessions.SelectedRows[0].Cells["SessionID"].Value);

            // Open new EditSession window
            EditSession newSessionWindow = new EditSession(selectedSessionId);
            newSessionWindow.ShowDialog();
        }

        /// <summary>
        /// Event handler that opens the EditSession form and displays selected session data when a datagrid row header is double-clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewSessions_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get SessionID for the selected row
            int selectedSessionID = Convert.ToInt32(dataGridViewSessions.SelectedRows[0].Cells["SessionID"].Value.ToString());
            MessageBox.Show(selectedSessionID.ToString());

            // Open new EditSession window
            EditSession newSessionWindow = new EditSession(selectedSessionID);
            newSessionWindow.ShowDialog();

            // When form is closed, refresh the datagrid
            getSessionData();
        }

        /// <summary>
        /// Event handler that opens a blank EditSession form when the Add button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            EditSession newSessionWindow = new EditSession();
            newSessionWindow.ShowDialog();

            // When form is closed, refresh the datagrid
            getSessionData();
        }
    }
}
