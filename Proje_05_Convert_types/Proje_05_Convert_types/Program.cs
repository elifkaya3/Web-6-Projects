using System;

namespace Proje_05_Convert_types
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        Console.Write("Adınızı giriniz:");
                        string ad = Console.ReadLine();
                        Console.WriteLine($"Merhaba {ad}, hoşgeldin");*/
            /*
                        Console.Write("Bir sayı giriniz:");
                        int sayi = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(sayi*sayi);*/

            ///klavyeden iki syaı al topla  ///dönüştürme convert

            Console.Write("Lütfen 1. sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen 2. sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(sayi1+ sayi2);

            Console.ReadLine( );
 
           
            ///short s1 = 258;
            ///byte b1 = (byte)s1;
            ///Console.WriteLine($"<s1-short:{ s1}===> b1-byte:{ b1}");
            ///Console.ReadLine();
            
            ///alan hesabını farklı dönüştür yap parse

            Console.WriteLine("1. keanrın uzunluğnu girin:");
            int kenar1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2. keanrın uzunluğnu girin:");
            int kenar2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"girdiğiniz değerlere göre alan : {kenar1*kenar2}");
            Console.ReadLine();
        }
    }
}
