using System;
using System.Collections.Generic;

namespace P09ObjectOrientedProgramming3
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoanManager mortgageLoanManager = new MortgageLoanManager();

            ILoanManager vehicleLoanManager = new VehicleLoanManager();

            ILoanManager personalLoanManager = new PersonalLoanManager();

            List<ILoggerService> loggerServices1 = new List<ILoggerService>() { new DatabaseLoggerService(), new FileLoggerService() };

            List<ILoggerService> loggerServices2 = new List<ILoggerService>() { new FileLoggerService() };

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(vehicleLoanManager, loggerServices1);
            applicationManager.Apply(mortgageLoanManager, loggerServices2);
            applicationManager.Apply(personalLoanManager, loggerServices1);

            List<ILoanManager> loans = new List<ILoanManager>() { vehicleLoanManager, personalLoanManager };

            //applicationManager.LoanPreInformation(loans);
        }
    }
}
