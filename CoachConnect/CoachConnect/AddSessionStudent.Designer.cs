namespace CoachConnect
{
    partial class AddSessionStudent
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridViewEligibleStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEligibleStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEditSessionHeader
            // 
            this.lblEditSessionHeader.AutoSize = true;
            this.lblEditSessionHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEditSessionHeader.Location = new System.Drawing.Point(40, 15);
            this.lblEditSessionHeader.Name = "lblEditSessionHeader";
            this.lblEditSessionHeader.Size = new System.Drawing.Size(206, 24);
            this.lblEditSessionHeader.TabIndex = 15;
            this.lblEditSessionHeader.Text = "Add Student to Session";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 208);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(196, 208);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCloseClick);
            // 
            // dataGridViewEligibleStudents
            // 
            this.dataGridViewEligibleStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewEligibleStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEligibleStudents.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewEligibleStudents.Name = "dataGridViewEligibleStudents";
            this.dataGridViewEligibleStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEligibleStudents.Size = new System.Drawing.Size(259, 150);
            this.dataGridViewEligibleStudents.TabIndex = 28;
            this.dataGridViewEligibleStudents.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewEligibleStudentsCellContentDoubleClick);
            this.dataGridViewEligibleStudents.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewEligibleStudentsRowHeaderMouseDoubleClick);
            // 
            // AddSessionStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 243);
            this.Controls.Add(this.dataGridViewEligibleStudents);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblEditSessionHeader);
            this.Name = "AddSessionStudent";
            this.Text = "Add Student to Session";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEligibleStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditSessionHeader;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridViewEligibleStudents;
    }
}