int IS_PART_TIME = 1; //value 1 is assign to IS_FULL_TIME variable
int IS_FULL_TIME = 2; //value 2 is assign to IS_PART_TIME variable
int EMP_RATE_PER_HOUR = 20;// value 20 is assign to EMP_RATE_PER_HOUR
int empHrs = 0;//initalizing the empHrs to 0
int empWage = 0; //initalizing the empWage to 0
Random random = new Random();// creating the Random class object
int empCheck = random.Next(0, 3); // using random.Next to generate random value between 0 to 2
if (empCheck == IS_FULL_TIME) // In this if both values are same the the empHrs value is set to 8
{
    empHrs = 8;
}
else if (empCheck == IS_PART_TIME) // In this if both values are same the the empHrs value is set to 4
{
    empHrs = 4;
}
else // if both the above condition becomes false then empHrs is set to 0
{
    empHrs = 0;
}
empWage = empHrs * EMP_RATE_PER_HOUR; // calculating the that day empWage
Console.WriteLine("Emp Wage: " + empWage); // displaying the calculated empWage