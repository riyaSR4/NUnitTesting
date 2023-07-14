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
                Console.WriteLine("Enter input to be executed\n 1.Day of Week\n 2.Vending Machine\n " +
                    "3.Temperature Conversion\n 4.Monthly Payment\n 5.Exit\n");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        DayOfWeek dayOfWeek = new DayOfWeek();
                        dayOfWeek.PrintDayOfWeek();
                        break;
                    case 2:
                        VendingMachine vendingmachine = new VendingMachine();
                        vendingmachine.Run();
                        break;
                    case 3:
                        TemperatureConversion temperatureconversion = new TemperatureConversion();
                        temperatureconversion.ConvertTemperature();
                        break;
                    case 4:
                        MonthlyPayment monthlyPayment = new MonthlyPayment();
                        monthlyPayment.GetAmount();
                        break;
                    case 5:
                        flag = false;
                        break;

                }
            }
        }
    }
}
