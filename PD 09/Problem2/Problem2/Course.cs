using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    abstract class Course
    {
        public string Name;
        public abstract bool Passed();
    }
}
