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
    public partial class AdminForm : Form
    {
        private List<string> adminToolList; 


        public AdminForm()
        {
            InitializeComponent();

            SessionAdminForm PanelForm = new SessionAdminForm();
            PanelForm.TopLevel = false;
            PanelForm.AutoScroll = true;
            panelAdmin.Controls.Add(PanelForm);
            PanelForm.FormBorderStyle = FormBorderStyle.None;
            PanelForm.Show();
        }

        private void listBoxAdminTools_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
