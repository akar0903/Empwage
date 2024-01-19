using System;

namespace UC6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalNoOfDays = 20;
            int totalNoOfHrs = 100;
            int wageRate = 20;

            int totalSalary = 0;

            for (int day = 1; day <= totalNoOfDays && totalSalary < totalNoOfHrs * wageRate; day++)
            {
                totalSalary += 8 * wageRate;
            }

            Console.WriteLine($"Your salary at the end of the month is {totalSalary}");
            Console.ReadLine();
        }
    }
}
