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
    public partial class EditCoachProfileForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditCoachProfileForm" /> class.
        /// </summary>
        public EditCoachProfileForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditCoachProfileForm" /> class.
        /// </summary>
        /// <param name="original">The original calling form</param>
        public EditCoachProfileForm(Form original)
        {
            this.InitializeComponent();
            this.GetCoachInfo();
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
        private void GetCoachInfo()
        {
            using (var context = new db_sft_2172Entities())
            {
                var coachQuery = from u in context.Coaches
                                where u.CoachID.Equals(Program.CurrentUser)
                                select u;
                var coachResult = coachQuery.FirstOrDefault<Coach>();
                this.txtFirstName.Text = coachResult.FirstName;
                this.txtMiddleName.Text = coachResult.MiddleName;
                this.txtLastName.Text = coachResult.LastName;
                this.txtDisplayName.Text = coachResult.DisplayName;
                this.txtEmail.Text = coachResult.Email;
                this.txtPhone.Text = coachResult.Phone;

                // TODO: Add code to handle populating and selection of Supervisors
                this.cbxSupervisor.SelectedValue = coachResult.SupervisorID;
            }
        }

        // TODO: Need to refactor validation code and display all issues at same time.
        // TODO: Disable Save button when validation errors are found, and enable Save button when validation errors are resolved.
      
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
                string firstName = this.txtFirstName.Text;
                string midddleName = this.txtMiddleName.Text;
                string lastName = this.txtLastName.Text;
                string email = this.txtEmail.Text;
                string phone = this.txtPhone.Text;

                if (string.IsNullOrEmpty(firstName))
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
                else if (cbxSupervisor.SelectedIndex < 0)
                {
                    this.lblSupervisor.Visible = true;
                }
                else
                {
                    this.lblFirstNameError.Visible = false;
                    this.lblMiddleNameError.Visible = false;
                    this.lblLastNameError.Visible = false;
                    this.lblErrorEmail.Visible = false;
                    this.lblErrorPhone.Visible = false;
                    this.lblSupervisor.Visible = false;

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
                                MessageBox.Show("Enter your phone number using 10 digits!");
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
            if (myValidation.ValidateEmail(txtEmail.Text))
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
