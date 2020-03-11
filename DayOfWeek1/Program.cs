using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek1
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            var dateService = new DateService();
            Console.WriteLine(dateService.GetDayOfWeekFromDate(date));
        }
    }
}
