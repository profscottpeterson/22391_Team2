// <copyright file="Program.cs" company="PABT at NWTC">
//     Copyright 2017 PABT (Pao Xiong, Adam Smith, Brian Lueskow, Tim Durkee)
// </copyright>
namespace CoachConnect
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// The base class for the CoachConnect app
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Gets or sets a public static string to store the Coach role name
        /// </summary>
        public static string CoachRoleName { get; set; }

        /// <summary>
        /// Gets or sets a public static string to store the Student role name
        /// </summary>
        public static string StudentRoleName { get; set; }

        /// <summary>
        /// Gets or sets a public string to store the Admin role name
        /// </summary>
        public static string AdminRoleName { get; set; }

        /// <summary>
        /// Gets or sets a LoginForm object that is loaded when the program starts
        /// </summary>
        public static LoginForm LoginForm { get; set; }

        /// <summary>
        /// Gets or sets the username that is logged into the app.
        /// </summary>
        public static string CurrentUser { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user is a student.
        /// </summary>
        public static bool IsStudent { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user is a coach.
        /// </summary>
        public static bool IsCoach { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user is an admin.
        /// </summary>
        public static bool IsAdmin { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm = new LoginForm();

            Program.StudentRoleName = "Student";
            Program.CoachRoleName = "Coach";
            Program.AdminRoleName = "Admin";
            
            Application.Run(LoginForm);
        }

        /// <summary>
        /// RolePage: A method to create and show a new role form once the user is logged in
        /// </summary>
        public static void RolePage()
        {
            RoleForm roleForm = new RoleForm();
            roleForm.Show();
        }

        /// <summary>
        /// OpenUserHomepage: A method that opens the correct start page based on the selected role
        /// </summary>
        /// <param name="roleText">The role name selected in the RoleForm</param>
        public static void OpenUserHomepage(string roleText)
        {
            if (roleText == Program.StudentRoleName)
            {
                var newForm = new FindCoachForm();
                newForm.Show();
            }
            else if (roleText == Program.CoachRoleName)
            {
                var newForm = new FrmCoachView();
                newForm.Show();
            }
            else if (roleText == Program.AdminRoleName)
            {
                var newForm = new AdminForm();
                newForm.Show();
            }
        }
    }
}
