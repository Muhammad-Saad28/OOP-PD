using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class GradedCourse : Course
    {
        public int NumericGrade { get; set; }

        public override bool Passed()
        {
            return NumericGrade >= 2;
        }
    }
}
