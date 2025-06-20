using c_finalproject.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace c_finalproject.controller
{
    internal class roomcontroller
    {
        // Helper: Set WAL mode and timeout
        private void ConfigureConnection(SQLiteConnection conn)
        {
            using (var cmd1 = new SQLiteCommand("PRAGMA journal_mode=WAL;", conn))
                cmd1.ExecuteNonQuery();
            using (var cmd2 = new SQLiteCommand("PRAGMA busy_timeout = 5000;", conn))
                cmd2.ExecuteNonQuery();
        }

        // Add a room
        public bool AddRoom(room r)
        {
            using (var conn = dbconfig.getConnection())
            {
                conn.Open();
                ConfigureConnection(conn);

                string query = "INSERT INTO Rooms (RoomID, RoomType) VALUES (@RoomID, @RoomType)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoomID", r.RoomID);
                    cmd.Parameters.AddWithValue("@RoomType", r.RoomType);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Update a room
        public bool UpdateRoom(room r)
        {
            using (var conn = dbconfig.getConnection())
            {
                conn.Open();
                ConfigureConnection(conn);

                string query = "UPDATE Rooms SET RoomType = @RoomType WHERE RoomID = @RoomID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoomID", r.RoomID);
                    cmd.Parameters.AddWithValue("@RoomType", r.RoomType);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Delete a room
        public bool DeleteRoom(string roomID)
        {
            using (var conn = dbconfig.getConnection())
            {
                conn.Open();
                ConfigureConnection(conn);

                string query = "DELETE FROM Rooms WHERE RoomID = @RoomID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoomID", roomID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Get all rooms as DataTable (for DataGridView)
        public DataTable GetAllRooms()
        {
            using (var conn = dbconfig.getConnection())
            {
                conn.Open();
                ConfigureConnection(conn);

                string query = "SELECT RoomID, RoomType FROM Rooms";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        // ✅ Get all rooms as List<room> for ComboBox
        public List<room> GetRoomsForComboBox()
        {
            List<room> rooms = new List<room>();

            using (var conn = dbconfig.getConnection())
            {
                conn.Open();
                ConfigureConnection(conn);

                string query = "SELECT RoomID, RoomType FROM Rooms";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        room r = new room()
                        {
                            RoomID = reader["RoomID"].ToString(),
                            RoomType = reader["RoomType"].ToString()
                        };
                        rooms.Add(r);
                    }
                }
            }

            return rooms;
        }
    }
}
