using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class GradedCourse : Course
    {
        public int Grade;

        public override bool Passed()
        {
            return Grade >= 2;
        }
    }
}
