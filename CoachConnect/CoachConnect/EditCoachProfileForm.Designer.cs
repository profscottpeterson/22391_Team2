// <copyright file="EditStudentProfileForm.Designer.cs" company="PABT at NWTC">
//     Copyright 2017 PABT (Pao Xiong, Adam Smith, Brian Lueskow, Tim Durkee)
// </copyright>
namespace CoachConnect
{
    /// <summary>
    /// A form that allows the current user to edit his/her profile 
    /// </summary>
    public partial class EditCoachProfileForm
    {
        /// <summary>
        /// Group box
        /// </summary>
        private System.Windows.Forms.GroupBox groupBox1;

        /// <summary>
        /// Text box to hold the user's email address
        /// </summary>
        private System.Windows.Forms.TextBox txtEmail;

        /// <summary>
        /// A Label
        /// </summary>
        private System.Windows.Forms.Label lblEmail;

        /// <summary>
        /// A Label
        /// </summary>
        private System.Windows.Forms.Label lblPhone;

        /// <summary>
        /// A text box to hold the user's phone number
        /// </summary>
        private System.Windows.Forms.TextBox txtPhone;

        /// <summary>
        /// Button to save changes
        /// </summary>
        private System.Windows.Forms.Button btnSave;

        /// <summary>
        /// Button to cancel the update
        /// </summary>
        private System.Windows.Forms.Button btnCancel;

        /// <summary>
        /// Picture Box with an icon indicating an invalid email
        /// </summary>
        private System.Windows.Forms.PictureBox invalidEmail;

        /// <summary>
        /// Picture box with an icon indicating a valid email
        /// </summary>
        private System.Windows.Forms.PictureBox validEmail;

        /// <summary>
        /// Validation label indicating an invalid email
        /// </summary>
        private System.Windows.Forms.Label lblErrorEmail;

        /// <summary>
        /// Validation label indicating an invalid phone number
        /// </summary>
        private System.Windows.Forms.Label lblErrorPhone;

        /// <summary>
        /// A label
        /// </summary>
        private System.Windows.Forms.Label lblMiddleName;

        /// <summary>
        /// A text box to hold the user's middle name
        /// </summary>
        private System.Windows.Forms.TextBox txtMiddleName;

        /// <summary>
        /// A label
        /// </summary>
        private System.Windows.Forms.Label lblLastName;

        /// <summary>
        /// A text box to hold the user's last name
        /// </summary>
        private System.Windows.Forms.TextBox txtLastName;

        /// <summary>
        /// A label
        /// </summary>
        private System.Windows.Forms.Label lblFirstName;

        /// <summary>
        ///  At text box to hold the user's first name
        /// </summary>
        private System.Windows.Forms.TextBox txtFirstName;

        /// <summary>
        /// A Validation label to indicate an invalid last name
        /// </summary>
        private System.Windows.Forms.Label lblLastNameError;

        /// <summary>
        /// A Validation label to indicate an invalid middle name
        /// </summary>
        private System.Windows.Forms.Label lblMiddleNameError;

