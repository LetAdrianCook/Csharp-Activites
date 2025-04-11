using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_Activites.Services
{
    public class CalculateSum : Calculation
    {
        public List<float> gradeList { get; set; } = new List<float>();
        public CalculateSum(List<float> gradeList)
        {
            this.gradeList = gradeList;
        }
        public override float CalculateStudentGrade()
        {
            return gradeList.Sum();
        }

    }
}
