using c_finalproject.controller;
using c_finalproject.model;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace finalproject.view
{
    public partial class CourseForm : Form
    {
        private readonly CourseController courseController;

        public CourseForm()
        {
            InitializeComponent();
            courseController = new CourseController();
            LoadCourses();
        }

        private void LoadCourses()
        {
            List<Course> courses = courseController.GetAllCourses();
            dataGridViewCourses.DataSource = courses;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string courseId = courseIdTextBox.Text.Trim();
            string courseName = courseNameTextBox.Text.Trim();

            if (string.IsNullOrEmpty(courseId) || string.IsNullOrEmpty(courseName))
            {
                MessageBox.Show("Please enter both Course ID and Course Name.");
                return;
            }

            var course = new Course(courseId, courseName);
            bool success = courseController.AddCourse(course);

            if (success)
            {
                MessageBox.Show("Course inserted successfully.");
                LoadCourses();
            }
            else
            {
                MessageBox.Show("Failed to insert course. It might already exist.");
            }

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string courseId = courseIdTextBox.Text.Trim();
            string courseName = courseNameTextBox.Text.Trim();

            if (string.IsNullOrEmpty(courseId) || string.IsNullOrEmpty(courseName))
            {
                MessageBox.Show("Please enter both Course ID and Course Name.");
                return;
            }

            var course = new Course(courseId, courseName);
            bool success = courseController.UpdateCourse(course);

            if (success)
            {
                MessageBox.Show("Course updated successfully.");
                LoadCourses();
            }
            else
            {
                MessageBox.Show("Failed to update course.");
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string courseId = courseIdTextBox.Text.Trim();
            if (string.IsNullOrEmpty(courseId))
            {
                MessageBox.Show("Please select a course to delete.");
                return;
            }

            bool success = courseController.DeleteCourse(courseId);

            if (success)
            {
                MessageBox.Show("Course deleted successfully.");
                LoadCourses();
            }
            else
            {
                MessageBox.Show("Failed to delete course.");
            }
        }

        private void dataGridViewCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewCourses.Rows[e.RowIndex];
                courseIdTextBox.Text = row.Cells["CourseID"].Value?.ToString();
                courseNameTextBox.Text = row.Cells["CourseName"].Value?.ToString();

            }
        }

        private void dataGridViewCourses_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridViewCourses.Rows[e.RowIndex];
                    courseIdTextBox.Text = row.Cells["CourseID"].Value?.ToString();
                    courseNameTextBox.Text = row.Cells["CourseName"].Value?.ToString();
                }
            }
        }
    }
}
