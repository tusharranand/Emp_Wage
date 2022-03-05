using System;

Console.WriteLine("Welcome to Employee Wage Computation Program.");

// UC 5

int is_present = 1;
int full_time = 1;
int wage_per_hr = 20;
int hr_per_day = 0;
int wage_per_day = 0;
int present_days = 0;
int wage_per_month = 0;

Random check = new Random();
int emp_time = check.Next(0, 2);

if (emp_time == full_time)
{
    hr_per_day = 8;
}
else
{
    hr_per_day = 4;
}

for (int i = 0; i < 20; i++) { 

    Random check2 = new Random();
    int empCheck = check2.Next(0, 2);

    if (empCheck == is_present)
    {
        present_days++;
    }
}

wage_per_day = (wage_per_hr * hr_per_day);
Console.WriteLine("Daily wage = " + wage_per_day);

Console.WriteLine("Days present = " + present_days);

wage_per_month = (wage_per_day * present_days);
Console.WriteLine("Monthly wage = " + wage_per_month);