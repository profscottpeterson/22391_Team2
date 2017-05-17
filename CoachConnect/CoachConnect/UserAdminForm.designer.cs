// <copyright file="UserAdminForm.designer.cs" company="PABT at NWTC">
//     Copyright 2017 PABT (Pao Xiong, Adam Smith, Brian Lueskow, Tim Durkee)
// </copyright>
namespace CoachConnect
{
    /// <summary>
    /// A form to allow admins to edit user information
    /// </summary>
    public partial class UserAdminForm
    {
        /// <summary>
        /// A label for the User admin form header.
        /// </summary>
        private System.Windows.Forms.Label lblAdminForm;

        /// <summary>
        /// A label for the password text box
        /// </summary>
        private System.Windows.Forms.Label lblPassword;

        /// <summary>
        /// A text box to hold the userID
        /// </summary>
        private System.Windows.Forms.TextBox txtBoxUserID;

        /// <summary>
        /// A lable for the user ID text box
        /// </summary>
        private System.Windows.Forms.Label lblUserID;

        /// <summary>
        /// A label for the middle name text box
        /// </summary>
        private System.Windows.Forms.Label lblMiddleName;

        /// <summary>
        /// A label for the last name text box
        /// </summary>
        private System.Windows.Forms.Label lblLastName;

        /// <summary>
        /// A label for the first name text box
        /// </summary>
        private System.Windows.Forms.Label lblFirstName;

        /// <summary>
        /// A text box to hold the middle name
        /// </summary>
        private System.Windows.Forms.TextBox txtBoxMiddleName;

        /// <summary>
        /// A text box to hold the password
        /// </summary>
        private System.Windows.Forms.TextBox txtBoxPassword;

        /// <summary>
        /// A text box to hold the last name
        /// </summary>
        private System.Windows.Forms.TextBox txtBoxLastName;

        /// <summary>
        /// A text box to hold the first name
        /// </summary>
        private System.Windows.Forms.TextBox txtBoxFirstName;

        /// <summary>
        /// A list box to hold the list of users
        /// </summary>
        private System.Windows.Forms.ListBox lstBoxUsers;

        /// <summary>
        /// A label to act as the User List header
        /// </summary>
        private System.Windows.Forms.Label lblUsers;

        /// <summary>
        /// A check box to give the current user Student permissions
        /// </summary>
        private System.Windows.Forms.CheckBox chkBoxStudent;

        /// <summary>
        /// A check box to give the current user Coach permissions
        /// </summary>
        private System.Windows.Forms.CheckBox chkBoxCoach;

        /// <summary>
        /// A check box to give the current user Admin permissions
        /// </summary>
        private System.Windows.Forms.CheckBox chkBoxAdmin;

        /// <summary>
        /// A button to make the current user active
        /// </summary>
        private System.Windows.Forms.CheckBox chkBoxActive;

        /// <summary>
        /// A button to add a new user
        /// </summary>
        private System.Windows.Forms.Button btnAdd;

        /// <summary>
        /// A button to set the current selected user as Inactive
        /// </summary>
        private System.Windows.Forms.Button btnMinus;

        /// <summary>
        /// A button to submit user profile changes
        /// </summary>
        private System.Windows.Forms.Button btnSubmit;

