using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Project
    {
        public List<Course> Courses = new List<Course>();

        public bool Passed()
        {
            int passedCount = 0;

            foreach (Course course in Courses)
            {
                if (course.Passed())
                {
                    passedCount++;
                }
            }
            return passedCount >= 3;
        }
    }
}
