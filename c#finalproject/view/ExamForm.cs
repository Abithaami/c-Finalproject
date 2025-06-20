using c_finalproject;
using c_finalproject.controller;
using c_finalproject.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject.view
{
    public partial class ExamForm : Form
    {
        private readonly examcontroller controller = new examcontroller();
        public ExamForm()
        {
            InitializeComponent();
            LoadExams();
            LoadSubjectToComboBox();
        }

        private void LoadExams()
        {
            dataGridViewExams.DataSource = controller.GetAllExams();
        }

        private void LoadSubjectToComboBox()
        {
            using (var conn = dbconfig.getConnection())
            {
                conn.Open();
                string query = "SELECT SubjectID FROM Subjects";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    var dt = new System.Data.DataTable();
                    dt.Load(reader);

                    txtSubjectID.DisplayMember = "SubjectID";  // What user sees
                    txtSubjectID.ValueMember = "SubjectID";      // The actual value you want to save
                    txtSubjectID.DataSource = dt;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtExamID.Text == "" || txtExamName.Text == "" || txtSubjectID.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            var exam = new Exam(
                txtExamID.Text,
                txtExamName.Text,
                txtSubjectID.Text,
                dateTimePickerExamDate.Value
            );

            controller.AddExam(exam);
            LoadExams();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtExamID.Text == "")
            {
                MessageBox.Show("Please select an exam to update.");
                return;
            }

            var exam = new Exam(
                txtExamID.Text,
                txtExamName.Text,
                txtSubjectID.Text,
                dateTimePickerExamDate.Value
            );

            controller.UpdateExam(exam);
            LoadExams();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtExamID.Text == "")
            {
                MessageBox.Show("Please select an exam to delete.");
                return;
            }

            controller.DeleteExam(txtExamID.Text);
            LoadExams();
            ClearFields();
        }

        private void dataGridViewExams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewExams.Rows[e.RowIndex];
                txtExamID.Text = row.Cells["ExamID"].Value.ToString();
                txtExamName.Text = row.Cells["ExamName"].Value.ToString();
                txtSubjectID.Text = row.Cells["SubjectID"].Value.ToString();
                dateTimePickerExamDate.Value = Convert.ToDateTime(row.Cells["ExamDate"].Value);
            }

        }
        private void ClearFields()
        {
            txtExamID.Clear();
            txtExamName.Clear();
            txtSubjectID.SelectedIndex = -1; // FIX: Do not use Items.Clear()
            dateTimePickerExamDate.Value = DateTime.Today;
        }

    }
}
