namespace EmpWageUc6
{
    using System;

    class EmployeeWage
    {
        static int GetWorkHours(Random random)
        {
            // Simulate employee work hours: 0 for no work, 4 for part-time, and 8 for full-time
            int workType = random.Next(0, 3);

            switch (workType)
            {
                case 0:
                    return 0;  // Employee did not work
                case 1:
                    return 4;  // Employee worked part-time
                case 2:
                    return 8;  // Employee worked full-time
                default:
                    return 0;
            }
        }

        static void Main(string[] args)
        {
            const int WagePerHour = 20;
            const int MaxWorkingHours = 100;  // Total maximum working hours for the month
            const int WorkingDaysPerMonth = 20;  // Maximum working days in a month

            int totalWorkingHours = 0;
            int totalMonthlyWage = 0;
            int totalWorkingDays = 0;

            Random random = new Random();

            // Loop through the days of the month until max working hours or days are reached
            for (int day = 1; day <= WorkingDaysPerMonth; day++)
            {
                if (totalWorkingHours >= MaxWorkingHours)
                {
                    Console.WriteLine("Employee has reached the maximum working hours for the month.");
                    break;
                }

                int workHours = GetWorkHours(random);
                totalWorkingHours += workHours;
                int dailyWage = workHours * WagePerHour;
                totalMonthlyWage += dailyWage;

                totalWorkingDays++;

                Console.WriteLine($"Day {day}: Work Hours = {workHours}, Daily Wage = ${dailyWage}");
            }

            // Output the total wages for the month
            Console.WriteLine($"\nTotal Monthly Wage: ${totalMonthlyWage}");
            Console.WriteLine($"Total Working Hours: {totalWorkingHours}");
            Console.WriteLine($"Total Working Days: {totalWorkingDays}");

            Console.ReadLine();
        }
    }
}

