using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputationProblem
{
    internal class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;
        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth) // constructor is used to assign values
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void setTotalEmpWage(int totalEmpWage) // this methods is used to assign totalempwage value received from EmpWageBuilder class to totalEmpWage of CompanyEmpWage class 
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString() // this method is used the display the totalempwage for each company 
        {
            return "Total Emp Wage for Company: " + this.company + " is: " + this.totalEmpWage;
        }
    }
}
