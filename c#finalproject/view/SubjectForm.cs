using c_finalproject;
using c_finalproject.controller;
using c_finalproject.model;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace finalproject.view
{
    public partial class SubjectForm : Form
    {
        private readonly subjectcontroller controller = new subjectcontroller();

        public SubjectForm()
        {
            InitializeComponent();
            LoadCoursesToComboBox();
            LoadSubjects();
        }

        private void LoadSubjects()
        {
            dataGridViewSubjects.DataSource = controller.GetAllSubjects();
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
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    txtCourseName.DisplayMember = "CourseName";  // What user sees
                    txtCourseName.ValueMember = "CourseID";      // Actual value used
                    txtCourseName.DataSource = dt;
                }
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSubjectID.Text) ||
                string.IsNullOrEmpty(txtSubjectName.Text) ||
                txtCourseName.SelectedValue == null)
            {
                MessageBox.Show("Please enter Subject ID, Subject Name, and select a Course.");
                return;
            }

            var subject = new Subject(
                txtSubjectID.Text.Trim(),
                txtSubjectName.Text.Trim(),
                txtCourseName.SelectedValue.ToString() // Use CourseID
            );

            controller.AddSubject(subject);
            LoadSubjects();
            ClearFields();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSubjectID.Text) ||
                string.IsNullOrEmpty(txtSubjectName.Text) ||
                txtCourseName.SelectedValue == null)
            {
                MessageBox.Show("Please select a subject and fill in all fields to update.");
                return;
            }

            var subject = new Subject(
                txtSubjectID.Text.Trim(),
                txtSubjectName.Text.Trim(),
                txtCourseName.SelectedValue.ToString()
            );

            controller.UpdateSubject(subject);
            LoadSubjects();
            ClearFields();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSubjectID.Text))
            {
                MessageBox.Show("Please select a subject to delete.");
                return;
            }

            controller.DeleteSubject(txtSubjectID.Text.Trim());
            LoadSubjects();
            ClearFields();
        }

        private void dataGridViewSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewSubjects.Rows[e.RowIndex];

                txtSubjectID.Text = row.Cells["SubjectID"].Value.ToString();
                txtSubjectName.Text = row.Cells["SubjectName"].Value.ToString();

                // Set ComboBox by CourseID
                string courseId = row.Cells["CourseID"].Value.ToString();
                txtCourseName.SelectedValue = courseId;
            }
        }

        private void ClearFields()
        {
            txtSubjectID.Clear();
            txtSubjectName.Clear();
            txtCourseName.SelectedIndex = -1; // Clear selection
        }
    }
}
