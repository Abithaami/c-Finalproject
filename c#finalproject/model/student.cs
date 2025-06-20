namespace c_finalproject.model
{
    public class Student
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string CourseID { get; set; }

        public Student(string studentID, string studentName, string courseID)
        {
            StudentID = studentID;
            StudentName = studentName;
            CourseID = courseID;
        }
    }
}
