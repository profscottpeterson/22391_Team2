namespace CoachConnect
{
    partial class CoachAvailabilityForm
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
            this.lblEditSessionHeader = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddToCourseList = new System.Windows.Forms.Button();
            this.dataGridViewAvailability = new System.Windows.Forms.DataGridView();
            this.cbxChooseCoach = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailability)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEditSessionHeader
            // 
            this.lblEditSessionHeader.AutoSize = true;
            this.lblEditSessionHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEditSessionHeader.Location = new System.Drawing.Point(109, 16);
            this.lblEditSessionHeader.Name = "lblEditSessionHeader";
            this.lblEditSessionHeader.Size = new System.Drawing.Size(193, 24);
            this.lblEditSessionHeader.TabIndex = 13;
            this.lblEditSessionHeader.Text = "Edit Coach Availability";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnAddToCourseList);
            this.groupBox1.Controls.Add(this.dataGridViewAvailability);
            this.groupBox1.Location = new System.Drawing.Point(15, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 231);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Availability";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(302, 197);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 34;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAddToCourseList
            // 
            this.btnAddToCourseList.Location = new System.Drawing.Point(12, 197);
            this.btnAddToCourseList.Name = "btnAddToCourseList";
            this.btnAddToCourseList.Size = new System.Drawing.Size(95, 23);
            this.btnAddToCourseList.TabIndex = 33;
            this.btnAddToCourseList.Text = "Add New Listing";
            this.btnAddToCourseList.UseVisualStyleBackColor = true;
            this.btnAddToCourseList.Click += new System.EventHandler(this.btnAddToCourseList_Click);
            // 
            // dataGridViewAvailability
            // 
            this.dataGridViewAvailability.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAvailability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailability.Location = new System.Drawing.Point(9, 28);
            this.dataGridViewAvailability.MultiSelect = false;
            this.dataGridViewAvailability.Name = "dataGridViewAvailability";
            this.dataGridViewAvailability.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAvailability.Size = new System.Drawing.Size(365, 163);
            this.dataGridViewAvailability.TabIndex = 31;
            this.dataGridViewAvailability.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewAvailability_RowHeaderMouseDoubleClick);
            // 
            // cbxChooseCoach
            // 
            this.cbxChooseCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbxChooseCoach.FormattingEnabled = true;
            this.cbxChooseCoach.Location = new System.Drawing.Point(174, 62);
            this.cbxChooseCoach.Name = "cbxChooseCoach";
            this.cbxChooseCoach.Size = new System.Drawing.Size(192, 21);
            this.cbxChooseCoach.TabIndex = 55;
            this.cbxChooseCoach.SelectedIndexChanged += new System.EventHandler(this.cbxChooseCoach_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Choose a Coach:";
            // 
            // CoachAvailabilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 349);
            this.Controls.Add(this.cbxChooseCoach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEditSessionHeader);
            this.Name = "CoachAvailabilityForm";
            this.Text = "CoachAvailabilityForm";
            this.Load += new System.EventHandler(this.CoachAvailabilityFormLoad);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailability)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditSessionHeader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddToCourseList;
        private System.Windows.Forms.DataGridView dataGridViewAvailability;
        private System.Windows.Forms.ComboBox cbxChooseCoach;
        private System.Windows.Forms.Label label3;
    }
}