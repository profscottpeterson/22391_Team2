using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoachConnect
{
    public partial class EditStudentProfileForm : Form
    {
        public EditStudentProfileForm()
        {
            InitializeComponent();
            getStudentInfo();
        }

        private void getStudentInfo()
        {
            using (var context = new db_sft_2172Entities())
            {
                var userQuery = from u in context.Users
                                where u.UserID.Equals(Program.CurrentUser)
                                select u;
                var userResult = userQuery.FirstOrDefault<User>();
                txtStdURL.Text = userResult.ProfilePic;
                txtStdEmail.Text = userResult.Email;
                txtStdPhone.Text = userResult.Phone;

            }
        }

        private void btnSaveEditProfile_Click(object sender, EventArgs e)
        {
            using (var context = new db_sft_2172Entities())
            {

                User user = context.Users.Single(u => u.UserID == Program.CurrentUser);
                string url = txtStdURL.Text;
                string email = txtStdEmail.Text;
                string phone = txtStdPhone.Text;
                if (String.IsNullOrEmpty(url))
                {
                    //lblErrorURL.Text = "Field URL is required!";
                }/*
                else if (String.IsNullOrEmpty(email))
                {
                    lblErrorEmail.Text = "Field Email is required!"
                }
                else if (String.IsNullOrEmpty(email))
                {
                    lblErrorPhone.Text = "Field Phone is required!";
                }*/
                else
                {
                    context.SaveChanges();
                    MessageBox.Show("Your change is saved!");;
                    FindCoachForm coach = new FindCoachForm();
                    coach.Show();
                    this.Close();
                }
            }
        }

        private void btnCancleEditProfile_Click(object sender, EventArgs e)
        {
            FindCoachForm mainForm = new FindCoachForm();
            mainForm.Show();
            this.Close();
        }

        private void txtStdEmail_Leave(object sender, EventArgs e)
        {
            if (isValidEmail(txtStdEmail.Text))
            {
                validEmail.Visible = true;
                InvalidEmail.Visible = false;
            }
            else
            {
                validEmail.Visible = false;
                InvalidEmail.Visible = true;
            }
        }

        //Validate input email address
        private bool isValidEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
    }
}
