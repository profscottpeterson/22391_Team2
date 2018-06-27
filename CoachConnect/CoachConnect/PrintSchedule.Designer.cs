﻿namespace CoachConnect
{
    partial class PrintSchedule
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
            this.btnSaveScheduleToExcel = new System.Windows.Forms.Button();
            this.lblSessionAdminForm = new System.Windows.Forms.Label();
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.cbxChooseDepartment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveScheduleToExcel
            // 
            this.btnSaveScheduleToExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveScheduleToExcel.Location = new System.Drawing.Point(49, 412);
            this.btnSaveScheduleToExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveScheduleToExcel.Name = "btnSaveScheduleToExcel";
            this.btnSaveScheduleToExcel.Size = new System.Drawing.Size(139, 23);
            this.btnSaveScheduleToExcel.TabIndex = 23;
            this.btnSaveScheduleToExcel.Text = "Save Schedule to Excel";
            this.btnSaveScheduleToExcel.UseVisualStyleBackColor = true;
            this.btnSaveScheduleToExcel.Click += new System.EventHandler(this.btnSaveScheduleToExcel_Click);
            // 
            // lblSessionAdminForm
            // 
            this.lblSessionAdminForm.AutoSize = true;
            this.lblSessionAdminForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionAdminForm.Location = new System.Drawing.Point(314, 27);
            this.lblSessionAdminForm.Name = "lblSessionAdminForm";
            this.lblSessionAdminForm.Size = new System.Drawing.Size(339, 31);
            this.lblSessionAdminForm.TabIndex = 24;
            this.lblSessionAdminForm.Text = "Print Department Schedule";
            this.lblSessionAdminForm.UseWaitCursor = true;
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.AllowUserToAddRows = false;
            this.dataGridViewSchedule.AllowUserToDeleteRows = false;
            this.dataGridViewSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(49, 112);
            this.dataGridViewSchedule.MultiSelect = false;
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(871, 295);
            this.dataGridViewSchedule.TabIndex = 22;
            // 
            // cbxChooseDepartment
            // 
            this.cbxChooseDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbxChooseDepartment.FormattingEnabled = true;
            this.cbxChooseDepartment.Location = new System.Drawing.Point(456, 74);
            this.cbxChooseDepartment.Name = "cbxChooseDepartment";
            this.cbxChooseDepartment.Size = new System.Drawing.Size(192, 21);
            this.cbxChooseDepartment.TabIndex = 57;
            this.cbxChooseDepartment.SelectedIndexChanged += new System.EventHandler(this.cbxChooseDepartment_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Choose a Department:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(781, 412);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 59;
            this.button1.Text = "Close Window";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PrintSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxChooseDepartment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSaveScheduleToExcel);
            this.Controls.Add(this.lblSessionAdminForm);
            this.Controls.Add(this.dataGridViewSchedule);
            this.Name = "PrintSchedule";
            this.Text = "Print Schedule by Interest";
            this.Load += new System.EventHandler(this.PrintScheduleFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveScheduleToExcel;
        private System.Windows.Forms.Label lblSessionAdminForm;
        private System.Windows.Forms.DataGridView dataGridViewSchedule;
        private System.Windows.Forms.ComboBox cbxChooseDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}