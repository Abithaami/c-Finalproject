using c_finalproject.model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace c_finalproject.controller
{
    public class examcontroller
    {
        private string connectionString = "Data Source=School_DBMS.db;Version=3;";

        public List<Exam> GetAllExams()
        {
            var exams = new List<Exam>();

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ExamID, ExamName, SubjectID, ExamDate FROM Exams";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        exams.Add(new Exam(
                            reader["ExamID"].ToString(),
                            reader["ExamName"].ToString(),
                            reader["SubjectID"].ToString(),
                            DateTime.Parse(reader["ExamDate"].ToString())
                        ));
                    }
                }
            }

            return exams;
        }

        public void AddExam(Exam exam)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Exams (ExamID, ExamName, SubjectID, ExamDate) VALUES (@ExamID, @ExamName, @SubjectID, @ExamDate)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ExamID", exam.ExamID);
                    cmd.Parameters.AddWithValue("@ExamName", exam.ExamName);
                    cmd.Parameters.AddWithValue("@SubjectID", exam.SubjectID);
                    cmd.Parameters.AddWithValue("@ExamDate", exam.ExamDate.ToString("yyyy-MM-dd"));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateExam(Exam exam)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Exams SET ExamName = @ExamName, SubjectID = @SubjectID, ExamDate = @ExamDate WHERE ExamID = @ExamID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ExamName", exam.ExamName);
                    cmd.Parameters.AddWithValue("@SubjectID", exam.SubjectID);
                    cmd.Parameters.AddWithValue("@ExamDate", exam.ExamDate.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@ExamID", exam.ExamID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteExam(string examID)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Exams WHERE ExamID = @ExamID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ExamID", examID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
