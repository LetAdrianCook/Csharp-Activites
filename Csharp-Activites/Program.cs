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
            Grade grade = new Grade();
            UserInputService inputService = new UserInputService();

            inputService.InputStudentInfo();

        }
    }
}
