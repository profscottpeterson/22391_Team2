// <copyright file="UserAdminForm.cs" company="Adam Smith at NWTC">
//     Copyright 2017 Smithbucks Computing (Adam J. Smith)
// </copyright>
namespace CoachConnect
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.Entity.Infrastructure;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// Initializes a new instance of the <see cref="CourseAdminForm"/> class.
    /// </summary>
    public partial class CourseAdminForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the UserAdminForm class.
        /// </summary>
        public CourseAdminForm()
        {
            this.InitializeComponent();
        }
  
        /// <summary>
        /// Maximizes Form and displays the users with load event of the form.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CourseAdminFormLoad(object sender, EventArgs e)
        {
            this.DisplayDepartments();
            this.DisplayCourses();
        }

        /// <summary>
        /// Method to display the list of users
        /// </summary>
        private void DisplayDepartments()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Query user table in database and returns the list of the users in ascending order according to last name
                    var departmentQuery = from departments in context.Departments
                        orderby departments.DepartmentName ascending
                        select departments;

                    // Convert query results to list
                    List<Department> departmentList = departmentQuery.ToList();

                    // Set combo box data source and update data member settings
                    this.cbxDepartment.DataSource = departmentList;
                    this.cbxDepartment.ValueMember = "DepartmentID";
                    this.cbxDepartment.DisplayMember = "DepartmentName";
                }
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.InnerException != null)
                    MessageBox.Show(sqlEx.InnerException.Message);
                else
                {
                    MessageBox.Show(sqlEx.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Method to display the list of courses
        /// </summary>
        private void DisplayCourses()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Query user table in database and returns the list of the users in ascending order according to last name
                    var courseQuery = from courses in context.CourseListings
                        orderby courses.CourseID ascending
                        select courses;

                    // Convert query results to list
                    List<CourseListing> courseList = courseQuery.ToList();

                    // Set combo box data source and update data member settings
                    this.cbxChooseCourse.DataSource = courseList;
                    this.cbxChooseCourse.ValueMember = "CourseID";
                    this.cbxChooseCourse.DisplayMember = "CourseListID";
                }
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.InnerException != null)
                    MessageBox.Show(sqlEx.InnerException.Message);
                else
                {
                    MessageBox.Show(sqlEx.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Clear all data fields
        /// </summary>
        private void ClearAllFields()
        {
            // Clearing check boxes and text boxes.
            this.txtCourseID.Clear();
            this.txtCourseName.Clear();
            this.chkActive.Checked = false;
            this.cbxDepartment.SelectedIndex = -1;
            this.cbxChooseCourse.SelectedIndex = -1;
        }

        /// <summary>
        /// Populates the combo boxes and text boxes with the selected user's information
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void cbxChooseCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxChooseCourse.SelectedIndex == -1) return;

            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Query obtains the user ID from the combo box
                    string courseId = this.cbxChooseCourse.SelectedValue.ToString();

                    // Find the user in the database
                    var courseQuery = from course in context.Courses
                        where course.CourseID.Equals(courseId)
                        select course;

                    // If the query returns a user, display the corresponding info in the form
                    if (courseQuery.Any())
                    {
                        var courseResult = courseQuery.FirstOrDefault<Course>();

                        if (courseResult != null)
                        {
                            this.txtCourseID.Text = courseResult.CourseID;
                            this.txtCourseName.Text = courseResult.CourseName;
                            this.chkActive.Checked = courseResult.IsActive;
                            this.cbxDepartment.SelectedValue = courseResult.DepartmentID;
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.InnerException != null)
                    MessageBox.Show(sqlEx.InnerException.Message);
                else
                {
                    MessageBox.Show(sqlEx.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Add button clears all text boxes and check boxes so user can enter new information.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnAddClick(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        /// <summary>
        /// Submit button sends the added or updated info to the database.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnSubmitClick(object sender, EventArgs e)
        {
            try
            {
                // Run query to check for a corresponding user in the database
                using (var context = new db_sft_2172Entities())
                {
                    string courseId = txtCourseID.Text;
                    var courseQuery = from course in context.Courses
                                    where course.CourseID.Equals(courseId)
                                    select course;

                    if (courseQuery.Any())
                    {
                        var courseResult = courseQuery.FirstOrDefault<Course>();
                        courseResult.CourseID = txtCourseID.Text;
                        courseResult.CourseName = txtCourseName.Text;
                        courseResult.Department = (Department)cbxDepartment.SelectedItem;
                        courseResult.IsActive = chkActive.Checked;

                    }
                    else
                    {
                        Course newCourse = new Course();
                        newCourse.CourseID = this.txtCourseID.Text;
                        newCourse.CourseName = this.txtCourseName.Text;
                        newCourse.Department = (Department)this.cbxDepartment.SelectedItem;
                        newCourse.IsActive = true;

                        context.Courses.Add(newCourse);
                        context.SaveChanges();

                        // TODO: Need to add error handling and ensure update was completed correctly
                        MessageBox.Show("Course Added");

                        // If save is successful, update the user list and display the new user profile
                        this.DisplayCourses();
                        this.cbxChooseCourse.SelectedValue = newCourse.CourseID;
                    }
                }
            }
            catch (DbUpdateException dbUEx)
            {
                if (dbUEx.InnerException != null)
                {
                    MessageBox.Show(dbUEx.InnerException.Message);
                }
                else
                {
                    MessageBox.Show(dbUEx.Message);
                }
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.InnerException != null)
                    MessageBox.Show(sqlEx.InnerException.Message);
                else
                {
                    MessageBox.Show(sqlEx.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            this.DisplayCourses();
            MessageBox.Show("Course Updated");
        }

        /// <summary>
        /// A method to disable a selected user
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnMinusClick(object sender, EventArgs e)
        {
            this.chkActive.Checked = false;
        }
    }
}