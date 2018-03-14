// <copyright file="SessionAdminForm.designer.cs" company="PABT at NWTC">
//     Copyright 2017 PABT (Pao Xiong, Adam Smith, Brian Lueskow, Tim Durkee)
// </copyright>
namespace CoachConnect
{
    /// <summary>
    /// A form to display a list of available sessions
    /// </summary>
    public partial class SessionAdminForm
    {
        /// <summary>
        /// A data grid view to show the current sessions
        /// </summary>
        private System.Windows.Forms.DataGridView dataGridViewSessions;

        /// <summary>
        /// A button to add a new session to the database
        /// </summary>
        private System.Windows.Forms.Button btnAdd;

        /// <summary>
        /// A label for the admin window
        /// </summary>
        private System.Windows.Forms.Label lblSessionAdminForm;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SessionAdminForm));
            this.dataGridViewSessions = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSessionAdminForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSessions
            // 
            this.dataGridViewSessions.AllowUserToAddRows = false;
            this.dataGridViewSessions.AllowUserToDeleteRows = false;
            this.dataGridViewSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSessions.Location = new System.Drawing.Point(10, 56);
            this.dataGridViewSessions.MultiSelect = false;
            this.dataGridViewSessions.Name = "dataGridViewSessions";
            this.dataGridViewSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSessions.Size = new System.Drawing.Size(720, 295);
            this.dataGridViewSessions.TabIndex = 0;
            this.dataGridViewSessions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSessions_CellContentClick);
            this.dataGridViewSessions.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewSessionsCellContentDoubleClick);
            this.dataGridViewSessions.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewSessionsRowHeaderMouseDoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(10, 356);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add New Session";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
            // 
            // lblSessionAdminForm
            // 
            this.lblSessionAdminForm.AutoSize = true;
            this.lblSessionAdminForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionAdminForm.Location = new System.Drawing.Point(227, 9);
            this.lblSessionAdminForm.Name = "lblSessionAdminForm";
            this.lblSessionAdminForm.Size = new System.Drawing.Size(259, 31);
            this.lblSessionAdminForm.TabIndex = 21;
            this.lblSessionAdminForm.Text = "Update Session Info";
            this.lblSessionAdminForm.UseWaitCursor = true;
            // 
            // SessionAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 387);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSessionAdminForm);
            this.Controls.Add(this.dataGridViewSessions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SessionAdminForm";
            this.Text = "Session Admin Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SessionAdminFormFormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}