using System;
using System.Collections.Generic;
using System.Text;

namespace P08ObjectOrientedProgramming2
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer Added. (Customer Number = {0})", customer.CustomerNumber);
        }
    }
}
