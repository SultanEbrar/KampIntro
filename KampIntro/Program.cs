using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //DO NOT REPEAT YOURSELF!!!
            
            string kategoriEtiketi = "Kategoriler";
            double faizOrani = 1.45;
            bool sistemeGirişYapildiMi = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.50;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else if (dolarDun < dolarBugun) 
            {
                Console.WriteLine("Artış oku");
            }
            else
            {
                Console.WriteLine("Değişmedi Oku");
            }
            if (sistemeGirişYapildiMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");

            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
