using System;

Console.WriteLine("Welcome to Employee Wage Computation Program.");

// UC 3

int Is_Present = 1;
int Wage_Per_Hr = 20;
int Hr_Per_Day = 0;
int Wage_Per_Day = 0;
int Full_Time = 1;

Random check = new Random();
int Emp_Time = check.Next(0, 2);

Random Present = new Random();
int EmpCheck = Present.Next(0, 2);

if (EmpCheck == Is_Present)
{
    
    if (Emp_Time == Full_Time)
    {
        Hr_Per_Day = 8;
        Console.WriteLine("Full time employee is present.");
    }
    else
    {
        Hr_Per_Day = 4;
        Console.WriteLine("Part time employee is present.");
    }
}
else
{
        Console.WriteLine("Employee is absent.");
}

Wage_Per_Day = (Wage_Per_Hr * Hr_Per_Day);
Console.WriteLine("Daily wage = " + Wage_Per_Day);
