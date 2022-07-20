int IS_FULL_TIME = 1; // value 1 is assign to IS_FULL_TIME variable
int EMP_RATE_PER_HOUR = 20; // value 20 is assign to EMP_RATE_PER_HOUR
int empHrs = 0; //initalizing the empHrs to 0
int empWage = 0; //initializing the empWage to 0
Random random = new Random(); // creating the Random class object
int empCheck = random.Next(0, 2); // using random.Next to generate random value 0 or 1
if (empCheck == IS_FULL_TIME) // In this if both values are same the the empHrs value is set to 8
{
    empHrs = 8;
}
else // if the above condition becomes false then empHrs is set to 0
{
    empHrs = 0;
}
empWage = empHrs * EMP_RATE_PER_HOUR; // calculating the that day empWage
Console.WriteLine("Emp Wage: " + empWage); // displaying the calculated empWage