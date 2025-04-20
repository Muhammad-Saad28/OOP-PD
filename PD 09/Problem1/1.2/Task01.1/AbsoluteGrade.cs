using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class AbsoluteGradedCourse : Course
    {
        public int Marks { get; set; }
        public string Grade { get; set; }

        public override bool Passed()
        {
            return Grade == "A" || Grade == "B" || Grade == "C";
        }
    }

}
