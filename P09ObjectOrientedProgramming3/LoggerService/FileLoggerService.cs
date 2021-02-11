using System;
using System.Collections.Generic;
using System.Text;

namespace P09ObjectOrientedProgramming3
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}