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
    public partial class EditStudentProfileForm : Form
    {
        private TextBox txtStdEmail;
        private TextBox txtStdPhone;
        private Label lblErrorURL;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtStdURL;

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
                //txtStdLName.Text = userResult.FirstName + " " + userResult.LastName;
                txtStdURL.Text = userResult.ProfilePic;
                //txtStdEmail.Text = userResult.Email;
                //.Text = userResult.Phone;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new db_sft_2172Entities())
            {

                User user = context.Users.Single(u => u.UserID == Program.CurrentUser);
                string url = txtStdURL.Text;
                string email = txtStdEmail.Text;
                string phone = txtStdPhone.Text;
                if (String.IsNullOrEmpty(url))
                {
                    lblErrorURL.Text = "Field URL is required!";
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
                    int save = context.SaveChanges();
                    MessageBox.Show("Your change is saved!");
                    MessageBox.Show(save.ToString());
                    FindCoachForm coach = new FindCoachForm();
                    coach.Show();
                    this.Close();
                }
               
                
                //user.Email = txtStdEmail.Text;
                //user.Phone = txtStdPhone.Text;
               
                
            }
        }

        private void btbEditProfile_Click(object sender, EventArgs e)
        {
            FindCoachForm mainForm = new FindCoachForm();
            mainForm.Show();
            this.Close();

        }

        private void InitializeComponent()
        {
            this.txtStdURL = new System.Windows.Forms.TextBox();
            this.txtStdEmail = new System.Windows.Forms.TextBox();
            this.txtStdPhone = new System.Windows.Forms.TextBox();
            this.lblErrorURL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStdURL
            // 
            this.txtStdURL.Location = new System.Drawing.Point(157, 67);
            this.txtStdURL.Name = "txtStdURL";
            this.txtStdURL.Size = new System.Drawing.Size(150, 20);
            this.txtStdURL.TabIndex = 0;
            // 
            // txtStdEmail
            // 
            this.txtStdEmail.Location = new System.Drawing.Point(157, 119);
            this.txtStdEmail.Name = "txtStdEmail";
            this.txtStdEmail.Size = new System.Drawing.Size(150, 20);
            this.txtStdEmail.TabIndex = 1;
            // 
            // txtStdPhone
            // 
            this.txtStdPhone.Location = new System.Drawing.Point(157, 170);
            this.txtStdPhone.Name = "txtStdPhone";
            this.txtStdPhone.Size = new System.Drawing.Size(150, 20);
            this.txtStdPhone.TabIndex = 2;
            // 
            // lblErrorURL
            // 
            this.lblErrorURL.Location = new System.Drawing.Point(157, 90);
            this.lblErrorURL.Name = "lblErrorURL";
            this.lblErrorURL.Size = new System.Drawing.Size(150, 23);
            this.lblErrorURL.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Profile Image URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone:";
            // 
            // EditStudentProfileForm
            // 
            this.ClientSize = new System.Drawing.Size(343, 324);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblErrorURL);
            this.Controls.Add(this.txtStdPhone);
            this.Controls.Add(this.txtStdEmail);
            this.Controls.Add(this.txtStdURL);
            this.Name = "EditStudentProfileForm";
            this.Text = "Edit Student Profile Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
