using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.İzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "React";
            kurs2.Egitmen = "Ege Manyaslı";
            kurs2.İzlenmeOranı = 78;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Kerem Varış";
            kurs3.İzlenmeOranı = 89;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Berke Bezek";
            kurs4.İzlenmeOranı = 100;


            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " : %" + kurs.İzlenmeOranı);

            }


            //Console.WriteLine("Hello World");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOranı { get; set; }
    }
}
