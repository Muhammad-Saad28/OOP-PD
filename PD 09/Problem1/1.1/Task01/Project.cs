using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Project
    {
        public string ProjectName { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();

        public bool Passed()
        {
            int passCount = 0;
            foreach (var course in Courses)
            {
                if (course.Passed()) passCount++;
            }
            return passCount >= 3;
        }
    }
}
