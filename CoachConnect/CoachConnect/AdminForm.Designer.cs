namespace CoachConnect
{
    partial class AdminForm
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
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.listBoxAdminTools = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // panelAdmin
            // 
            this.panelAdmin.AutoScroll = true;
            this.panelAdmin.Location = new System.Drawing.Point(163, 12);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(621, 510);
            this.panelAdmin.TabIndex = 0;
            // 
            // listBoxAdminTools
            // 
            this.listBoxAdminTools.FormattingEnabled = true;
            this.listBoxAdminTools.Location = new System.Drawing.Point(12, 9);
            this.listBoxAdminTools.Name = "listBoxAdminTools";
            this.listBoxAdminTools.Size = new System.Drawing.Size(151, 511);
            this.listBoxAdminTools.TabIndex = 1;
            this.listBoxAdminTools.SelectedIndexChanged += new System.EventHandler(this.listBoxAdminTools_SelectedIndexChanged);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(790, 530);
            this.Controls.Add(this.listBoxAdminTools);
            this.Controls.Add(this.panelAdmin);
            this.Name = "AdminForm";
            this.Text = "Administration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.ListBox listBoxAdminTools;
    }
}