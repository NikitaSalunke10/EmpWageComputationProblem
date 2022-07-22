using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputationProblem
{
    public interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string company, int empRatePerHr, int numOfWorkingDays, int maxHrsPerMonth);
        public void computeEmpWage();
    }
}
