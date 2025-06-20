using c_finalproject.model;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace c_finalproject.controller
{
    public class markscontroller
    {
        private string connectionString = "Data Source=School_DBMS.db;Version=3;";

        public List<Marks> GetAllMarks()
        {
            var marksList = new List<Marks>();

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MarkID, StudentID, ExamID, MarksObtained FROM Marks";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        marksList.Add(new Marks(
                            reader["MarkID"].ToString(),
                            reader["StudentID"].ToString(),
                            reader["ExamID"].ToString(),
                            float.Parse(reader["MarksObtained"].ToString())
                        ));
                    }
                }
            }

            return marksList;
        }

        public DataTable SearchMarksByName(string id)
        {
            {
                DataTable dt = new DataTable();
                using (var conn = dbconfig.getConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Marks WHERE StudentID LIKE @id";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", "%" + id + "%");
                        using (var adapter = new SQLiteDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                return dt;
            }
        }
        public void AddMark(Marks mark)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Marks (MarkID, StudentID, ExamID, MarksObtained) VALUES (@MarkID, @StudentID, @ExamID, @MarksObtained)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MarkID", mark.MarkID);
                    cmd.Parameters.AddWithValue("@StudentID", mark.StudentID);
                    cmd.Parameters.AddWithValue("@ExamID", mark.ExamID);
                    cmd.Parameters.AddWithValue("@MarksObtained", mark.MarksObtained);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateMark(Marks mark)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Marks SET StudentID = @StudentID, ExamID = @ExamID, MarksObtained = @MarksObtained WHERE MarkID = @MarkID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", mark.StudentID);
                    cmd.Parameters.AddWithValue("@ExamID", mark.ExamID);
                    cmd.Parameters.AddWithValue("@MarksObtained", mark.MarksObtained);
                    cmd.Parameters.AddWithValue("@MarkID", mark.MarkID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteMark(string markID)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Marks WHERE MarkID = @MarkID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MarkID", markID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
