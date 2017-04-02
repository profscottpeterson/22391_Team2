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
    public partial class frmCoachInterest : Form
    {
        Form originalForm { get; set; }
        Image picInterest { get; set; }
        string titleInterest { get; set; }
        
        public frmCoachInterest()
        {
            InitializeComponent();
        }
        public frmCoachInterest(Form original, Image interest, string title)
        {
            InitializeComponent();
            originalForm = original;
            picInterest = interest;
            titleInterest = title;
            SetForm();
        }

        private void btnInterestExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            originalForm.Show();
        }

        /// <summary>
        /// Sets Form according to button clicked.
        /// </summary>
        private void SetForm()
        {
            lblTitle.Text = titleInterest;
            pbInterest.Image = picInterest;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.Hide();
            originalForm.Show();
        }
    }
}
