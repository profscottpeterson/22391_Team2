namespace CoachConnect
{
    partial class frmCoachsSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoachsSchedule));
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pbProfilePic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCoachName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblScheduleTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 30);
            this.label9.TabIndex = 9;
            this.label9.Text = "Morning";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 347);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 30);
            this.label11.TabIndex = 11;
            this.label11.Text = "Midday";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 394);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 30);
            this.label12.TabIndex = 12;
            this.label12.Text = "Afternoon";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 441);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 30);
            this.label13.TabIndex = 13;
            this.label13.Text = "Evening";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbProfilePic
            // 
            this.pbProfilePic.Image = ((System.Drawing.Image)(resources.GetObject("pbProfilePic.Image")));
            this.pbProfilePic.Location = new System.Drawing.Point(14, 23);
            this.pbProfilePic.Name = "pbProfilePic";
            this.pbProfilePic.Size = new System.Drawing.Size(150, 150);
            this.pbProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbProfilePic.TabIndex = 14;
            this.pbProfilePic.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Current Schedule";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCoachName
            // 
            this.lblCoachName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoachName.Location = new System.Drawing.Point(12, 176);
            this.lblCoachName.Name = "lblCoachName";
            this.lblCoachName.Size = new System.Drawing.Size(154, 27);
            this.lblCoachName.TabIndex = 16;
            this.lblCoachName.Text = "CoachName";
            this.lblCoachName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(12, 196);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(154, 27);
            this.lblUsername.TabIndex = 17;
            this.lblUsername.Text = "user";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScheduleTitle
            // 
            this.lblScheduleTitle.AutoSize = true;
            this.lblScheduleTitle.Location = new System.Drawing.Point(333, 80);
            this.lblScheduleTitle.Name = "lblScheduleTitle";
            this.lblScheduleTitle.Size = new System.Drawing.Size(42, 13);
            this.lblScheduleTitle.TabIndex = 18;
            this.lblScheduleTitle.Text = "hi there";
            // 
            // frmCoachsSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 481);
            this.Controls.Add(this.lblScheduleTitle);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblCoachName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbProfilePic);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Name = "frmCoachsSchedule";
            this.Text = " Coaches Page";
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pbProfilePic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCoachName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblScheduleTitle;
    }
}