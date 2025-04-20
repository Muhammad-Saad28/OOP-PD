using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class AbsoluteGradedCourse : Course
    {
        public int Marks;
        public string Grade;

        public override bool Passed()
        {
            return Grade != "F";
        }
    }
}
