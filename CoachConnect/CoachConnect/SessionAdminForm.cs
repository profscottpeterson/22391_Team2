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
        public SessionAdminForm()
        {
            InitializeComponent();
            getSessionData();
        }

        private void getSessionData()
        {
            // Generate query
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    var sessionQuery = from sessions in context.ViewSessions
                                       select sessions;

                    dataGridViewSessions.DataSource = sessionQuery.ToList();

                    dataGridViewSessions.Columns["SessionID"].Visible = false;
                    dataGridViewSessions.Columns["SessionID"].DisplayIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SessionAdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridViewSessions_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get SessionID for the selected row
            string selectedSessionID = dataGridViewSessions.SelectedRows[0].Cells["SessionID"].Value.ToString();

            // Open new EditSession window
            // 

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EditSession newSessionWindow = new EditSession();
            newSessionWindow.ShowDialog();
        }
    }
}
