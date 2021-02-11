using System;

namespace P08ObjectOrientedProgramming2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer indCustomer1 = new IndividualCustomer
            {
                CustomerNumber = "141516",
                CitizenIdNumber = "12345678901",
                FirstName = "Fatih",
                LastName = "Karaca"
            };

            CorporateCustomer corCustomer1 = new CorporateCustomer
            {
                CustomerNumber = "141517",
                TaxNumber = "145050012",
                CompanyName = "Salacak Teknoloji"
            };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(indCustomer1);
            customerManager.Add(corCustomer1);
        }
    }
}
