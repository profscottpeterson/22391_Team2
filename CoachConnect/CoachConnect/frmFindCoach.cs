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
    public partial class frmFindCoach : Form
    {        
        public frmFindCoach()
        {
            InitializeComponent();
        }
        private void showInterestForm(Image img, string title)
        {
            frmInterest frm = new frmInterest(img, title);
            frm.BackToInterest = this;
            this.Hide();
            frm.Show(this);
        }

        private void btnAgriculture_Click(object sender, EventArgs e)
        {
            showInterestForm(btnAgriculture.BackgroundImage, lblAgri.Text);
        }

        private void btnArchitecture_Click(object sender, EventArgs e)
        {
            showInterestForm(btnArchitecture.BackgroundImage, lblArch.Text);
        }

        private void btnBusiness_Click(object sender, EventArgs e)
        {
            showInterestForm(btnBusiness.BackgroundImage, lblBusiness.Text);
        }

        private void btnDigital_Click(object sender, EventArgs e)
        {
            showInterestForm(btnDigital.BackgroundImage, lblDigital.Text);
        }

        private void btnEnergy_Click(object sender, EventArgs e)
        {
            showInterestForm(btnEnergy.BackgroundImage, lblEnergy.Text);
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            showInterestForm(btnGeneral.BackgroundImage, lblGeneral.Text);
        }

        private void btnHealth_Click(object sender, EventArgs e)
        {
            showInterestForm(btnHealth.BackgroundImage, lblHealth.Text);
        }

        private void btnHuman_Click(object sender, EventArgs e)
        {
            showInterestForm(btnHuman.BackgroundImage, lblHuman.Text);
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            showInterestForm(btnInformation.BackgroundImage, lblIT.Text);
        }

        private void btnLaw_Click(object sender, EventArgs e)
        {
            showInterestForm(btnLaw.BackgroundImage, lblLaw.Text);
        }

        private void btnManufacturing_Click(object sender, EventArgs e)
        {
            showInterestForm(btnManufacturing.BackgroundImage, lblManu.Text);
        }

        private void btnScience_Click(object sender, EventArgs e)
        {
            showInterestForm(btnScience.BackgroundImage, lblScience.Text);
        }

        private void btnTransportation_Click(object sender, EventArgs e)
        {
            showInterestForm(btnTransportation.BackgroundImage, lblTransportation.Text);
        }

        private void frmFindCoach_Load(object sender, EventArgs e)
        {

        }
    }
}
