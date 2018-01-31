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
        /// Gets or sets a mainForm object that is loaded when the program starts
        /// </summary>
        public static MainForm mainForm { get; set; }

        /// <summary>
        /// Gets or sets the username that is logged into the app.
        /// </summary>
        public static string CurrentUser { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user is a supervisor.
        /// </summary>
        public static bool IsSupervisor { get; set; }

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
            mainForm = new MainForm();

            Application.Run(mainForm);
        }

        // TODO: Remove this code once we rebuild the new MainForm
        /*
        /// <summary>
        /// RolePage: A method to create and show a new role form once the user is logged in
        /// </summary>
        public static void RolePage()
        {
            RoleForm roleForm = new RoleForm();
            roleForm.Show();
        }
        */

        // TODO: Rebuild this method to show/hide menu options based on user type (Admin or Supervisor)
        /// <summary>
        /// OpenUserHomepage: A method that opens the correct start page based on the selected role
        /// </summary>
        /// <param name="roleText">The role name selected in the RoleForm</param>
        public static void UpdateMenus()
        {
            if (Program.IsAdmin)
            {
                // TODO: Fill in menu options that should be enabled for Admin users
            }
            else
            {
                // TODO: Fill in menu options that should be disabled for non-Admin users
            }

            if (Program.IsSupervisor)
            {
                // TODO: Fill in menu options that should be enabled for Supervisor users
            }
            else
            {
                // TODO: Fill in menu options that should be enabled for non-Supervisor users
            }
        }

        /// <summary>
        /// Method to handle Logout process
        /// </summary>
        public static void Logout()
        {
            // Clear out all static variables related to user
            Program.CurrentUser = null;
            Program.IsSupervisor = false;
            Program.IsAdmin = false;
        }

        public static void Login()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
    }
}
