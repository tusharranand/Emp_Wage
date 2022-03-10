namespace EmpWage_alt
{
    class Program
    {
        public const int Full_Time = 1;
        public const int Part_Time = 2;
        public const int Wage_Per_Hr = 20;

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program.");

            int Full_Day_Hr = 0;
            int Wage_Per_Day = 0;

            Random check = new Random();
            int Status = check.Next(0, 3);

            switch (Status)
            {
                case Full_Time:
                    Console.WriteLine("Full time employee is present.");
                    Full_Day_Hr = 8;
                    break;
                case Part_Time:
                    Console.WriteLine("Part time employee is present.");
                    Full_Day_Hr = 4;
                    break;
                default:
                    Console.WriteLine("Employee is absent.");
                    break;
            }

            Wage_Per_Day = (Wage_Per_Hr * Full_Day_Hr);
            Console.WriteLine("Daily wage = " + Wage_Per_Day);
        }
    }
}
