using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace c_finalproject.model
{
    public class Marks
    {
        public string MarkID { get; set; }
        public string StudentID { get; set; }
        public string ExamID { get; set; }
        public float MarksObtained { get; set; }

        public Marks() { }

        public Marks(string markID, string studentID, string examID, float marksObtained)
        {
            MarkID = markID;
            StudentID = studentID;
            ExamID = examID;
            MarksObtained = marksObtained;
        }
    }
}


