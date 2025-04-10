using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Csharp_Activites.Models
{
    class FinalStudent
    {
        public string studentName { get; set; }
        public int subjectCount { get; set; }
        public string studentLevel { get; set; }
        public List<string> subjectList { get; set; } = new List<string>();
        public List<float> gradeList { get; set; } = new List<float>();
        public float average { get; set; }
        public string grading { get; set; }

        public FinalStudent(string studentName, int subjectCount, string studentLevel, List<string> subjectList, List<float> gradeList, float average, string grading)
        {
            this.studentName = studentName;
            this.subjectCount = subjectCount;
            this.studentLevel = studentLevel;
            this.subjectList = subjectList;
            this.gradeList = gradeList;
            this.average = average;
            this.grading = grading;

            DisplayStudentResult(studentName, subjectCount, studentLevel, subjectList, gradeList, average, grading);
        }
        void DisplayStudentResult(string studentName,int subjectCount, string studentLevel, List<string> subjectList, List<float> gradeList, float average, string grading)
        {
            Console.WriteLine();
            Console.WriteLine("|--------------------Grading-System--------------------|");
            Console.WriteLine("|");
            Console.WriteLine("| Name         : " + studentName);
            Console.WriteLine("| Grade Level  : " + studentLevel);
            Console.WriteLine("|");
            Console.WriteLine("|-----------------------Subjects-----------------------|");
            Console.WriteLine("|");
            for (int i = 0; i < subjectCount; i++)
            {
                Console.WriteLine("|" + subjectList[i] + " : " + gradeList[i]);
            }
            Console.WriteLine("|");
            Console.WriteLine("|------------------------------------------------------|");
            Console.WriteLine("|");
            Console.WriteLine("| Your Final Average is : " + average);
            Console.WriteLine("| Grading               : " + grading);
            Console.WriteLine("|");
            Console.WriteLine("|------------------------------------------------------|");
            Console.WriteLine();
        }
    }
}
