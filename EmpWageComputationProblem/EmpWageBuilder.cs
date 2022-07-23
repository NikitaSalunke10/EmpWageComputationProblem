using System;
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

        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

        public EmpWageBuilder()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>(); // Linkedlist object is created of type CompanyEmpWage 
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>(); //Dictionay class object created 
        }
        //addCompanyEmpWage method receive values for different parameters when method is called from Program.cs
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            //storing the received values of multiple parameters of multiple companies in companyEmpWage array
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            this.companyEmpWageList.AddLast(companyEmpWage); // adding the values at last node in linked list
            this.companyToEmpWageMap.Add(company, companyEmpWage); // adding the key and value in dictionary
        }
        public void computeEmpWage() //this method is used to call setTotalEmpWage method to store the value of totalEmpWage of multiple company
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList) //using foreach loop to for accessing values one by one
            {
                companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));//inside setTotalEmpWage method, the computeEmpWage method is called
                Console.WriteLine(companyEmpWage.toString());// calls toString method for each company to display totalEmpWage
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage) // this method is used to calulate the total Emp Wage
        {
            int empHrs; 
            int totalEmpHrs = 0; 
            int totalWorkingDays = 0;
            int empWage = 0, totalEmpWage = 0 ;
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
                empWage = empHrs * companyEmpWage.empRatePerHour; // calculating daily wage
                totalEmpWage += empWage; // adding the daily empWage to get the totalEmpWage
                Console.WriteLine("Day: " + totalWorkingDays + " Emp Hrs: " + empHrs+ " Emp Wage: "+empWage); 
            }
            return totalEmpWage;  
        }
        public int getTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmpWage;
        }
    }
}

