using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoachConnect
{
    static class Program
    {
        public static LoginForm loginForm;

        public static User CurrentUser { get; set; }

        public static string coachRoleName = "Coach";
        public static string studentRoleName = "Student";
        public static string adminRoleName = "Admin";


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            loginForm = new LoginForm();

            //Application.Run(loginForm);

            Application.Run(new frmChangePassword());
        }

        public static void RolePage()
        {
            using (var context = new db_sft_2172Entities())
            {
                var roleQuery = from r in context.Roles
                                select r;

                var roleNameQuery = from n in roleQuery
                                    select n.Name;

                RoleForm roleForm = new RoleForm();
                roleForm.Show();
            }
        }

        public static void ChangePassword()
        {

        }

        public static void openUserHomepage(string roleText)
        {
            // Check if current user is a coach
            // If so, load the coach page; if not, load the student page.
            using (var context = new db_sft_2172Entities())
            {
                var userQuery = from u in context.Users
                                where u.UserID.Equals(Program.CurrentUser)
                                select u;

                var userResult = userQuery.FirstOrDefault<User>();

                if (roleText == studentRoleName)
                {
                    //var newForm = new FindCoachForm();
                    var newForm = new frmCoachView();
                    newForm.Show();
                }
                else if (roleText == coachRoleName)
                {
                    var newForm = new frmCoachView();
                    newForm.Show();
                }
                else if (roleText == adminRoleName)
                {
                    var newForm = new UserAdminForm();
                    newForm.Show();
                }
            }
        }
    }
}
