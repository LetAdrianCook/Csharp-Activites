using Csharp_Activites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_Activites.Services
{
    class GradingService
    {        
        public float CalculateFinalGrade(List<float> gradeList, int subjectCount)
        {
            float sum = gradeList.Sum();
            return sum / subjectCount;
        }

        public string DisplayResult(string studentName, string studentType )
        {
            return studentName + studentName;
        }

    }
}
