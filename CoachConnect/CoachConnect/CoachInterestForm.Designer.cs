//-----------------------------------------------------------------------
// <copyright file="CoachInterestForm.Designer.cs" company="PABT,Inc">
//     Copyright (c) Pabt, Inc. All rights reserved
// </copyright>
//-----------------------------------------------------------------------

namespace CoachConnect
{
    /// <content>
    /// Contains functionalities and features for the frmCoachInterest class.
    /// </content>
    public partial class frmCoachInterest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoachInterest));
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbInterest = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridAvailableCoaches = new System.Windows.Forms.DataGridView();
            this.btnInterestExit = new System.Windows.Forms.Button();
            this.btnSelectCoach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbInterest)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAvailableCoaches)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(195, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(353, 149);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Interest Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbInterest
            // 
            this.pbInterest.Image = global::CoachConnect.Properties.Resources.transportation_icon;
            this.pbInterest.Location = new System.Drawing.Point(28, 12);
            this.pbInterest.Name = "pbInterest";
            this.pbInterest.Size = new System.Drawing.Size(150, 150);
            this.pbInterest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInterest.TabIndex = 0;
            this.pbInterest.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridAvailableCoaches);
            this.groupBox4.Location = new System.Drawing.Point(12, 167);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(536, 268);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Available Coaches";
            // 
            // dataGridAvailableCoaches
            // 
            this.dataGridAvailableCoaches.AllowUserToAddRows = false;
            this.dataGridAvailableCoaches.AllowUserToDeleteRows = false;
            this.dataGridAvailableCoaches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridAvailableCoaches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAvailableCoaches.Location = new System.Drawing.Point(7, 20);
            this.dataGridAvailableCoaches.Name = "dataGridAvailableCoaches";
            this.dataGridAvailableCoaches.ReadOnly = true;
            this.dataGridAvailableCoaches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAvailableCoaches.Size = new System.Drawing.Size(523, 242);
            this.dataGridAvailableCoaches.TabIndex = 1;
            this.dataGridAvailableCoaches.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAvailableCoaches_RowEnter);
            // 
            // btnInterestExit
            // 
            this.btnInterestExit.Location = new System.Drawing.Point(339, 446);
            this.btnInterestExit.Name = "btnInterestExit";
            this.btnInterestExit.Size = new System.Drawing.Size(105, 23);
            this.btnInterestExit.TabIndex = 5;
            this.btnInterestExit.Text = "Back To Coaches";
            this.btnInterestExit.UseVisualStyleBackColor = true;
            this.btnInterestExit.Click += new System.EventHandler(this.btnInterestExit_Click);
            // 
            // btnSelectCoach
            // 
            this.btnSelectCoach.Enabled = false;
            this.btnSelectCoach.Location = new System.Drawing.Point(460, 446);
            this.btnSelectCoach.Name = "btnSelectCoach";
            this.btnSelectCoach.Size = new System.Drawing.Size(88, 23);
            this.btnSelectCoach.TabIndex = 6;
            this.btnSelectCoach.Text = "Assign Coach";
            this.btnSelectCoach.UseVisualStyleBackColor = true;
            this.btnSelectCoach.Click += new System.EventHandler(this.btnSelectCoach_Click);
            // 
            // frmCoachInterest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 481);
            this.Controls.Add(this.btnSelectCoach);
            this.Controls.Add(this.btnInterestExit);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbInterest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCoachInterest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Coach By Interest";
            ((System.ComponentModel.ISupportInitialize)(this.pbInterest)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAvailableCoaches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbInterest;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnInterestExit;
        private System.Windows.Forms.DataGridView dataGridAvailableCoaches;
        private System.Windows.Forms.Button btnSelectCoach;
    }
}