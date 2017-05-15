// <copyright file="AdminForm.Designer.cs" company="PABT at NWTC">
//     Copyright 2017 PABT (Pao Xiong, Adam Smith, Brian Lueskow, Tim Durkee)
// </copyright>
namespace CoachConnect
{
    /// <summary>
    /// AdminForm: A class which is used to create a placeholder form to hold "admin tool" sub-forms
    /// </summary>
    public partial class AdminForm
    {
        /// <summary>
        /// A button that allows the user to change his/her password
        /// </summary>
        private System.Windows.Forms.Button btnChangePassword;

        /// <summary>
        /// A tab control object to allow different admin tool subforms to be displayed
        /// </summary>
        private System.Windows.Forms.TabControl tabControl1;

        /// <summary>
        /// A tab page to hold the Users admin tool as a subform
        /// </summary>
        private System.Windows.Forms.TabPage usersTabPage;

        /// <summary>
        /// A tab page to hold the Sessions admin tool as a subform
        /// </summary>
        private System.Windows.Forms.TabPage sessionsTabPage;

        /// <summary>
        /// A button that allows the user to exit the program
        /// </summary>
        private System.Windows.Forms.Button btnExit;

        /// <summary>
        /// A button that allows the user to logoff
        /// </summary>
        private System.Windows.Forms.Button btnLogOff;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.usersTabPage = new System.Windows.Forms.TabPage();
            this.sessionsTabPage = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(16, 547);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(151, 23);
            this.btnChangePassword.TabIndex = 2;
            this.btnChangePassword.Text = "Change My Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.BtnChangePasswordClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.usersTabPage);
            this.tabControl1.Controls.Add(this.sessionsTabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(769, 531);
            this.tabControl1.TabIndex = 3;
            // 
            // usersTabPage
            // 
            this.usersTabPage.Location = new System.Drawing.Point(4, 22);
            this.usersTabPage.Name = "usersTabPage";
            this.usersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.usersTabPage.Size = new System.Drawing.Size(761, 505);
            this.usersTabPage.TabIndex = 0;
            this.usersTabPage.Text = "Users";
            this.usersTabPage.UseVisualStyleBackColor = true;
            // 
            // sessionsTabPage
            // 
            this.sessionsTabPage.Location = new System.Drawing.Point(4, 22);
            this.sessionsTabPage.Name = "sessionsTabPage";
            this.sessionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.sessionsTabPage.Size = new System.Drawing.Size(835, 505);
            this.sessionsTabPage.TabIndex = 1;
            this.sessionsTabPage.Text = "Sessions";
            this.sessionsTabPage.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnExit.Location = new System.Drawing.Point(697, 547);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 23);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
            // 
            // btnLogOff
            // 
            this.btnLogOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnLogOff.Location = new System.Drawing.Point(592, 547);
            this.btnLogOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(99, 23);
            this.btnLogOff.TabIndex = 28;
            this.btnLogOff.Text = "Log Off";
            this.btnLogOff.UseVisualStyleBackColor = true;
            this.btnLogOff.Click += new System.EventHandler(this.BtnLogOffClick);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(788, 580);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogOff);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnChangePassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminFormFormClosed);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
    }
}