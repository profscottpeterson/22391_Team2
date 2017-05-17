// <copyright file="CoachInterestForm.Designer.cs" company="PABT at NWTC">
//     Copyright 2017 PABT (Pao Xiong, Adam Smith, Brian Lueskow, Tim Durkee)
// </copyright>
namespace CoachConnect
{
    /// <summary>
    /// A form that shows coach search results based on a selected interest
    /// </summary>
    public partial class FrmCoachInterest
    {
        /// <summary>
        /// Picture box to store an image representing the selected interest
        /// </summary>
        private System.Windows.Forms.PictureBox picBoxInterest;

        /// <summary>
        /// A title to show the selected interest
        /// </summary>
        private System.Windows.Forms.Label lblTitle;

        /// <summary>
        /// A group box for the Available Sessions section
        /// </summary>
        private System.Windows.Forms.GroupBox groupBox4;

        /// <summary>
        /// Button that allows user to return to previous window
        /// </summary>
        private System.Windows.Forms.Button btnInterestExit;

        /// <summary>
        /// Data grid to show available sessions
        /// </summary>
        private System.Windows.Forms.DataGridView dataGridAvailableSessions;

        /// <summary>
        /// Button that allows the user to enroll in the selected session
        /// </summary>
        private System.Windows.Forms.Button btnSelectSession;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCoachInterest));
            this.lblTitle = new System.Windows.Forms.Label();
            this.picBoxInterest = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridAvailableSessions = new System.Windows.Forms.DataGridView();
            this.btnInterestExit = new System.Windows.Forms.Button();
            this.btnSelectSession = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInterest)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAvailableSessions)).BeginInit();
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
            // picBoxInterest
            // 
            this.picBoxInterest.Image = global::CoachConnect.Properties.Resources.transportation_icon;
            this.picBoxInterest.Location = new System.Drawing.Point(28, 12);
            this.picBoxInterest.Name = "picBoxInterest";
            this.picBoxInterest.Size = new System.Drawing.Size(150, 150);
            this.picBoxInterest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxInterest.TabIndex = 0;
            this.picBoxInterest.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridAvailableSessions);
            this.groupBox4.Location = new System.Drawing.Point(12, 167);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(536, 268);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Available Sessions";
            // 
            // dataGridAvailableSessions
            // 
            this.dataGridAvailableSessions.AllowUserToAddRows = false;
            this.dataGridAvailableSessions.AllowUserToDeleteRows = false;
            this.dataGridAvailableSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridAvailableSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAvailableSessions.Location = new System.Drawing.Point(7, 20);
            this.dataGridAvailableSessions.MultiSelect = false;
            this.dataGridAvailableSessions.Name = "dataGridAvailableSessions";
            this.dataGridAvailableSessions.ReadOnly = true;
            this.dataGridAvailableSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAvailableSessions.Size = new System.Drawing.Size(523, 242);
            this.dataGridAvailableSessions.TabIndex = 1;
            this.dataGridAvailableSessions.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridAvailableCoaches_RowEnter);
            // 
            // btnInterestExit
            // 
            this.btnInterestExit.Location = new System.Drawing.Point(296, 446);
            this.btnInterestExit.Name = "btnInterestExit";
            this.btnInterestExit.Size = new System.Drawing.Size(147, 23);
            this.btnInterestExit.TabIndex = 5;
            this.btnInterestExit.Text = "Back To Previous Window";
            this.btnInterestExit.UseVisualStyleBackColor = true;
            this.btnInterestExit.Click += new System.EventHandler(this.BtnInterestExit_Click);
            // 
            // btnSelectSession
            // 
            this.btnSelectSession.Enabled = false;
            this.btnSelectSession.Location = new System.Drawing.Point(449, 446);
            this.btnSelectSession.Name = "btnSelectSession";
            this.btnSelectSession.Size = new System.Drawing.Size(99, 23);
            this.btnSelectSession.TabIndex = 6;
            this.btnSelectSession.Text = "Enroll in Session";
            this.btnSelectSession.UseVisualStyleBackColor = true;
            this.btnSelectSession.Click += new System.EventHandler(this.BtnSelectCoachClick);
            // 
            // FrmCoachInterest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 481);
            this.Controls.Add(this.btnSelectSession);
            this.Controls.Add(this.btnInterestExit);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picBoxInterest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCoachInterest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Coach By Interest";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInterest)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAvailableSessions)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
    }
}