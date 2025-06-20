using finalproject.view;

namespace c_finalproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;

            if (username == "admin" && password == "admin@123")
            {
                finalproject.view.AdminLoginForm adminForm = new finalproject.view.AdminLoginForm();
                adminForm.Show();
                this.Hide();
            }
            else if (username == "lecturer" && password == "lecturer@123")
            {
                LecturerLoginForm lecturerForm = new LecturerLoginForm();
                lecturerForm.Show();
                this.Hide();
            }
            else if (username == "staff" && password == "staff@123")
            {
                StaffLoginForm staffForm = new StaffLoginForm();
                staffForm.Show();
                this.Hide();
            }
            else if (username == "student" && password == "student@123")
            {
                StudentsLoginForm studentForm = new StudentsLoginForm();
                studentForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

