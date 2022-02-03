using System;

namespace Proje_08_For
{
    class Program
    {
        static void Main(string[] args)
        {
            /* for (int i = 0; i < 5; i++)
             {
                 Console.WriteLine($"hello world - {i+1}");
             }
             Console.ReadLine();*/
            //1 ile 10 arasındaki sayıları yaz toplamını yazdır

            /*
            int toplam=0 ;
            int i = 0;
            for ( i = 1; i <= 10; i++)
            {
                toplam += i;
                Console.WriteLine(i);
            }
            Console.WriteLine(toplam);
            Console.ReadLine();
*//*
            int toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    toplam += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(toplam);
            Console.ReadLine();*/


            //1 ile 100 arasındaki asal sayıları bulup listele
            /*bool asalSayi = (true);
            for (int i = 2; i < 100; i++)//asal mı değil mi kontrol listesi
            {
                for (int j=2; j<i ;j++)//bölünme kuralını kontrol etmek için
                {
                    if (i % j == 0 )
                    {
                        asalSayi = false;
                        break;
                    }


                }
                if (asalSayi)
                {
                    Console.WriteLine(i);

                }

                asalSayi = true;
            }
            Console.ReadLine();*/

            //1-100 arası 5 ve 7 nin katı olmayan syaıları yazdırın
            /*
                        for (int i = 1; i < 100; i++)
                        {
                            if (i%5!=0 && i%7!=0)
                            {
                                Console.WriteLine(i);

                            }
                        }
                        Console.ReadLine();*/
            //5*5 lik yıldız çizdir


            /* for (int i = 1; i <= 5; i++)
             {

                 for (int j=1; j<=5; j++)
                 {
                     Console.Write("*");

                 }
                 Console.WriteLine();
             }
             Console.ReadLine();*/

            //çarpım tablosu
            /*for (int i = 1; i <= 10; i++)
            {

                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j}\t");

                }
                Console.WriteLine();
            }
            Console.ReadLine();*/

            //klavyeden girilecek 3 adet sayıdan en büyük olanını bulup ekrana yazdır
            /* Console.WriteLine(@"1. sayıyı giriniz:
 2. sayıyı giriniz:
 3. sayıyı giriniz:");

             int sayi1 = int.Parse(Console.ReadLine());
             int sayi2 = int.Parse(Console.ReadLine());
             int sayi3 = int.Parse(Console.ReadLine());
             int sayi = 0;



                 if (sayi1>sayi2 && sayi1>sayi3)
                 {
                     Console.WriteLine("sayi 1 büyüktür");
                 }
                 else if(sayi2>sayi1 && sayi2>sayi3 ) 
                 if (sayi2>sayi3)
                 {
                     Console.WriteLine("sayi 2 büyüktür");
                 }
                 else 
                 {
                     Console.WriteLine("sayı 3 büyüktür");
                 }
             Console.ReadLine();*/

            int enBuyuk = 0;
            int sayi;
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"{i}. sayıyı gir: ");
                sayi = int.Parse(Console.ReadLine());
                if (sayi>enBuyuk)
                {
                    enBuyuk = sayi;

                }
            }
            Console.WriteLine($"EN buyuk sayı {enBuyuk}");
            Console.ReadLine();



        }

    }
}
