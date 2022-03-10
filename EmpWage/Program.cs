using System;

Console.WriteLine("Welcome to Employee Wage Computation Program.");

// UC 6

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

int Days = 1;

while ((Hr_Per_Day * Is_Present <= 100) && (Days <= 20)) {

    Random Present = new Random();
    int EmpCheck = Present.Next(0, 2);

    if (EmpCheck == Is_Present)
    {
        Present_Days++;
    }

    Days++;
}

Wage_Per_Day = (Wage_Per_Hr * Hr_Per_Day);
Console.WriteLine("Daily wage = " + Wage_Per_Day);

Console.WriteLine("Days present = " + Present_Days);

Console.WriteLine("Working Hours = " + (Present_Days * Hr_Per_Day));

wage_per_month = (Wage_Per_Day * Present_Days);
Console.WriteLine("Monthly wage = " + Wage_Per_Month);
