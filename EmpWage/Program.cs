using System;

Console.WriteLine("Welcome to Employee Wage Computation Program.");

// UC 1

int Is_Present = 1;

Random check = new Random();
int EmpCheck = check.Next(0, 2);

if (EmpCheck == Is_Present)
{
    Console.WriteLine("Employee is present.");
}
else
{
    Console.WriteLine("Employee is absent.");
}
