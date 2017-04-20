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

namespace CoachConnect
{
    public partial class frmCoachView : Form
    {
        public string OriginalPic;
        public frmCoachView()
        {
            InitializeComponent();
            User coach = new User();
            coach = getCoach();
            this.Text = coach.FirstName + " " + coach.LastName + " - " + coach.UserID;
            pbProfile.ImageLocation = coach.ProfilePic;
            pbEditPic.ImageLocation = coach.ProfilePic;
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
    }
}