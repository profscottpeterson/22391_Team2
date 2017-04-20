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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvAvailable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCoachName = new System.Windows.Forms.Label();
            this.lblCoachUser = new System.Windows.Forms.Label();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPicSubmit = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.txtPicURL = new System.Windows.Forms.TextBox();
            this.btnEditPic = new System.Windows.Forms.Button();
            this.pbEditPic = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbForm.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditPic)).BeginInit();
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
            this.tabPage4.Controls.Add(this.textBox2);
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.btnCancel);
            this.tabPage4.Controls.Add(this.btnPicSubmit);
            this.tabPage4.Controls.Add(this.btnPreview);
            this.tabPage4.Controls.Add(this.txtPicURL);
            this.tabPage4.Controls.Add(this.btnEditPic);
            this.tabPage4.Controls.Add(this.pbEditPic);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(530, 423);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Edit Profile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Name";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(107, 186);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPicSubmit
            // 
            this.btnPicSubmit.Location = new System.Drawing.Point(26, 186);
            this.btnPicSubmit.Name = "btnPicSubmit";
            this.btnPicSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnPicSubmit.TabIndex = 5;
            this.btnPicSubmit.Text = "Submit";
            this.btnPicSubmit.UseVisualStyleBackColor = true;
            this.btnPicSubmit.Visible = false;
            this.btnPicSubmit.Click += new System.EventHandler(this.btnPicSubmit_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(26, 186);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Visible = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // txtPicURL
            // 
            this.txtPicURL.Enabled = false;
            this.txtPicURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPicURL.Location = new System.Drawing.Point(26, 215);
            this.txtPicURL.Name = "txtPicURL";
            this.txtPicURL.Size = new System.Drawing.Size(156, 26);
            this.txtPicURL.TabIndex = 3;
            this.txtPicURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnEditPic
            // 
            this.btnEditPic.Location = new System.Drawing.Point(26, 186);
            this.btnEditPic.Name = "btnEditPic";
            this.btnEditPic.Size = new System.Drawing.Size(75, 23);
            this.btnEditPic.TabIndex = 2;
            this.btnEditPic.Text = "Edit Pic";
            this.btnEditPic.UseVisualStyleBackColor = true;
            this.btnEditPic.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbEditPic
            // 
            this.pbEditPic.Location = new System.Drawing.Point(26, 30);
            this.pbEditPic.Name = "pbEditPic";
            this.pbEditPic.Size = new System.Drawing.Size(156, 150);
            this.pbEditPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbEditPic.TabIndex = 1;
            this.pbEditPic.TabStop = false;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(292, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(292, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 10;
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
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditPic)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}