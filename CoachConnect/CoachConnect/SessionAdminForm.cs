// <copyright file="SessionAdminForm.cs" company="PABT at NWTC">
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
    /// An admin tool form to display existing sessions and allow the user to edit or create a new session.
    /// </summary>
    public partial class SessionAdminForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionAdminForm" /> class.
        /// </summary>
        public SessionAdminForm()
        {
            this.InitializeComponent();
            this.GetSessionData();
        }

        /// <summary>
        /// Method to get session data from the database
        /// </summary>
        private void GetSessionData()
        {
            // Generate query to pull all sessions from the database
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    var sessionQuery = from sessions in context.ViewSessions
                                       select sessions;

                    this.dataGridViewSessions.DataSource = sessionQuery.ToList();

                    // Hide SessionID...field is needed for EditSession form, but user doesn't need to see it
                    this.dataGridViewSessions.Columns["SessionID"].Visible = false;
                    this.dataGridViewSessions.Columns["SessionID"].DisplayIndex = 0;
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
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void SessionAdminFormFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Event handler that opens the EditSession form and displays selected session data when a data grid cell is double-clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void DataGridViewSessionsCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get SessionID for the selected row
            int selectedSessionId = Convert.ToInt32(this.dataGridViewSessions.SelectedRows[0].Cells["SessionID"].Value);

            // Open new EditSession window
            EditSession newSessionWindow = new EditSession(selectedSessionId);
            newSessionWindow.ShowDialog();
        }

        /// <summary>
        /// Event handler that opens the EditSession form and displays selected session data when a data grid row header is double-clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void DataGridViewSessionsRowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get SessionID for the selected row
            int selectedSessionId = Convert.ToInt32(this.dataGridViewSessions.SelectedRows[0].Cells["SessionID"].Value.ToString());

            // Open new EditSession window
            EditSession newSessionWindow = new EditSession(selectedSessionId);
            newSessionWindow.ShowDialog();

            // When form is closed, refresh the datagrid
            this.GetSessionData();
        }

        /// <summary>
        /// Event handler that opens a blank EditSession form when the Add button is clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnAddClick(object sender, EventArgs e)
        {
            EditSession newSessionWindow = new EditSession();
            newSessionWindow.ShowDialog();

            // When form is closed, refresh the datagrid
            this.GetSessionData();
        }

        private void dataGridViewSessions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
