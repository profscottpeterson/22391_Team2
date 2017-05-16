//-----------------------------------------------------------------------
// <copyright file="EditStudentProfileForm.Designer.cs" company="PABT,Inc">
//     Copyright (c) Pabt, Inc. All rights reserved
// </copyright>
//-----------------------------------------------------------------------

namespace CoachConnect
{
    partial class EditStudentProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStudentProfileForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLastNameError = new System.Windows.Forms.Label();
            this.lblMiddleNameError = new System.Windows.Forms.Label();
            this.lblFirstNameError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStdMiddleName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStdLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStdFirstName = new System.Windows.Forms.TextBox();
            this.lblErrorPhone = new System.Windows.Forms.Label();
            this.lblErrorEmail = new System.Windows.Forms.Label();
            this.lblErrorURL = new System.Windows.Forms.Label();
            this.InvalidEmail = new System.Windows.Forms.PictureBox();
            this.validEmail = new System.Windows.Forms.PictureBox();
            this.txtStdEmail = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.txtStdURL = new System.Windows.Forms.TextBox();
            this.txtStdPhone = new System.Windows.Forms.TextBox();
            this.btnSaveEditProfile = new System.Windows.Forms.Button();
            this.btnCancleEditProfile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvalidEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLastNameError);
            this.groupBox1.Controls.Add(this.lblMiddleNameError);
            this.groupBox1.Controls.Add(this.lblFirstNameError);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtStdMiddleName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStdLastName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtStdFirstName);
            this.groupBox1.Controls.Add(this.lblErrorPhone);
            this.groupBox1.Controls.Add(this.lblErrorEmail);
            this.groupBox1.Controls.Add(this.lblErrorURL);
            this.groupBox1.Controls.Add(this.InvalidEmail);
            this.groupBox1.Controls.Add(this.validEmail);
            this.groupBox1.Controls.Add(this.txtStdEmail);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.label36);
            this.groupBox1.Controls.Add(this.label37);
            this.groupBox1.Controls.Add(this.txtStdURL);
            this.groupBox1.Controls.Add(this.txtStdPhone);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editing Profile";
            // 
            // lblLastNameError
            // 
            this.lblLastNameError.AutoSize = true;
            this.lblLastNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameError.ForeColor = System.Drawing.Color.Red;
            this.lblLastNameError.Location = new System.Drawing.Point(106, 167);
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
            this.lblMiddleNameError.Location = new System.Drawing.Point(106, 127);
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
            this.lblFirstNameError.Location = new System.Drawing.Point(106, 88);
            this.lblFirstNameError.Name = "lblFirstNameError";
            this.lblFirstNameError.Size = new System.Drawing.Size(111, 13);
            this.lblFirstNameError.TabIndex = 48;
            this.lblFirstNameError.Text = "First Name is required!";
            this.lblFirstNameError.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Midd Name:";
            // 
            // txtStdMiddleName
            // 
            this.txtStdMiddleName.Location = new System.Drawing.Point(105, 104);
            this.txtStdMiddleName.Name = "txtStdMiddleName";
            this.txtStdMiddleName.Size = new System.Drawing.Size(151, 20);
            this.txtStdMiddleName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Last Name:";
            // 
            // txtStdLastName
            // 
            this.txtStdLastName.Location = new System.Drawing.Point(105, 145);
            this.txtStdLastName.Name = "txtStdLastName";
            this.txtStdLastName.Size = new System.Drawing.Size(151, 20);
            this.txtStdLastName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "First Name:";
            // 
            // txtStdFirstName
            // 
            this.txtStdFirstName.Location = new System.Drawing.Point(106, 65);
            this.txtStdFirstName.Name = "txtStdFirstName";
            this.txtStdFirstName.Size = new System.Drawing.Size(151, 20);
            this.txtStdFirstName.TabIndex = 2;
            // 
            // lblErrorPhone
            // 
            this.lblErrorPhone.AutoSize = true;
            this.lblErrorPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPhone.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPhone.Location = new System.Drawing.Point(103, 244);
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
            this.lblErrorEmail.Location = new System.Drawing.Point(106, 206);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(86, 13);
            this.lblErrorEmail.TabIndex = 40;
            this.lblErrorEmail.Text = "Email is required!";
            this.lblErrorEmail.Visible = false;
            // 
            // lblErrorURL
            // 
            this.lblErrorURL.AutoSize = true;
            this.lblErrorURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorURL.ForeColor = System.Drawing.Color.Red;
            this.lblErrorURL.Location = new System.Drawing.Point(106, 49);
            this.lblErrorURL.Name = "lblErrorURL";
            this.lblErrorURL.Size = new System.Drawing.Size(83, 13);
            this.lblErrorURL.TabIndex = 39;
            this.lblErrorURL.Text = "URL is required!";
            this.lblErrorURL.Visible = false;
            // 
            // InvalidEmail
            // 
            this.InvalidEmail.Image = global::CoachConnect.Properties.Resources.wrong;
            this.InvalidEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.InvalidEmail.Location = new System.Drawing.Point(263, 182);
            this.InvalidEmail.Name = "InvalidEmail";
            this.InvalidEmail.Size = new System.Drawing.Size(36, 33);
            this.InvalidEmail.TabIndex = 38;
            this.InvalidEmail.TabStop = false;
            this.InvalidEmail.Visible = false;
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
            // txtStdEmail
            // 
            this.txtStdEmail.Location = new System.Drawing.Point(106, 183);
            this.txtStdEmail.Name = "txtStdEmail";
            this.txtStdEmail.Size = new System.Drawing.Size(151, 20);
            this.txtStdEmail.TabIndex = 5;
            this.txtStdEmail.Leave += new System.EventHandler(this.txtStdEmail_Leave);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(25, 27);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(75, 13);
            this.label35.TabIndex = 9;
            this.label35.Text = "Profile Picture:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(62, 183);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(38, 13);
            this.label36.TabIndex = 10;
            this.label36.Text = "E-mail:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(75, 221);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(25, 13);
            this.label37.TabIndex = 11;
            this.label37.Text = "Tel:";
            // 
            // txtStdURL
            // 
            this.txtStdURL.Location = new System.Drawing.Point(106, 24);
            this.txtStdURL.Name = "txtStdURL";
            this.txtStdURL.Size = new System.Drawing.Size(151, 20);
            this.txtStdURL.TabIndex = 1;
            // 
            // txtStdPhone
            // 
            this.txtStdPhone.Location = new System.Drawing.Point(106, 221);
            this.txtStdPhone.Name = "txtStdPhone";
            this.txtStdPhone.Size = new System.Drawing.Size(151, 20);
            this.txtStdPhone.TabIndex = 6;
            // 
            // btnSaveEditProfile
            // 
            this.btnSaveEditProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEditProfile.Location = new System.Drawing.Point(209, 291);
            this.btnSaveEditProfile.Name = "btnSaveEditProfile";
            this.btnSaveEditProfile.Padding = new System.Windows.Forms.Padding(1);
            this.btnSaveEditProfile.Size = new System.Drawing.Size(59, 28);
            this.btnSaveEditProfile.TabIndex = 7;
            this.btnSaveEditProfile.Text = "Save";
            this.btnSaveEditProfile.UseVisualStyleBackColor = true;
            this.btnSaveEditProfile.Click += new System.EventHandler(this.btnSaveEditProfile_Click);
            // 
            // btnCancleEditProfile
            // 
            this.btnCancleEditProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancleEditProfile.Location = new System.Drawing.Point(274, 291);
            this.btnCancleEditProfile.Name = "btnCancleEditProfile";
            this.btnCancleEditProfile.Padding = new System.Windows.Forms.Padding(1);
            this.btnCancleEditProfile.Size = new System.Drawing.Size(62, 28);
            this.btnCancleEditProfile.TabIndex = 8;
            this.btnCancleEditProfile.Text = "Cancle";
            this.btnCancleEditProfile.UseVisualStyleBackColor = true;
            this.btnCancleEditProfile.Click += new System.EventHandler(this.btnCancleEditProfile_Click);
            // 
            // EditStudentProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 330);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancleEditProfile);
            this.Controls.Add(this.btnSaveEditProfile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditStudentProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Student Profile Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvalidEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validEmail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStdEmail;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtStdURL;
        private System.Windows.Forms.TextBox txtStdPhone;
        private System.Windows.Forms.Button btnSaveEditProfile;
        private System.Windows.Forms.Button btnCancleEditProfile;
        private System.Windows.Forms.PictureBox InvalidEmail;
        private System.Windows.Forms.PictureBox validEmail;
        private System.Windows.Forms.Label lblErrorURL;
        private System.Windows.Forms.Label lblErrorEmail;
        private System.Windows.Forms.Label lblErrorPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStdMiddleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStdLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStdFirstName;
        private System.Windows.Forms.Label lblLastNameError;
        private System.Windows.Forms.Label lblMiddleNameError;
        private System.Windows.Forms.Label lblFirstNameError;
    }
}