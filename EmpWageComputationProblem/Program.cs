const int IS_PART_TIME = 1; //declared and value 1 is assign to IS_PART_TIME variable
const int IS_FULL_TIME = 2; //declared and value 2 is assign to IS_FULL_TIME variable
const int NUM_OF_WORKING_DAYS = 20; //declared and value 20 is assign to NUM_OF_WORKING_DAYS
const int EMP_RATE_PER_HOUR = 20; //declared and value 20 is assign to EMP_RATE_PER_HOUR
const int MAX_HRS_IN_MONTH = 100; //declared and value 100 is assign to MAX_HRS_IN_MONTH
int empHrs; //declared and initalizing the empHrs to 0
int totalEmpHrs = 0; //declared and initalizing the totalEmpHrs to 0
int totalWorkingDays = 0; //declared and initalizing the totalWorkingDays to 0
int totalEmpWage; //declared the totalEmpWage variable
while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS) //through while loop we are calculating daily empWage till the condition is true
{
    totalWorkingDays++; // incrementing the totalWorkingDays variable by one
    Random random = new Random(); // creating the Random class object
    int empCheck = random.Next(0, 3); // using random.Next to generate random value between 0 to 2
    switch (empCheck)
    {
        case IS_FULL_TIME: // In this case, IS_FULL_TIME value is check whether it matches with empCheck or not
            empHrs = 8; // if the case matches then empHrs is set to 8
            break;
        case IS_PART_TIME: // In this case, IS_PART_TIME value is check whether it matches with empCheck or not
            empHrs = 4; // if the case matches then empHrs is set to 4
            break;
        default: // If both the cases are not match then it comes to default case and empHrs is set to 0
            empHrs = 0;
            break;
    }
    totalEmpHrs += empHrs; // adding the empHrs to get the totalEmpHrs 
    Console.WriteLine("Day: " + totalWorkingDays + " Emp Hrs: " +empHrs); //displaying for which day how many empHrs were there
}
totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR; // with this formula we get the totalEmpWage 
Console.WriteLine("Total Emp Wage: " + totalEmpWage); // displaying the totalEmpwage