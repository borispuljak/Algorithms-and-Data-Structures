using Comparers;
using System;

namespace Comparers
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

            Console.WriteLine("Studenti:");
            DisplayStudents(students);

            StudentComparer comparerByName = new StudentComparer(StudentComparerType.Name);
            Bubble.Sort(students, comparerByName);

            Console.WriteLine("\nStudenti nakon sortiranja prema imenu:");
            DisplayStudents(students);

            StudentComparer comparerByGrade = new StudentComparer(StudentComparerType.Grade);
            Bubble.Sort(students, comparerByGrade);

            Console.WriteLine("\nStudenti nakon sortiranja prema ocjeni:");
            DisplayStudents(students);
        }

        static void DisplayStudents(Student[] students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}