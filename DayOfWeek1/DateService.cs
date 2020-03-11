using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek1
{
    public class DateService
    {
        public string GetDayOfWeekFromDate(string date)
        {
            var x = DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture);
            return DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture).DayOfWeek.ToString();
        }
    }
}
