using EmpWageComputationProblem;

EmpWageBuilder empWageBuilder = new EmpWageBuilder(); // creating a object of EmpWageBuilder class to access methods
empWageBuilder.addCompanyEmpWage("Bridgelabz", 25, 25, 120);
empWageBuilder.addCompanyEmpWage("Reliance", 20, 20, 130);
empWageBuilder.addCompanyEmpWage("ABC", 30, 20, 150);
empWageBuilder.computeEmpWage();
