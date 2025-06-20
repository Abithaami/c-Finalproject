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
    public partial class marksview : Form
    {
        private readonly markscontroller controller;
        public marksview()
        {
            InitializeComponent();
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string studentid = btnSearch.Text.Trim(); // ✅ use txtSearchName, not btnSearch!

            if (!string.IsNullOrEmpty(studentid))
            {
                DataTable result = controller.SearchMarksByName(studentid);
                dataGridView1.DataSource = result; // ✅ viewstudentdetails must be a DataGridView control
            }
            else
            {
                MessageBox.Show("Please enter a id to search.");
            }
        }
    }
}
