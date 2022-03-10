using System;

Console.WriteLine("Welcome to Employee Wage Computation Program.");

// UC 4

int Wage_Per_Hr = 20;
int Hr_Per_Day = 0;
int Wage_Per_Day = 0;

// absent = 0;
// full_time = 1;
// part_time = 2;

Random check = new Random();
int Status = check.Next(0, 3);

switch (Status)
{
    case 0:
        Console.WriteLine("Employee is absent.");
        break;
    case 1:
        Console.WriteLine("Full time employee is present.");
        Hr_Per_Day = 8;
        break;
    case 2:
        Console.WriteLine("Part time employee is present.");
        Hr_Per_Day = 4;
        break;
}

Wage_Per_Day = (Wage_Per_Hr * Hr_Per_Day);
Console.WriteLine("Daily wage = " + Wage_Per_Day);
