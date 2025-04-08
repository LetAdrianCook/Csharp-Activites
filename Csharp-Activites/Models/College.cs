using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Activites.Models
{
    class College : Student
    {
        public override void studentLevel()
        {
            Console.WriteLine();
            Console.WriteLine("The student is in College Level");
            Console.WriteLine();
        }
    }
}
