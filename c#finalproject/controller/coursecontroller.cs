using c_finalproject.model;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace c_finalproject.controller
{
    public class CourseController
    {
        private string connectionString = "Data Source=School_DBMS.db;Version=3;";

        public List<Course> GetAllCourses()
        {
            var courses = new List<Course>();

            using (var conn = dbconfig.getConnection())
            {
                conn.Open();
                string query = "SELECT CourseID, CourseName FROM Courses";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        courses.Add(new Course(
                            reader["CourseID"].ToString(),
                            reader["CourseName"].ToString()
                        ));
                    }
                }
            }
            return courses;
        }
        public DataTable SearchCoursesByName(string name)
        {
            {
                DataTable dt = new DataTable();
                using (var conn = dbconfig.getConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Courses WHERE CourseName LIKE @name";
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

        public bool AddCourse(Course course)
        {
            try
            {
                using (var conn = dbconfig.getConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Courses (CourseID, CourseName) VALUES (@CourseID, @CourseName)";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CourseID", course.CourseID);
                        cmd.Parameters.AddWithValue("@CourseName", course.CourseName);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateCourse(Course course)
        {
            try
            {
                using (var conn = dbconfig.getConnection())
                {
                    conn.Open();
                    string query = "UPDATE Courses SET CourseName = @CourseName WHERE CourseID = @CourseID";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CourseName", course.CourseName);
                        cmd.Parameters.AddWithValue("@CourseID", course.CourseID);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteCourse(string courseId)
        {
            try
            {
                using (var conn = dbconfig.getConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Courses WHERE CourseID = @CourseID";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CourseID", courseId);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
