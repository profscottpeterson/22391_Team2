namespace CoachConnect
{
    partial class frmInterest
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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Scotty Pipen",
            "Sunday",
            "Afternoon",
            "Javascript"}, -1);
            this.pbInterest = new System.Windows.Forms.PictureBox();
            this.txtInterestTitle = new System.Windows.Forms.Label();
            this.lstInterestView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnInterestExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbInterest)).BeginInit();
            this.SuspendLayout();
            // 
            // pbInterest
            // 
            this.pbInterest.Image = global::CoachConnect.Properties.Resources.agri_icon;
            this.pbInterest.Location = new System.Drawing.Point(41, 12);
            this.pbInterest.Name = "pbInterest";
            this.pbInterest.Size = new System.Drawing.Size(150, 150);
            this.pbInterest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInterest.TabIndex = 26;
            this.pbInterest.TabStop = false;
            // 
            // txtInterestTitle
            // 
            this.txtInterestTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterestTitle.Location = new System.Drawing.Point(226, 12);
            this.txtInterestTitle.Name = "txtInterestTitle";
            this.txtInterestTitle.Size = new System.Drawing.Size(324, 150);
            this.txtInterestTitle.TabIndex = 27;
            this.txtInterestTitle.Text = "Put the previously selected Interest Here!";
            this.txtInterestTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstInterestView
            // 
            this.lstInterestView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstInterestView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5});
            this.lstInterestView.Location = new System.Drawing.Point(12, 192);
            this.lstInterestView.Name = "lstInterestView";
            this.lstInterestView.Size = new System.Drawing.Size(538, 244);
            this.lstInterestView.TabIndex = 28;
            this.lstInterestView.UseCompatibleStateImageBehavior = false;
            this.lstInterestView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Coach";
            this.columnHeader1.Width = 112;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Day";
            this.columnHeader2.Width = 89;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Time";
            this.columnHeader3.Width = 82;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Subjects";
            this.columnHeader4.Width = 111;
            // 
            // btnInterestExit
            // 
            this.btnInterestExit.Location = new System.Drawing.Point(216, 446);
            this.btnInterestExit.Name = "btnInterestExit";
            this.btnInterestExit.Size = new System.Drawing.Size(131, 23);
            this.btnInterestExit.TabIndex = 29;
            this.btnInterestExit.Text = "Back to Interests";
            this.btnInterestExit.UseVisualStyleBackColor = true;
            this.btnInterestExit.Click += new System.EventHandler(this.btnInterestExit_Click);
            // 
            // frmInterest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 481);
            this.Controls.Add(this.btnInterestExit);
            this.Controls.Add(this.lstInterestView);
            this.Controls.Add(this.txtInterestTitle);
            this.Controls.Add(this.pbInterest);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInterest";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmInterest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbInterest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbInterest;
        private System.Windows.Forms.Label txtInterestTitle;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.ListView lstInterestView;
        private System.Windows.Forms.Button btnInterestExit;
    }
}