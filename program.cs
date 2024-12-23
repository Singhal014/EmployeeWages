using System;

namespace EmpWagesUc3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int wageperhour = 20;
            
            int work = random.Next(8);

            if (work < 4)
            {
                Console.WriteLine("It is Part time Employee");
            }
        }
    }
}

