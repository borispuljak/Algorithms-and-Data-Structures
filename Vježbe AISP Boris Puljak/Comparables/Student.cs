using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    public class Student : IComparable
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
            return $"{name}: {grade}";
        }

        public int CompareTo(object obj)
        {
            Student other = obj as Student;
            if (grade < other.grade)
                return -1;
            else if (grade > other.grade)
                return 1;
            return 0;
        }
    }
}