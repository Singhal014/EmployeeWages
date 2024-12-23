using System;

namespace EmployeeWage
{
    class EmployeeWage
    {
        const int WagePerHour = 20;
        const int FullTimeWorkHours = 8;
        const int PartTimeWorkHours = 4;
        const int WorkingDaysPerMonth = 20;
        const int MaxWorkingHours = 100;

        public static void CheckAttendance()
        {
            Random random = new Random();
            int attend = random.Next(0, 2);

            if (attend == 0)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }

        public static void CalculateDailyWage()
        {
            Random random = new Random();
            int workHours = random.Next(0, 3);
            int dailyWage = 0;

            switch (workHours)
            {
                case 0:
                    Console.WriteLine("Employee is absent");
                    break;
                case 1:
                    Console.WriteLine("Employee worked part-time (4 hours)");
                    dailyWage = PartTimeWorkHours * WagePerHour;
                    break;
                case 2:
                    Console.WriteLine("Employee worked full-time (8 hours)");
                    dailyWage = FullTimeWorkHours * WagePerHour;
                    break;
            }

            Console.WriteLine("Daily Wage: $" + dailyWage);
        }

        public static void AddPartTimeEmployee()
        {
            Console.WriteLine("Assuming the employee worked part-time (4 hours).");
            int dailyWage = PartTimeWorkHours * WagePerHour;
            Console.WriteLine("Daily Wage for Part-Time Employee: $" + dailyWage);
        }

        public static void WorkWithSwitchCase()
        {
            Random random = new Random();
            int workType = random.Next(0, 3);

            int workHours = 0;
            switch (workType)
            {
                case 0:
                    Console.WriteLine("Employee did not work today.");
                    break;
                case 1:
                    workHours = PartTimeWorkHours;
                    Console.WriteLine("Employee worked part-time.");
                    break;
                case 2:
                    workHours = FullTimeWorkHours;
                    Console.WriteLine("Employee worked full-time.");
                    break;
            }

            int dailyWage = workHours * WagePerHour;
            Console.WriteLine("Daily Wage: $" + dailyWage);
        }

        public static void CalculateMonthlyWage()
        {
            int totalMonthlyWage = 0;
            Random random = new Random();

            Console.WriteLine("\nCalculating Monthly Wages...");
            for (int day = 1; day <= WorkingDaysPerMonth; day++)
            {
                int workHours = random.Next(0, 3);
                int dailyWage = 0;

                switch (workHours)
                {
                    case 0:
                        Console.WriteLine($"Day {day}: Employee was absent.");
                        break;
                    case 1:
                        Console.WriteLine($"Day {day}: Employee worked part-time (4 hours).");
                        dailyWage = PartTimeWorkHours * WagePerHour;
                        break;
                    case 2:
                        Console.WriteLine($"Day {day}: Employee worked full-time (8 hours).");
                        dailyWage = FullTimeWorkHours * WagePerHour;
                        break;
                }

                totalMonthlyWage += dailyWage;
            }

            Console.WriteLine("\nTotal Monthly Wage: $" + totalMonthlyWage);
        }

        public static void CalculateWagesWithConditions()
        {
            int totalWorkingHours = 0;
            int totalMonthlyWage = 0;
            int totalWorkingDays = 0;
            Random random = new Random();

            Console.WriteLine("\nCalculating Wages with a limit on working hours (100 hours).");
            for (int day = 1; day <= WorkingDaysPerMonth; day++)
            {
                if (totalWorkingHours >= MaxWorkingHours)
                {
                    Console.WriteLine("Employee has reached the maximum working hours for the month.");
                    break;
                }

                int workHours = random.Next(0, 3);
                int dailyWage = 0;

                switch (workHours)
                {
                    case 0:
                        Console.WriteLine($"Day {day}: Employee was absent.");
                        break;
                    case 1:
                        workHours = PartTimeWorkHours;
                        Console.WriteLine($"Day {day}: Employee worked part-time.");
                        break;
                    case 2:
                        workHours = FullTimeWorkHours;
                        Console.WriteLine($"Day {day}: Employee worked full-time.");
                        break;
                }

                totalWorkingHours += workHours;
                dailyWage = workHours * WagePerHour;
                totalMonthlyWage += dailyWage;
                totalWorkingDays++;

                Console.WriteLine($"Day {day}: Work Hours = {workHours}, Daily Wage = ${dailyWage}");
            }

            Console.WriteLine("\nTotal Monthly Wage: $" + totalMonthlyWage);
            Console.WriteLine($"Total Working Hours: {totalWorkingHours}");
            Console.WriteLine($"Total Working Days: {totalWorkingDays}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UC1 - Check Employee Attendance");
            EmployeeWage.CheckAttendance();
            Console.WriteLine();

            Console.WriteLine("UC2 - Calculate Daily Wage");
            EmployeeWage.CalculateDailyWage();
            Console.WriteLine();

            Console.WriteLine("UC3 - Add Part-Time Employee and Calculate Wage");
            EmployeeWage.AddPartTimeEmployee();
            Console.WriteLine();

            Console.WriteLine("UC4 - Work with Switch Case for Daily Wage");
            EmployeeWage.WorkWithSwitchCase();
            Console.WriteLine();

            Console.WriteLine("UC5 - Calculate Wages for a Month");
            EmployeeWage.CalculateMonthlyWage();
            Console.WriteLine();

            Console.WriteLine("UC6 - Calculate Wages till a Condition of Total Working Hours or a Month");
            EmployeeWage.CalculateWagesWithConditions();
            Console.ReadLine();
        }
    }
}

