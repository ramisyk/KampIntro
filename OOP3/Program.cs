using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsumerCreditManager consumerCreditManager = new ConsumerCreditManager();
            //consumerCreditManager.Calculate();

            VehicleCreditManager vehicleCreditManager = new VehicleCreditManager();
            //vehicleCreditManager.Calculate();

            MortgageCreditManager mortgageCreditManager = new MortgageCreditManager();
            //mortgageCreditManager.Calculate();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(consumerCreditManager);

            List<ICreditManager> credits = new List<ICreditManager>() { consumerCreditManager, vehicleCreditManager };
            basvuruManager.KrediOnBilgilendirmesiYap(credits);
        }
    }
}
