using System;

namespace P06ObjectOrientedProgramming1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1001;
            product1.CategoryId = 14;
            product1.ProductName = "Bluetooth Hoparlör";
            product1.UnitPrice = 249.90;
            product1.StockAmount = 500;

            Product product2 = new Product
            {
                Id = 1002,
                CategoryId = 11,
                ProductName = "Daire Testere",
                UnitPrice = 859.90,
                StockAmount = 120
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product2);
        }
    }
}