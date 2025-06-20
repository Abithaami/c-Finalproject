using c_finalproject.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace c_finalproject.controller
{
    public class subjectcontroller
    {
        private string connectionString = "Data Source=School_DBMS.db;Version=3;";

        public List<Subject> GetAllSubjects()
        {
            List<Subject> subjects = new List<Subject>();

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT SubjectID, SubjectName, CourseID FROM Subjects";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            subjects.Add(new Subject(
                                reader["SubjectID"].ToString(),
                                reader["SubjectName"].ToString(),
                                reader["CourseID"].ToString()
                            ));
                        }
                    }
                }
            }

            return subjects;
        }

        public void AddSubject(Subject subject)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Subjects (SubjectID, SubjectName, CourseID) VALUES (@SubjectID, @SubjectName, @CourseID)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SubjectID", subject.SubjectID);
                    cmd.Parameters.AddWithValue("@SubjectName", subject.SubjectName);
                    cmd.Parameters.AddWithValue("@CourseID", subject.CourseID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateSubject(Subject subject)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Subjects SET SubjectName = @SubjectName, CourseID = @CourseID WHERE SubjectID = @SubjectID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SubjectName", subject.SubjectName);
                    cmd.Parameters.AddWithValue("@CourseID", subject.CourseID);
                    cmd.Parameters.AddWithValue("@SubjectID", subject.SubjectID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteSubject(string subjectId)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Subjects WHERE SubjectID = @SubjectID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SubjectID", subjectId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
