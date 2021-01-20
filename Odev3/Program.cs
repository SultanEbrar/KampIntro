using System;

namespace Odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 30; //ref kullanımında buraya değer atamamız gerekiyor.
            int sayi2 = 10;

            int sayi3; //out kullamında buraya değer ataması yapmayız ancak aşağıdaki metot kısmında return yapmadan önce değer atamamız gerekiyor.
            int sayi4; 

            var result = Add(ref sayi1, sayi2);
            Console.WriteLine(result);

            

            var result2 = Multiply(out sayi3,out sayi4); //iki sayıya da değer atamazsak eğer ikisinin başına da out koyamamız gerekiyor.
            Console.WriteLine(result2);
            
        }
        static  int Add(ref int sayi1,int sayi2)
        {
            return sayi1 + sayi2;

        }
        static int Multiply(out int sayi3,out int sayi4)
        {
            sayi3 = 30;
            sayi4 = 5;
            return sayi3 * sayi4;
        }
    }
}
