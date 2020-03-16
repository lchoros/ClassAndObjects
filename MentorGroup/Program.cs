using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorGroup
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static Dictionary<string, Student> ReadStudents()
        {
            string command = Console.ReadLine();
            while (!command.Equals("end of dates"))
            {
                string[] dateArgs = command.Split(new char[] { ' ', ',' });
            }
            return new Dictionary<string, Student>();
        }
    }
}
