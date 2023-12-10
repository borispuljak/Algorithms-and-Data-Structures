using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Comparers
{
    public class StudentComparer : IComparer
    {
        private StudentComparerType criterion;

        public StudentComparer(StudentComparerType criterion)
        {
            this.criterion = criterion;
        }

        public int Compare(object x, object y)
        {
            Student studentX = (Student)x;
            Student studentY = (Student)y;

            switch (criterion)
            {
                case StudentComparerType.Name:
                    return studentX.name.CompareTo(studentY.name);
                case StudentComparerType.Grade:
                    return studentY.grade.CompareTo(studentX.grade);
                default:
                    throw new Exception("Kriterij ne postoji");
            }
        }
    }

    public enum StudentComparerType
    {
        Name, Grade
    }
}