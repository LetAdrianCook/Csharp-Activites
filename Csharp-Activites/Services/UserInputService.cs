﻿using Csharp_Activites.Models;
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
        public void InputStudentInfo()
        {
            Student student = new Student();
            Student highschoolStudent = new Highschool();
            Student collegeStudent = new College();
            GradingService gradingService = new GradingService();
            int choiceType;

            try
            {
                Console.WriteLine("[1 - College] [2 - Highschool]");
                Console.Write("Please Enter Grade Level of  Student: ");
                choiceType = Convert.ToInt32(Console.ReadLine());

                if (choiceType.Equals(1))
                { 
                    collegeStudent.ShowStudentLevel();
                    student.studentLevel = "College Level";
                }
                else if (choiceType.Equals(2))
                {
                    highschoolStudent.ShowStudentLevel();
                    student.studentLevel = "Highschool Level";
                }
                else
                {
                    Console.WriteLine("Invalid Grade level input selection");
                    return;
                }
                   
                Console.WriteLine();
                Console.Write("Please Enter Your Name: ");
                student.studentName = Console.ReadLine();
                Console.Write("Please how many subjects you currently take: ");
                student.subjectCount = Convert.ToInt32(Console.ReadLine());

                if (student.subjectCount > 0)
                {
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

                    Calculation calcSum = new CalculateSum(student.gradeList); //dili pwede i pass directly ang gradesum sa calculate finalaverage kay entire calculate object siya
                    float gradeSum = calcSum.CalculateStudentGrade();

                    Calculation calcAverage = new CalculateFinalAverage(gradeSum, student.subjectCount);
                    student.finalAverage = calcAverage.CalculateStudentGrade();

                    student.grading = gradingService.GradingAverage(student.finalAverage);

                    FinalStudent studentDisplay = new FinalStudent(student.studentName, student.subjectCount,
                                                                   student.studentLevel, student.subjectList,
                                                                   student.gradeList, student.finalAverage,
                                                                   student.grading);
                } else
                {
                    Console.WriteLine("Number of subject must be 1 or above");
                    return;
                }            
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
            }         
        }
    }
}
