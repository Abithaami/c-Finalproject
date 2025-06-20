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
    public partial class viewtimetable : Form
    {
        private readonly timetablecontroller controller;
        public viewtimetable()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string studentid = btnSearch.Text.Trim(); // ✅ use txtSearchName, not btnSearch!

            if (!string.IsNullOrEmpty(studentid))
            {
                DataTable result = controller.SearchTimeTableByName(studentid);
                dataGridView1.DataSource = result; // ✅ viewstudentdetails must be a DataGridView control
            }
            else
            {
                MessageBox.Show("Please enter a name to search.");
            }
        }
    }
}
