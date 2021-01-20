using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //BU CLASS TA İŞLEMLER/METODLAR GERÇEKLEŞİR.
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+" eklendi.");
        }
        public void Upddate(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}
        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2);        }
    }
}
