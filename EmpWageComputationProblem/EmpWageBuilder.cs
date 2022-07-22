﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpWageComputationProblem;
namespace EmpWageComputationProblem
{
    internal class EmpWageBuilder : IComputeEmpWage
    {
        const int IS_PART_TIME = 1; //declared and value 1 is assign to IS_PART_TIME variable
        const int IS_FULL_TIME = 2; //declared and value 2 is assign to IS_FULL_TIME variable

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWage;// declaring a array of CompanyEmpWage

        public EmpWageBuilder()
        {
            this.companyEmpWage = new CompanyEmpWage[3]; // assigned the arraysize to CompanyEmpWage array 
        }
        //addCompanyEmpWage method receive values for different parameters when method is called from Program.cs
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            //storing the received values of multiple parameters of multiple companies in companyEmpWage array
            companyEmpWage[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }
        public void computeEmpWage() //this method is used to call setTotalEmpWage method to store the value of totalEmpWage of multiple company
        {
            for(int i = 0; i < numOfCompany; i++)//for loop is used to store the calculated value for multiple companies
            {
                companyEmpWage[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWage[i])); //inside setTotalEmpWage method, the computeEmpWage method is called
                Console.WriteLine(this.companyEmpWage[i].toString());// calls toString method for each company to display totalEmpWage
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage) // this method is used to calulate the total Emp Wage
        {
            int empHrs; 
            int totalEmpHrs = 0; 
            int totalWorkingDays = 0; 
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays) //through while loop we are calculating daily empWage till the condition is true
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
                Console.WriteLine("Day: " + totalWorkingDays + " Emp Hrs: " + empHrs); //displaying for which day how many empHrs were there
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour; // with this formula we get the totalEmpWage 
        }
        
    }
}
