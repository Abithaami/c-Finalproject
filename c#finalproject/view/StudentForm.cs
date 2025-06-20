using c_finalproject;
using c_finalproject.controller;
using c_finalproject.model;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace finalproject.view
{
    public partial class StudentForm : Form
    {
        private readonly StudentController controller;

        public StudentForm()
        {
            InitializeComponent();
            controller = new StudentController();
            LoadCoursesToComboBox();
            LoadStudents();
        }

        private void LoadStudents()
        {
            dataGridView1.DataSource = controller.GetAllStudents();
        }

        private void LoadCoursesToComboBox()
        {
            using (var conn = dbconfig.getConnection())
            {
                conn.Open();
                string query = "SELECT CourseID, CourseName FROM Courses";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    var dt = new DataTable();
                    dt.Load(reader);

                    courseIdTextBox.DisplayMember = "CourseName";
                    courseIdTextBox.ValueMember = "CourseID";
                    courseIdTextBox.DataSource = dt;
                }
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string studentID = studentNameTextBox.Text.Trim();
            string studentName = Stnametext.Text.Trim();

            if (string.IsNullOrEmpty(studentName) || courseIdTextBox.SelectedValue == null)
            {
                MessageBox.Show("Please fill in Student Name and select a Course.");
                return;
            }

            string courseID = courseIdTextBox.SelectedValue.ToString();

            if (string.IsNullOrEmpty(studentID))
            {
                studentID = Guid.NewGuid().ToString();
            }

            var student = new Student(studentID, studentName, courseID);

            if (controller.AddStudent(student))
            {
                MessageBox.Show("Student added successfully.");
                LoadStudents();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to add student.");
            }
        }

        private void ClearFields()
        {
            studentNameTextBox.Clear();
            Stnametext.Clear();
            courseIdTextBox.SelectedIndex = -1;
        }
    }
}
