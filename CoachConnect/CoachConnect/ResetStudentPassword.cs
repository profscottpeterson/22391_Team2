using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoachConnect
{
    public partial class ResetStudentPassword : Form
    {
        private TextBox txtPassword;
        private TextBox txtStdNewPassword;
        private TextBox txtStdNewConfirmPassword;

        public ResetStudentPassword()
        {
            InitializeComponent();
        }

        private void btbEditProfile_Click(object sender, EventArgs e)
        {
            FindCoachForm mainForm = new FindCoachForm();
            mainForm.Show();
            this.Close();
        }

        private void InitializeComponent()
        {
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtStdNewPassword = new System.Windows.Forms.TextBox();
            this.txtStdNewConfirmPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(107, 34);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(150, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtStdNewPassword
            // 
            this.txtStdNewPassword.Location = new System.Drawing.Point(107, 94);
            this.txtStdNewPassword.Name = "txtStdNewPassword";
            this.txtStdNewPassword.Size = new System.Drawing.Size(150, 20);
            this.txtStdNewPassword.TabIndex = 2;
            // 
            // txtStdNewConfirmPassword
            // 
            this.txtStdNewConfirmPassword.Location = new System.Drawing.Point(107, 148);
            this.txtStdNewConfirmPassword.Name = "txtStdNewConfirmPassword";
            this.txtStdNewConfirmPassword.Size = new System.Drawing.Size(150, 20);
            this.txtStdNewConfirmPassword.TabIndex = 3;
            // 
            // ResetStudentPassword
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtStdNewConfirmPassword);
            this.Controls.Add(this.txtStdNewPassword);
            this.Controls.Add(this.txtPassword);
            this.Name = "ResetStudentPassword";
            this.Text = "Reset Student Password Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }

   
}
