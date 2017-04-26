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
    public partial class UserAdminForm : Form
    {
        public UserAdminForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblUsers_Click(object sender, EventArgs e)
        {

        }

        private void UserAdminForm_Load(object sender, EventArgs e)
        {
            using (var context = new db_sft_2172Entities())
            {
                var userQuery = from u in context.Users
                                select u;
                foreach (var item in userQuery)
                {
                    string username = (item.UserID + " " + item.FirstName + " " + item.LastName);
                    lstBoxUsers.Items.Add(username);
                }
            }
        }

        private void lstBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new db_sft_2172Entities())
            {

                string username = lstBoxUsers.SelectedItem.ToString();
                string[] userNameSplit = username.Split(' ');
                string usernum = userNameSplit[0];
                var userQuery = from u in context.Users
                                where u.UserID.Equals(usernum)
                                select u;
                if (userQuery.Count<User>() > 0)
                {
                    var userResult = userQuery.FirstOrDefault<User>();
                    txtBoxFirstName.Text = userResult.FirstName;
                    txtBoxLastName.Text = userResult.LastName;
                }
            }
        }
    }
}