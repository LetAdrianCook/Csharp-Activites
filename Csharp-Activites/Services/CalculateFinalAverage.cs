using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_Activites.Services
{
    class CalculateFinalAverage : Calculation
    {
        public float gradeSum { get; set; }
        public int subjectCount { get; set; }

        public CalculateFinalAverage(float gradeSum, int subjectCount)
        {
            this.gradeSum = gradeSum;
            this.subjectCount = subjectCount;
        }
        public override float CalculateStudentGrade()
        {
            return gradeSum / subjectCount;
        }
    }
}
