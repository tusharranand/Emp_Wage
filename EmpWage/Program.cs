using System;

Console.WriteLine("Welcome to Employee Wage Computation Program.");

// UC 1

int is_present = 1;

Random check = new Random();
int empCheck = check.Next(0, 2);

if (empCheck == is_present)
{
    Console.WriteLine("Employee is present.");
}
else
{
    Console.WriteLine("Employee is absent.");
}