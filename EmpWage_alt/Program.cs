using System;

// UC 5

namespace EmpWage
{
    class Program
    {
        public const int Full_Time = 1;
        public const int Part_Time = 2;
        public const int Wage_Per_Hr = 20;
        public const int Working_Days = 20;

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program.");

            int Full_Day_Hr = 0;
            int Wage_Per_Day = 0;
            int Monthly_Wage = 0;

            for (int Day = 0; Day < Working_Days; Day++)
            {
                Random Check = new Random();
                int Status = Check.Next(0, 3);

                switch (Status)
                {
                    case Full_Time:
                        Full_Day_Hr = 8;
                        break;
                    case Part_Time:
                        Full_Day_Hr = 4;
                        break;
                    default:
                        Full_Day_Hr = 0;
                        break;
                }
                Wage_Per_Day = (Wage_Per_Hr * Full_Day_Hr);
                Monthly_Wage += Wage_Per_Day;
                Console.WriteLine("Daily wage = " + Wage_Per_Day);
            }
            Console.WriteLine("Monthly wage = " + Monthly_Wage);
        }
    }
}
