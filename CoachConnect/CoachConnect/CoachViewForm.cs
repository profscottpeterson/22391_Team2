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
    public partial class CoachViewForm : Form
    {
        public CoachViewForm()
        {
            InitializeComponent();
            User coach = new User();
            coach = getCoach();
            pbProfile.ImageLocation = coach.ProfilePic;
            lblCoachName.Text = coach.FirstName;
            lblCoachUser.Text = coach.UserID;
        }
        public User getCoach()
        {
            using(var context = new db_sft_2172Entities())
            {
                var coach = from c in context.Users
                            where c.UserID.Equals(Program.CurrentUser)
                            select c;
                return coach.First<User>();
            }
        }
    }
}
