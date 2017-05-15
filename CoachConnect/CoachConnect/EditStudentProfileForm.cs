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

        /// <summary>
        /// To get student information to display on the home tab.
        /// </summary>
        private void getStudentInfo()
        {
            using (var context = new db_sft_2172Entities())
            {
                var userQuery = from u in context.Users
                                where u.UserID.Equals(Program.CurrentUser)
                                select u;
                var userResult = userQuery.FirstOrDefault<User>();
                txtStdURL.Text = userResult.ProfilePic;
                txtStdFirstName.Text = userResult.FirstName;
                txtStdMiddleName.Text = userResult.MiddleName;
                txtStdLastName.Text = userResult.LastName;
                txtStdEmail.Text = userResult.Email;
                txtStdPhone.Text = userResult.Phone;

            }
        }

        /// <summary>
        /// Event handler to save user edited profile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveEditProfile_Click(object sender, EventArgs e)
        {
            Validation myValidation = new Validation();
            using (var context = new db_sft_2172Entities())
            {

                User user = context.Users.Single(u => u.UserID == Program.CurrentUser);
                string url = txtStdURL.Text;
                string fName = txtStdFirstName.Text;
                string midleName = txtStdMiddleName.Text;
                string lName = txtStdLastName.Text;
                string email = txtStdEmail.Text;
                string phone = txtStdPhone.Text;
                if (String.IsNullOrEmpty(url))
                {
                    lblErrorURL.Visible = true;
                }
                else if (String.IsNullOrEmpty(fName))
                {
                    lblFirstNameError.Visible = true;
                }
                else if (String.IsNullOrEmpty(midleName))
                {
                    lblMiddleNameError.Visible = true;
                }
                else if (String.IsNullOrEmpty(lName))
                {
                    lblLastNameError.Visible = true;
                }
                else if (String.IsNullOrEmpty(email))
                {
                    lblErrorEmail.Visible = true;
                }
                else if (String.IsNullOrEmpty(phone))
                {
                    lblErrorPhone.Visible = true;
                }
                else
                {
                    lblErrorURL.Visible = false;
                    lblFirstNameError.Visible = false;
                    lblMiddleNameError.Visible = false;
                    lblLastNameError.Visible = false;
                    lblErrorEmail.Visible = false;
                    lblErrorPhone.Visible = false;

                    //Add profile url
                    user.ProfilePic = url;

                    //Validate firstname, middlename, and lastname
                    if (myValidation.ValidateTextBox(fName) && myValidation.ValidateTextBox(midleName) && myValidation.ValidateTextBox(lName))
                    {
                        //Add firstname, middlename, and lastname
                        user.FirstName = myValidation.CleanString(fName);
                        user.MiddleName = myValidation.CleanString(midleName);
                        user.LastName = myValidation.CleanString(lName);

                        //Update the dipslay name
                        if(user.MiddleName == "None" || user.MiddleName == "none" || user.MiddleName == null || user.MiddleName == "")
                        {
                            user.DisplayName = user.FirstName + " " + user.LastName;
                        }
                        else
                        {
                            user.DisplayName = user.FirstName + " " + user.MiddleName + " " + user.LastName;
                        }

                        //Validate email address
                        if (myValidation.ValidateEmail(email))
                        {
                            //Add email address
                            user.Email = email;

                            //Validate phone
                            if (myValidation.ValidatePhone(phone))
                            {
                                //Add phone
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
                    else
                    {
                        MessageBox.Show("Invalid first name or middle name or last name!");
                    }
                }
            }
        }

        /// <summary>
        /// Event handler to cancel the editing profile.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancleEditProfile_Click(object sender, EventArgs e)
        {
            originalForm.Show();
            this.Close();
        }

        /// <summary>
        /// Event handler to leave the focus on the textbox email.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Override method event handler to perform when the form is closed.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            originalForm.Show();
        }
    }
}
