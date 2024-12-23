namespace EmpWageUc5
{
    using System;

    class EmployeeWage
    {
        static int GetWorkHours(Random random)
        {
            int workType = random.Next(0, 3);

            switch (workType)
            {
                case 0:
                    return 0;
                case 1:
                    return 4;
                case 2:
                    return 8;
                default:
                    return 0;
            }
        }

        static void Main(string[] args)
        {
            const int WagePerHour = 20;
            const int WorkingDaysPerMonth = 20;
            int totalMonthlyWage = 0;
            Random random = new Random();


            for (int day = 1; day <= WorkingDaysPerMonth; day++)
            {
                int workHours = GetWorkHours(random);
                int dailyWage = workHours * WagePerHour;
                totalMonthlyWage += dailyWage;

                Console.WriteLine($"Day {day}: Work Hours = {workHours}, Daily Wage = ${dailyWage}");
            }

            Console.WriteLine($"\nTotal Monthly Wage: ${totalMonthlyWage}");
            Console.ReadLine();
        }
    }
}

