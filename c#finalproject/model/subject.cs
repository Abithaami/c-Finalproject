namespace c_finalproject.model
{
    public class Subject
    {
        public string SubjectID { get; set; }
        public string SubjectName { get; set; }
        public string CourseID { get; set; }  

        public Subject() { }

        public Subject(string subjectId, string subjectName, string courseId)
        {
            SubjectID = subjectId;
            SubjectName = subjectName;
            CourseID = courseId;
        }
    }
}
