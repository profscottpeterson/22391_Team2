// <copyright file = "EditStudentProfileForm.cs" company="PABT at NWTC">
//     Copyright 2017 PABT (Pao Xiong, Adam Smith, Brian Lueskow, Tim Durkee)
// </copyright>
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

    /// <summary>
    /// A form that allows a student user to update his/her profile.
    /// </summary>
    public partial class EditStudentProfileForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditStudentProfileForm" /> class.
        /// </summary>
        public EditStudentProfileForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditStudentProfileForm" /> class.
        /// </summary>
        /// <param name="original">The original calling form</param>
        public EditStudentProfileForm(Form original)
        {
            this.InitializeComponent();
            this.GetStudentInfo();
            this.OriginalForm = original;
        }

        /// <summary>
        /// Gets or sets the original "calling" form
        /// </summary>
        private Form OriginalForm { get; set; }

        /// <summary>
        /// Override method event handler to perform when the form is closed.
        /// </summary>
        /// <param name="e">The parameter is not used.</param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.OriginalForm.Show();
        }
        
        /// <summary>
        /// To get student information to display on the home tab.
        /// </summary>
        private void GetStudentInfo()
        {
            using (var context = new db_sft_2172Entities())
            {
                var userQuery = from u in context.Users
                                where u.UserID.Equals(Program.CurrentUser)
                                select u;
                var userResult = userQuery.FirstOrDefault<User>();
                this.txtStdURL.Text = userResult.ProfilePic;
                this.txtStdFirstName.Text = userResult.FirstName;
                this.txtStdMiddleName.Text = userResult.MiddleName;
                this.txtStdLastName.Text = userResult.LastName;
                this.txtStdEmail.Text = userResult.Email;
                this.txtStdPhone.Text = userResult.Phone;
            }
        }

        /// <summary>
        /// Event handler to save user edited profile
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnSaveEditProfileClick(object sender, EventArgs e)
        {
            Validation myValidation = new Validation();
            using (var context = new db_sft_2172Entities())
            {
                User user = context.Users.Single(u => u.UserID == Program.CurrentUser);
                string url = this.txtStdURL.Text;
                string firstName = this.txtStdFirstName.Text;
                string midddleName = this.txtStdMiddleName.Text;
                string lastName = this.txtStdLastName.Text;
                string email = this.txtStdEmail.Text;
                string phone = this.txtStdPhone.Text;

                if (string.IsNullOrEmpty(url))
                {
                    this.lblErrorURL.Visible = true;
                }
                else if (string.IsNullOrEmpty(firstName))
                {
                    this.lblFirstNameError.Visible = true;
                }
                else if (string.IsNullOrEmpty(midddleName))
                {
                    this.lblMiddleNameError.Visible = true;
                }
                else if (string.IsNullOrEmpty(lastName))
                {
                    this.lblLastNameError.Visible = true;
                }
                else if (string.IsNullOrEmpty(email))
                {
                    this.lblErrorEmail.Visible = true;
                }
                else if (string.IsNullOrEmpty(phone))
                {
                    this.lblErrorPhone.Visible = true;
                }
                else
                {
                    this.lblErrorURL.Visible = false;
                    this.lblFirstNameError.Visible = false;
                    this.lblMiddleNameError.Visible = false;
                    this.lblLastNameError.Visible = false;
                    this.lblErrorEmail.Visible = false;
                    this.lblErrorPhone.Visible = false;

                    // Add profile url
                    user.ProfilePic = url;

                    // Validate firstname, middlename, and lastname
                    if (myValidation.ValidateTextBox(firstName) && myValidation.ValidateTextBox(midddleName) && myValidation.ValidateTextBox(lastName))
                    {
                        // Add firstname, middlename, and lastname
                        user.FirstName = myValidation.CleanString(firstName);
                        user.MiddleName = myValidation.CleanString(midddleName);
                        user.LastName = myValidation.CleanString(lastName);

                        // Update the dipslay name
                        if (user.MiddleName == "None" || user.MiddleName == "none" || user.MiddleName == null || user.MiddleName == string.Empty)
                        {
                            user.DisplayName = user.FirstName + " " + user.LastName;
                        }
                        else
                        {
                            user.DisplayName = user.FirstName + " " + user.MiddleName + " " + user.LastName;
                        }

                        // Validate email address
                        if (myValidation.ValidateEmail(email))
                        {
                            // Add email address
                            user.Email = email;

                            // Validate phone
                            if (myValidation.ValidatePhone(phone))
                            {
                                // Add phone
                                user.Phone = myValidation.FormatPhone(phone);
                                context.SaveChanges();
                                MessageBox.Show("Your change is saved!");
                                this.OriginalForm.Show();
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
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnCancelEditProfileClick(object sender, EventArgs e)
        {
            this.OriginalForm.Show();
            this.Close();
        }

        /// <summary>
        /// Event handler to leave the focus on the textbox email.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void TxtStdEmailLeave(object sender, EventArgs e)
        {
            Validation myValidation = new Validation();
            if (myValidation.ValidateEmail(txtStdEmail.Text))
            {
                validEmail.Visible = true;
                this.invalidEmail.Visible = false;
            }
            else
            {
                validEmail.Visible = false;
                this.invalidEmail.Visible = true;
            }
        }
    }
}
