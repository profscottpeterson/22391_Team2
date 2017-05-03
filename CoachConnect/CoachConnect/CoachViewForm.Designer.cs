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
            this.tbForm = new System.Windows.Forms.TabControl();
            this.tbSchedule = new System.Windows.Forms.TabPage();
            this.dgvAvailable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCoachName = new System.Windows.Forms.Label();
            this.lblCoachUser = new System.Windows.Forms.Label();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.tbAvailabilty = new System.Windows.Forms.TabPage();
            this.tbProfile = new System.Windows.Forms.TabPage();
            this.grpProfilePic = new System.Windows.Forms.GroupBox();
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
            this.lblEmailError = new System.Windows.Forms.Label();
            this.lblPhoneError = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblMiddleError = new System.Windows.Forms.Label();
            this.lblFNameError = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.grpPass = new System.Windows.Forms.GroupBox();
            this.btnPass = new System.Windows.Forms.Button();
            this.tbForm.SuspendLayout();
            this.tbSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.tbProfile.SuspendLayout();
            this.grpProfilePic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditPic)).BeginInit();
            this.grpPersonalInfo.SuspendLayout();
            this.grpPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbForm
            // 
            this.tbForm.Controls.Add(this.tbSchedule);
            this.tbForm.Controls.Add(this.tbAvailabilty);
            this.tbForm.Controls.Add(this.tbProfile);
            this.tbForm.Location = new System.Drawing.Point(12, 12);
            this.tbForm.Name = "tbForm";
            this.tbForm.SelectedIndex = 0;
            this.tbForm.Size = new System.Drawing.Size(538, 495);
            this.tbForm.TabIndex = 0;
            this.tbForm.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tbForm_Deselecting);
            // 
            // tbSchedule
            // 
            this.tbSchedule.BackColor = System.Drawing.SystemColors.Control;
            this.tbSchedule.Controls.Add(this.dgvAvailable);
            this.tbSchedule.Controls.Add(this.label1);
            this.tbSchedule.Controls.Add(this.lblCoachName);
            this.tbSchedule.Controls.Add(this.lblCoachUser);
            this.tbSchedule.Controls.Add(this.pbProfile);
            this.tbSchedule.Location = new System.Drawing.Point(4, 22);
            this.tbSchedule.Name = "tbSchedule";
            this.tbSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tbSchedule.Size = new System.Drawing.Size(530, 423);
            this.tbSchedule.TabIndex = 1;
            this.tbSchedule.Text = "Current Schedule";
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
            // tbAvailabilty
            // 
            this.tbAvailabilty.BackColor = System.Drawing.SystemColors.Control;
            this.tbAvailabilty.Location = new System.Drawing.Point(4, 22);
            this.tbAvailabilty.Name = "tbAvailabilty";
            this.tbAvailabilty.Size = new System.Drawing.Size(530, 423);
            this.tbAvailabilty.TabIndex = 2;
            this.tbAvailabilty.Text = "Availability";
            // 
            // tbProfile
            // 
            this.tbProfile.BackColor = System.Drawing.SystemColors.Control;
            this.tbProfile.Controls.Add(this.grpPass);
            this.tbProfile.Controls.Add(this.grpProfilePic);
            this.tbProfile.Controls.Add(this.grpPersonalInfo);
            this.tbProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProfile.Location = new System.Drawing.Point(4, 22);
            this.tbProfile.Name = "tbProfile";
            this.tbProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tbProfile.Size = new System.Drawing.Size(530, 469);
            this.tbProfile.TabIndex = 3;
            this.tbProfile.Text = "Profile";
            // 
            // grpProfilePic
            // 
            this.grpProfilePic.Controls.Add(this.btnPreview);
            this.grpProfilePic.Controls.Add(this.btnPicSubmit);
            this.grpProfilePic.Controls.Add(this.txtPicURL);
            this.grpProfilePic.Controls.Add(this.lblMemberSince);
            this.grpProfilePic.Controls.Add(this.btnEditPic);
            this.grpProfilePic.Controls.Add(this.btnCancel);
            this.grpProfilePic.Controls.Add(this.pbEditPic);
            this.grpProfilePic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProfilePic.Location = new System.Drawing.Point(12, 3);
            this.grpProfilePic.Name = "grpProfilePic";
            this.grpProfilePic.Size = new System.Drawing.Size(343, 177);
            this.grpProfilePic.TabIndex = 14;
            this.grpProfilePic.TabStop = false;
            this.grpProfilePic.Text = "Profile Pic";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(174, 82);
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
            this.btnPicSubmit.Location = new System.Drawing.Point(174, 82);
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
            this.txtPicURL.Location = new System.Drawing.Point(174, 49);
            this.txtPicURL.Name = "txtPicURL";
            this.txtPicURL.Size = new System.Drawing.Size(156, 26);
            this.txtPicURL.TabIndex = 3;
            // 
            // btnEditPic
            // 
            this.btnEditPic.Location = new System.Drawing.Point(174, 82);
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
            this.btnCancel.Location = new System.Drawing.Point(255, 82);
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
            this.pbEditPic.Location = new System.Drawing.Point(12, 18);
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
            this.grpPersonalInfo.Controls.Add(this.lblEmailError);
            this.grpPersonalInfo.Controls.Add(this.lblPhoneError);
            this.grpPersonalInfo.Controls.Add(this.lblLastName);
            this.grpPersonalInfo.Controls.Add(this.lblMiddleError);
            this.grpPersonalInfo.Controls.Add(this.lblFNameError);
            this.grpPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPersonalInfo.Location = new System.Drawing.Point(12, 180);
            this.grpPersonalInfo.Name = "grpPersonalInfo";
            this.grpPersonalInfo.Size = new System.Drawing.Size(512, 283);
            this.grpPersonalInfo.TabIndex = 13;
            this.grpPersonalInfo.TabStop = false;
            this.grpPersonalInfo.Text = "Personal Information";
            // 
            // btnSubmitInfo
            // 
            this.btnSubmitInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitInfo.Location = new System.Drawing.Point(174, 254);
            this.btnSubmitInfo.Name = "btnSubmitInfo";
            this.btnSubmitInfo.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitInfo.TabIndex = 14;
            this.btnSubmitInfo.Text = "Update";
            this.btnSubmitInfo.UseVisualStyleBackColor = true;
            this.btnSubmitInfo.Visible = false;
            this.btnSubmitInfo.Click += new System.EventHandler(this.btnSubmitInfo_Click);
            // 
            // btnCancelInfo
            // 
            this.btnCancelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelInfo.Location = new System.Drawing.Point(255, 254);
            this.btnCancelInfo.Name = "btnCancelInfo";
            this.btnCancelInfo.Size = new System.Drawing.Size(75, 23);
            this.btnCancelInfo.TabIndex = 15;
            this.btnCancelInfo.Text = "Cancel";
            this.btnCancelInfo.UseVisualStyleBackColor = true;
            this.btnCancelInfo.Visible = false;
            this.btnCancelInfo.Click += new System.EventHandler(this.btnCancelInfo_Click);
            // 
            // btnEditInfo
            // 
            this.btnEditInfo.Location = new System.Drawing.Point(214, 254);
            this.btnEditInfo.Name = "btnEditInfo";
            this.btnEditInfo.Size = new System.Drawing.Size(75, 23);
            this.btnEditInfo.TabIndex = 18;
            this.btnEditInfo.Text = "Edit";
            this.btnEditInfo.UseVisualStyleBackColor = true;
            this.btnEditInfo.Click += new System.EventHandler(this.btnEditInfo_Click);
            // 
            // lblMemberSince
            // 
            this.lblMemberSince.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberSince.Location = new System.Drawing.Point(171, 16);
            this.lblMemberSince.Name = "lblMemberSince";
            this.lblMemberSince.Size = new System.Drawing.Size(159, 30);
            this.lblMemberSince.TabIndex = 17;
            this.lblMemberSince.Text = "Member date";
            this.lblMemberSince.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(212, 211);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(201, 20);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblEmail.Location = new System.Drawing.Point(149, 213);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 16);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email";
            // 
            // txtMiddle
            // 
            this.txtMiddle.BackColor = System.Drawing.SystemColors.Window;
            this.txtMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMiddle.Enabled = false;
            this.txtMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddle.Location = new System.Drawing.Point(212, 64);
            this.txtMiddle.Name = "txtMiddle";
            this.txtMiddle.Size = new System.Drawing.Size(201, 20);
            this.txtMiddle.TabIndex = 10;
            this.txtMiddle.Leave += new System.EventHandler(this.txtMiddle_Leave);
            // 
            // lblMiddle
            // 
            this.lblMiddle.AutoSize = true;
            this.lblMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblMiddle.Location = new System.Drawing.Point(102, 66);
            this.lblMiddle.Name = "lblMiddle";
            this.lblMiddle.Size = new System.Drawing.Size(89, 16);
            this.lblMiddle.TabIndex = 13;
            this.lblMiddle.Text = "Middle Name";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Enabled = false;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(215, 160);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(95, 20);
            this.txtPhone.TabIndex = 12;
            this.txtPhone.Text = "(888)888.8888";
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblPhone.Location = new System.Drawing.Point(144, 164);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(47, 16);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "Phone";
            // 
            // txtLName
            // 
            this.txtLName.BackColor = System.Drawing.SystemColors.Window;
            this.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLName.Enabled = false;
            this.txtLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(212, 113);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(201, 20);
            this.txtLName.TabIndex = 11;
            this.txtLName.Leave += new System.EventHandler(this.txtLName_Leave);
            // 
            // txtFName
            // 
            this.txtFName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFName.Enabled = false;
            this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(212, 15);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(201, 20);
            this.txtFName.TabIndex = 9;
            this.txtFName.Leave += new System.EventHandler(this.txtFName_Leave);
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblLName.Location = new System.Drawing.Point(118, 115);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(73, 16);
            this.lblLName.TabIndex = 8;
            this.lblLName.Text = "Last Name";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblFName.Location = new System.Drawing.Point(118, 17);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(73, 16);
            this.lblFName.TabIndex = 7;
            this.lblFName.Text = "First Name";
            // 
            // lblEmailError
            // 
            this.lblEmailError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailError.ForeColor = System.Drawing.Color.Red;
            this.lblEmailError.Location = new System.Drawing.Point(209, 236);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(201, 19);
            this.lblEmailError.TabIndex = 5;
            this.lblEmailError.Text = "Invalid Email Address";
            this.lblEmailError.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblEmailError.Visible = false;
            // 
            // lblPhoneError
            // 
            this.lblPhoneError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneError.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneError.Location = new System.Drawing.Point(212, 185);
            this.lblPhoneError.Name = "lblPhoneError";
            this.lblPhoneError.Size = new System.Drawing.Size(98, 19);
            this.lblPhoneError.TabIndex = 21;
            this.lblPhoneError.Text = "Invalid Number";
            this.lblPhoneError.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblPhoneError.Visible = false;
            // 
            // lblLastName
            // 
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.Red;
            this.lblLastName.Location = new System.Drawing.Point(212, 138);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(201, 19);
            this.lblLastName.TabIndex = 22;
            this.lblLastName.Text = "Invalid Last Name";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblLastName.Visible = false;
            // 
            // lblMiddleError
            // 
            this.lblMiddleError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleError.ForeColor = System.Drawing.Color.Red;
            this.lblMiddleError.Location = new System.Drawing.Point(212, 89);
            this.lblMiddleError.Name = "lblMiddleError";
            this.lblMiddleError.Size = new System.Drawing.Size(201, 19);
            this.lblMiddleError.TabIndex = 23;
            this.lblMiddleError.Text = "Invalid Middle Name";
            this.lblMiddleError.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblMiddleError.Visible = false;
            // 
            // lblFNameError
            // 
            this.lblFNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFNameError.ForeColor = System.Drawing.Color.Red;
            this.lblFNameError.Location = new System.Drawing.Point(212, 40);
            this.lblFNameError.Name = "lblFNameError";
            this.lblFNameError.Size = new System.Drawing.Size(201, 19);
            this.lblFNameError.TabIndex = 24;
            this.lblFNameError.Text = "Invalid First Name";
            this.lblFNameError.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblFNameError.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(468, 8);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // grpPass
            // 
            this.grpPass.Controls.Add(this.btnPass);
            this.grpPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grpPass.Location = new System.Drawing.Point(361, 8);
            this.grpPass.Name = "grpPass";
            this.grpPass.Size = new System.Drawing.Size(163, 172);
            this.grpPass.TabIndex = 15;
            this.grpPass.TabStop = false;
            this.grpPass.Text = "Reset Password";
            // 
            // btnPass
            // 
            this.btnPass.Location = new System.Drawing.Point(42, 77);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(75, 23);
            this.btnPass.TabIndex = 0;
            this.btnPass.Text = "Reset Password";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // frmCoachView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 513);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tbForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCoachView";
            this.Text = "CoachViewForm";
            this.tbForm.ResumeLayout(false);
            this.tbSchedule.ResumeLayout(false);
            this.tbSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.tbProfile.ResumeLayout(false);
            this.grpProfilePic.ResumeLayout(false);
            this.grpProfilePic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditPic)).EndInit();
            this.grpPersonalInfo.ResumeLayout(false);
            this.grpPersonalInfo.PerformLayout();
            this.grpPass.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbForm;
        private System.Windows.Forms.TabPage tbSchedule;
        private System.Windows.Forms.TabPage tbAvailabilty;
        private System.Windows.Forms.Label lblCoachName;
        private System.Windows.Forms.Label lblCoachUser;
        private System.Windows.Forms.PictureBox pbProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAvailable;
        private System.Windows.Forms.TabPage tbProfile;
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
        private System.Windows.Forms.GroupBox grpProfilePic;
        private System.Windows.Forms.Label lblMemberSince;
        private System.Windows.Forms.Button btnEditInfo;
        private System.Windows.Forms.Button btnSubmitInfo;
        private System.Windows.Forms.Button btnCancelInfo;
        private System.Windows.Forms.Label lblEmailError;
        private System.Windows.Forms.Label lblPhoneError;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblMiddleError;
        private System.Windows.Forms.Label lblFNameError;
        private System.Windows.Forms.GroupBox grpPass;
        private System.Windows.Forms.Button btnPass;
    }
}