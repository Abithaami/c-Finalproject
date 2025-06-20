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
    public partial class viewcourses : Form
    {
        private readonly CourseController controller;
        public viewcourses()
        {
            InitializeComponent();
            controller = new CourseController();
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string courseName = btnSearch.Text.Trim(); // ✅ use txtSearchName, not btnSearch!

            if (!string.IsNullOrEmpty(courseName))
            {
                DataTable result = controller.SearchCoursesByName(courseName);
                dataGridView1.DataSource = result; // ✅ viewstudentdetails must be a DataGridView control
            }
            else
            {
                MessageBox.Show("Please enter a name to search.");
            }
        }
    }
}
