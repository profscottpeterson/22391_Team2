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
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.listBoxAdminTools = new System.Windows.Forms.ListBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelAdmin
            // 
            this.panelAdmin.AutoScroll = true;
            this.panelAdmin.Location = new System.Drawing.Point(169, 12);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(740, 511);
            this.panelAdmin.TabIndex = 0;
            // 
            // listBoxAdminTools
            // 
            this.listBoxAdminTools.FormattingEnabled = true;
            this.listBoxAdminTools.Location = new System.Drawing.Point(12, 12);
            this.listBoxAdminTools.Name = "listBoxAdminTools";
            this.listBoxAdminTools.Size = new System.Drawing.Size(151, 459);
            this.listBoxAdminTools.TabIndex = 1;
            this.listBoxAdminTools.SelectedIndexChanged += new System.EventHandler(this.listBoxAdminTools_SelectedIndexChanged);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(12, 482);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(151, 27);
            this.btnChangePassword.TabIndex = 2;
            this.btnChangePassword.Text = "Change My Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(916, 531);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.listBoxAdminTools);
            this.Controls.Add(this.panelAdmin);
            this.Name = "AdminForm";
            this.Text = "Administration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.ListBox listBoxAdminTools;
        private System.Windows.Forms.Button btnChangePassword;
    }
}