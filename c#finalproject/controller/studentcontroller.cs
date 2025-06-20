using c_finalproject.model;
using System.Data;
using System.Data.SQLite;

namespace c_finalproject.controller
{
    internal class StudentController
    {

        public DataTable SearchStudentsByName(string name)
        {
            {
                DataTable dt = new DataTable();
                using (var conn = dbconfig.getConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Students WHERE StudentName LIKE @name";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", "%" + name + "%");
                        using (var adapter = new SQLiteDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                return dt;
            }
        }
        public bool AddStudent(Student stu)
        {
            using (var conn = dbconfig.getConnection())
            {
                conn.Open();
                string query = "INSERT INTO Students (StudentID, StudentName, CourseID) VALUES (@StudentID, @StudentName, @CourseID)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", stu.StudentID);
                    cmd.Parameters.AddWithValue("@StudentName", stu.StudentName);
                    cmd.Parameters.AddWithValue("@CourseID", stu.CourseID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateStudent(Student stu)
        {
            using (var conn = dbconfig.getConnection())
            {
                conn.Open();
                string query = "UPDATE Students SET StudentName = @StudentName, CourseID = @CourseID WHERE StudentID = @StudentID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", stu.StudentID);
                    cmd.Parameters.AddWithValue("@StudentName", stu.StudentName);
                    cmd.Parameters.AddWithValue("@CourseID", stu.CourseID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteStudent(string studentID)
        {
            using (var conn = dbconfig.getConnection())
            {
                conn.Open();
                string query = "DELETE FROM Students WHERE StudentID = @StudentID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable GetAllStudents()
        {
            using (var conn = dbconfig.getConnection())
            {
                conn.Open();
                string query = "SELECT StudentID, StudentName, CourseID FROM Students";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
