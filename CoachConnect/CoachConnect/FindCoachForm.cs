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
    public partial class FindCoachForm : Form
    {
        public FindCoachForm()
        {
            InitializeComponent();
        }

        private void SelectedInterest(Image interest, string title)
        {
            this.Hide();
            frmCoachInterest frm2 = new frmCoachInterest(this, interest,title);
            frm2.Show();
            frm2.Location = this.Location;
        }

        private void btnAgri_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnAgri.BackgroundImage, lblAgri.Text);
        }

        private void btnArch_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnArch.BackgroundImage, lblArch.Text);
        }

        private void btnBusiness_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnBusiness.BackgroundImage,lblBusiness.Text);
        }

        private void btnDigital_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnDigital.BackgroundImage,lblDigital.Text);
        }

        private void btnEnergy_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnEnergy.BackgroundImage,lblEnergy.Text);
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnGeneral.BackgroundImage,lblGeneral.Text);
        }

        private void bthHealth_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnHealth.BackgroundImage,lblHealth.Text);
        }

        private void btnHuman_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnHuman.BackgroundImage,lblHuman.Text);
        }

        private void btnIT_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnIT.BackgroundImage, lblIT.Text);
        }

        private void btnLaw_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnLaw.BackgroundImage,lblLaw.Text);
        }

        private void btnManu_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnManu.BackgroundImage, lblManu.Text);
        }

        private void btnScience_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnScience.BackgroundImage,lblScience.Text);
        }

        private void btnTransport_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnTransport.BackgroundImage,lblTransport.Text);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
