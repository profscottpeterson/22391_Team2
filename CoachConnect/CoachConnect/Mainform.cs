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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Show();

            LoginForm loginForm = new LoginForm();
            //loginForm.MdiParent = this;
            loginForm.ShowDialog();
        }

        private void AddUpdateCoachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoachProfileForm coachForm = new CoachProfileForm {MdiParent = this};
            coachForm.Show();
        }

        private void AddUpdateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAdminForm userForm = new UserAdminForm {MdiParent = this};
            userForm.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?",
                "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void ResetMyPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetPassword resetForm = new ResetPassword();
            resetForm.ShowDialog();
        }
    }
}
