using System;

namespace Marketing3ComingSooN
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Karpuz";
            urun1.UrunFiyati = 15.5;
            urun1.UrunAciklamasi = "Diyarbakır Karpuzu";

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Şeftali";
            urun2.UrunFiyati = 8.5;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Elma";
            urun3.UrunFiyati = 7.5;
                
            string[] meyveler = new string[] { };
            Urun[] urunler = new Urun[] { urun1,urun2,urun3 };

            foreach (var Urun in urunler)
            {
                Console.WriteLine(Urun.UrunAdi);
                Console.WriteLine(Urun.UrunFiyati);
                Console.WriteLine(Urun.UrunAciklamasi);
            }
            SepetMeneger sepetMeneger = new SepetMeneger();
            Console.WriteLine(urun1);
            Console.WriteLine(urun2);
            Console.WriteLine(urun3);
        }
    }
}
