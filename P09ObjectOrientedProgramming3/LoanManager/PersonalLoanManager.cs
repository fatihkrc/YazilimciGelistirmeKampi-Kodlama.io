using System;
using System.Collections.Generic;
using System.Text;

namespace P09ObjectOrientedProgramming3.LoanManager
{
    class PersonalLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("\nİhtiyaç kredisi miktarı hesaplandı.");
        }

        public void Control()
        {
            Console.WriteLine("Sonuç : İhtiyaç kredisi kriterlerini sağlamaktadır.");
        }
    }
}
