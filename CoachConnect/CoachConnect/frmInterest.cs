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
    public partial class frmInterest : Form
    {
        public Form BackToInterest { get; set; }
        public frmInterest(Image pb, string title)
        {
            InitializeComponent();
            pbInterest.Image = pb;
            txtInterestTitle.Text = title;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Location = Owner.Location;
            this.Size = Owner.Size;
        }
        private void btnInterestExit_Click(object sender, EventArgs e)
        {
            BackToInterest.Show();
            BackToInterest.Location = this.Location;
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            BackToInterest.Show();
            BackToInterest.Location = this.Location;
            this.Hide();
        }
        private void frmInterest_Load(object sender, EventArgs e)
        {

        }
    }
}
