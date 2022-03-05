using System;

Console.WriteLine("Welcome to Employee Wage Computation Program.");

// UC 4

int wage_per_hr = 20;
int hr_per_day = 0;
int wage_per_day = 0;

// absent = 0;
// full_time = 1;
// part_time = 2;

Random check = new Random();
int status = check.Next(0, 3);

switch (status)
{
    case 0:
        Console.WriteLine("Employee is absent.");
        break;
    case 1:
        Console.WriteLine("Full time employee is present.");
        hr_per_day = 8;
        break;
    case 2:
        Console.WriteLine("Part time employee is present.");
        hr_per_day = 4;
        break;
}

wage_per_day = (wage_per_hr * hr_per_day);
Console.WriteLine("Daily wage = " + wage_per_day);
