// <copyright file="EditSession.Designer.cs" company="PABT at NWTC">
//     Copyright 2017 PABT (Pao Xiong, Adam Smith, Brian Lueskow, Tim Durkee)
// </copyright>
namespace CoachConnect
{
    /// <summary>
    /// EditSession: A form which allows users to create and edit session data, then save the data to the database.
    /// </summary>
    public partial class EditSession
    {
        /// <summary>
        /// Label for the Course combo box
        /// </summary>
        private System.Windows.Forms.Label lblCourse;

        /// <summary>
        /// Combo box containing active courses
        /// </summary>
        private System.Windows.Forms.ComboBox cbxCourse;

        /// <summary>
        /// Label for the Room combo box
        /// </summary>
        private System.Windows.Forms.Label lblRoom;

        /// <summary>
        /// Combo box containing active rooms
        /// </summary>
        private System.Windows.Forms.ComboBox cbxRoom;

        /// <summary>
        /// Label for the Day combo box
        /// </summary>
        private System.Windows.Forms.Label lblDay;

        /// <summary>
        /// Combo box containing active Days
        /// </summary>
        private System.Windows.Forms.ComboBox cbxDay;

        /// <summary>
        /// Label for the Time combo box
        /// </summary>
        private System.Windows.Forms.Label lblTime;

        /// <summary>
        /// Combo box containing active Times
        /// </summary>
        private System.Windows.Forms.ComboBox cbxTime;

        /// <summary>
        /// Label for the Coach combo box
        /// </summary>
        private System.Windows.Forms.Label lblCoach;

        /// <summary>
        /// Combo box containing active coaches
        /// </summary>
        private System.Windows.Forms.ComboBox cbxCoach;

        /// <summary>
        /// Label for the form title
        /// </summary>
        private System.Windows.Forms.Label lblEditSessionHeader;

        /// <summary>
        /// Button allowing users to save changes
        /// </summary>
        private System.Windows.Forms.Button btnSave;

        /// <summary>
        /// Button allowing users to cancel changes
        /// </summary>
        private System.Windows.Forms.Button btnCancel;

        /// <summary>
        /// Label for the Active combo box
        /// </summary>
        private System.Windows.Forms.Label lblActive;

        /// <summary>
        /// Combo box allowing users to select an active value (Yes or No)
        /// </summary>
        private System.Windows.Forms.ComboBox cbxActive;

        /// <summary>
        /// Validation label indicating a course was not selected
        /// </summary>
        private System.Windows.Forms.Label lblInvalidCourse;

        /// <summary>
        /// Validation label indicating a room was not selected
        /// </summary>
        private System.Windows.Forms.Label lblInvalidRoom;

        /// <summary>
        /// Validation label indicating a day was not selected
        /// </summary>
        private System.Windows.Forms.Label lblInvalidDay;

        /// <summary>
        /// Validation label indicating a time was not selected
        /// </summary>
        private System.Windows.Forms.Label lblInvalidTime;

        /// <summary>
        /// Validation label indicating a coach was not selected
        /// </summary>
        private System.Windows.Forms.Label lblInvalidCoach;

        /// <summary>
        /// Validation label indicating an inactive value was not selected
        /// </summary>
        private System.Windows.Forms.Label lblInvalidActive;

        /// <summary>
        /// A data grid to show the session roster
        /// </summary>
        private System.Windows.Forms.DataGridView dataGridViewRoster;

        /// <summary>
        /// A group box
        /// </summary>
        private System.Windows.Forms.GroupBox groupBox1;

        /// <summary>
        /// Another group box
        /// </summary>
        private System.Windows.Forms.GroupBox groupBox2;

        /// <summary>
        /// A button to remove a student from the roster
        /// </summary>
        private System.Windows.Forms.Button btnRemove;

