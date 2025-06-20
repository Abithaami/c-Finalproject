using c_finalproject.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_finalproject.view
{
    public partial class studentsview : Form
    {
        private readonly StudentController controller;
        public studentsview()
        {
            InitializeComponent();
            controller = new StudentController();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string studentName = btnSearch.Text.Trim(); // ✅ use txtSearchName, not btnSearch!

            if (!string.IsNullOrEmpty(studentName))
            {
                DataTable result = controller.SearchStudentsByName(studentName);
                dataGridView1.DataSource = result; // ✅ viewstudentdetails must be a DataGridView control
            }
            else
            {
                MessageBox.Show("Please enter a name to search.");
            }
        }
    }
}
