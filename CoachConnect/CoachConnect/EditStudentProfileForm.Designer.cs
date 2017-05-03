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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStdEmail = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.txtStdURL = new System.Windows.Forms.TextBox();
            this.txtStdPhone = new System.Windows.Forms.TextBox();
            this.btnSaveEditProfile = new System.Windows.Forms.Button();
            this.btnCancleEditProfile = new System.Windows.Forms.Button();
            this.InvalidEmail = new System.Windows.Forms.PictureBox();
            this.validEmail = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvalidEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InvalidEmail);
            this.groupBox1.Controls.Add(this.validEmail);
            this.groupBox1.Controls.Add(this.txtStdEmail);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.label36);
            this.groupBox1.Controls.Add(this.label37);
            this.groupBox1.Controls.Add(this.txtStdURL);
            this.groupBox1.Controls.Add(this.txtStdPhone);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editing Profile";
            // 
            // txtStdEmail
            // 
            this.txtStdEmail.Location = new System.Drawing.Point(106, 77);
            this.txtStdEmail.Name = "txtStdEmail";
            this.txtStdEmail.Size = new System.Drawing.Size(151, 20);
            this.txtStdEmail.TabIndex = 2;
            this.txtStdEmail.Leave += new System.EventHandler(this.txtStdEmail_Leave);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(25, 39);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(75, 13);
            this.label35.TabIndex = 9;
            this.label35.Text = "Profile Picture:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(62, 77);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(38, 13);
            this.label36.TabIndex = 10;
            this.label36.Text = "E-mail:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(75, 115);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(25, 13);
            this.label37.TabIndex = 11;
            this.label37.Text = "Tel:";
            // 
            // txtStdURL
            // 
            this.txtStdURL.Location = new System.Drawing.Point(106, 36);
            this.txtStdURL.Name = "txtStdURL";
            this.txtStdURL.Size = new System.Drawing.Size(151, 20);
            this.txtStdURL.TabIndex = 1;
            // 
            // txtStdPhone
            // 
            this.txtStdPhone.Location = new System.Drawing.Point(106, 115);
            this.txtStdPhone.Name = "txtStdPhone";
            this.txtStdPhone.Size = new System.Drawing.Size(151, 20);
            this.txtStdPhone.TabIndex = 3;
            // 
            // btnSaveEditProfile
            // 
            this.btnSaveEditProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEditProfile.Location = new System.Drawing.Point(209, 235);
            this.btnSaveEditProfile.Name = "btnSaveEditProfile";
            this.btnSaveEditProfile.Padding = new System.Windows.Forms.Padding(1);
            this.btnSaveEditProfile.Size = new System.Drawing.Size(59, 28);
            this.btnSaveEditProfile.TabIndex = 4;
            this.btnSaveEditProfile.Text = "Save";
            this.btnSaveEditProfile.UseVisualStyleBackColor = true;
            this.btnSaveEditProfile.Click += new System.EventHandler(this.btnSaveEditProfile_Click);
            // 
            // btnCancleEditProfile
            // 
            this.btnCancleEditProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancleEditProfile.Location = new System.Drawing.Point(274, 235);
            this.btnCancleEditProfile.Name = "btnCancleEditProfile";
            this.btnCancleEditProfile.Padding = new System.Windows.Forms.Padding(1);
            this.btnCancleEditProfile.Size = new System.Drawing.Size(62, 28);
            this.btnCancleEditProfile.TabIndex = 5;
            this.btnCancleEditProfile.Text = "Cancle";
            this.btnCancleEditProfile.UseVisualStyleBackColor = true;
            this.btnCancleEditProfile.Click += new System.EventHandler(this.btnCancleEditProfile_Click);
            // 
            // InvalidEmail
            // 
            this.InvalidEmail.Image = global::CoachConnect.Properties.Resources.wrong;
            this.InvalidEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.InvalidEmail.Location = new System.Drawing.Point(263, 76);
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
            this.validEmail.Location = new System.Drawing.Point(262, 71);
            this.validEmail.Name = "validEmail";
            this.validEmail.Size = new System.Drawing.Size(36, 33);
            this.validEmail.TabIndex = 37;
            this.validEmail.TabStop = false;
            this.validEmail.Visible = false;
            // 
            // EditStudentProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 288);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancleEditProfile);
            this.Controls.Add(this.btnSaveEditProfile);
            this.Name = "EditStudentProfileForm";
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
    }
}