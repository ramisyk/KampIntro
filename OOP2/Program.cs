using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer1 = new Customer();
            //customer1.Name = "Ramis";
            //customer1.Surame = "Yüksel";
            //customer1.Id = 1;
            //customer1.TcNo = "12312312312";
            //customer1.CustomerNumber = "123";
            //customer1.CompanyName = "?";

            //Gerçek - Tüzel -> birbirlerine benzemelerine rağmen birbirleri yerine kullanılamazlar
            //soLid : birbirlerinin yerine kullanma inheritence ı farklı şekilde yap

            GercekMusteri customer1 = new GercekMusteri();
            customer1.Name = "Ramis";
            customer1.Surame = "Yüksel";
            customer1.Id = 1;
            customer1.TcNo = "12312312312";
            customer1.CustomerNumber = "123";

            Corporate customer2 = new Corporate();
            customer2.Id = 2;
            customer2.CustomerNumber = "456";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxId = "123123123";

            Customer customer3 = new GercekMusteri();
            Customer customer4 = new Corporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}
