   {
        static void Main(string[] args)
        {
            Random random = new Random();

            int attend = random.Next(0, 2);

            if (attend == 0)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is not present");
            }
        }
    }
}

