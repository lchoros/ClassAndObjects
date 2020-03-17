using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorGroup
{
    public class Student
    {
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> Dates { get; set; }

        public Student(string name, List<DateTime> dates, List<string> comments)
        {
            Name = name;
            Comments = comments;
            Dates = dates;
        }         
    }
}
