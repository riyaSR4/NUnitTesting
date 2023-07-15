using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class DayOfWeek
    {
        public void PrintDayOfWeek()
        {
            Console.WriteLine(" Enter the day : ");
            int date = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Enter the month : ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Enter the year : ");
            int year = Convert.ToInt32(Console.ReadLine());

            DateTime ss = new DateTime(year, month, date);

            Console.WriteLine(ss.DayOfWeek);
        }
    }
}
