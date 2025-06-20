using c_finalproject.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace c_finalproject.controller
{
    public class timetablecontroller
    {
        private string connectionString = "Data Source=School_DBMS.db;Version=3;";

        public List<Timetable> GetAllTimetables()
        {
            List<Timetable> timetables = new List<Timetable>();

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT TimetableID, SubjectID, RoomID, Day, TimeSlot FROM Timetables";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Timetable timetable = new Timetable()
                            {
                                TimetableID = reader["TimetableID"] != DBNull.Value ? Convert.ToInt32(reader["TimetableID"]) : 0,
                                SubjectID = reader["SubjectID"]?.ToString(),
                                RoomID = reader["RoomID"]?.ToString(),
                                Day = reader["Day"]?.ToString(),
                                TimeSlot = reader["TimeSlot"]?.ToString()
                            };
                            timetables.Add(timetable);
                        }
                    }
                }
            }

            return timetables;
        }

        public DataTable SearchTimeTableByName(string day)
        {
            {
                DataTable dt = new DataTable();
                using (var conn = dbconfig.getConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Timetables WHERE Day LIKE @day";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@day", "%" + day + "%");
                        using (var adapter = new SQLiteDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                return dt;
            }

        }
        public bool AddTimetable(Timetable timetable)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Timetables (SubjectID, RoomID, Day, TimeSlot) VALUES (@subjectID, @roomId, @day, @timeSlot)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@subjectID", timetable.SubjectID);
                    cmd.Parameters.AddWithValue("@roomId", timetable.RoomID);
                    cmd.Parameters.AddWithValue("@day", timetable.Day);
                    cmd.Parameters.AddWithValue("@timeSlot", timetable.TimeSlot);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateTimetable(Timetable timetable)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Timetables SET SubjectID = @subjectID, RoomID = @roomId, Day = @day, TimeSlot = @timeSlot WHERE TimetableID = @timetableID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@subjectID", timetable.SubjectID);
                    cmd.Parameters.AddWithValue("@roomId", timetable.RoomID);
                    cmd.Parameters.AddWithValue("@day", timetable.Day);
                    cmd.Parameters.AddWithValue("@timeSlot", timetable.TimeSlot);
                    cmd.Parameters.AddWithValue("@timetableID", timetable.TimetableID);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteTimetable(int timetableID)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Timetables WHERE TimetableID = @timetableID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@timetableID", timetableID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