        /// <summary>
        /// A button to open a new form and select a student to add
        /// </summary>
        private System.Windows.Forms.Button btnAddToRoster;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSession));
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
            this.lblActive = new System.Windows.Forms.Label();
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
            this.lblCourse.Location = new System.Drawing.Point(18, 31);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(40, 13);
            this.lblCourse.TabIndex = 3;
            this.lblCourse.Text = "Course";
            // 
            // cbxCourse
            // 
            this.cbxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCourse.FormattingEnabled = true;
            this.cbxCourse.Location = new System.Drawing.Point(61, 28);
            this.cbxCourse.Name = "cbxCourse";
            this.cbxCourse.Size = new System.Drawing.Size(121, 21);
            this.cbxCourse.TabIndex = 2;
            this.cbxCourse.Leave += new System.EventHandler(this.CbxCourse_Leave);
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(18, 58);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(35, 13);
            this.lblRoom.TabIndex = 5;
            this.lblRoom.Text = "Room";
            // 
            // cbxRoom
            // 
            this.cbxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoom.FormattingEnabled = true;
            this.cbxRoom.Location = new System.Drawing.Point(61, 55);
            this.cbxRoom.Name = "cbxRoom";
            this.cbxRoom.Size = new System.Drawing.Size(121, 21);
            this.cbxRoom.TabIndex = 4;
            this.cbxRoom.Leave += new System.EventHandler(this.CbxRoom_Leave);
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(18, 87);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(26, 13);
            this.lblDay.TabIndex = 7;
            this.lblDay.Text = "Day";
            // 
            // cbxDay
            // 
            this.cbxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDay.FormattingEnabled = true;
            this.cbxDay.Location = new System.Drawing.Point(61, 84);
            this.cbxDay.Name = "cbxDay";
            this.cbxDay.Size = new System.Drawing.Size(121, 21);
            this.cbxDay.TabIndex = 6;
            this.cbxDay.Leave += new System.EventHandler(this.CbxDay_Leave);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(18, 114);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "Time";
            // 
            // cbxTime
            // 
            this.cbxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTime.FormattingEnabled = true;
            this.cbxTime.Location = new System.Drawing.Point(61, 111);
            this.cbxTime.Name = "cbxTime";
            this.cbxTime.Size = new System.Drawing.Size(121, 21);
            this.cbxTime.TabIndex = 8;
            this.cbxTime.Leave += new System.EventHandler(this.CbxTime_Leave);
            // 
            // lblCoach
            // 
            this.lblCoach.AutoSize = true;
            this.lblCoach.Location = new System.Drawing.Point(18, 141);
            this.lblCoach.Name = "lblCoach";
            this.lblCoach.Size = new System.Drawing.Size(38, 13);
            this.lblCoach.TabIndex = 11;
            this.lblCoach.Text = "Coach";
            // 
            // cbxCoach
            // 
            this.cbxCoach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCoach.FormattingEnabled = true;
            this.cbxCoach.Location = new System.Drawing.Point(61, 138);
            this.cbxCoach.Name = "cbxCoach";
            this.cbxCoach.Size = new System.Drawing.Size(121, 21);
            this.cbxCoach.TabIndex = 10;
            this.cbxCoach.Leave += new System.EventHandler(this.CbxCoach_Leave);
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
            this.btnSave.Location = new System.Drawing.Point(219, 261);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(317, 261);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(18, 168);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(37, 13);
            this.lblActive.TabIndex = 16;
            this.lblActive.Text = "Active";
            // 
            // cbxActive
            // 
            this.cbxActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxActive.FormattingEnabled = true;
            this.cbxActive.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbxActive.Location = new System.Drawing.Point(61, 165);
            this.cbxActive.Name = "cbxActive";
            this.cbxActive.Size = new System.Drawing.Size(121, 21);
            this.cbxActive.TabIndex = 15;
            this.cbxActive.Leave += new System.EventHandler(this.CbxActive_Leave);
            // 
            // lblInvalidCourse
            // 
            this.lblInvalidCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidCourse.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidCourse.Location = new System.Drawing.Point(188, 31);
            this.lblInvalidCourse.Name = "lblInvalidCourse";
            this.lblInvalidCourse.Size = new System.Drawing.Size(75, 13);
            this.lblInvalidCourse.TabIndex = 25;
            this.lblInvalidCourse.Text = "Invalid Course";
            this.lblInvalidCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInvalidCourse.Visible = false;
            // 
            // lblInvalidRoom
            // 
            this.lblInvalidRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidRoom.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidRoom.Location = new System.Drawing.Point(188, 58);
            this.lblInvalidRoom.Name = "lblInvalidRoom";
            this.lblInvalidRoom.Size = new System.Drawing.Size(75, 13);
            this.lblInvalidRoom.TabIndex = 26;
            this.lblInvalidRoom.Text = "Invalid Room";
            this.lblInvalidRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInvalidRoom.Visible = false;
            // 
            // lblInvalidDay
            // 
            this.lblInvalidDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidDay.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidDay.Location = new System.Drawing.Point(188, 87);
            this.lblInvalidDay.Name = "lblInvalidDay";
            this.lblInvalidDay.Size = new System.Drawing.Size(75, 13);
            this.lblInvalidDay.TabIndex = 27;
            this.lblInvalidDay.Text = "Invalid Day";
            this.lblInvalidDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInvalidDay.Visible = false;
            // 
            // lblInvalidTime
            // 
            this.lblInvalidTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidTime.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidTime.Location = new System.Drawing.Point(188, 114);
            this.lblInvalidTime.Name = "lblInvalidTime";
            this.lblInvalidTime.Size = new System.Drawing.Size(75, 13);
            this.lblInvalidTime.TabIndex = 28;
            this.lblInvalidTime.Text = "Invalid Time";
            this.lblInvalidTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInvalidTime.Visible = false;
            // 
            // lblInvalidCoach
            // 
            this.lblInvalidCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidCoach.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidCoach.Location = new System.Drawing.Point(188, 138);
            this.lblInvalidCoach.Name = "lblInvalidCoach";
            this.lblInvalidCoach.Size = new System.Drawing.Size(75, 18);
            this.lblInvalidCoach.TabIndex = 29;
            this.lblInvalidCoach.Text = "Invalid Coach";
            this.lblInvalidCoach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInvalidCoach.Visible = false;
            // 
            // lblInvalidActive
            // 
            this.lblInvalidActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidActive.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidActive.Location = new System.Drawing.Point(188, 164);
            this.lblInvalidActive.Name = "lblInvalidActive";
            this.lblInvalidActive.Size = new System.Drawing.Size(75, 20);
            this.lblInvalidActive.TabIndex = 30;
            this.lblInvalidActive.Text = "Invalid Choice";
            this.lblInvalidActive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInvalidActive.Visible = false;
            // 
            // dataGridViewRoster
            // 
            this.dataGridViewRoster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoster.Location = new System.Drawing.Point(12, 28);
            this.dataGridViewRoster.MultiSelect = false;
            this.dataGridViewRoster.Name = "dataGridViewRoster";
            this.dataGridViewRoster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRoster.Size = new System.Drawing.Size(270, 136);
            this.dataGridViewRoster.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnAddToRoster);
            this.groupBox1.Controls.Add(this.dataGridViewRoster);
            this.groupBox1.Location = new System.Drawing.Point(300, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 205);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Session Roster";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(207, 170);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 34;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnAddToRoster
            // 
            this.btnAddToRoster.Location = new System.Drawing.Point(12, 173);
            this.btnAddToRoster.Name = "btnAddToRoster";
            this.btnAddToRoster.Size = new System.Drawing.Size(86, 23);
            this.btnAddToRoster.TabIndex = 33;
            this.btnAddToRoster.Text = "Add To Roster";
            this.btnAddToRoster.UseVisualStyleBackColor = true;
            this.btnAddToRoster.Click += new System.EventHandler(this.BtnAddToRoster_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblInvalidActive);
            this.groupBox2.Controls.Add(this.lblInvalidCoach);
            this.groupBox2.Controls.Add(this.lblInvalidTime);
            this.groupBox2.Controls.Add(this.lblInvalidDay);
            this.groupBox2.Controls.Add(this.lblInvalidRoom);
            this.groupBox2.Controls.Add(this.lblInvalidCourse);
            this.groupBox2.Controls.Add(this.lblActive);
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
            this.groupBox2.Size = new System.Drawing.Size(269, 205);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Session Details";
            // 
            // EditSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 300);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblEditSessionHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditSession";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoster)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}