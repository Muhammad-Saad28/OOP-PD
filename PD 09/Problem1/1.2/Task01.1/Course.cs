using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Course
    {
        public string CourseName { get; set; }
        public virtual bool Passed() => false;
    }
}
