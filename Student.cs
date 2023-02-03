using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Example___Selection_Box___ListBox_and_Combo_Box__
{
    public class Student
    {
        public string FirstName;
        public string LastName;
        public int CSIGrade;
        public int GenEdGrade;

        public Student(string firstName, string lastName, int cSIGrade, int genEdGrade)
        {
            FirstName = firstName;
            LastName = lastName;
            CSIGrade = cSIGrade;
            GenEdGrade = genEdGrade;
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }
}
