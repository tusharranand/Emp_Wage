using System;
using System.Collections.Generic;

namespace EmpWage
{
    class Company
    {
        public string Company_Name;
        public int Wage_Per_Hr;
        public int Full_Hr_Per_Day;
        public int Part_Hr_Per_Day;
        public int Max_Working_Days;
        public int Max_Working_Hrs;

        public Company(string Company_Name, int Wage_Per_Hr, int Full_Hr_Per_Day, int Part_Hr_Per_Day, int Max_Working_Hrs, int Max_Working_Days)
        {
            this.Company_Name = Company_Name;
            this.Wage_Per_Hr = Wage_Per_Hr;
            this.Full_Hr_Per_Day = Full_Hr_Per_Day;
            this.Part_Hr_Per_Day = Part_Hr_Per_Day;
            this.Max_Working_Hrs = Max_Working_Hrs;
            this.Max_Working_Days = Max_Working_Days;
        }

    }
    public interface ICompute_Emp_Wage
    {
        public void AddCompany(string Company_Name, int Wage_Per_Hr, int Full_Hr_Per_Day,
            int Part_Hr_Per_Day, int Max_Working_Hrs, int Max_Working_Days);
        public void Calculations(string Company_Name);

    }
    class Wage_Computation : ICompute_Emp_Wage
    {
        public const int Full_Time = 1;
        public const int Part_Time = 2;
        private Dictionary<string, Company> Companies_Dict;
        public string[] Company_List;
        public int Company_Index = 0;

        public Wage_Computation(int Number)
        {
            Companies_Dict = new Dictionary<string, Company>();
            Company_List = new string[2 * Number];
        }

        public void AddCompany(string Company_Name, int Wage_Per_Hr, int Full_Hr_Per_Day, 
            int Part_Hr_Per_Day, int Max_Working_Hrs, int Max_Working_Days)
        {
            Company comp_obj = new Company(Company_Name.ToLower(), Wage_Per_Hr, Full_Hr_Per_Day, 
                Part_Hr_Per_Day, Max_Working_Hrs, Max_Working_Days);
            Companies_Dict.Add(Company_Name.ToLower(), comp_obj);
            Company_List[Company_Index] = Company_Name;
            Company_Index++;
        }

        private int Present_Check()
        {
            return new Random().Next(0, 3);
        }

        public void Calculations(string Company_Name)
        {
            int Hr_Per_Day = 0;
            int Wage_Per_Day = 0;
            int Total_Working_Hrs = 0;
            int Present_Days = 0;
            int Monthly_Wage = 0;

            if (!Companies_Dict.ContainsKey(Company_Name.ToLower()))
                throw new ArgumentNullException("Company doesn't Exist!");
            Companies_Dict.TryGetValue(Company_Name.ToLower(), out Company comp_obj);

            while (Total_Working_Hrs < comp_obj.Max_Working_Hrs && 
                Present_Days < comp_obj.Max_Working_Days)
            {

                switch (Present_Check())
                {
                    case Full_Time:
                        Hr_Per_Day = comp_obj.Full_Hr_Per_Day;
                        Present_Days++;
                        break;
                    case Part_Time:
                        Hr_Per_Day = comp_obj.Part_Hr_Per_Day;
                        Present_Days++;
                        break;
                    default:
                        Hr_Per_Day = 0;
                        break;
                }
                Total_Working_Hrs += Hr_Per_Day;
                Wage_Per_Day = (comp_obj.Wage_Per_Hr * Hr_Per_Day);
                Monthly_Wage += Wage_Per_Day;
            }
            Company_List[Company_Index] = Convert.ToString(Monthly_Wage);
            Company_Index++;
        }
        public void View_Wage()
        {
            for (int i=0; i < Company_List.Length; i+=2)
            {
                Console.WriteLine("Monthly wage for {0} is {1}", Company_List[i], 
                    Company_List[i + 1]);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program.");
            Wage_Computation Employee = new Wage_Computation(3);

            Employee.AddCompany("TATA", 20, 8, 4, 100, 20);
            Employee.Calculations("Tata");

            Employee.AddCompany("Mahindra", 30, 8, 4, 100, 20);
            Employee.Calculations("Mahindra");

            Employee.AddCompany("DMart", 40, 9, 5, 100, 20);
            Employee.Calculations("Dmart");

            Employee.View_Wage();
        }
    }
}
