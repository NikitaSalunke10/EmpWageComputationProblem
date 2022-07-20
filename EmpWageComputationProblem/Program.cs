using EmpWageComputationProblem;

ComputeEmpWage empWage = new ComputeEmpWage(); // creating a object of ComputeEmpWage class to access methods
int totalEmpWage = empWage.calculateEmpWage(); // using object we are calling the method calculateEmpWage and storing the returned value in variable
Console.WriteLine("Total Emp Wage: " + totalEmpWage); // displaying the totalEmpwage