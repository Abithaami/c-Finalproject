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
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadFormInPanel4(new StudentForm());
        }

        private void LoadFormInPanel4(Form form)
        {
            panel3.Controls.Clear(); // Clear previous controls
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel3.Controls.Add(form);
            form.Show();
        }


        private void button8_Click(object sender, EventArgs e)

        {
            LoadFormInPanel(new MainForm());
        }

        private void LoadFormInPanel(Form form)
        {
            panel3.Controls.Clear(); // Clear previous controls
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel3.Controls.Add(form);
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LoadFormInPanel2(new CourseForm());
        }

        private void LoadFormInPanel2(Form form)
        {
            panel3.Controls.Clear(); // Clear previous controls
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel3.Controls.Add(form);
            form.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            LoadFormInPanel3(new SubjectForm());
        }

        private void LoadFormInPanel3(Form form)
        {
            panel3.Controls.Clear(); // Clear previous controls
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel3.Controls.Add(form);
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadFormInPanel5(new ExamForm());
        }

        private void LoadFormInPanel5(Form form)
        {
            panel3.Controls.Clear(); // Clear previous controls
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel3.Controls.Add(form);
            form.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            LoadFormInPanel6(new MarksForm());
        }

        private void LoadFormInPanel6(Form form)
        {
            panel3.Controls.Clear(); // Clear previous controls
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel3.Controls.Add(form);
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadFormInPanel7(new TimetableForm());
        }

        private void LoadFormInPanel7(Form form)
        {
            panel3.Controls.Clear(); // Clear previous controls
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel3.Controls.Add(form);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 loginform = new Form1();
            loginform.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LoadFormInPanel7(new RoomForm());
        }
    }
}





