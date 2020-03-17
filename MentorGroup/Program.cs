using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MentorGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            //var students = ReadStudents();

            var testStudents = new List<Student>
            {
                new Student("nakov", new List<DateTime> { new DateTime(2016, 8, 22), new DateTime(2016, 8, 20) }, new List<string> { "Excellent algorithmetic thinking." }),
                new Student("simeon10", new List<DateTime> { new DateTime(2016, 8, 22) }, new List<string>()),
                new Student("Gesh4o", new List<DateTime>(), new List<string> { "Total noob." })
            };
            PrintStudents(testStudents);
        }

        public static void PrintStudents(List<Student> students)
        {
            foreach (var student in students.Where(m=>m.Dates.Any()))
            {
                Console.WriteLine(student.Name);
                Console.WriteLine("Comments: ");
                foreach (var comment in student.Comments)
                {
                    Console.WriteLine("- {0}", comment);
                }
                Console.WriteLine("Dates attended: ");
                foreach (var date in student.Dates.OrderBy(x=>x))
                {
                    Console.WriteLine("-- {0}", date.ToString("dd/MM/yyyy"));
                }
            }
        }

        public static List<Student> ReadStudents()
        {
            string command = Console.ReadLine();
            List<Student> students = new List<Student>();
            while (!command.Equals("end of dates"))
            {
                string[] studentActivities = command.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string studentName = studentActivities[0];
                List<DateTime> dates = studentActivities.Skip(1).Select(x=>DateTime.ParseExact(x, "dd/MM/yyyy", CultureInfo.InvariantCulture)).ToList();

                var student = students.FirstOrDefault(m => m.Name == studentName);
                if(student == null)
                {
                    students.Add(new Student(studentName, dates, new List<string>()));
                }
                else
                {
                    student.Dates.AddRange(dates);
                }
                command = Console.ReadLine();
            }
            command = Console.ReadLine();

            while(!command.Equals("end of comments"))
            {
                string[] studentComments = command.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string studentName = studentComments[0];
                string comment = studentComments[1];

                var student = students.FirstOrDefault(m => m.Name == studentName);
                if (student == null)
                {
                    students.Add(new Student(studentName, new List<DateTime>(), new List<string>() { comment }));
                }
                else
                {
                    student.Comments.Add(comment);
                }
                command = Console.ReadLine();
            }
            return students.ToList();
        }
    }
}
