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
            lblCoachName.Text = coach.FirstName;
            lblCoachUser.Text = coach.UserID;
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

        private void txtCurrentPass_TextChanged(object sender, EventArgs e)
        {

            lblPassSuccess.Visible = false;
            lblPassInstructions.Visible = true;
            if (!string.IsNullOrEmpty(txtCurrentPass.Text) && (EditMode = false)) EditModePrep();
            if (!string.IsNullOrEmpty(txtCurrentPass.Text))
            {
                //btnPassCancel.Visible = true;
                //grpProfilePic.Enabled = false;
                //grpPersonalInfo.Enabled = false;
                //EditMode = true;
                //User coach = new User();
                //coach = getCoach();
                //EditModePrep();
                grpPassword.Enabled = true;
                btnPassCancel.Visible = true;
                btnPassCancel.Enabled = true;
                if (txtCurrentPass.Text == coach.Password)
                {
                    lblPassInstructions.Visible = false;
                    pbcurrentPassCorrect.Visible = true;
                    txtConfirmNewPass.Enabled = true;
                    txtNewPass.Enabled = true;
                    txtCurrentPass.Enabled = false;
                    btnPassCancel.Visible = true;
                }
            }
            else
            {
                EditModePrep();
            }
        }

        private void txtConfirmNewPass_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmNewPass.Text.Length >= txtNewPass.Text.Length && !string.IsNullOrEmpty(txtConfirmNewPass.Text))
            {
                if (txtConfirmNewPass.Text != txtNewPass.Text)
                {
                    grpPersonalInfo.Enabled = true;
                    grpProfilePic.Enabled = true;
                    EditMode = false;
                    lblMatchPass.Visible = true;
                    pbNewPass.Visible = false;
                    pbConfirmPass.Visible = false;
                    btnUpdatePass.Visible = false;
                    btnPassCancel.Visible = true;
                }
                else if (txtNewPass.Text == txtConfirmNewPass.Text)
                {
                    btnUpdatePass.Visible = false;
                    lblMatchPass.Visible = false;
                    pbNewPass.Visible = true;
                    pbConfirmPass.Visible = true;
                    btnUpdatePass.Visible = true;
                }
            }
            else
            {
                btnUpdatePass.Visible = false;
                pbConfirmPass.Visible = false;
                pbNewPass.Visible = false;
                lblMatchPass.Visible = false;

            }
        }

        private void btnPassCancel_Click(object sender, EventArgs e)
        {
            EditModePrep();
            LoadEditProfile(coach);
            txtCurrentPass.Enabled = true;
            pbConfirmPass.Visible = false;
            pbcurrentPassCorrect.Visible = false;
            pbNewPass.Visible = false;
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtConfirmNewPass.Text) && txtNewPass.Text.Length >= txtConfirmNewPass.Text.Length)
            {
                if (txtConfirmNewPass.Text != txtNewPass.Text)
                {
                    lblMatchPass.Visible = true;
                    pbNewPass.Visible = false;
                    pbConfirmPass.Visible = false;
                    btnUpdatePass.Visible = false;
                }
                else if (txtNewPass.Text == txtConfirmNewPass.Text)
                {
                    lblMatchPass.Visible = false;
                    pbNewPass.Visible = true;
                    pbConfirmPass.Visible = true;
                    btnUpdatePass.Visible = true;
                }
            }
            else
            {
                pbConfirmPass.Visible = false;
                pbNewPass.Visible = false;
                lblMatchPass.Visible = false;
                btnUpdatePass.Visible = false;
            }
        }

        private void btnUpdatePass_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text == txtConfirmNewPass.Text)
            {
                User coach = new User();
                coach = getCoach();
                if (coach.Password == txtCurrentPass.Text)
                {
                    using (var context = new db_sft_2172Entities())
                    {
                        var result = context.Users.SingleOrDefault(b => b.UserID == Program.CurrentUser);
                        result.Password = txtConfirmNewPass.Text;
                        context.SaveChanges();
                    }
                    btnPassCancel.PerformClick();
                    lblPassInstructions.Visible = false;
                    lblPassSuccess.Visible = true;
                    grpProfilePic.Enabled = true;
                    grpPersonalInfo.Enabled = true;
                    EditMode = false;
                }
            }
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
            txtCurrentPass.Clear();
            txtNewPass.Clear();
            txtConfirmNewPass.Clear();
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
            foreach (Control c in grpPassword.Controls) c.Enabled = false;
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
            txtCurrentPass.Enabled = true;
        }

        public void EditModePrep()
        {
            grpPassword.Enabled = !grpPassword.Enabled;
            grpPersonalInfo.Enabled = !grpPersonalInfo.Enabled;
            grpProfilePic.Enabled = !grpProfilePic.Enabled;
            EditMode = !EditMode;
        }
    }
}