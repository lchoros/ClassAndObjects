using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    public class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }
        public double AverageGrade
        {
            get
            {
                return Grades.Average();
            }
        }

        public Student(string name, double[] grades)
        {
            Name = name;
            Grades = grades;
        }

        public override string ToString()
        {
            return string.Format("{0} -> {1:f2}", Name, AverageGrade);
        }
    }
}
