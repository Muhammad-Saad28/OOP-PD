using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String ProjectName = "Research Project";

            Project project = new Project();
            project.ProjectName = ProjectName;
            Console.WriteLine($"Project Name: {ProjectName}");

            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine($"\nEnter Details for the course number {i}: ");
                Console.Write("Is this an Absolute Graded Course? (yes/no): ");

                string type = Console.ReadLine().ToLower();

                if (type == "yes")
                {
                    AbsoluteGradedCourse course = new AbsoluteGradedCourse();

                    Console.Write("Course Name: ");
                    course.CourseName = Console.ReadLine();

                    Console.Write("Marks: ");
                    course.Marks = int.Parse(Console.ReadLine());

                    Console.Write("Grade (A/B/C/D/F): ");
                    course.Grade = Console.ReadLine().ToUpper();

                    project.Courses.Add(course);
                }
                else if (type == "no")
                {
                    GradedCourse course = new GradedCourse();

                    Console.Write("Course Name: ");
                    course.CourseName = Console.ReadLine();

                    Console.Write("Numeric Grade (-3 to 12): ");
                    course.NumericGrade = int.Parse(Console.ReadLine());

                    project.Courses.Add(course);
                }
                else
                {
                    Console.WriteLine("Invalid Operation......");
                }
            }

            Console.WriteLine($"\nProject {project.ProjectName} Passed: {project.Passed()}");
        }
    }
}
