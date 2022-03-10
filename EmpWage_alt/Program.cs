using System;

// UC 6

namespace EmpWage
{
    class Program
    {
        public const int Full_Time = 1;
        public const int Part_Time = 2;
        public const int Wage_Per_Hr = 20;
        public const int Working_Days = 20;
        public const int Max_Working_Hrs = 100;

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program.");

            int Full_Day_Hr = 0;
            int Wage_Per_Day = 0;
            int Monthly_Wage = 0;
            int Total_Working_Hrs = 0;
            int Present_Days = 0;

            while (Total_Working_Hrs <= Max_Working_Hrs && Present_Days <= Working_Days)
            {
                Random Check = new Random();
                int Status = Check.Next(0, 3);

                switch (Status)
                {
                    case Full_Time:
                        Full_Day_Hr = 8;
                        Present_Days++;
                        break;
                    case Part_Time:
                        Full_Day_Hr = 4;
                        Present_Days++;
                        break;
                    default:
                        Full_Day_Hr = 0;
                        break;
                }
                Total_Working_Hrs += Full_Day_Hr;
                Wage_Per_Day = (Wage_Per_Hr * Full_Day_Hr);
                Monthly_Wage += Wage_Per_Day;
                Console.WriteLine("Daily wage = " + Wage_Per_Day);
            }
            Console.WriteLine("Total hours worked = " + Total_Working_Hrs);
            Console.WriteLine("Total days present = " + Present_Days);
            Console.WriteLine("Monthly wage = " + Monthly_Wage);
        }
    }
}
