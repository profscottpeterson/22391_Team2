// <copyright file="RoleForm.Designer.cs" company="PABT at NWTC">
//     Copyright 2017 PABT (Pao Xiong, Adam Smith, Brian Lueskow, Tim Durkee)
// </copyright>

namespace CoachConnect
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RoleForm"/> class.
    /// </summary>
    public partial class RoleForm
    {
        /// <summary>
        /// A label for the window header
        /// </summary>
        private System.Windows.Forms.Label lblRoleHeader;

        /// <summary>
        /// A button to accept the new password
        /// </summary>
        private System.Windows.Forms.Button btnAccept;

        /// <summary>
        /// A button to logout from the app
        /// </summary>
        private System.Windows.Forms.Button btnLogout;

        /// <summary>
        /// A button to exit the app
        /// </summary>
        private System.Windows.Forms.Button btnExit;

        /// <summary>
        ///  A combo box used to confirm a child's 
        /// </summary>
        private System.Windows.Forms.ComboBox cmbRoleChoice;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleForm));
            this.lblRoleHeader = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbRoleChoice = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblRoleHeader
            // 
            this.lblRoleHeader.AutoSize = true;
            this.lblRoleHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleHeader.Location = new System.Drawing.Point(63, 9);
            this.lblRoleHeader.Name = "lblRoleHeader";
            this.lblRoleHeader.Size = new System.Drawing.Size(139, 20);
            this.lblRoleHeader.TabIndex = 7;
            this.lblRoleHeader.Text = "Choose Your Role";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(12, 79);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 8;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.BtnAcceptClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(93, 79);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogoutClick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(174, 79);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
            // 
            // cmbRoleChoice
            // 
            this.cmbRoleChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoleChoice.FormattingEnabled = true;
            this.cmbRoleChoice.Location = new System.Drawing.Point(71, 41);
            this.cmbRoleChoice.Name = "cmbRoleChoice";
            this.cmbRoleChoice.Size = new System.Drawing.Size(121, 21);
            this.cmbRoleChoice.TabIndex = 11;
            // 
            // RoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 115);
            this.Controls.Add(this.cmbRoleChoice);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblRoleHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RoleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}