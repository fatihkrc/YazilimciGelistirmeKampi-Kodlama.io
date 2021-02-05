using System;

namespace P07GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Fatih");
            names.Add("Yakup");
            names.Add("Dilber");
            names.Add("Abdullah Hilmi");
            names.Add("Melek");

            Console.WriteLine("Liste Eleman Sayısı : {0}", names.Length);

            foreach (var item in names.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
