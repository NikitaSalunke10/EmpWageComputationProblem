int IS_FULL_TIME = 1; // the value 1 is assign to variable IS_FULL_TIME 
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