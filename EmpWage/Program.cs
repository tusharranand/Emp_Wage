using System;

Console.WriteLine("Welcome to Employee Wage Computation Program.");

// UC 5

int Is_Present = 1;
int Full_Time = 1;
int Wage_Per_Hr = 20;
int Hr_Per_Day = 0;
int Wage_Per_Day = 0;
int Present_Days = 0;
int Wage_Per_Month = 0;

Random Check = new Random();
int Emp_Time = Check.Next(0, 2);

if (Emp_Time == Full_Time)
{
    Hr_Per_Day = 8;
}
else
{
    Hr_Per_Day = 4;
}

for (int i = 0; i < 20; i++) { 

    Random Present = new Random();
    int EmpCheck = Present.Next(0, 2);

    if (EmpCheck == Is_Present)
    {
        Present_Days++;
    }
}

Wage_Per_Day = (Wage_Per_Hr * Hr_Per_Day);
Console.WriteLine("Daily wage = " + Wage_Per_Day);

Console.WriteLine("Days present = " + Present_Days);

Wage_Per_Month = (Wage_Per_Day * Present_Days);
Console.WriteLine("Monthly wage = " + Wage_Per_Month);
