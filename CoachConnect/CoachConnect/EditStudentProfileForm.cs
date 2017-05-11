//-----------------------------------------------------------------------
// <copyright file="EditStudentProfileForm.cs" company="PABT,Inc">
//     Copyright (c) Pabt, Inc. All rights reserved
// </copyright>
//-----------------------------------------------------------------------

namespace CoachConnect
{
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

    public partial class EditStudentProfileForm : Form
    {
        Form originalForm { get; set; }

        public EditStudentProfileForm()
        {
            InitializeComponent();
        }

        public EditStudentProfileForm(Form original)
        {
            InitializeComponent();
            getStudentInfo();
            originalForm = original;
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
            Validation myValidation = new Validation();
            using (var context = new db_sft_2172Entities())
            {

                User user = context.Users.Single(u => u.UserID == Program.CurrentUser);
                string url = txtStdURL.Text;
                string email = txtStdEmail.Text;
                string phone = txtStdPhone.Text;
                if (String.IsNullOrEmpty(url))
                {
                    lblErrorURL.Visible = true;
                }
                else if (String.IsNullOrEmpty(email))
                {
                    lblErrorEmail.Visible = true;
                }
                else if (String.IsNullOrEmpty(email))
                {
                    lblErrorPhone.Visible = true;
                }
                else
                {
                    lblErrorURL.Visible = false;
                    lblErrorEmail.Visible = false;
                    lblErrorPhone.Visible = false;
                    user.ProfilePic = url;
                    if (myValidation.ValidateEmail(email))
                    {
                        user.Email = email;
                        if (myValidation.ValidatePhone(phone))
                        {
                            user.Phone = myValidation.FormatPhone(phone);
                            context.SaveChanges();
                            MessageBox.Show("Your change is saved!"); ;
                            originalForm.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Enter your phone number in 10 digits!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid email address!");
                    }     
                }
            }
        }

        private void btnCancleEditProfile_Click(object sender, EventArgs e)
        {
            originalForm.Show();
            this.Close();
        }

        private void txtStdEmail_Leave(object sender, EventArgs e)
        {
            Validation myValidation = new Validation();
            //if (isValidEmail(txtStdEmail.Text))
            if (myValidation.ValidateEmail(txtStdEmail.Text))
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            originalForm.Show();
        }

        //Validate input email address
        //private bool isValidEmail(string inputEmail)
        //{
        //    string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
        //          @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
        //          @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        //    Regex re = new Regex(strRegex);
        //    if (re.IsMatch(inputEmail))
        //        return (true);
        //    else
        //        return (false);
        //}
    }
}
