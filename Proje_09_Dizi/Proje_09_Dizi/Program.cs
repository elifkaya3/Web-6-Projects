using System;

namespace Proje_09_Dizi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] firstArray = {40,80,60};
            for (int i = 0; i < 3; i++)
            {
            Console.WriteLine(firstArray[i]);
            Console.ReadLine();

            }*/

            //rastgele sayı böyle üretlir  Random rnd = new Random();
            // int rastgele = rnd.Next(1,100);

            /* Random rstgl = new Random();
             int[] sayilar=new int[10];
             for (int i = 1; i < 10; i++)
             {
                 sayilar[i]=(rstgl.Next(1,100));
             }
             *//* for (int i = 0; i < 10; i++)
              {
                  Console.WriteLine(sayilar[i]*2);
              }*//*
             foreach (var sayi in sayilar)
             {
                 Console.WriteLine(sayi);
             }
             Console.ReadLine();*/

            //programımız 1 ile 100 arasında rastgele bir sayı üretsin
            //kullanıcıdan bu sayıyı atahmin etmesini isteyelim
            //bilirse tebrik edelim bilemezse kaybettin diyelim ve bitirelim

            /* Random rnd = new Random();
             int sayi = rnd.Next(1,100);
             Console.WriteLine($"{sayi}1 ile 100 arasında bir sayı giriniz:");
             int kullaniciTahmin = int.Parse(Console.ReadLine());

               if (sayi == kullaniciTahmin)
                 {
                     Console.WriteLine("tebrikler");
                 }
                 else
                 {
                     Console.WriteLine("kaybettiniz");
                 }
            
             Console.ReadLine();*/
            /* Random rnd = new Random();
             int sayi = rnd.Next(1, 100);
             Console.WriteLine($"{sayi}--1 ile 100 arasında 5 adet sayı giriniz:");
             int girilecekSayi = 1;

             while (girilecekSayi<=5)
             {
                 Console.WriteLine($"{girilecekSayi}.sayi" );
                 int kullaniciTahmin = int.Parse(Console.ReadLine());
                 girilecekSayi++;

                 if (sayi == kullaniciTahmin)
                 {
                     Console.WriteLine("tebrikler oyun bitti");
                     break;
                 }
                 else
                 {
                     Console.WriteLine("yanlış tahmin");

                 }
             }
             Console.WriteLine("kaybettiniz!");
             Console.ReadLine();*/


            /* Random rnd = new Random();
             int sayi = rnd.Next(1, 100);
             int tahmin = 0;
             int sayac = 1;
             do
             {    Console.WriteLine($"{sayac}.sayi ");
                  tahmin = int.Parse(Console.ReadLine());
                 if (sayi!=tahmin)
                 {
                     Console.WriteLine("yanlış tahmin");
                 }

                 sayac++;
             } while (sayac<=5 && sayi!=tahmin);
             if (sayi == tahmin)
             {
                 Console.WriteLine("tebrikler");
             }
             else
             {
                 Console.WriteLine("oyun bitti");
             }
             Console.ReadLine();*/


            /*Random rnd = new Random();
            int sayi = rnd.Next(1, 100);
            Console.WriteLine($"{sayi}--1 ile 100 arasında 5 adet sayı giriniz:");
            int girilecekSayi = 0;
            
            while (girilecekSayi <= 4)
            {
                Console.WriteLine($"{girilecekSayi+1}.sayi");
                int kullaniciTahmin = int.Parse(Console.ReadLine());
                girilecekSayi++;

                if (sayi == kullaniciTahmin)
                {
                    Console.WriteLine($"{girilecekSayi}.sayi+{girilecekSayi-1 *10}");

                    Console.WriteLine("tebrikler oyun bitti");
                    break;
                }
                else
                {
                    Console.WriteLine("yanlış tahmin");
                    Console.WriteLine($"{girilecekSayi-1} hakkınız kaldı");


                }
                Console.WriteLine("kaybettiniz!");

            }
            Console.ReadLine();*/

            Random rnd = new Random();
            int sayi = rnd.Next(1, 100);
            int randomSayi = 1;
            int tahminHakki = randomSayi;
            Console.WriteLine("-> Random Değer Üretildi.\n-> Üretilen Random Değer 0 ile 100 Arasında Olabilir.");
            while (randomSayi <= 5)
            {
                Console.WriteLine($"-> {randomSayi}. Tahminin: ", (tahminHakki + 1));
                int kullaniciTahmin = int.Parse(Console.ReadLine());
                randomSayi++;
                if (sayi == kullaniciTahmin)
                {
                    Console.WriteLine($"Tebrik Ederim! {tahminHakki + 1} Deneme Hakkında Doğru Bildin.");
                    Console.WriteLine("-> Bilgisayar Tarafından Üretilen Değer: ", randomSayi);
                    break;
                }
                else if (randomSayi <= 5)
                {
                    Console.WriteLine("yanlış tahmin");
                    Console.WriteLine("-> Bilgisayar Tarafından Üretilen Değer: " + randomSayi);
                }
                tahminHakki++;
            }
            Console.ReadLine();
        }

    }
}
