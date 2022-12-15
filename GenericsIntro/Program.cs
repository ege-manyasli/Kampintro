using System;
using System.Security.Cryptography.X509Certificates;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Ege");

        }
    }
}