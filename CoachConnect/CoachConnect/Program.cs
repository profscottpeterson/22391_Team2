using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoachConnect
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Application.Run(new LoginForm());
            //Application.Run(new frmCoachsSchedule());
        }

        public static void OpenUserHomepage()
        {
            // Check if current user is a coach
            // If so, load the coach page; if not, load the student page.
            using (var context = new db_sft_2172Entities())
            {
                var userQuery = from u in context.Users
                                where u.UserID.Equals(Program.CurrentUser)
                                select u;

                var userResult = userQuery.FirstOrDefault<User>();

                if (userResult.IsCoach)
                {
                    //var newForm = new FindCoachForm();
                    var newForm = new frmCoachsSchedule();
                    newForm.Show();
                }
                else
                {
                    //var newForm = new FindStudentFom();
                    //newForm.Show();
                    //Application.Run(new FindStudentForm());
                }
            }
        }

        public static string CurrentUser
        {
            get;
            set;
        }

        public static string UserType
        {
            get;
            set;
        }
    }
}
