namespace CoachConnect
{
    partial class frmCoachInterest
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Scotty Pipen",
            "Sunday",
            "Afternoon",
            "Javascript"}, -1);
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbInterest = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstAvailableCoaches = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnInterestExit = new System.Windows.Forms.Button();
            this.dataGridAvailableCoaches = new System.Windows.Forms.DataGridView();
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
            this.groupBox4.Controls.Add(this.lstAvailableCoaches);
            this.groupBox4.Location = new System.Drawing.Point(12, 167);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(536, 268);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Available Coaches";
            // 
            // lstAvailableCoaches
            // 
            this.lstAvailableCoaches.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstAvailableCoaches.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lstAvailableCoaches.Location = new System.Drawing.Point(3, 142);
            this.lstAvailableCoaches.Name = "lstAvailableCoaches";
            this.lstAvailableCoaches.Size = new System.Drawing.Size(527, 120);
            this.lstAvailableCoaches.TabIndex = 0;
            this.lstAvailableCoaches.UseCompatibleStateImageBehavior = false;
            this.lstAvailableCoaches.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Coach";
            this.columnHeader1.Width = 122;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Day";
            this.columnHeader2.Width = 82;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Time";
            this.columnHeader3.Width = 93;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Subjects";
            this.columnHeader4.Width = 84;
            // 
            // btnInterestExit
            // 
            this.btnInterestExit.Location = new System.Drawing.Point(214, 446);
            this.btnInterestExit.Name = "btnInterestExit";
            this.btnInterestExit.Size = new System.Drawing.Size(105, 23);
            this.btnInterestExit.TabIndex = 5;
            this.btnInterestExit.Text = "Back To Coaches";
            this.btnInterestExit.UseVisualStyleBackColor = true;
            this.btnInterestExit.Click += new System.EventHandler(this.btnInterestExit_Click);
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
            this.dataGridAvailableCoaches.Size = new System.Drawing.Size(523, 116);
            this.dataGridAvailableCoaches.TabIndex = 1;
            // 
            // frmCoachInterest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 481);
            this.Controls.Add(this.btnInterestExit);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbInterest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCoachInterest";
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
        private System.Windows.Forms.ListView lstAvailableCoaches;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnInterestExit;
        private System.Windows.Forms.DataGridView dataGridAvailableCoaches;
    }
}