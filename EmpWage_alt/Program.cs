using System;

// UC 5

namespace EmpWage
{
    class Program
    {
        public const int full_time = 1;
        public const int part_time = 2;
        public const int wage_per_hr = 20;
        public const int working_days = 20;

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program.");

            int full_day_hr = 0;
            int wage_per_day = 0;
            int monthly_wage = 0;

            for (int day = 0; day < working_days; day++)
            {
                Random check = new Random();
                int status = check.Next(0, 3);

                switch (status)
                {
                    case full_time:
                        full_day_hr = 8;
                        break;
                    case part_time:
                        full_day_hr = 4;
                        break;
                    default:
                        full_day_hr = 0;
                        break;
                }
                wage_per_day = (wage_per_hr * full_day_hr);
                monthly_wage += wage_per_day;
                Console.WriteLine("Daily wage = " + wage_per_day);
            }
            Console.WriteLine("Monthly wage = " + monthly_wage);
        }
    }
}