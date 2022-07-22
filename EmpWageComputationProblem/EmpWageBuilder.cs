using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputationProblem
{
    internal class EmpWageBuilder
    {
        const int IS_PART_TIME = 1; //declared and value 1 is assign to IS_PART_TIME variable
        const int IS_FULL_TIME = 2; //declared and value 2 is assign to IS_FULL_TIME variable

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public EmpWageBuilder(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth) // constructor is used to assign values
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void calculateEmpWage() // this method is used to calulate the total Emp Wage
        {
            int empHrs; 
            int totalEmpHrs = 0; 
            int totalWorkingDays = 0; 
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays) //through while loop we are calculating daily empWage till the condition is true
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
            totalEmpWage = totalEmpHrs * this.empRatePerHour; // with this formula we get the totalEmpWage 
        }
        public string toString() // this method is used the display the totalempwage for each company 
        {
            return "Total Emp Wage for Company: " + this.company + " is: " + this.totalEmpWage;
        }
    }
}
