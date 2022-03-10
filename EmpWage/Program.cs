using System;

Console.WriteLine("Welcome to Employee Wage Computation Program.");

// UC 2

int Is_Present = 1;
int Wage_Per_Hr = 20;
int Hr_Per_Day = 0;
int Wage_Per_Day = 0;

Random check = new Random();
int EmpCheck = check.Next(0, 2);

if (EmpCheck == Is_Present)
{
    Console.WriteLine("Employee is present.");
    Hr_Per_Day = 8;
}
else
{
    Console.WriteLine("Employee is absent.");
}

Wage_Per_Day = (Wage_Per_Hr * Hr_Per_Day);
Console.WriteLine("Daily wage = " + Wage_Per_Day);
