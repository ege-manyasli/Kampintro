using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("\n");
            Console.WriteLine(musteri.Ad + "-" + musteri.Soyad + " ----->  " + "İsimli Müşteri Listelendi");
            Console.WriteLine("TC: " + musteri.TC);
            Console.WriteLine("Doğum Yeri: " + musteri.DogumYeri);
            Console.WriteLine("Telefon Numarası: " + musteri.TelefonNumarasi);
            Console.WriteLine("\n");
        }

        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("\n");
            Console.WriteLine(musteri.Ad + "-" + musteri.Soyad + " ----->  " + "İsimli Müşteri Eklendi");
            Console.WriteLine("TC: " + musteri.TC);
            Console.WriteLine("Doğum Yeri: " + musteri.DogumYeri);
            Console.WriteLine("Telefon Numarası: " + musteri.TelefonNumarasi);
            Console.WriteLine("\n");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("\n");
            Console.WriteLine(musteri.Ad + "-" + musteri.Soyad + " ----->  " + "İsimli Müşteri Silindi");
            Console.WriteLine("TC: " + musteri.TC);
            Console.WriteLine("Doğum Yeri: " + musteri.DogumYeri);
            Console.WriteLine("Telefon Numarası: " + musteri.TelefonNumarasi);
            Console.WriteLine("\n");
        }



    }
}
