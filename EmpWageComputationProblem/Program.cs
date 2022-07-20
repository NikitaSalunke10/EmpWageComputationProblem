const int IS_PART_TIME = 1; //value 1 is assign to IS_FULL_TIME variable
const int IS_FULL_TIME = 2; //value 2 is assign to IS_PART_TIME variable
const int NUM_OF_WORKING_DAYS = 20; // value 20 is assign to NUM_OF_WORKING_DAYS
const int EMP_RATE_PER_HOUR = 20; // value 20 is assign to EMP_RATE_PER_HOUR
int empHrs = 0; //initalizing the empHrs to 0
int empWage = 0; //initalizing the empWage to 0
int totalEmpWage = 0; //initalizing the totalEmpWage to 0
Random random = new Random(); // creating the Random class object
for (int day = 1; day <= NUM_OF_WORKING_DAYS; day++) // through for loop we are calculating daily empWage till the condition is true
{
    int empCheck = random.Next(0, 3); // using random.Next to generate random value between 0 to 2
    switch (empCheck)
    {
        case IS_PART_TIME: // In this case, IS_PART_TIME value is check whether it matches with empCheck or not
            empHrs = 4;// if the case matches then empHrs is set to 4
            break;
        case IS_FULL_TIME:// In this case, IS_FULL_TIME value is check whether it matches with empCheck or not
            empHrs = 8; // if the case matches then empHrs is set to 8
            break;
        default: // If both the cases are not match then it comes to default case and empHrs is set to 0
            empHrs = 0;
            break;
    }
    empWage = empHrs * EMP_RATE_PER_HOUR; // calculating daily empWage
    totalEmpWage += empWage; // adding the daily wage to get the totalEmpWage of 20 Working days 
    Console.WriteLine("Day "+day+" Emp Wage: " + empWage); //displaying for which day how much empWage is
}
Console.WriteLine("Total Emp Wage: " + totalEmpWage); // displaying the totalEmpwage