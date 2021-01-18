using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Phyton";
            string kurs2 = "C#";
            string kurs3 = "C++";
            string kurs4 = "Java";

            //Yukaırdakilerin hepsini tek bir arrayde yapalım.

            string[] kurslar = new string[] { kurs1, "C#", kurs3, kurs4 };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti.");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
