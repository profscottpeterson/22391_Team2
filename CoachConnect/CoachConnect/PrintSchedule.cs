using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Office.Interop.Excel;

namespace CoachConnect
{
    public partial class PrintSchedule : Form
    {
        public PrintSchedule()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Displays the list of available interests
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void PrintScheduleFormLoad(object sender, EventArgs e)
        {
            this.DisplayInterests();
            cbxChooseDepartment.SelectedIndex = 0;
        }

        /// <summary>
        /// Method to display the list of interests
        /// </summary>
        private void DisplayInterests()
        {
            using (var context = new db_sft_2172Entities())
            {
                // Query interest table in database and returns the list of the interests in ascending order
                var interestQuery = from interests in context.Interests
                    orderby interests.InterestName ascending
                    select interests;

                // Convert query results to list
                List<Interest> interestList = interestQuery.ToList();

                // Set combo box data sources and update data member settings
                this.cbxChooseDepartment.DataSource = interestList;
                this.cbxChooseDepartment.ValueMember = "InterestName";
                this.cbxChooseDepartment.DisplayMember = "InterestName";
            }
        }

        /// <summary>
        /// A method to populate data in the coach availability data grid
        /// </summary>
        private void PopulateScheduleGrid()
        {
            // Query obtains the interest ID from the combo box.
            string interestId = this.cbxChooseDepartment.SelectedValue.ToString();
            
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Run stored procedure to build schedule in the database
                    context.GenerateSchedule(interestId);

                    // Run a query to get the new schedule
                    var interestScheduleQuery = from interestSchedules in context.SchedulePivots
                        select interestSchedules;

                    // Display the schedule to the Data Grid View
                    this.dataGridViewSchedule.DataSource = interestScheduleQuery.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void cbxChooseDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateScheduleGrid();
        }

        private void btnSaveScheduleToExcel_Click(object sender, EventArgs e)
        {
            string currentUsername = Environment.UserName;

            // creating Excel Application  
            _Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            _Workbook workbook = app.Workbooks.Open("c:\\users\\" + currentUsername + "\\Documents\\currentCoachScheduleTEMPLATE.xlsx");
            // creating new Excelsheet in workbook  
            _Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // storing header part in Excel  
            for (int i = 1; i < dataGridViewSchedule.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridViewSchedule.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridViewSchedule.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewSchedule.Columns.Count; j++)
                {
                    if (dataGridViewSchedule.Rows[i].Cells[j].Value == null)
                        worksheet.Cells[i + 2, j + 1] = null;
                    else
                        worksheet.Cells[i + 2, j + 1] = dataGridViewSchedule.Rows[i].Cells[j].Value.ToString();

                    worksheet.Cells[i + 2, j + 1].WrapText = true;
                }
            }

            // save the application  
            workbook.SaveAs("c:\\users\\" + currentUsername + "\\Documents\\currentCoachSchedule.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);


            // Exit from the application  
            app.Quit();
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
