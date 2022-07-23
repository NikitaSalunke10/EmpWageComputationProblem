using EmpWageComputationProblem;

EmpWageBuilder empWageBuilder = new EmpWageBuilder(); 
empWageBuilder.addCompanyEmpWage("Bridgelabz", 25, 25, 120);
empWageBuilder.addCompanyEmpWage("Reliance", 20, 20, 130);
empWageBuilder.addCompanyEmpWage("ABC", 30, 20, 150);
empWageBuilder.computeEmpWage();
Console.WriteLine("--------------------------------------------------------");
Console.WriteLine("Total Wage for Reliance company is : "+empWageBuilder.getTotalWage("Reliance"));