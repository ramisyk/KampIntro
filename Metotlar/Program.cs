using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            SepetManager manager = new SepetManager();

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);            
                manager.Ekle(urun);

                Console.WriteLine("-----------------------------");
            }
            Console.WriteLine("Welcome to MANAV. Ne vereyim ablama :D");

        }
    }
}
//Don't Repeat Yourself - DRY