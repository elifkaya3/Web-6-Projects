using System;

namespace Proje_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //[VeriTipi] [İsim];
            //[VeriTipi] [İsim]=[ilkdeğer]

            string adSoyad;
            adSoyad = "elifkkk";
            Console.WriteLine(adSoyad);

            int yas = 22;
            Console.WriteLine(yas);

            int hour = DateTime.Now.Hour;
            int year = DateTime.Today.Year;
            Console.WriteLine(year +" "+ hour);

            //merhaba [adSoyad],günün güzel geçsin
            Console.WriteLine("Merhaba " + adSoyad + ", günün güzel geçsin");
            Console.WriteLine($"merhaba {adSoyad},günün güzel geçsin");

            Console.ReadLine();

        }

    }
}
