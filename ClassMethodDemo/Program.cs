using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Aslı";
            musteri1.Soyadi = "K";
            musteri1.TCNo = 10000000000;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Kasım";
            musteri2.Soyadi = "H";
            musteri2.TCNo = 10000000001;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Sultan Ebrar";
            musteri3.Soyadi = "Güzel";
            musteri3.TCNo = 10000000003;



            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 ,musteri3};

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + ":" + musteri.TCNo);
            }

            MusteriManager musteriManager= new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

        }
    }
}
