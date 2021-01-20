using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //void: işlem yapacak ancak sonucunda bir bilgiye ihtiyaç duymayan olaylarda (değer döndürmeyen)
        public void Add(Product product) 
        {
            Console.WriteLine("Ürün eklendi : " + product.ProductName);
        }
        public void Update(Product product)
        {
            Console.WriteLine("Ürün güncellendi : " + product.ProductName);
        }
    }
}
