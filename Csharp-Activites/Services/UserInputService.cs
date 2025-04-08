using Csharp_Activites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Xml.Linq;

namespace Csharp_Activites.Services
{
    class UserInputService
    {
        Student student = new Student();
        GradingService gradingService = new GradingService();
        public void InputStudentInfo()
        {
           // Console.Write("Please Enter type of  Student: [1-College] [2-Highschool] ");
           // student.studentType = Console.ReadLine();
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

           float finalGrade = gradingService.CalculateFinalGrade(student.gradeList, student.subjectCount);      
            
        }

        

    }
}
