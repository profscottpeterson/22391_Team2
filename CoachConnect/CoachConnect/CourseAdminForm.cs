// <copyright file="UserAdminForm.cs" company="Adam Smith at NWTC">
//     Copyright 2017 Smithbucks Computing (Adam J. Smith)
// </copyright>
namespace CoachConnect
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure;
    using System.Data.SqlClient;
    using System.Linq;
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
            InitializeComponent();
        }
  
        /// <summary>
        /// Maximizes Form and displays the users with load event of the form.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CourseAdminFormLoad(object sender, EventArgs e)
        {
            DisplayDepartments();
            DisplayCourses();
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
                        orderby departments.DepartmentName
                        select departments;

                    // Convert query results to list
                    List<Department> departmentList = departmentQuery.ToList();

                    // Set combo box data source and update data member settings
                    cbxDepartment.DataSource = departmentList;
                    cbxDepartment.ValueMember = "DepartmentID";
                    cbxDepartment.DisplayMember = "DepartmentName";
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.InnerException != null ? sqlEx.InnerException.Message : sqlEx.Message);
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
                    cbxChooseCourse.DataSource = courseList;
                    cbxChooseCourse.ValueMember = "CourseID";
                    cbxChooseCourse.DisplayMember = "CourseListID";
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.InnerException != null ? sqlEx.InnerException.Message : sqlEx.Message);
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
            txtCourseID.Clear();
            txtCourseName.Clear();
            chkActive.Checked = false;
            cbxDepartment.SelectedIndex = -1;
            cbxChooseCourse.SelectedIndex = -1;
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
                    string courseId = cbxChooseCourse.SelectedValue.ToString();

                    // Find the user in the database
                    var courseQuery = from course in context.Courses
                        where course.CourseID.Equals(courseId)
                        select course;

                    // If the query returns a user, display the corresponding info in the form
                    if (courseQuery.Any())
                    {
                        var courseResult = courseQuery.FirstOrDefault();

                        if (courseResult != null)
                        {
                            txtCourseID.Text = courseResult.CourseID;
                            txtCourseName.Text = courseResult.CourseName;
                            chkActive.Checked = courseResult.IsActive;
                            cbxDepartment.SelectedValue = courseResult.DepartmentID;
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.InnerException != null ? sqlEx.InnerException.Message : sqlEx.Message);
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
                        var courseResult = courseQuery.FirstOrDefault();

                        if (courseResult != null)
                        {
                            courseResult.CourseID = txtCourseID.Text;
                            courseResult.CourseName = txtCourseName.Text;
                            courseResult.Department = (Department) cbxDepartment.SelectedItem;
                            courseResult.IsActive = chkActive.Checked;
                        }

                        context.SaveChanges();
                        DisplayCourses();
                        MessageBox.Show(@"Course Updated");
                    }
                    else
                    {
                        Course newCourse = new Course
                        {
                            CourseID = txtCourseID.Text,
                            CourseName = txtCourseName.Text,
                            Department = (Department)cbxDepartment.SelectedItem,
                            IsActive = true
                        };

                        context.Courses.Add(newCourse);
                        context.SaveChanges();
                        MessageBox.Show(@"Course Added");

                        // If save is successful, update the user list and display the new user profile
                        DisplayCourses();
                        cbxChooseCourse.SelectedValue = newCourse.CourseID;
                    }
                }
            }
            catch (DbUpdateException dbUEx)
            {
                MessageBox.Show(dbUEx.InnerException != null ? dbUEx.InnerException.Message : dbUEx.Message);
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.InnerException != null ? sqlEx.InnerException.Message : sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// A method to disable a selected user
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnMinusClick(object sender, EventArgs e)
        {
            chkActive.Checked = false;
        }
    }
}