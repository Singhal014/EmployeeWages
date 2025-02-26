using System;

namespace EmpWageUc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random wage = new Random();
            int WagePerHour = 20;
            int total = 0;

            int work = wage.Next(1,9);

            if (work <= 8)
            {
                total = work * WagePerHour;
                Console.WriteLine("Employee work " +work +" days and Total Wage :" + total);
            }
        }
    }
}


