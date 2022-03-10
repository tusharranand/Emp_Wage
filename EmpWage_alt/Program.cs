using System;
// UC7
namespace EmpWage_alt
{
    class Wage_Computation
    {
        public const int Full_Time = 1;
        public const int Part_Time = 2;
        public int Wage_Per_Hr = 20;
        public int Hr_Per_Day = 0;
        public int Full_Hr_Per_Day = 0;
        public int Part_Hr_Per_Day = 0;
        public int Wage_Per_Day = 0;
        public int Total_Working_Hrs = 0;
        public int Max_Working_Days = 20;
        public int Max_Working_Hrs = 100;
        public int Present_Days = 0;
        public int Monthly_Wage = 0;

        public Wage_Computation(int Wage_Per_Hr, int Full_Hr_Per_Day, int Part_Hr_Per_Day, int Max_Working_Hrs, int Max_Working_Days)
        {
            this.Wage_Per_Hr = Wage_Per_Hr;
            this.Full_Hr_Per_Day = Full_Hr_Per_Day;
            this.Part_Hr_Per_Day = Part_Hr_Per_Day;
            this.Max_Working_Hrs = Max_Working_Hrs;
            this.Max_Working_Days = Max_Working_Days;
        }

        private int Present_Check()
        {
            return new Random().Next(0, 3);
        }

        public void Calculations()
        {
            while (Total_Working_Hrs <= Max_Working_Hrs && Present_Days <= Max_Working_Days)
            {

                switch (Present_Check())
                {
                    case Full_Time:
                        Hr_Per_Day = Full_Hr_Per_Day;
                        Present_Days++;
                        break;
                    case Part_Time:
                        Hr_Per_Day = Part_Hr_Per_Day;
                        Present_Days++;
                        break;
                    default:
                        Hr_Per_Day= 0;
                        break;
                }
                Total_Working_Hrs += Hr_Per_Day;
                Wage_Per_Day = (Wage_Per_Hr * Hr_Per_Day);
                Monthly_Wage += Wage_Per_Day;
                Console.WriteLine("Daily wage = " + Wage_Per_Day);
            }
            Console.WriteLine("Total hours worked = " + Total_Working_Hrs);
            Console.WriteLine("Total days present = " + Present_Days);
            Console.WriteLine("Monthly wage = " + Monthly_Wage);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program.");
            Wage_Computation First_Employee = new Wage_Computation(20, 8, 4, 100, 20);
            First_Employee.Calculations();
        }
    }
}