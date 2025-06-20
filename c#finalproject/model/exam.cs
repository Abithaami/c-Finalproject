
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_finalproject.model
{
    public class Exam
    {
        public string ExamID { get; set; }
        public string ExamName { get; set; }
        public string SubjectID { get; set; }
        public DateTime ExamDate { get; set; }

        public Exam() { }

        public Exam(string examID, string examName, string subjectID, DateTime examDate)
        {
            ExamID = examID;
            ExamName = examName;
            SubjectID = subjectID;
            ExamDate = examDate;
        }
    }
}

