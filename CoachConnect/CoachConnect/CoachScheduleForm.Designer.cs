namespace CoachConnect
{
    partial class CoachScheduleForm
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
            this.lblEditScheduleSessionHeader = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddToCourseList = new System.Windows.Forms.Button();
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.cbxChooseCoach = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEditScheduleSessionHeader
            // 
            this.lblEditScheduleSessionHeader.AutoSize = true;
            this.lblEditScheduleSessionHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEditScheduleSessionHeader.Location = new System.Drawing.Point(109, 16);
            this.lblEditScheduleSessionHeader.Name = "lblEditScheduleSessionHeader";
            this.lblEditScheduleSessionHeader.Size = new System.Drawing.Size(188, 24);
            this.lblEditScheduleSessionHeader.TabIndex = 13;
            this.lblEditScheduleSessionHeader.Text = "Edit Coach Schedule";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnAddToCourseList);
            this.groupBox1.Controls.Add(this.dataGridViewSchedule);
            this.groupBox1.Location = new System.Drawing.Point(15, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 231);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schedule";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(302, 197);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 34;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddToCourseList
            // 
            this.btnAddToCourseList.Location = new System.Drawing.Point(12, 197);
            this.btnAddToCourseList.Name = "btnAddToCourseList";
            this.btnAddToCourseList.Size = new System.Drawing.Size(101, 23);
            this.btnAddToCourseList.TabIndex = 33;
            this.btnAddToCourseList.Text = "Add New Session";
            this.btnAddToCourseList.UseVisualStyleBackColor = true;
            this.btnAddToCourseList.Click += new System.EventHandler(this.btnAddToCourseList_Click);
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(9, 28);
            this.dataGridViewSchedule.MultiSelect = false;
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(365, 163);
            this.dataGridViewSchedule.TabIndex = 31;
            this.dataGridViewSchedule.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSchedule_RowHeaderMouseDoubleClick);
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
            // CoachScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 349);
            this.Controls.Add(this.cbxChooseCoach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEditScheduleSessionHeader);
            this.Name = "CoachScheduleForm";
            this.Text = "CoachAvailabilityForm";
            this.Load += new System.EventHandler(this.CoachAvailabilityFormLoad);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditScheduleSessionHeader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddToCourseList;
        private System.Windows.Forms.DataGridView dataGridViewSchedule;
        private System.Windows.Forms.ComboBox cbxChooseCoach;
        private System.Windows.Forms.Label label3;
    }
}