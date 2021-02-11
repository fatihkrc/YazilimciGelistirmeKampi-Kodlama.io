using System;
using System.Collections.Generic;
using System.Text;

namespace P09ObjectOrientedProgramming3
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı.");
        }
    }
}
