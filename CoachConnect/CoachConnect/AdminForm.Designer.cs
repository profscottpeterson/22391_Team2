namespace CoachConnect
{
    partial class AdminForm
    {
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.UsersTabPage = new System.Windows.Forms.TabPage();
            this.SessionsTabPage = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(8, 547);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(151, 23);
            this.btnChangePassword.TabIndex = 2;
            this.btnChangePassword.Text = "Change My Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.BtnChangePasswordClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.UsersTabPage);
            this.tabControl1.Controls.Add(this.SessionsTabPage);
            this.tabControl1.Location = new System.Drawing.Point(8, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(791, 531);
            this.tabControl1.TabIndex = 3;
            // 
            // UsersTabPage
            // 
            this.UsersTabPage.Location = new System.Drawing.Point(4, 22);
            this.UsersTabPage.Name = "UsersTabPage";
            this.UsersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.UsersTabPage.Size = new System.Drawing.Size(783, 505);
            this.UsersTabPage.TabIndex = 0;
            this.UsersTabPage.Text = "Users";
            this.UsersTabPage.UseVisualStyleBackColor = true;
            // 
            // SessionsTabPage
            // 
            this.SessionsTabPage.Location = new System.Drawing.Point(4, 22);
            this.SessionsTabPage.Name = "SessionsTabPage";
            this.SessionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SessionsTabPage.Size = new System.Drawing.Size(783, 505);
            this.SessionsTabPage.TabIndex = 1;
            this.SessionsTabPage.Text = "Sessions";
            this.SessionsTabPage.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnExit.Location = new System.Drawing.Point(715, 547);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 23);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
            // 
            // btnMenu
            // 
            this.btnMenu.Enabled = false;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnMenu.Location = new System.Drawing.Point(505, 547);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(99, 23);
            this.btnMenu.TabIndex = 27;
            this.btnMenu.Text = "Return to Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnLogOff
            // 
            this.btnLogOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnLogOff.Location = new System.Drawing.Point(610, 547);
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
            this.ClientSize = new System.Drawing.Size(811, 580);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMenu);
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
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage UsersTabPage;
        private System.Windows.Forms.TabPage SessionsTabPage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnLogOff;
    }
}