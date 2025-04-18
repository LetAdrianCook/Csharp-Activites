﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Activites.Models
{
    class Student
    {
        public string studentName { get; set; }
        public string studentLevel { get; set; }
        public int subjectCount { get; set; }
        public string subjectName { get; set; }
        public float subjectGrade { get; set; }
        public List<string> subjectList { get; set; } = new List<string>();
        public List<float> gradeList { get; set; } = new List<float>();
        public float finalAverage { get; set; }
        public string grading { get; set; }

        public virtual void ShowStudentLevel()
        {
            Console.WriteLine();
            Console.WriteLine("Student");
        }

    }
}
