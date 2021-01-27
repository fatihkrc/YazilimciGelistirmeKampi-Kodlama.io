using System;

namespace P04Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product
            {
                Id = 1,
                Name = "Karpuz",
                KgPrice = 1.50,
                Explanation = "Diyarbakır Karpuzu"
            };

            Product product2 = new Product
            {
                Id = 2,
                Name = "Elma",
                KgPrice = 3,
                Explanation = "Amasya Elması"
            };

            Product product3 = new Product
            {
                Id = 3,
                Name = "Muz",
                KgPrice = 7,
                Explanation = "Anamur Muzu"
            };

            Product[] fruits = new Product[] {product1, product2, product3};

            foreach (var fruit in fruits)
            {
                Console.WriteLine("----- {0} -----", fruit.Name.ToUpper());
                Console.WriteLine("Fiyatı : {0} TL / kg", fruit.KgPrice);
                Console.WriteLine("Açıklama : {0}\n", fruit.Explanation);
            }

            Console.WriteLine("\n\n<<<<<<<<< METHODS >>>>>>>>>\n");

            CartManager cartManager = new CartManager();

            Console.WriteLine("----- Add -----");
            cartManager.Add(product3);
            cartManager.Add(product1);
        }
    }
}
