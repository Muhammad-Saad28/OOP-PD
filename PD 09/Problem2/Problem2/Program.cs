using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Improved Grading System");

            Project project = new Project();

            Console.WriteLine("\nEnter course details:");

            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine($"\nAbsolute Graded Course {i}:");
                
                AbsoluteGradedCourse course = new AbsoluteGradedCourse();
                
                Console.Write("Course Name: ");
                course.Name = Console.ReadLine();
                
                Console.Write("Marks: ");
                course.Marks = int.Parse(Console.ReadLine());
                
                Console.Write("Grade (A/B/C/D/E/F): ");
                course.Grade = Console.ReadLine();
                
                project.Courses.Add(course);
            }

            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine($"\nGraded Course {i} (7-step scale):");
                
                GradedCourse course = new GradedCourse();
                
                Console.Write("Course Name: ");
                course.Name = Console.ReadLine();
                
                Console.Write("Grade (12, 10, 7, 4, 2, 0, -3): ");
                course.Grade = int.Parse(Console.ReadLine());
                
                project.Courses.Add(course);
            }

            Console.WriteLine("\nProject Results:");
            
            for (int i = 0; i < project.Courses.Count; i++)
            {
                Console.WriteLine($"{project.Courses[i].Name}: Passed - {project.Courses[i].Passed()}");
            }
            Console.WriteLine($"\nOverall Project Passed: {project.Passed()}");
        }
    }
}
