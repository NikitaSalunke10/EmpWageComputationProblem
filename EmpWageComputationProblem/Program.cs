const int IS_PART_TIME = 1;
const int IS_FULL_TIME = 2;
const int NUM_OF_WORKING_DAYS = 20;
const int EMP_RATE_PER_HOUR = 20;
int empHrs = 0;
int empWage = 0;
int totalEmpWage = 0;
Random random = new Random();
for (int day = 1; day <= NUM_OF_WORKING_DAYS; day++)
{
    int empCheck = random.Next(0, 3);
    switch (empCheck)
    {
        case IS_PART_TIME:
            empHrs = 4;
            break;
        case IS_FULL_TIME:
            empHrs = 8;
            break;
        default:
            empHrs = 0;
            break;
    }
    empWage = empHrs * EMP_RATE_PER_HOUR;
    totalEmpWage += empWage;
    Console.WriteLine("Day "+day+" Emp Wage: " + empWage);
}
Console.WriteLine("Total Emp Wage: " + totalEmpWage);