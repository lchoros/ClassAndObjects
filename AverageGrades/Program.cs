using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            students = ReadStudents(studentCount);
            var topStudents =  students.Where(x => x.AverageGrade > 5).OrderBy(x=>x.Name).ThenByDescending(x=>x.AverageGrade).ToList();
            PrintStudent(topStudents);
        }

        public static void PrintStudent(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        public static List<Student> ReadStudents(int studentCount)
        {
            List<Student> students = new List<Student>();

            for (int i = 0; i < studentCount; i++)
            {
                string[] studentData = Console.ReadLine().Split().ToArray();

                string studentName = studentData[0];
                double[] studentGrades = studentData.Skip(1).Select(double.Parse).ToArray();
                Student student = new Student(studentName, studentGrades);
                students.Add(student);
            }
            return students;
        }
    }
}
