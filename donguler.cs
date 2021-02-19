using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string IlkUrun = "Çiçek buketi";
            string IkinciUrun = "Krem";
            string UçuncuUrun = "Tablo";
            string[] Urunler = new string[] {
            IlkUrun, IkinciUrun, UçuncuUrun
            };
            int i;
            for (i = 0; i < Urunler.Length; i++)
            {
                Console.WriteLine(Urunler[i]);
            }

            Console.WriteLine("\nWhile döngüsüne göre listelenmesi:");
            int a = 0;
            while (a < Urunler.Length)
            {
                Console.WriteLine(Urunler[a]);
                a++;
            }
            //Farkların anlaşılması açısından farklı ürünler kullanacağım foreach'te.
            Console.WriteLine("\nForeach döngüsüne göre listelenmesi:");

            Product urun1 = new Product();
            urun1.adi = "kalem";
            urun1.marka = "FaberCastell";
            urun1.fiyat = 30;
            Product urun2 = new Product();
            urun2.adi = "Defter";
            urun2.marka = "Mopak";
            urun2.fiyat = 15;
            Product[] urunler = new Product[] { urun1, urun2 };
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun1.adi + " " + urun1.marka + " " + urun1.fiyat + " " + urun2.adi + " " + urun2.marka + " " + urun2.fiyat);
            } //Burada ürünlerin özelliklerini yani adını,markasını,fiyatını yazar.
        }
        class Product
        {
            public int fiyat { get; set; }
            public string adi { get; set; }
            public string marka { get; set; }
        }
    }
}
