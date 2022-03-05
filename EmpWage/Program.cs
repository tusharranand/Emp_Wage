using System;

Console.WriteLine("Welcome to Employee Wage Computation Program.");

// UC 3

int is_present = 1;
int wage_per_hr = 20;
int hr_per_day = 0;
int wage_per_day = 0;
int full_time = 1;

Random check = new Random();
int emp_time = check.Next(0, 2);

Random check2 = new Random();
int empCheck = check2.Next(0, 2);

if (emp_time == full_time)
{
    hr_per_day = 8;
    if (empCheck == is_present)
    {
        Console.WriteLine("Full time employee is present.");
    }
    else
    {
        Console.WriteLine("Full time employee is absent.");
    }
}
else
{
    hr_per_day = 4;
    if (empCheck == is_present)
    {
        Console.WriteLine("Part time employee is present.");
    }
    else
    {
        Console.WriteLine("Part time employee is absent.");
    }
}

wage_per_day = (wage_per_hr * hr_per_day);
Console.WriteLine("Daily wage = " + wage_per_day);