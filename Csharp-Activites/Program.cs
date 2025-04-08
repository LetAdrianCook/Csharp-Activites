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
            int choice;
            bool run = true;
            UserInputService inputService = new UserInputService();

            while (run == true)
            {
                try
                {
                    Console.WriteLine("----------------------------Automatic Grading System----------------------------");
                    Console.WriteLine("            [1] - Calculate Grade | [2] - Clear Console | [3] - Exit");
                    Console.Write("Enter choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            inputService.InputStudentInfo();
                            break;
                        case 2:
                            Console.WriteLine("Cleared the console.");
                            Console.ReadLine();
                            Console.Clear();
                            break;  
                        case 3:
                            Console.WriteLine("Exiting...");
                            run = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice please enter only 1, 2 and 3");
                            break;
                    }
                }
                catch { 
                    Console.WriteLine("Invalid Input");
                }
            }

        }
    }
}

