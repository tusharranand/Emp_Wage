using System;

Console.WriteLine("Welcome to Employee Wage Computation Program.");

// UC 2

int is_present = 1;
int wage_per_hr = 20;
int hr_per_day = 0;
int wage_per_day = 0;

Random check = new Random();
int empCheck = check.Next(0, 2);

if (empCheck == is_present)
{
    Console.WriteLine("Employee is present.");
    hr_per_day = 8;
}
else
{
    Console.WriteLine("Employee is absent.");
}

wage_per_day = (wage_per_hr * hr_per_day);
Console.WriteLine("Daily wage = " + wage_per_day);