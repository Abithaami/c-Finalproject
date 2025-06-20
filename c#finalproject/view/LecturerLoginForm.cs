using c_finalproject;
using c_finalproject.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject.view
{
    public partial class LecturerLoginForm : Form
    {
        public LecturerLoginForm()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new MainForm());
        }

        private void LoadFormInPanel(Form form)
        {
            panel4.Controls.Clear(); // Clear previous controls
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel4.Controls.Add(form);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 loginform = new Form1();
            loginform.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new viewcourses());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new viewtimetable());
        }
    }
}
