using System;
using System.Collections.Generic;
using System.Text;

namespace P09ObjectOrientedProgramming3
{
    class MortgageLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("\nKonut kredisi miktarı hesaplandı.");
        }

        public void Control()
        {
            Console.WriteLine("Sonuç : Konut kredisi kriterlerini sağlamaktadır.");
        }
    }
}
