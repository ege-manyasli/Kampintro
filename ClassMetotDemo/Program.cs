using ClassMetotDemo;
using System;

namespace ClasssMethotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            { 
                musteri1.Ad = "Ege";
                musteri1.Soyadı = "Manyasli";
                musteri1.TC = 2;
                musteri1.TelefonNumarasi = 05437262738;
                musteri1.DogumYeri = "Bandırma";
            }
            Musteri musteri2 = new Musteri();
            {
                musteri2.Ad = "Melih";
                musteri2.Soyadı = "Guner";
                musteri2.TC = 2;
                musteri2.TelefonNumarasi = 05462853689;
                musteri2.DogumYeri = "Bnadırma";
                
            }
            Musteri musteri3 = new Musteri();
            {              
                musteri3.Ad = "Barkın";
                musteri3.Soyadı = "Yıldız";
                musteri3.TC = 3;
                musteri3.TelefonNumarasi = 05438264823;
                musteri3.DogumYeri = "İstanbul";
            }

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            // Listeleme 
            Console.WriteLine("Müşteri Listesi:\n");
            musteriManager.MusteriListele(musteri1);
            musteriManager.MusteriListele(musteri2);
            musteriManager.MusteriListele(musteri3);
            

            // Ekleme
            Console.WriteLine("Müşteri Ekleme:\n");
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            

            // Silme
            Console.WriteLine("Müşteri Silindi:\n");
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriSil(musteri3);


            Console.ReadLine();

        }
    }
}
