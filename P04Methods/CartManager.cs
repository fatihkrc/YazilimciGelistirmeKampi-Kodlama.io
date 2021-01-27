using System;
using System.Collections.Generic;
using System.Text;

namespace P04Methods
{
    class CartManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("'" + product.Name + "'" + " adlı ürün sepete eklendi.");
        }
    }
}
