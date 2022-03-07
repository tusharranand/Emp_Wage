namespace EmpWage_alt
{
    class Program
    {
        public const int full_time = 1;
        public const int part_time = 2;
        public const int wage_per_hr = 20;

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program.");

            int full_day_hr = 0;
            int wage_per_day = 0;

            Random check = new Random();
            int status = check.Next(0, 3);

            switch (status)
            {
                case full_time:
                    Console.WriteLine("Full time employee is present.");
                    full_day_hr = 8;
                    break;
                case part_time:
                    Console.WriteLine("Part time employee is present.");
                    full_day_hr = 4;
                    break;
                default:
                    Console.WriteLine("Employee is absent.");
                    break;
            }

            wage_per_day = (wage_per_hr * full_day_hr);
            Console.WriteLine("Daily wage = " + wage_per_day);
        }
    }
}