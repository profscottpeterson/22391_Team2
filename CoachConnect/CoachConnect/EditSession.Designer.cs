namespace CoachConnect
{
    partial class EditSession
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
            this.lblCourse = new System.Windows.Forms.Label();
            this.cbxCourse = new System.Windows.Forms.ComboBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.cbxRoom = new System.Windows.Forms.ComboBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.cbxDay = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.cbxTime = new System.Windows.Forms.ComboBox();
            this.lblCoach = new System.Windows.Forms.Label();
            this.cbxCoach = new System.Windows.Forms.ComboBox();
            this.lblEditSessionHeader = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxActive = new System.Windows.Forms.ComboBox();
            this.lblInvalidCourse = new System.Windows.Forms.Label();
            this.lblInvalidRoom = new System.Windows.Forms.Label();
            this.lblInvalidDay = new System.Windows.Forms.Label();
            this.lblInvalidTime = new System.Windows.Forms.Label();
            this.lblInvalidCoach = new System.Windows.Forms.Label();
            this.lblInvalidActive = new System.Windows.Forms.Label();
            this.dataGridViewRoster = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddToRoster = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoster)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(18, 36);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(40, 13);
            this.lblCourse.TabIndex = 3;
            this.lblCourse.Text = "Course";
            // 
            // cbxCourse
            // 
            this.cbxCourse.FormattingEnabled = true;
            this.cbxCourse.Location = new System.Drawing.Point(61, 33);
            this.cbxCourse.Name = "cbxCourse";
            this.cbxCourse.Size = new System.Drawing.Size(121, 21);
            this.cbxCourse.TabIndex = 2;
            this.cbxCourse.Leave += new System.EventHandler(this.cbxCourse_Leave);
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(18, 63);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(35, 13);
            this.lblRoom.TabIndex = 5;
            this.lblRoom.Text = "Room";
            // 
            // cbxRoom
            // 
            this.cbxRoom.FormattingEnabled = true;
            this.cbxRoom.Location = new System.Drawing.Point(61, 60);
            this.cbxRoom.Name = "cbxRoom";
            this.cbxRoom.Size = new System.Drawing.Size(121, 21);
            this.cbxRoom.TabIndex = 4;
            this.cbxRoom.Leave += new System.EventHandler(this.cbxRoom_Leave);
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(18, 92);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(26, 13);
            this.lblDay.TabIndex = 7;
            this.lblDay.Text = "Day";
            // 
            // cbxDay
            // 
            this.cbxDay.FormattingEnabled = true;
            this.cbxDay.Location = new System.Drawing.Point(61, 89);
            this.cbxDay.Name = "cbxDay";
            this.cbxDay.Size = new System.Drawing.Size(121, 21);
            this.cbxDay.TabIndex = 6;
            this.cbxDay.Leave += new System.EventHandler(this.cbxDay_Leave);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(18, 119);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "Time";
            // 
            // cbxTime
            // 
            this.cbxTime.FormattingEnabled = true;
            this.cbxTime.Location = new System.Drawing.Point(61, 116);
            this.cbxTime.Name = "cbxTime";
            this.cbxTime.Size = new System.Drawing.Size(121, 21);
            this.cbxTime.TabIndex = 8;
            this.cbxTime.Leave += new System.EventHandler(this.cbxTime_Leave);
            // 
            // lblCoach
            // 
            this.lblCoach.AutoSize = true;
            this.lblCoach.Location = new System.Drawing.Point(18, 146);
            this.lblCoach.Name = "lblCoach";
            this.lblCoach.Size = new System.Drawing.Size(38, 13);
            this.lblCoach.TabIndex = 11;
            this.lblCoach.Text = "Coach";
            // 
            // cbxCoach
            // 
            this.cbxCoach.FormattingEnabled = true;
            this.cbxCoach.Location = new System.Drawing.Point(61, 143);
            this.cbxCoach.Name = "cbxCoach";
            this.cbxCoach.Size = new System.Drawing.Size(121, 21);
            this.cbxCoach.TabIndex = 10;
            this.cbxCoach.Leave += new System.EventHandler(this.cbxCoach_Leave);
            // 
            // lblEditSessionHeader
            // 
            this.lblEditSessionHeader.AutoSize = true;
            this.lblEditSessionHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEditSessionHeader.Location = new System.Drawing.Point(234, 9);
            this.lblEditSessionHeader.Name = "lblEditSessionHeader";
            this.lblEditSessionHeader.Size = new System.Drawing.Size(114, 24);
            this.lblEditSessionHeader.TabIndex = 12;
            this.lblEditSessionHeader.Text = "Edit Session";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(231, 274);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(317, 274);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Active";
            // 
            // cbxActive
            // 
            this.cbxActive.FormattingEnabled = true;
            this.cbxActive.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbxActive.Location = new System.Drawing.Point(61, 170);
            this.cbxActive.Name = "cbxActive";
            this.cbxActive.Size = new System.Drawing.Size(121, 21);
            this.cbxActive.TabIndex = 15;
            this.cbxActive.Leave += new System.EventHandler(this.cbxActive_Leave);
            // 
            // lblInvalidCourse
            // 
            this.lblInvalidCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidCourse.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidCourse.Location = new System.Drawing.Point(188, 36);
            this.lblInvalidCourse.Name = "lblInvalidCourse";
            this.lblInvalidCourse.Size = new System.Drawing.Size(90, 16);
            this.lblInvalidCourse.TabIndex = 25;
            this.lblInvalidCourse.Text = "Invalid Course";
            this.lblInvalidCourse.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblInvalidCourse.Visible = false;
            // 
            // lblInvalidRoom
            // 
            this.lblInvalidRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidRoom.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidRoom.Location = new System.Drawing.Point(188, 63);
            this.lblInvalidRoom.Name = "lblInvalidRoom";
            this.lblInvalidRoom.Size = new System.Drawing.Size(90, 16);
            this.lblInvalidRoom.TabIndex = 26;
            this.lblInvalidRoom.Text = "Invalid Room";
            this.lblInvalidRoom.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblInvalidRoom.Visible = false;
            // 
            // lblInvalidDay
            // 
            this.lblInvalidDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidDay.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidDay.Location = new System.Drawing.Point(188, 92);
            this.lblInvalidDay.Name = "lblInvalidDay";
            this.lblInvalidDay.Size = new System.Drawing.Size(90, 16);
            this.lblInvalidDay.TabIndex = 27;
            this.lblInvalidDay.Text = "Invalid Day";
            this.lblInvalidDay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblInvalidDay.Visible = false;
            // 
            // lblInvalidTime
            // 
            this.lblInvalidTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidTime.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidTime.Location = new System.Drawing.Point(188, 119);
            this.lblInvalidTime.Name = "lblInvalidTime";
            this.lblInvalidTime.Size = new System.Drawing.Size(90, 16);
            this.lblInvalidTime.TabIndex = 28;
            this.lblInvalidTime.Text = "Invalid Time";
            this.lblInvalidTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblInvalidTime.Visible = false;
            // 
            // lblInvalidCoach
            // 
            this.lblInvalidCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidCoach.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidCoach.Location = new System.Drawing.Point(188, 146);
            this.lblInvalidCoach.Name = "lblInvalidCoach";
            this.lblInvalidCoach.Size = new System.Drawing.Size(90, 16);
            this.lblInvalidCoach.TabIndex = 29;
            this.lblInvalidCoach.Text = "Invalid Coach";
            this.lblInvalidCoach.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblInvalidCoach.Visible = false;
            // 
            // lblInvalidActive
            // 
            this.lblInvalidActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidActive.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidActive.Location = new System.Drawing.Point(188, 173);
            this.lblInvalidActive.Name = "lblInvalidActive";
            this.lblInvalidActive.Size = new System.Drawing.Size(90, 16);
            this.lblInvalidActive.TabIndex = 30;
            this.lblInvalidActive.Text = "Invalid Choice";
            this.lblInvalidActive.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblInvalidActive.Visible = false;
            // 
            // dataGridViewRoster
            // 
            this.dataGridViewRoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoster.Location = new System.Drawing.Point(19, 28);
            this.dataGridViewRoster.Name = "dataGridViewRoster";
            this.dataGridViewRoster.Size = new System.Drawing.Size(270, 136);
            this.dataGridViewRoster.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnAddToRoster);
            this.groupBox1.Controls.Add(this.dataGridViewRoster);
            this.groupBox1.Location = new System.Drawing.Point(317, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 215);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Session Roster";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(169, 173);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 34;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAddToRoster
            // 
            this.btnAddToRoster.Location = new System.Drawing.Point(77, 173);
            this.btnAddToRoster.Name = "btnAddToRoster";
            this.btnAddToRoster.Size = new System.Drawing.Size(86, 23);
            this.btnAddToRoster.TabIndex = 33;
            this.btnAddToRoster.Text = "Add To Roster";
            this.btnAddToRoster.UseVisualStyleBackColor = true;
            this.btnAddToRoster.Click += new System.EventHandler(this.btnAddToRoster_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblInvalidActive);
            this.groupBox2.Controls.Add(this.lblInvalidCoach);
            this.groupBox2.Controls.Add(this.lblInvalidTime);
            this.groupBox2.Controls.Add(this.lblInvalidDay);
            this.groupBox2.Controls.Add(this.lblInvalidRoom);
            this.groupBox2.Controls.Add(this.lblInvalidCourse);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbxActive);
            this.groupBox2.Controls.Add(this.lblCoach);
            this.groupBox2.Controls.Add(this.cbxCoach);
            this.groupBox2.Controls.Add(this.lblTime);
            this.groupBox2.Controls.Add(this.cbxTime);
            this.groupBox2.Controls.Add(this.lblDay);
            this.groupBox2.Controls.Add(this.cbxDay);
            this.groupBox2.Controls.Add(this.lblRoom);
            this.groupBox2.Controls.Add(this.cbxRoom);
            this.groupBox2.Controls.Add(this.lblCourse);
            this.groupBox2.Controls.Add(this.cbxCourse);
            this.groupBox2.Location = new System.Drawing.Point(16, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 214);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Session Details";
            // 
            // EditSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 300);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblEditSessionHeader);
            this.Name = "EditSession";
            this.Text = "EditSession";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoster)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox cbxCourse;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.ComboBox cbxRoom;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.ComboBox cbxDay;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cbxTime;
        private System.Windows.Forms.Label lblCoach;
        private System.Windows.Forms.ComboBox cbxCoach;
        private System.Windows.Forms.Label lblEditSessionHeader;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxActive;
        private System.Windows.Forms.Label lblInvalidCourse;
        private System.Windows.Forms.Label lblInvalidRoom;
        private System.Windows.Forms.Label lblInvalidDay;
        private System.Windows.Forms.Label lblInvalidTime;
        private System.Windows.Forms.Label lblInvalidCoach;
        private System.Windows.Forms.Label lblInvalidActive;
        private System.Windows.Forms.DataGridView dataGridViewRoster;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddToRoster;
    }
}