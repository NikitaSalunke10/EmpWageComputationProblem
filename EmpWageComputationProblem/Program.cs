<<<<<<< HEAD
﻿const int IS_PART_TIME = 1;
const int IS_FULL_TIME = 2;
const int NUM_OF_WORKING_DAYS = 20;
const int EMP_RATE_PER_HOUR = 20;
const int MAX_HRS_IN_MONTH = 100;
int empHrs;
int totalEmpHrs = 0;
int totalWorkingDays = 0;
int totalEmpWage;
while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
{
    totalWorkingDays++;
    Random random = new Random();
    int empCheck = random.Next(0, 3);
    switch (empCheck)
    {
        case IS_FULL_TIME:
            empHrs = 8;
            break;
        case IS_PART_TIME:
            empHrs = 4;
            break;
        default:
            empHrs = 0;
            break;
    }
    totalEmpHrs += empHrs;
    Console.WriteLine("Day: " + totalWorkingDays + " Emp Hrs: " +empHrs);
}
totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
Console.WriteLine("Total Emp Wage: " + totalEmpWage);
=======
﻿int IS_FULL_TIME = 1; // the value 1 is assign to variable IS_FULL_TIME 
Random random = new Random(); //creating a Random class object to call the methods inside this class
int empCheck = random.Next(0, 2); //using random.Next method we are generating random values 0 or 1
if (empCheck == IS_FULL_TIME) // In if condition, we are checking whether empCheck value is equals to IS_FULL_TIME value
{
    Console.WriteLine("Employee is Present"); //if condition becomes true then "Employee is present" is display
}
else // if the condition becomes false then it comes to else part and displays "Employee is absent"
{
    Console.WriteLine("Employee is Absent");
}
>>>>>>> UC-1-CheckAttendance
