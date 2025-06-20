using c_finalproject;
using System;
using System.Data.SQLite;

namespace finalproject
{
    internal class Tablecreator
    {
        public static void Table()
        {
            using (var conn = dbconfig.getConnection())
            {
                conn.Open();

                string[] tableQueries =
                {
                    @"CREATE TABLE IF NOT EXISTS Students (
                        StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                        StudentName TEXT NOT NULL,
                        CourseID TEXT NOT NULL
                    );",

                    @"CREATE TABLE IF NOT EXISTS Courses (
                        CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
                        CourseName TEXT NOT NULL
                    );",

                    @"CREATE TABLE IF NOT EXISTS Subjects (
                        SubjectID INTEGER PRIMARY KEY AUTOINCREMENT,
                        SubjectName TEXT,
                        CourseID INTEGER,
                        FOREIGN KEY(CourseID) REFERENCES Courses
                    );",
                       @"CREATE TABLE IF NOT EXISTS Exams (
                        ExamID INTEGER PRIMARY KEY AUTOINCREMENT,
                        ExamName TEXT,
                        ExamDate TEXT,
                        SubjectID INTEGER,
                        FOREIGN KEY(SubjectID) REFERENCES Subjects
                    );",

                          @"CREATE TABLE IF NOT EXISTS Marks (
                        MarkID INTEGER PRIMARY KEY AUTOINCREMENT,
                        StudentID INTEGER,
                        ExamID INTEGER,
                        MarksObtained INTEGER,
                        FOREIGN KEY(StudentID) REFERENCES Students,
                        FOREIGN KEY(ExamID) REFERENCES Exams
                    );",


                    @"CREATE TABLE IF NOT EXISTS Rooms (
                        RoomID INTEGER PRIMARY KEY AUTOINCREMENT,
                        RoomName TEXT,
                        RoomType TEXT
                    );",

                    @"CREATE TABLE IF NOT EXISTS Timetables (
                        TimetableID INTEGER PRIMARY KEY AUTOINCREMENT,
                        SubjectID INTEGER,
                        TimeSlot TEXT,
                        RoomID INTEGER,
                        Day TEXT,
                        FOREIGN KEY(SubjectID) REFERENCES Subjects,
                        FOREIGN KEY(RoomID) REFERENCES Rooms
                    );"
                };

                foreach (string query in tableQueries)
                {
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
