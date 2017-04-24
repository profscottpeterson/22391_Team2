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
    public partial class frmCoachView : Form
    {
        public string OriginalPic;
        public bool EditMode = false;
        public bool flagValidate = true;
        public frmCoachView()
        {
            InitializeComponent();
            User coach = new User();
            coach = getCoach();
            this.Text = coach.FirstName + " " + coach.LastName + " - " + coach.UserID;
            pbProfile.ImageLocation = coach.ProfilePic;
            LoadEditProfile(coach);
            lblCoachName.Text = coach.FirstName;
            lblCoachUser.Text = coach.UserID;
            OriginalPic = coach.ProfilePic;
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

        private void button1_Click(object sender, EventArgs e)
        {
            btnEditPic.Hide();
            btnPreview.Show();
            btnPicSubmit.Show();
            btnCancel.Show();
            txtPicURL.Enabled = true;
            txtPicURL.SelectionStart = 0;
            txtPicURL.Text = "URL link";
            txtPicURL.ForeColor = Color.Gray;
            txtPicURL.SelectionLength = txtPicURL.Text.Length;
            txtPicURL.Focus();
            EditMode = true;
            grpPersonalInfo.Enabled = false;
            grpPassword.Enabled = false;
            this.AcceptButton = btnPreview;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPicURL.Enabled = false;
            btnCancel.Hide();
            btnPicSubmit.Hide();
            btnPreview.Hide();
            btnEditPic.Show();
            pbEditPic.ImageLocation = OriginalPic;
            txtPicURL.Clear();
            EditMode = false;
            grpPassword.Enabled = true;
            grpPersonalInfo.Enabled = true;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            pbEditPic.ImageLocation = txtPicURL.Text;
            btnPreview.Hide();
            btnPicSubmit.Show();
        }

        private void btnPicSubmit_Click(object sender, EventArgs e)
        {
            btnPicSubmit.Hide();
            btnEditPic.Show();
            btnCancel.Hide();
            OriginalPic = txtPicURL.Text;
            using (var context = new db_sft_2172Entities())
            {
                var result = context.Users.SingleOrDefault(b => b.UserID == Program.CurrentUser);
                result.ProfilePic = txtPicURL.Text;
                context.SaveChanges();
            }
            txtPicURL.Enabled = false;
            pbProfile.ImageLocation = txtPicURL.Text;
            txtPicURL.Clear();
        }

        public void LoadEditProfile(User coach)
        {
            txtEmail.Text = coach.Email;
            txtFName.Text = coach.FirstName;
            txtLName.Text = coach.LastName;
            txtMiddle.Text = coach.MiddleName;
            txtPhone.Text = "(" + coach.Phone.Substring(0, 3) + ")" + coach.Phone.Substring(3,3)+"-"+coach.Phone.Substring(5,4);
            pbEditPic.ImageLocation = coach.ProfilePic;
            int endDate = coach.ActiveCoachSince.ToString().IndexOf(" ");
            lblMemberSince.Text = "Active Coach Since: " + coach.ActiveCoachSince.ToString().Substring(0,endDate);
        }

        private void txtCurrentPass_TextChanged(object sender, EventArgs e)
        {
            
            lblPassSuccess.Visible = false;
            lblPassInstructions.Visible = true;
            if (!string.IsNullOrEmpty(txtCurrentPass.Text))
            {
                btnPassCancel.Visible = true;
                grpProfilePic.Enabled = false;
                grpPersonalInfo.Enabled = false;
                EditMode = true;
                User coach = new User();
                coach = getCoach();

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
                grpProfilePic.Enabled = true;
                grpPersonalInfo.Enabled = true;
                EditMode = false;
            }
        }

        private void txtConfirmNewPass_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmNewPass.Text.Length >= txtNewPass.Text.Length && !string.IsNullOrEmpty(txtConfirmNewPass.Text))
            {
                if (txtConfirmNewPass.Text != txtNewPass.Text) {
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
            
            txtConfirmNewPass.Enabled = false;
            txtNewPass.Enabled = false;

            txtCurrentPass.Clear();
            txtNewPass.Clear();
            txtConfirmNewPass.Clear();
            
            pbNewPass.Visible = false;
            pbcurrentPassCorrect.Visible = false;
            pbConfirmPass.Visible = false;
            btnUpdatePass.Visible = false;
            btnPassCancel.Visible = false;

            lblMatchPass.Visible = false;
            lblWarningCurrentPass.Visible = false;
            txtCurrentPass.Enabled = true;

            txtCurrentPass.Focus();
            txtConfirmNewPass.BorderStyle = BorderStyle.FixedSingle;
            txtNewPass.BorderStyle = BorderStyle.FixedSingle;

            grpPersonalInfo.Enabled = true;
            grpProfilePic.Enabled = true;
            EditMode = false;
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
       {
            if (!string.IsNullOrEmpty(txtConfirmNewPass.Text) && txtNewPass.Text.Length >=txtConfirmNewPass.Text.Length )
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
            txtFName.Enabled = true;
            txtLName.Enabled = true;
            txtMiddle.Enabled = true;
            txtPhone.Enabled = true;
            txtEmail.Enabled = true;
            txtFName.Focus();
            btnCancelInfo.Visible = true;
            btnEditInfo.Visible = false;
            grpProfilePic.Enabled = false;
            grpPassword.Enabled = false;
            EditMode = true;
            this.AcceptButton = btnCancelInfo;
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {
           // btnSubmitInfo.Visible = true;
        }

        private void txtFName_Leave(object sender, EventArgs e)
        {
            txtFName.Text = txtFName.Text.Trim();
            ValidateTextbox(txtFName.Text);
            if (flagValidate)
            {
                txtFName.Text = FormatTextBox(txtFName.Text);
                lblFNameError.Visible = false;
            }
            else
            {
                lblFNameError.Visible = true;
                txtFName.Focus();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Program.loginForm.logout();

            // Close this window
            this.Close();
        }

        private void btnCancelInfo_Click(object sender, EventArgs e)
        {
            LoadEditProfile(getCoach());
            txtFName.Enabled = false;
            txtLName.Enabled = false;
            txtMiddle.Enabled = false;
            txtPhone.Enabled = false;
            txtEmail.Enabled = false;
            btnSubmitInfo.Visible = false;
            btnCancelInfo.Visible = false;
            btnEditInfo.Visible = true;
            EditMode = false;
            grpPassword.Enabled = true;
            grpProfilePic.Enabled = true;
        }

        private void btnSubmitInfo_Click(object sender, EventArgs e)
        {

        }

        private void tbForm_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            if (EditMode)
            {
                MessageBox.Show("Please submit your edit or cancel before moving to other Tab");
                e.Cancel = true;
            }
        }
        private void ValidateTextbox(String tb)
        {
            flagValidate = true;
            if ((String.IsNullOrEmpty(tb)) || (!tb.All(char.IsLetter))) flagValidate = false;
        }

        private string FormatTextBox(String s)
        {
            if (s.Length > 1) return char.ToUpper(s[0]) + s.Substring(1).ToLower();
            else return s.ToUpper();
        }

        private void txtMiddle_Leave(object sender, EventArgs e)
        {
            txtMiddle.Text = txtMiddle.Text.Trim();
            ValidateTextbox(txtMiddle.Text);
            if (flagValidate)
            {
                txtMiddle.Text = FormatTextBox(txtMiddle.Text);
                lblMiddleError.Visible = false;
            }
            else
            {
                lblMiddleError.Visible = true;
                txtMiddle.Focus();
            }
        }

        private void txtLName_Leave(object sender, EventArgs e)
        {
            txtLName.Text = txtLName.Text.Trim();
            ValidateTextbox(txtLName.Text);
            if (flagValidate)
            {
                txtLName.Text = FormatTextBox(txtLName.Text);
                lblLastName.Visible = false;
            }
            else
            {
                lblLastName.Visible = true;
                txtLName.Focus();
            }
        }
    }
}
