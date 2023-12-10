using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparisons
{
    class Student : IComparable<Student>
    {
        private string name;
        private double grade;

        public Student(string name, double grade)
        {
            this.name = name;
            this.grade = grade;
        }

        public override string ToString()
        {
            return $"Name: {name}, Grade: {grade}";
        }

        public int CompareTo(Student other)
        {
            return String.Compare(this.name, other.name, StringComparison.Ordinal);
        }

        public static bool CompareName(object a, object b)
        {
            if (a is Student && b is Student)
            {
                return ((Student)a).name.CompareTo(((Student)b).name) < 0;
            }
            return false;
        }

        public static bool CompareGrade(object a, object b)
        {
            if (a is Student && b is Student)
            {
                return ((Student)a).grade > ((Student)b).grade;
            }
            return false;
        }
    }
}