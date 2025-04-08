using Csharp_Activites.Models;
using Csharp_Activites.Services;
using System;
using System.Xml.Linq;

namespace Csharp_Activites
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = false;
            Student student = new Student();
            UserInput

            do
            {
                try
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
                        float subjectGrade = Convert.ToSingle(Console.ReadLine());
                        student.gradeList.Add(subjectGrade);
                    }
                    sum = gradeList.Sum();
                    totalPercentageSubjects = (subjectCount / 100.0f);
                    finalAverage = sum / (totalPercentageSubjects * 100.0f);

                    if (finalAverage >= 75) grading = "Passed";
                    else grading = "Failed";

                    Console.WriteLine();
                    Console.WriteLine("--------------------Grading-System--------------------");
                    Console.WriteLine("Name : " + name);
                    Console.WriteLine("-----------------------Subjects-----------------------");
                    for (int i = 0; i < subjectCount; i++)
                    {
                        Console.WriteLine(subjectList[i] + " : " + gradeList[i]);
                    }
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("Your Final Average is : " + finalAverage);
                    Console.WriteLine("Grading               : " + grading);
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("Calculate another student grade? [type 'yes' to proceed] [Input any keys to exit]");
                    response = Console.ReadLine();
                    Console.WriteLine();

                    if (response.Equals("yes"))
                    {
                        subjectList.Clear();
                        gradeList.Clear();
                        run = true;
                    }
                    else run = false;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Error! Invalid input value.");
                }
            }
            while (run != false);

        }
    }
}
