using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi1 = 20; //ref keywordu kullanılırken metoddaki atanan değer gösterilir
            int sayi2 = 85; //number 2 değeri atanmadığı zaman buradaki değeri alır

            var result1 = Refkullanimi(ref sayi1, ref sayi2);
            Console.WriteLine(result1);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Ref keyword kullanımı :" + sayi1);
            Console.WriteLine("--------------------------------------");

            int sayi3 = 35; //out keywordu çalışırken ise number3 değeri aşağıda belirlediği için  buradaki değeri önemli değil
            int sayi4 = 95; //out kullandığımız için buradaki değeri önemli değil

            var result2 = AddOut(out sayi3, out sayi4);
            Console.WriteLine(result2);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Out keyword kullanımı :" + sayi3);

        }
        static int Refkullanimi(ref int sayi1, ref int sayi2)
        {
            sayi1 = 55;
            return sayi1 - sayi2;
        }
        static int AddOut(out int sayi3, out int sayi4)
        {
            sayi3 = 30;
            sayi4 = 6;
            return sayi3 / sayi4;
        }
    }
}
