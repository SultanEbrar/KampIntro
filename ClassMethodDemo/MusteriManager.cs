using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Kişi bilgileri oluşturuldu:" + musteri.Adi+" "+musteri.Soyadi);
        }
       
    }
}
