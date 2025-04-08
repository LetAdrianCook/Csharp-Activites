using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Activites.Models
{
    class Highschool : Student
    {
        public override void ShowStudentLevel()
        {
            Console.WriteLine();
            Console.WriteLine("The student is in Highschool Level");
        }
    }
}
