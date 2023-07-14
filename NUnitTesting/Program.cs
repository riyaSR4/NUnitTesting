using System;
using System.Diagnostics;

namespace NUnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter input to be executed\n 1.Day of Week\n 2.Exit\n");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        DayOfWeek dayOfWeek = new DayOfWeek();
                        dayOfWeek.PrintDayOfWeek();
                        break;
                    case 2:
                        flag = false;
                        break;

                }
            }
        }
    }
}