        /// <summary>
        /// A validation label to indicate an invalid first name
        /// </summary>
        private System.Windows.Forms.Label lblFirstNameError;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCoachProfileForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.lblLastNameError = new System.Windows.Forms.Label();
            this.lblMiddleNameError = new System.Windows.Forms.Label();
            this.lblFirstNameError = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblErrorPhone = new System.Windows.Forms.Label();
            this.lblErrorEmail = new System.Windows.Forms.Label();
            this.invalidEmail = new System.Windows.Forms.PictureBox();
            this.validEmail = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSupervisor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxSupervisor = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invalidEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxSupervisor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblSupervisor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblDisplayName);
            this.groupBox1.Controls.Add(this.txtDisplayName);
            this.groupBox1.Controls.Add(this.lblLastNameError);
            this.groupBox1.Controls.Add(this.lblMiddleNameError);
            this.groupBox1.Controls.Add(this.lblFirstNameError);
            this.groupBox1.Controls.Add(this.lblMiddleName);
            this.groupBox1.Controls.Add(this.txtMiddleName);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.lblErrorPhone);
            this.groupBox1.Controls.Add(this.lblErrorEmail);
            this.groupBox1.Controls.Add(this.invalidEmail);
            this.groupBox1.Controls.Add(this.validEmail);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 351);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coach Profile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(106, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Display Name is required!";
            this.label4.Visible = false;
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.Location = new System.Drawing.Point(27, 172);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(72, 13);
            this.lblDisplayName.TabIndex = 52;
            this.lblDisplayName.Text = "Display Name";
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(105, 169);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(151, 20);
            this.txtDisplayName.TabIndex = 51;
            // 
            // lblLastNameError
            // 
            this.lblLastNameError.AutoSize = true;
            this.lblLastNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameError.ForeColor = System.Drawing.Color.Red;
            this.lblLastNameError.Location = new System.Drawing.Point(106, 146);
            this.lblLastNameError.Name = "lblLastNameError";
            this.lblLastNameError.Size = new System.Drawing.Size(112, 13);
            this.lblLastNameError.TabIndex = 50;
            this.lblLastNameError.Text = "Last Name is required!";
            this.lblLastNameError.Visible = false;
            // 
            // lblMiddleNameError
            // 
            this.lblMiddleNameError.AutoSize = true;
            this.lblMiddleNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleNameError.ForeColor = System.Drawing.Color.Red;
            this.lblMiddleNameError.Location = new System.Drawing.Point(107, 99);
            this.lblMiddleNameError.Name = "lblMiddleNameError";
            this.lblMiddleNameError.Size = new System.Drawing.Size(123, 13);
            this.lblMiddleNameError.TabIndex = 49;
            this.lblMiddleNameError.Text = "Middle Name is required!";
            this.lblMiddleNameError.Visible = false;
            // 
            // lblFirstNameError
            // 
            this.lblFirstNameError.AutoSize = true;
            this.lblFirstNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameError.ForeColor = System.Drawing.Color.Red;
            this.lblFirstNameError.Location = new System.Drawing.Point(107, 53);
            this.lblFirstNameError.Name = "lblFirstNameError";
            this.lblFirstNameError.Size = new System.Drawing.Size(111, 13);
            this.lblFirstNameError.TabIndex = 48;
            this.lblFirstNameError.Text = "First Name is required!";
            this.lblFirstNameError.Visible = false;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.Location = new System.Drawing.Point(30, 79);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(69, 13);
            this.lblMiddleName.TabIndex = 47;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(105, 76);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(151, 20);
            this.txtMiddleName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(41, 126);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 45;
            this.lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(105, 123);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(151, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(43, 33);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 43;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(105, 30);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(151, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblErrorPhone
            // 
            this.lblErrorPhone.AutoSize = true;
            this.lblErrorPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPhone.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPhone.Location = new System.Drawing.Point(107, 282);
            this.lblErrorPhone.Name = "lblErrorPhone";
            this.lblErrorPhone.Size = new System.Drawing.Size(92, 13);
            this.lblErrorPhone.TabIndex = 41;
            this.lblErrorPhone.Text = "Phone is required!";
            this.lblErrorPhone.Visible = false;
            // 
            // lblErrorEmail
            // 
            this.lblErrorEmail.AutoSize = true;
            this.lblErrorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEmail.Location = new System.Drawing.Point(106, 236);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(86, 13);
            this.lblErrorEmail.TabIndex = 40;
            this.lblErrorEmail.Text = "Email is required!";
            this.lblErrorEmail.Visible = false;
            // 
            // invalidEmail
            // 
            this.invalidEmail.Image = global::CoachConnect.Properties.Resources.wrong;
            this.invalidEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.invalidEmail.Location = new System.Drawing.Point(263, 178);
            this.invalidEmail.Name = "invalidEmail";
            this.invalidEmail.Size = new System.Drawing.Size(36, 33);
            this.invalidEmail.TabIndex = 38;
            this.invalidEmail.TabStop = false;
            this.invalidEmail.Visible = false;
            // 
            // validEmail
            // 
            this.validEmail.Image = global::CoachConnect.Properties.Resources.correct1;
            this.validEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.validEmail.Location = new System.Drawing.Point(262, 177);
            this.validEmail.Name = "validEmail";
            this.validEmail.Size = new System.Drawing.Size(36, 33);
            this.validEmail.TabIndex = 37;
            this.validEmail.TabStop = false;
            this.validEmail.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(106, 213);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(151, 20);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Leave += new System.EventHandler(this.TxtStdEmailLeave);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(62, 213);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(62, 262);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(105, 259);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(151, 20);
            this.txtPhone.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(210, 369);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(1);
            this.btnSave.Size = new System.Drawing.Size(59, 28);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSaveEditProfileClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(274, 369);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(1);
            this.btnCancel.Size = new System.Drawing.Size(62, 28);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelEditProfileClick);
            // 
            // lblSupervisor
            // 
            this.lblSupervisor.AutoSize = true;
            this.lblSupervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupervisor.Location = new System.Drawing.Point(43, 306);
            this.lblSupervisor.Name = "lblSupervisor";
            this.lblSupervisor.Size = new System.Drawing.Size(57, 13);
            this.lblSupervisor.TabIndex = 55;
            this.lblSupervisor.Text = "Supervisor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(107, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Supervisor is required!";
            this.label2.Visible = false;
            // 
            // cbxSupervisor
            // 
            this.cbxSupervisor.FormattingEnabled = true;
            this.cbxSupervisor.Location = new System.Drawing.Point(105, 303);
            this.cbxSupervisor.Name = "cbxSupervisor";
            this.cbxSupervisor.Size = new System.Drawing.Size(151, 21);
            this.cbxSupervisor.TabIndex = 57;
            // 
            // EditCoachProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 409);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditCoachProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Coach Profile";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invalidEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validEmail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.ComboBox cbxSupervisor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSupervisor;
    }
}