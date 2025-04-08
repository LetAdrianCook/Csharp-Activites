using Csharp_Activites.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Csharp_Activites.Services
{
    class UserInputService
    {
        Student student = new Student();
        void InputStudentInfo()
        {
            Console.Write("Please Enter Your Name: ");
            student.studentName = Console.ReadLine();
            Console.Write("Please how many subjects you currently take: ");
            student.subjectCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < student.subjectCount; i++)
            {
                Console.Write("Please Enter Subject Number " + (i + 1) + ": ");
                student.subjectName = Console.ReadLine();
                student.subjectList.Add(student.subjectName);
            }
            Console.WriteLine();
            for (int i = 0; i < student.subjectCount; i++)
            {
                Console.Write("Please Enter your grade for " + student.subjectList[i] + " Subject: ");
                student.subjectGrade = Convert.ToSingle(Console.ReadLine());
                student.gradeList.Add(student.subjectGrade);
            }
            sum = gradeList.Sum();
            totalPercentageSubjects = (subjectCount / 100.0f);
            finalAverage = sum / (totalPercentageSubjects * 100.0f);
        }
    }
}
