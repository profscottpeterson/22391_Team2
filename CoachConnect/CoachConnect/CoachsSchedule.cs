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
    public partial class frmCoachsSchedule : Form
    {
        public frmCoachsSchedule()
        {
            InitializeComponent();
            loadSchedule();
        }

        public void loadSchedule()
        {
            const int HEIGHT = 30;
            const int WIDTH = 65;
            const int BUFFER = 17;
            int days = dayCount();
            int dayparts = dayPartCount();
            const int startX = 90;
            const int startY = 300;
            //Program.CurrentUser = "345678901";
            pbProfilePic.ImageLocation = FetchPic(Program.CurrentUser);

            for (int y = 0; y< dayparts;y++)
            {
                for (int x = 0; x < days; x++)
                {
                    Label lblBlock = new Label();
                    Point currentLocation = new Point(startX+(x*WIDTH), startY+((HEIGHT+BUFFER)*y));
                    lblBlock.Location = currentLocation;
                    lblBlock.Name = "block" + x + y;
                    lblBlock.Size = new Size(WIDTH, HEIGHT);
                    lblBlock.Text = lblBlock.Name;
                    lblBlock.TextAlign = ContentAlignment.MiddleCenter;
                    lblBlock.BackColor = Color.Red;
                    lblBlock.Click += (s,ee) => { blockClicked(lblBlock); };
                    this.Controls.Add(lblBlock);
                }
            }
        }

        public void blockClicked(Label block)
        {
            MessageBox.Show(block.Text);
        }
        public int dayCount()
        {
            using(var context= new db_sft_2172Entities())
            {
                var dayParts = from day in context.Days
                               select day;
                return dayParts.Count();
            }
        }
        public int dayPartCount()
        {
            using (var context = new db_sft_2172Entities())
            {
                var dayParts = from day in context.TimePeriods
                               select day;
                return dayParts.Count();
            }
        }
        public string FetchPic(String currentUser)
        {
            String url = "http://imgur.com/X8XhA6M";
            
                using (var context = new db_sft_2172Entities())
                {
                    var userQuery = from u in context.Users
                                    where u.UserID.Equals(currentUser)
                                    select u;
                    url= userQuery.First<User>().ProfilePic;
                }
                
                return url;
            
        }

    }
}
