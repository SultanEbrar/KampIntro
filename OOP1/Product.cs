
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        //BU CLASS ÜRÜNÜN BİLİGİLERİNİ İSTER.
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; } //urun fiyatı
        public int UnitInStock { get; set; } //stok adedi

    }
}
