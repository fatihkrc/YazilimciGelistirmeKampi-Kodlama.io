using System;
using System.Collections.Generic;
using System.Text;

namespace P09ObjectOrientedProgramming3
{
    class VehicleLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("\nTaşıt kredisi miktarı hesaplandı.");
        }

        public void Control()
        {
            Console.WriteLine("Sonuç : Taşıt kredisi kriterlerini sağlamaktadır.");
        }
    }
}
