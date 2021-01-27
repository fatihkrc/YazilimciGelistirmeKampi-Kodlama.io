using System;

namespace P02Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 138; i += 3)
            {
                Console.Write("{0,-4}", i);

                if (i % 10 >= 7)
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}