        /// <summary>
        /// A button to reset the current user's password
        /// </summary>
        private System.Windows.Forms.Button btnResetUserPassword;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAdminForm));
            this.lblAdminForm = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxUserID = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtBoxMiddleName = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.lstBoxUsers = new System.Windows.Forms.ListBox();
            this.lblUsers = new System.Windows.Forms.Label();
            this.chkBoxStudent = new System.Windows.Forms.CheckBox();
            this.chkBoxCoach = new System.Windows.Forms.CheckBox();
            this.chkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.chkBoxActive = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnResetUserPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdminForm
            // 
            this.lblAdminForm.AutoSize = true;
            this.lblAdminForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminForm.Location = new System.Drawing.Point(216, 16);
            this.lblAdminForm.Name = "lblAdminForm";
            this.lblAdminForm.Size = new System.Drawing.Size(220, 31);
            this.lblAdminForm.TabIndex = 7;
            this.lblAdminForm.Text = "Update User Info";
            this.lblAdminForm.UseWaitCursor = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(336, 312);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 43;
            this.lblPassword.Text = " Password";
            this.lblPassword.Visible = false;
            // 
            // txtBoxUserID
            // 
            this.txtBoxUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUserID.Location = new System.Drawing.Point(336, 289);
            this.txtBoxUserID.Name = "txtBoxUserID";
            this.txtBoxUserID.ReadOnly = true;
            this.txtBoxUserID.Size = new System.Drawing.Size(188, 20);
            this.txtBoxUserID.TabIndex = 6;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(333, 273);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(43, 13);
            this.lblUserID.TabIndex = 40;
            this.lblUserID.Text = "User ID";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.Location = new System.Drawing.Point(333, 208);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(69, 13);
            this.lblMiddleName.TabIndex = 39;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(335, 139);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 38;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(335, 75);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name";
            // 
            // txtBoxMiddleName
            // 
            this.txtBoxMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMiddleName.Location = new System.Drawing.Point(336, 224);
            this.txtBoxMiddleName.Name = "txtBoxMiddleName";
            this.txtBoxMiddleName.Size = new System.Drawing.Size(188, 20);
            this.txtBoxMiddleName.TabIndex = 5;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.Location = new System.Drawing.Point(336, 328);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(188, 20);
            this.txtBoxPassword.TabIndex = 7;
            this.txtBoxPassword.Visible = false;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLastName.Location = new System.Drawing.Point(336, 155);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(188, 20);
            this.txtBoxLastName.TabIndex = 4;
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFirstName.Location = new System.Drawing.Point(336, 91);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(188, 20);
            this.txtBoxFirstName.TabIndex = 3;
            // 
            // lstBoxUsers
            // 
            this.lstBoxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxUsers.FormattingEnabled = true;
            this.lstBoxUsers.Location = new System.Drawing.Point(12, 84);
            this.lstBoxUsers.Name = "lstBoxUsers";
            this.lstBoxUsers.Size = new System.Drawing.Size(288, 264);
            this.lstBoxUsers.TabIndex = 0;
            this.lstBoxUsers.SelectedIndexChanged += new System.EventHandler(this.LstBoxUsersSelectedIndexChanged);
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(110, 61);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(72, 20);
            this.lblUsers.TabIndex = 48;
            this.lblUsers.Text = "User List";
            // 
            // chkBoxStudent
            // 
            this.chkBoxStudent.AutoSize = true;
            this.chkBoxStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxStudent.Location = new System.Drawing.Point(556, 172);
            this.chkBoxStudent.Name = "chkBoxStudent";
            this.chkBoxStudent.Size = new System.Drawing.Size(63, 17);
            this.chkBoxStudent.TabIndex = 10;
            this.chkBoxStudent.Text = "Student";
            this.chkBoxStudent.UseVisualStyleBackColor = true;
            // 
            // chkBoxCoach
            // 
            this.chkBoxCoach.AutoSize = true;
            this.chkBoxCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxCoach.Location = new System.Drawing.Point(556, 207);
            this.chkBoxCoach.Name = "chkBoxCoach";
            this.chkBoxCoach.Size = new System.Drawing.Size(57, 17);
            this.chkBoxCoach.TabIndex = 11;
            this.chkBoxCoach.Text = "Coach";
            this.chkBoxCoach.UseVisualStyleBackColor = true;
            // 
            // chkBoxAdmin
            // 
            this.chkBoxAdmin.AutoSize = true;
            this.chkBoxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxAdmin.Location = new System.Drawing.Point(556, 137);
            this.chkBoxAdmin.Name = "chkBoxAdmin";
            this.chkBoxAdmin.Size = new System.Drawing.Size(55, 17);
            this.chkBoxAdmin.TabIndex = 9;
            this.chkBoxAdmin.Text = "Admin";
            this.chkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // chkBoxActive
            // 
            this.chkBoxActive.AutoSize = true;
            this.chkBoxActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxActive.Location = new System.Drawing.Point(556, 102);
            this.chkBoxActive.Name = "chkBoxActive";
            this.chkBoxActive.Size = new System.Drawing.Size(56, 17);
            this.chkBoxActive.TabIndex = 8;
            this.chkBoxActive.Text = "Active";
            this.chkBoxActive.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(12, 354);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 22);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add User";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(156, 354);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(144, 22);
            this.btnMinus.TabIndex = 2;
            this.btnMinus.Text = "Disable User";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.BtnMinusClick);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(538, 354);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(81, 22);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
            // 
            // btnResetUserPassword
            // 
            this.btnResetUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetUserPassword.Location = new System.Drawing.Point(336, 354);
            this.btnResetUserPassword.Name = "btnResetUserPassword";
            this.btnResetUserPassword.Size = new System.Drawing.Size(126, 22);
            this.btnResetUserPassword.TabIndex = 49;
            this.btnResetUserPassword.Text = "Reset User Password";
            this.btnResetUserPassword.UseVisualStyleBackColor = true;
            this.btnResetUserPassword.Click += new System.EventHandler(this.BtnResetPasswordClick);
            // 
            // UserAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 389);
            this.Controls.Add(this.btnResetUserPassword);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chkBoxActive);
            this.Controls.Add(this.chkBoxAdmin);
            this.Controls.Add(this.chkBoxCoach);
            this.Controls.Add(this.chkBoxStudent);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.lstBoxUsers);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtBoxUserID);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtBoxMiddleName);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.lblAdminForm);
            this.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserAdminForm";
            this.Text = "User Admin";
            this.Load += new System.EventHandler(this.UserAdminFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}
