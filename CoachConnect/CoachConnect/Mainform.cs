using System;
using System.Windows.Forms;

namespace CoachConnect
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Show();

            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoachProfileForm coachForm = new CoachProfileForm {MdiParent = this};
            coachForm.Show();
        }

        private void addUpdateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserProfileForm userForm = new UserProfileForm {MdiParent = this};
            userForm.Show();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(@"Are you sure you want to exit?",
                @"Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void setAvailabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoachAvailabilityForm coachAvailabilityForm = new CoachAvailabilityForm {MdiParent = this};
            coachAvailabilityForm.Show();
        }

        private void changeMyPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetMyPassword passwordResetForm = new ResetMyPassword {MdiParent = this};
            passwordResetForm.Show();
        }

        private void setScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoachScheduleForm coachScheduleForm = new CoachScheduleForm {MdiParent = this};
            coachScheduleForm.Show();
        }

        private void printScheduleByDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintSchedule printScheduleForm = new PrintSchedule {MdiParent = this};
            printScheduleForm.Show();
        }

        private void updateCourseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseAdminForm courseAdminForm = new CourseAdminForm {MdiParent = this};
            courseAdminForm.Show();
        }
    }
}
