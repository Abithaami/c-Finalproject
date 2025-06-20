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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace finalproject.view
{
    public partial class MarksForm : Form
    {
        private readonly markscontroller controller = new markscontroller();
        public MarksForm()
        {
            InitializeComponent();
            LoadExamsToComboBox();
            LoadStudentToComboBox();
            LoadMarks();
        }
        private void LoadMarks()
        {
            dataGridViewMarks.DataSource = controller.GetAllMarks();
        }


        private void LoadExamsToComboBox()
        {
            using (var conn = dbconfig.getConnection())
            {
                conn.Open();
                string query = "SELECT ExamID FROM Exams";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    var dt = new System.Data.DataTable();
                    dt.Load(reader);

                    txtExamID.DisplayMember = "ExamID";  // What user sees
                    txtExamID.ValueMember = "ExamID";      // The actual value you want to save
                    txtExamID.DataSource = dt;
                }
            }
        }

        private void LoadStudentToComboBox()
        {
            using (var conn = dbconfig.getConnection())
            {
                conn.Open();
                string query = "SELECT StudentID FROM Students";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    var dt = new System.Data.DataTable();
                    dt.Load(reader);

                    txtStudentID.DisplayMember = "StudentID";  // What user sees
                    txtStudentID.ValueMember = "StudentID";      // The actual value you want to save
                    txtStudentID.DataSource = dt;
                }
            }
        }


        private void update_btn_Click(object sender, EventArgs e)
        {
            if (txtMarkID.Text == "")
            {
                MessageBox.Show("Select a mark record to update.");
                return;
            }

            float marks;
            if (!float.TryParse(txtMarksObtained.Text, out marks))
            {
                MessageBox.Show("Invalid marks value.");
                return;
            }

            var mark = new Marks(txtMarkID.Text, txtStudentID.Text, txtExamID.Text, marks);
            controller.UpdateMark(mark);
            LoadMarks();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMarkID.Text == "" || txtStudentID.Text == "" || txtExamID.Text == "" || txtMarksObtained.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            float marks;
            if (!float.TryParse(txtMarksObtained.Text, out marks))
            {
                MessageBox.Show("Invalid marks value.");
                return;
            }

            var mark = new Marks(txtMarkID.Text, txtStudentID.Text, txtExamID.Text, marks);
            controller.AddMark(mark);
            LoadMarks();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMarkID.Text == "")
            {
                MessageBox.Show("Select a mark record to delete.");
                return;
            }

            controller.DeleteMark(txtMarkID.Text);
            LoadMarks();
        }

        private void dataGridViewMarks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewMarks.Rows[e.RowIndex];
                txtMarkID.Text = row.Cells["MarkID"].Value.ToString();
                txtStudentID.Text = row.Cells["StudentID"].Value.ToString();
                txtExamID.Text = row.Cells["ExamID"].Value.ToString();
                txtMarksObtained.Text = row.Cells["MarksObtained"].Value.ToString();
            }
        }
       
    }
}
