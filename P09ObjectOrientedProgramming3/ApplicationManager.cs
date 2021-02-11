using System;
using System.Collections.Generic;
using System.Text;

namespace P09ObjectOrientedProgramming3
{
    class ApplicationManager
    {
        public void Apply(ILoanManager loanManager, List<ILoggerService> loggerServices)
        {
            loanManager.Calculate();

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void LoanPreInformation(List<ILoanManager> loans)
        {
            foreach (var loan in loans)
            {
                loan.Calculate();
            }
        }
    }
}
