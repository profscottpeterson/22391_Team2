namespace CoachConnect
{
    partial class CoachViewForm
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.lblCoachUser = new System.Windows.Forms.Label();
            this.lblCoachName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAvailable = new System.Windows.Forms.DataGridView();
            this.tbForm.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailable)).BeginInit();
            this.SuspendLayout();
            // 
            // tbForm
            // 
            this.tbForm.Controls.Add(this.tabPage1);
            this.tbForm.Controls.Add(this.tabPage2);
            this.tbForm.Controls.Add(this.tabPage3);
            this.tbForm.Location = new System.Drawing.Point(12, 12);
            this.tbForm.Name = "tbForm";
            this.tbForm.SelectedIndex = 0;
            this.tbForm.Size = new System.Drawing.Size(538, 447);
            this.tbForm.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(530, 421);
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
            this.tabPage2.Size = new System.Drawing.Size(530, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Current Schedule";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(530, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Edit Availablity";
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
            // dgvAvailable
            // 
            this.dgvAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailable.Location = new System.Drawing.Point(6, 209);
            this.dgvAvailable.Name = "dgvAvailable";
            this.dgvAvailable.Size = new System.Drawing.Size(518, 197);
            this.dgvAvailable.TabIndex = 5;
            // 
            // CoachViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 481);
            this.Controls.Add(this.tbForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CoachViewForm";
            this.Text = "CoachViewForm";
            this.tbForm.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailable)).EndInit();
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
    }
}