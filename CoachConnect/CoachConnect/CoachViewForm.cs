using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CoachConnect
{
    //Before refactoring (4.28.2017) 469 lines    
    public partial class frmCoachView : Form
    {
        public bool EditMode = false;
        public bool flagValidate = false;
        Validation validator = new Validation();
        User coach;
        public frmCoachView()
        {
            InitializeComponent();
            coach = new User();
            coach = getCoach();
            this.Text = coach.FirstName + " " + coach.LastName + " - " + coach.UserID;
            pbProfile.ImageLocation = coach.ProfilePic;
            LoadEditProfile(coach);
            lblCoachName.Text = coach.DisplayName;
            lblCoachUser.Text = coach.UserID;
            lblAvailCoachName.Text = coach.DisplayName;
            lblAvailCoachUsername.Text = coach.UserID;
            pbAvailProfilePic.ImageLocation = coach.ProfilePic;
            LoadAvailability();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            EditModePrep();
            grpProfilePic.Enabled = true;
            btnEditPic.Hide();
            btnPreview.Show();
            btnPicSubmit.Show();
            btnCancel.Show();
            foreach (Control c in grpProfilePic.Controls) c.Enabled = true;
            txtPicURL.SelectionStart = 0;
            txtPicURL.Text = "URL link";
            txtPicURL.ForeColor = Color.Gray;
            txtPicURL.SelectionLength = txtPicURL.Text.Length;
            txtPicURL.Focus();
            this.AcceptButton = btnPreview;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grpProfilePic.Enabled = false;
            EditModePrep();
            LoadEditProfile(coach);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            pbEditPic.ImageLocation = txtPicURL.Text;
            btnPreview.Hide();
            btnPicSubmit.Show();
        }

        private void btnPicSubmit_Click(object sender, EventArgs e)
        {
            using (var context = new db_sft_2172Entities())
            {
                var result = context.Users.SingleOrDefault(b => b.UserID == Program.CurrentUser);
                result.ProfilePic = txtPicURL.Text;
                context.SaveChanges();
            }
            grpProfilePic.Enabled = false;
            EditModePrep();
            LoadEditProfile(coach);
        }

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            EditModePrep();
            grpPersonalInfo.Enabled = true;
            foreach (Control c in grpPersonalInfo.Controls) c.Enabled = true;
            btnEditInfo.Visible = false;
            btnSubmitInfo.Visible = true;
            btnCancelInfo.Visible = true;
            this.AcceptButton = btnSubmitInfo;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Program.loginForm.logout();

            // Close this window
            this.Close();
        }

        private void btnCancelInfo_Click(object sender, EventArgs e)
        {
            EditModePrep();
            grpPersonalInfo.Enabled = true;
            LoadEditProfile(coach);
        }

        private void btnSubmitInfo_Click(object sender, EventArgs e)
        {
            if (!lblFNameError.Visible && !lblMiddleError.Visible && !lblPhoneError.Visible && !lblLastName.Visible && !lblEmailError.Visible)
            {
                updatePersonalInfo();
                btnCancelInfo.PerformClick();
                EditMode = false;
                User coach = new User();
                coach = getCoach();
                this.Text = coach.FirstName + " " + coach.LastName + " - " + coach.UserID;
            }
        }

        private void tbForm_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            if (EditMode)
            {
                MessageBox.Show("Please submit your edit or cancel before moving to other Tab");
                e.Cancel = true;
            }
        }

        private void txtFName_Leave(object sender, EventArgs e)
        {
            lblFNameError.Visible = !validator.ValidateTextBox(txtFName.Text);
            if (lblFNameError.Visible) txtFName.Focus();
            else txtFName.Text = validator.CleanString(txtFName.Text);
        }

        private void txtMiddle_Leave(object sender, EventArgs e)
        {
            lblMiddleError.Visible = !validator.ValidateTextBox(txtMiddle.Text);
            if (lblMiddleError.Visible) txtMiddle.Focus();
            else txtMiddle.Text = validator.CleanString(txtMiddle.Text);
        }

        private void txtLName_Leave(object sender, EventArgs e)
        {
            lblLastName.Visible = !validator.ValidateTextBox(txtLName.Text);
            if (lblLastName.Visible) txtLName.Focus();
            else txtLName.Text = validator.CleanString(txtLName.Text);
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {

            string sanitizedNum = validator.CleanNumber(txtPhone.Text);
            lblPhoneError.Visible = (!validator.ValidatePhone(sanitizedNum));
            if (!validator.ValidatePhone(sanitizedNum)) txtPhone.Focus();
            else txtPhone.Text = validator.FormatPhone(sanitizedNum);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            lblEmailError.Visible = !(validator.ValidateEmail(txtEmail.Text));
            if (!validator.ValidateEmail(txtEmail.Text)) txtEmail.Focus();
        }

        public void updatePersonalInfo()
        {
            string phoneNoFormat = "";
            foreach (char num in txtPhone.Text)
            {
                if (char.IsDigit(num)) phoneNoFormat += num;
            }

            using (var context = new db_sft_2172Entities())
            {
                var result = context.Users.SingleOrDefault(b => b.UserID == Program.CurrentUser);
                result.FirstName = txtFName.Text;
                result.LastName = txtLName.Text;
                result.MiddleName = txtMiddle.Text;
                result.Phone = phoneNoFormat;
                result.Email = txtEmail.Text;
                context.SaveChanges();
            }
        }

        public void LoadEditProfile(User coach)
        {
            //Edit profile area
            coach = getCoach();
            txtEmail.Text = coach.Email;
            txtFName.Text = coach.FirstName;
            txtLName.Text = coach.LastName;
            txtMiddle.Text = coach.MiddleName;
            txtPhone.Text = validator.FormatPhone(coach.Phone);
            pbEditPic.ImageLocation = coach.ProfilePic;
            int endDate = coach.ActiveCoachSince.ToString().IndexOf(" ");
            lblMemberSince.Text = "Active Coach Since: " + coach.ActiveCoachSince.ToString().Substring(0, endDate);
            //txtCurrentPass.Clear();
            //txtNewPass.Clear();
            //txtConfirmNewPass.Clear();
            txtPicURL.Clear();
            btnPreview.Hide();
            btnPicSubmit.Hide();
            btnCancel.Hide();
            //Limit User interaction until they hit proper buttons
            DisableAreas();
            EnableEditBtns();
        }

        public User getCoach()
        {
            using (var context = new db_sft_2172Entities())
            {
                var coach = from c in context.Users
                            where c.UserID.Equals(Program.CurrentUser)
                            select c;
                return coach.First<User>();
            }
        }

        public void DisableAreas()
        {
            foreach (Control c in grpPersonalInfo.Controls) c.Enabled = false;
            foreach (Control c in grpPass.Controls) c.Enabled = false;
            foreach (Control c in grpProfilePic.Controls) c.Enabled = false;
        }

        public void EnableEditBtns()
        {
            btnEditInfo.Visible = true;
            btnEditInfo.Enabled = true;
            btnEditPic.Visible = true;
            btnEditPic.Enabled = true;
            btnCancelInfo.Visible = false;
            btnSubmitInfo.Visible = false;
            btnPass.Enabled = true;
            //txtCurrentPass.Enabled = true;
        }

        public void EditModePrep()
        {
            grpPass.Enabled = !grpPass.Enabled;
            grpPersonalInfo.Enabled = !grpPersonalInfo.Enabled;
            grpProfilePic.Enabled = !grpProfilePic.Enabled;
            EditMode = !EditMode;
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            ChangePasswordForm frm = new ChangePasswordForm();
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Program.loginForm.logout();
        }

        private void btnEditAvailability_Click(object sender, EventArgs e)
        {
            FlipGrpBoxes();
        }

        private void FlipGrpBoxes()
        {
            grpMon.Enabled = !grpMon.Enabled;
            grpTues.Enabled = !grpTues.Enabled;
            grpWed.Enabled = !grpWed.Enabled;
            grpThu.Enabled = !grpThu.Enabled;
            grpFri.Enabled = !grpFri.Enabled;
            grpSat.Enabled = !grpSat.Enabled;
            grpSun.Enabled = !grpSun.Enabled;
            btnCancelAvailability.Visible = !btnCancelAvailability.Visible;
            btnSubmitAvailability.Visible = !btnSubmitAvailability.Visible;
            btnEditAvailability.Visible = !btnSubmitAvailability.Visible;
            btnCheckAll.Visible = !btnCheckAll.Visible;
            btnCheckNone.Visible = !btnCheckNone.Visible;
            LoadAvailability();
        }

        private void btnCancelAvailability_Click(object sender, EventArgs e)
        {
            FlipGrpBoxes();
        }

        private void btnSubmitAvailability_Click(object sender, EventArgs e)
        {
            var newEntry = new UserAvailability();

            var removeOld = new db_sft_2172Entities();
            removeOld.UserAvailabilities.RemoveRange(removeOld.UserAvailabilities.Where(u => u.UserID == Program.CurrentUser));
            removeOld.SaveChanges();
            foreach (Control c in grpAvailability.Controls)
            {
                foreach (Control ca in c.Controls)
                {
                    if (ca is CheckBox)
                    {
                        CheckBox chkbox = (CheckBox)ca;

                        if (chkbox.Checked)
                        {
                            newEntry.UserID = Program.CurrentUser;
                            newEntry.DayID = chkbox.Name.Substring(0, 3);
                            newEntry.TimePeriodID = chkbox.Name.Substring(3, 3);

                            using (var context = new db_sft_2172Entities())
                            {
                                context.UserAvailabilities.Add(newEntry);
                                context.SaveChanges();
                            }
                        }
                    }
                    
                }
            }
            FlipGrpBoxes();
        }
        private void LoadAvailability()
        {
             List<CoachConnect.Availability> CoachAvailability = new List<CoachConnect.Availability>();
            using (var context = new db_sft_2172Entities())
            {
                
                var result = from Availability in context.Availabilities
                             where Availability.UserID.Equals(Program.CurrentUser)
                             select Availability;
                CoachAvailability = result.ToList();

                ClearCheckboxes();
                
                    foreach (Control c in grpAvailability.Controls)
                    {
                        foreach (Control ca in c.Controls)
                        {
                            foreach (Availability a in CoachAvailability)
                            {
                                if (ca is CheckBox)
                            {
                                CheckBox chk = (CheckBox)ca;
                                if (chk.Name == (a.DayID + a.TimePeriodID))
                                {
                                    chk.Checked = true;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void ClearCheckboxes()
        {
            foreach(Control c in grpAvailability.Controls)
            {
                foreach(Control ca in c.Controls)
                {
                    if (ca is CheckBox)
                    {
                        CheckBox chk = (CheckBox)ca;
                        chk.Checked = false;
                    }
                }
            }
        }
        private void CheckCheckboxes()
        {
            foreach (Control c in grpAvailability.Controls)
            {
                foreach (Control ca in c.Controls)
                {
                    if (ca is CheckBox)
                    {
                        CheckBox chk = (CheckBox)ca;
                        chk.Checked = true;
                    }
                }
            }
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            CheckCheckboxes();
        }

        private void btnCheckNone_Click(object sender, EventArgs e)
        {
            ClearCheckboxes();
        }

     }
}