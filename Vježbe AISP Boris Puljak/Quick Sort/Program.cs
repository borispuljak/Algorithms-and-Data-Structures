

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Quick_Sort
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
            new Student("Joe", 4.7),
            new Student("Tom", 4.4),
            new Student("Iko", 4.6),
        };

            Console.WriteLine("Početni niz studenata:");
            DisplayArray(students);

            Quick.Partition(students, 0, students.Length - 1, Student.CompareName);
            Console.WriteLine("\nSortirani niz studenata po imenu:");
            DisplayArray(students);

            Quick.Sort(students, 0, students.Length - 1, Student.CompareName);
            Console.WriteLine("\nSortirani niz studenata po imenu:");
            DisplayArray(students);

            Quick.Sort(students, 0, students.Length - 1, Student.CompareGrade);
            Console.WriteLine("\nSortirani niz studenata po ocjeni:");
            DisplayArray(students);
        }

        static void DisplayArray(Student[] array)
        {
            foreach (var student in array)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }
    }
}
