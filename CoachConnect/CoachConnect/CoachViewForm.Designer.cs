namespace CoachConnect
{
    partial class frmCoachView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoachView));
            this.tbForm = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvAvailable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCoachName = new System.Windows.Forms.Label();
            this.lblCoachUser = new System.Windows.Forms.Label();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.grpPassword = new System.Windows.Forms.GroupBox();
            this.pbConfirmPass = new System.Windows.Forms.PictureBox();
            this.pbNewPass = new System.Windows.Forms.PictureBox();
            this.pbcurrentPassCorrect = new System.Windows.Forms.PictureBox();
            this.lblWarningCurrentPass = new System.Windows.Forms.Label();
            this.btnPassCancel = new System.Windows.Forms.Button();
            this.btnUpdatePass = new System.Windows.Forms.Button();
            this.txtConfirmNewPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtCurrentPass = new System.Windows.Forms.TextBox();
            this.lblOldPass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMatchPass = new System.Windows.Forms.Label();
            this.grbProfilePic = new System.Windows.Forms.GroupBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnPicSubmit = new System.Windows.Forms.Button();
            this.txtPicURL = new System.Windows.Forms.TextBox();
            this.btnEditPic = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbEditPic = new System.Windows.Forms.PictureBox();
            this.grpPersonalInfo = new System.Windows.Forms.GroupBox();
            this.btnSubmitInfo = new System.Windows.Forms.Button();
            this.btnCancelInfo = new System.Windows.Forms.Button();
            this.btnEditInfo = new System.Windows.Forms.Button();
            this.lblMemberSince = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtMiddle = new System.Windows.Forms.TextBox();
            this.lblMiddle = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tbForm.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.grpPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcurrentPassCorrect)).BeginInit();
            this.grbProfilePic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditPic)).BeginInit();
            this.grpPersonalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbForm
            // 
            this.tbForm.Controls.Add(this.tabPage1);
            this.tbForm.Controls.Add(this.tabPage2);
            this.tbForm.Controls.Add(this.tabPage3);
            this.tbForm.Controls.Add(this.tabPage4);
            this.tbForm.Location = new System.Drawing.Point(12, 12);
            this.tbForm.Name = "tbForm";
            this.tbForm.SelectedIndex = 0;
            this.tbForm.Size = new System.Drawing.Size(538, 449);
            this.tbForm.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(530, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.dgvAvailable);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lblCoachName);
            this.tabPage2.Controls.Add(this.lblCoachUser);
            this.tabPage2.Controls.Add(this.pbProfile);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(530, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Current Schedule";
            // 
            // dgvAvailable
            // 
            this.dgvAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailable.Location = new System.Drawing.Point(6, 209);
            this.dgvAvailable.Name = "dgvAvailable";
            this.dgvAvailable.Size = new System.Drawing.Size(518, 197);
            this.dgvAvailable.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current Availability";
            // 
            // lblCoachName
            // 
            this.lblCoachName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoachName.Location = new System.Drawing.Point(126, 20);
            this.lblCoachName.Name = "lblCoachName";
            this.lblCoachName.Size = new System.Drawing.Size(398, 23);
            this.lblCoachName.TabIndex = 2;
            this.lblCoachName.Text = "coach";
            this.lblCoachName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCoachUser
            // 
            this.lblCoachUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoachUser.Location = new System.Drawing.Point(126, 52);
            this.lblCoachUser.Name = "lblCoachUser";
            this.lblCoachUser.Size = new System.Drawing.Size(398, 23);
            this.lblCoachUser.TabIndex = 1;
            this.lblCoachUser.Text = "username";
            this.lblCoachUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbProfile
            // 
            this.pbProfile.Location = new System.Drawing.Point(20, 20);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(100, 100);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfile.TabIndex = 0;
            this.pbProfile.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(530, 423);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Edit Availablity";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.grpPassword);
            this.tabPage4.Controls.Add(this.grbProfilePic);
            this.tabPage4.Controls.Add(this.grpPersonalInfo);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(530, 423);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Edit Profile";
            // 
            // grpPassword
            // 
            this.grpPassword.Controls.Add(this.pbConfirmPass);
            this.grpPassword.Controls.Add(this.pbNewPass);
            this.grpPassword.Controls.Add(this.pbcurrentPassCorrect);
            this.grpPassword.Controls.Add(this.lblWarningCurrentPass);
            this.grpPassword.Controls.Add(this.btnPassCancel);
            this.grpPassword.Controls.Add(this.btnUpdatePass);
            this.grpPassword.Controls.Add(this.txtConfirmNewPass);
            this.grpPassword.Controls.Add(this.txtNewPass);
            this.grpPassword.Controls.Add(this.txtCurrentPass);
            this.grpPassword.Controls.Add(this.lblOldPass);
            this.grpPassword.Controls.Add(this.label3);
            this.grpPassword.Controls.Add(this.label4);
            this.grpPassword.Controls.Add(this.lblMatchPass);
            this.grpPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPassword.Location = new System.Drawing.Point(15, 273);
            this.grpPassword.Name = "grpPassword";
            this.grpPassword.Size = new System.Drawing.Size(497, 149);
            this.grpPassword.TabIndex = 15;
            this.grpPassword.TabStop = false;
            this.grpPassword.Text = "Security Information";
            // 
            // pbConfirmPass
            // 
            this.pbConfirmPass.Image = ((System.Drawing.Image)(resources.GetObject("pbConfirmPass.Image")));
            this.pbConfirmPass.Location = new System.Drawing.Point(399, 85);
            this.pbConfirmPass.Name = "pbConfirmPass";
            this.pbConfirmPass.Size = new System.Drawing.Size(20, 20);
            this.pbConfirmPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbConfirmPass.TabIndex = 32;
            this.pbConfirmPass.TabStop = false;
            this.pbConfirmPass.Visible = false;
            // 
            // pbNewPass
            // 
            this.pbNewPass.Image = ((System.Drawing.Image)(resources.GetObject("pbNewPass.Image")));
            this.pbNewPass.Location = new System.Drawing.Point(399, 51);
            this.pbNewPass.Name = "pbNewPass";
            this.pbNewPass.Size = new System.Drawing.Size(20, 20);
            this.pbNewPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbNewPass.TabIndex = 31;
            this.pbNewPass.TabStop = false;
            this.pbNewPass.Visible = false;
            // 
            // pbcurrentPassCorrect
            // 
            this.pbcurrentPassCorrect.Image = ((System.Drawing.Image)(resources.GetObject("pbcurrentPassCorrect.Image")));
            this.pbcurrentPassCorrect.Location = new System.Drawing.Point(399, 17);
            this.pbcurrentPassCorrect.Name = "pbcurrentPassCorrect";
            this.pbcurrentPassCorrect.Size = new System.Drawing.Size(20, 20);
            this.pbcurrentPassCorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbcurrentPassCorrect.TabIndex = 30;
            this.pbcurrentPassCorrect.TabStop = false;
            this.pbcurrentPassCorrect.Visible = false;
            // 
            // lblWarningCurrentPass
            // 
            this.lblWarningCurrentPass.AutoSize = true;
            this.lblWarningCurrentPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarningCurrentPass.ForeColor = System.Drawing.Color.Red;
            this.lblWarningCurrentPass.Location = new System.Drawing.Point(396, 21);
            this.lblWarningCurrentPass.Name = "lblWarningCurrentPass";
            this.lblWarningCurrentPass.Size = new System.Drawing.Size(53, 13);
            this.lblWarningCurrentPass.TabIndex = 29;
            this.lblWarningCurrentPass.Text = "*Incorrect";
            this.lblWarningCurrentPass.Visible = false;
            // 
            // btnPassCancel
            // 
            this.btnPassCancel.Location = new System.Drawing.Point(315, 122);
            this.btnPassCancel.Name = "btnPassCancel";
            this.btnPassCancel.Size = new System.Drawing.Size(75, 23);
            this.btnPassCancel.TabIndex = 28;
            this.btnPassCancel.Text = "Cancel";
            this.btnPassCancel.UseVisualStyleBackColor = true;
            this.btnPassCancel.Visible = false;
            this.btnPassCancel.Click += new System.EventHandler(this.btnPassCancel_Click);
            // 
            // btnUpdatePass
            // 
            this.btnUpdatePass.Location = new System.Drawing.Point(196, 122);
            this.btnUpdatePass.Name = "btnUpdatePass";
            this.btnUpdatePass.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePass.TabIndex = 27;
            this.btnUpdatePass.Text = "Update";
            this.btnUpdatePass.UseVisualStyleBackColor = true;
            this.btnUpdatePass.Visible = false;
            // 
            // txtConfirmNewPass
            // 
            this.txtConfirmNewPass.Enabled = false;
            this.txtConfirmNewPass.Location = new System.Drawing.Point(196, 84);
            this.txtConfirmNewPass.Name = "txtConfirmNewPass";
            this.txtConfirmNewPass.PasswordChar = '*';
            this.txtConfirmNewPass.Size = new System.Drawing.Size(194, 22);
            this.txtConfirmNewPass.TabIndex = 26;
            this.txtConfirmNewPass.TextChanged += new System.EventHandler(this.txtConfirmNewPass_TextChanged);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Enabled = false;
            this.txtNewPass.Location = new System.Drawing.Point(196, 50);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(194, 22);
            this.txtNewPass.TabIndex = 25;
            this.txtNewPass.TextChanged += new System.EventHandler(this.txtNewPass_TextChanged);
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.Location = new System.Drawing.Point(196, 16);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.PasswordChar = '*';
            this.txtCurrentPass.Size = new System.Drawing.Size(194, 22);
            this.txtCurrentPass.TabIndex = 24;
            this.txtCurrentPass.TextChanged += new System.EventHandler(this.txtCurrentPass_TextChanged);
            // 
            // lblOldPass
            // 
            this.lblOldPass.AutoSize = true;
            this.lblOldPass.Location = new System.Drawing.Point(64, 19);
            this.lblOldPass.Name = "lblOldPass";
            this.lblOldPass.Size = new System.Drawing.Size(113, 16);
            this.lblOldPass.TabIndex = 21;
            this.lblOldPass.Text = "Current Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Enter New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Reenter new Password";
            // 
            // lblMatchPass
            // 
            this.lblMatchPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchPass.ForeColor = System.Drawing.Color.Red;
            this.lblMatchPass.Location = new System.Drawing.Point(399, 57);
            this.lblMatchPass.Name = "lblMatchPass";
            this.lblMatchPass.Size = new System.Drawing.Size(92, 46);
            this.lblMatchPass.TabIndex = 33;
            this.lblMatchPass.Text = "*Passwords Do Not Match";
            this.lblMatchPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMatchPass.Visible = false;
            // 
            // grbProfilePic
            // 
            this.grbProfilePic.Controls.Add(this.btnPreview);
            this.grbProfilePic.Controls.Add(this.btnPicSubmit);
            this.grbProfilePic.Controls.Add(this.txtPicURL);
            this.grbProfilePic.Controls.Add(this.btnEditPic);
            this.grbProfilePic.Controls.Add(this.btnCancel);
            this.grbProfilePic.Controls.Add(this.pbEditPic);
            this.grbProfilePic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProfilePic.Location = new System.Drawing.Point(12, -2);
            this.grbProfilePic.Name = "grbProfilePic";
            this.grbProfilePic.Size = new System.Drawing.Size(180, 269);
            this.grbProfilePic.TabIndex = 14;
            this.grbProfilePic.TabStop = false;
            this.grbProfilePic.Text = "Profile Pic";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(12, 184);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Visible = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnPicSubmit
            // 
            this.btnPicSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPicSubmit.Location = new System.Drawing.Point(12, 185);
            this.btnPicSubmit.Name = "btnPicSubmit";
            this.btnPicSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnPicSubmit.TabIndex = 5;
            this.btnPicSubmit.Text = "Submit";
            this.btnPicSubmit.UseVisualStyleBackColor = true;
            this.btnPicSubmit.Visible = false;
            this.btnPicSubmit.Click += new System.EventHandler(this.btnPicSubmit_Click);
            // 
            // txtPicURL
            // 
            this.txtPicURL.Enabled = false;
            this.txtPicURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPicURL.Location = new System.Drawing.Point(12, 231);
            this.txtPicURL.Name = "txtPicURL";
            this.txtPicURL.Size = new System.Drawing.Size(156, 26);
            this.txtPicURL.TabIndex = 3;
            this.txtPicURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnEditPic
            // 
            this.btnEditPic.Location = new System.Drawing.Point(12, 184);
            this.btnEditPic.Name = "btnEditPic";
            this.btnEditPic.Size = new System.Drawing.Size(75, 23);
            this.btnEditPic.TabIndex = 2;
            this.btnEditPic.Text = "Edit Pic";
            this.btnEditPic.UseVisualStyleBackColor = true;
            this.btnEditPic.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(93, 184);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pbEditPic
            // 
            this.pbEditPic.Location = new System.Drawing.Point(12, 24);
            this.pbEditPic.Name = "pbEditPic";
            this.pbEditPic.Size = new System.Drawing.Size(156, 150);
            this.pbEditPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbEditPic.TabIndex = 1;
            this.pbEditPic.TabStop = false;
            // 
            // grpPersonalInfo
            // 
            this.grpPersonalInfo.Controls.Add(this.btnSubmitInfo);
            this.grpPersonalInfo.Controls.Add(this.btnCancelInfo);
            this.grpPersonalInfo.Controls.Add(this.btnEditInfo);
            this.grpPersonalInfo.Controls.Add(this.lblMemberSince);
            this.grpPersonalInfo.Controls.Add(this.txtEmail);
            this.grpPersonalInfo.Controls.Add(this.lblEmail);
            this.grpPersonalInfo.Controls.Add(this.txtMiddle);
            this.grpPersonalInfo.Controls.Add(this.lblMiddle);
            this.grpPersonalInfo.Controls.Add(this.txtPhone);
            this.grpPersonalInfo.Controls.Add(this.lblPhone);
            this.grpPersonalInfo.Controls.Add(this.txtLName);
            this.grpPersonalInfo.Controls.Add(this.txtFName);
            this.grpPersonalInfo.Controls.Add(this.lblLName);
            this.grpPersonalInfo.Controls.Add(this.lblFName);
            this.grpPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPersonalInfo.Location = new System.Drawing.Point(204, -2);
            this.grpPersonalInfo.Name = "grpPersonalInfo";
            this.grpPersonalInfo.Size = new System.Drawing.Size(315, 269);
            this.grpPersonalInfo.TabIndex = 13;
            this.grpPersonalInfo.TabStop = false;
            this.grpPersonalInfo.Text = "Personal Information";
            // 
            // btnSubmitInfo
            // 
            this.btnSubmitInfo.Location = new System.Drawing.Point(75, 232);
            this.btnSubmitInfo.Name = "btnSubmitInfo";
            this.btnSubmitInfo.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitInfo.TabIndex = 20;
            this.btnSubmitInfo.Text = "Update";
            this.btnSubmitInfo.UseVisualStyleBackColor = true;
            this.btnSubmitInfo.Visible = false;
            // 
            // btnCancelInfo
            // 
            this.btnCancelInfo.Location = new System.Drawing.Point(156, 232);
            this.btnCancelInfo.Name = "btnCancelInfo";
            this.btnCancelInfo.Size = new System.Drawing.Size(75, 23);
            this.btnCancelInfo.TabIndex = 19;
            this.btnCancelInfo.Text = "Cancel";
            this.btnCancelInfo.UseVisualStyleBackColor = true;
            this.btnCancelInfo.Visible = false;
            // 
            // btnEditInfo
            // 
            this.btnEditInfo.Location = new System.Drawing.Point(115, 232);
            this.btnEditInfo.Name = "btnEditInfo";
            this.btnEditInfo.Size = new System.Drawing.Size(75, 23);
            this.btnEditInfo.TabIndex = 18;
            this.btnEditInfo.Text = "Edit";
            this.btnEditInfo.UseVisualStyleBackColor = true;
            // 
            // lblMemberSince
            // 
            this.lblMemberSince.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberSince.Location = new System.Drawing.Point(6, 24);
            this.lblMemberSince.Name = "lblMemberSince";
            this.lblMemberSince.Size = new System.Drawing.Size(303, 30);
            this.lblMemberSince.TabIndex = 17;
            this.lblMemberSince.Text = "Member date";
            this.lblMemberSince.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(108, 195);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(201, 22);
            this.txtEmail.TabIndex = 16;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(52, 196);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email";
            // 
            // txtMiddle
            // 
            this.txtMiddle.BackColor = System.Drawing.SystemColors.Window;
            this.txtMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMiddle.Enabled = false;
            this.txtMiddle.Location = new System.Drawing.Point(108, 90);
            this.txtMiddle.Name = "txtMiddle";
            this.txtMiddle.Size = new System.Drawing.Size(201, 22);
            this.txtMiddle.TabIndex = 14;
            // 
            // lblMiddle
            // 
            this.lblMiddle.AutoSize = true;
            this.lblMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddle.Location = new System.Drawing.Point(14, 91);
            this.lblMiddle.Name = "lblMiddle";
            this.lblMiddle.Size = new System.Drawing.Size(86, 20);
            this.lblMiddle.TabIndex = 13;
            this.lblMiddle.Text = "Last Name";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(108, 160);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(95, 22);
            this.txtPhone.TabIndex = 12;
            this.txtPhone.Text = "(888)888.8888";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(45, 161);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 20);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "Phone";
            // 
            // txtLName
            // 
            this.txtLName.BackColor = System.Drawing.SystemColors.Window;
            this.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLName.Enabled = false;
            this.txtLName.Location = new System.Drawing.Point(108, 125);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(201, 22);
            this.txtLName.TabIndex = 10;
            // 
            // txtFName
            // 
            this.txtFName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFName.Enabled = false;
            this.txtFName.Location = new System.Drawing.Point(108, 55);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(201, 22);
            this.txtFName.TabIndex = 9;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(14, 126);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(86, 20);
            this.lblLName.TabIndex = 8;
            this.lblLName.Text = "Last Name";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(14, 56);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(86, 20);
            this.lblFName.TabIndex = 7;
            this.lblFName.Text = "First Name";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(468, 8);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // frmCoachView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 481);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tbForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCoachView";
            this.Text = "CoachViewForm";
            this.tbForm.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.grpPassword.ResumeLayout(false);
            this.grpPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcurrentPassCorrect)).EndInit();
            this.grbProfilePic.ResumeLayout(false);
            this.grbProfilePic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditPic)).EndInit();
            this.grpPersonalInfo.ResumeLayout(false);
            this.grpPersonalInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbForm;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblCoachName;
        private System.Windows.Forms.Label lblCoachUser;
        private System.Windows.Forms.PictureBox pbProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAvailable;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox pbEditPic;
        private System.Windows.Forms.Button btnEditPic;
        private System.Windows.Forms.TextBox txtPicURL;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPicSubmit;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.GroupBox grpPersonalInfo;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtMiddle;
        private System.Windows.Forms.Label lblMiddle;
        private System.Windows.Forms.GroupBox grpPassword;
        private System.Windows.Forms.GroupBox grbProfilePic;
        private System.Windows.Forms.Label lblMemberSince;
        private System.Windows.Forms.Button btnEditInfo;
        private System.Windows.Forms.Button btnSubmitInfo;
        private System.Windows.Forms.Button btnCancelInfo;
        private System.Windows.Forms.Label lblOldPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfirmNewPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtCurrentPass;
        private System.Windows.Forms.Button btnPassCancel;
        private System.Windows.Forms.Button btnUpdatePass;
        private System.Windows.Forms.Label lblWarningCurrentPass;
        private System.Windows.Forms.PictureBox pbcurrentPassCorrect;
        private System.Windows.Forms.PictureBox pbConfirmPass;
        private System.Windows.Forms.PictureBox pbNewPass;
        private System.Windows.Forms.Label lblMatchPass;
    }
}