namespace c_finalproject.model
{
    public class Course
    {
        public string CourseID { get; set; }
        public string CourseName { get; set; }

        public Course() { }

        public Course(string courseId, string courseName)
        {
            CourseID = courseId;
            CourseName = courseName;
        }
    }
}
