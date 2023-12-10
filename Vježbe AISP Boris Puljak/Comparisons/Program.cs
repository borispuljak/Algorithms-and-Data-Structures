using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Comparisons
{

    class Program
    {
        static void Main()
        {
            Student[] students = {
            new Student("Ivo", 4.1),
            new Student("Ana", 4.9),
            new Student("Iva", 4.3),
            new Student("Bob", 4.5),
            new Student("Joe", 4.7)
        };

            Console.WriteLine("Original array:");
            DisplayStudents(students);

            Bubble.Sort(students, Student.CompareName);

            Console.WriteLine("\nArray sorted by name:");
            DisplayStudents(students);

            Bubble.Sort(students, Student.CompareGrade);

            Console.WriteLine("\nArray sorted by grade:");
            DisplayStudents(students);
        }

        static void DisplayStudents(Student[] students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }
    }
}