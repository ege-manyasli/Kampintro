using System;

namespace KodlamaİoOdev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Urunler urun1 = new Urunler();
            urun1.UrunAdi = "Mouse";
            urun1.UrunAdedi = "12";
            urun1.UrunFiyati = "129";
            urun1.UrunID = 85386;

            Urunler urun2 = new Urunler();
            urun2.UrunAdi = "Monitör";
            urun2.UrunAdedi = "85";
            urun2.UrunFiyati = "7852";
            urun2.UrunID = 85782;

            Urunler urun3 = new Urunler();
            urun3.UrunAdi = "Bilgisayar";
            urun3.UrunAdedi = "36";
            urun3.UrunFiyati = "17029";
            urun3.UrunID = 85358;

            Urunler urun4 = new Urunler();
            urun4.UrunAdi = "Klavye";
            urun4.UrunAdedi = "865";
            urun4.UrunFiyati = "980";
            urun4.UrunID = 86514;

            Urunler[] urunler = new Urunler[] { urun1, urun2, urun3, urun4 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + " : " + urun.UrunAdedi + " Adet : " + urun.UrunFiyati + " TRY : " + urun.UrunID + "  ID Numarası");
            }
        }
        class Urunler
        {
            public string UrunAdi { get; set; }
            public string UrunFiyati { get; set; }
            public string UrunAdedi { get; set; }
            public int UrunID { get; set; }
        }
    }
}







        