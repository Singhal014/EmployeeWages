
namespace EmpWageUc4
{
    internal class Program
    {
        public static int GetWork()
        {
            Random rnd = new Random();
            int work = rnd.Next(0, 3);

            switch (work)
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
            int WagePerHours = 20;

            int WorkHours = GetWork();

            int dailyWage = WagePerHours * WorkHours;

            if (WorkHours == 0)
            {
                Console.WriteLine("Employee did not work");
                Console.WriteLine("Total Wages : $ " + dailyWage);
            }
            else if (WorkHours == 4)
            {
                Console.WriteLine("Employee work part time");
                Console.WriteLine("Total Wages : $ " + dailyWage);
            }
            else if (WorkHours == 8)
            {
                Console.WriteLine("Employee work full time");
                Console.WriteLine("Total Wages : $ " + dailyWage);
            }



