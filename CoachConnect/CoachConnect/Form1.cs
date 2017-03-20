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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using (var context = new db_sft_2172Entities())
            {
                var L2EQuery = from bldg in context.Buildings
                               select bldg;

                var building = L2EQuery.FirstOrDefault<Building>();

                MessageBox.Show(building.BuildingName.ToString());
            }

        }
    }
}
