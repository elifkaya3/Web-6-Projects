using System;

namespace metotlar_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Random rnd = new Random();
             int sayi = rnd.Next(1, 100);
             int randomSayi = 1;
             int tahminHakki = randomSayi;
             Console.WriteLine("-> Random Değer Üretildi.\n-> Üretilen Random Değer 0 ile 100 Arasında Olabilir.");
             int puan = 50;

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
             Console.ReadLine();*/

            int TahminHakki = 0;
            int sayac = 0;
            int puan = 50;

            int uretilenSayi = sayiUret();
            Console.WriteLine(uretilenSayi);
            int girilenSayi;
            
         
            do
            {

                girilenSayi = Tahmin();

                if (girilenSayi==uretilenSayi)
                {
                    Console.WriteLine("tebrikler doğru bildiniz");
                }
                else
                {

                }
            } while (TahminHakki <=5 );

            Console.WriteLine($"yanlış tahmin {TahminHakki + 1} hakkınız kaldı");
            Console.WriteLine("-> Bilgisayar Tarafından Üretilen Değer: " + uretilenSayi);

            Console.ReadLine();

            int sayiUret()
            {
                    Random rnd = new Random();
                    return rnd.Next(1, 100);
            }
          
            int Tahmin(int TahminHakki)
            {
                Console.WriteLine("kullanici tahmini");
               return int.Parse(Console.ReadLine());
                
            }
           
            void win(int)
            {
                Console.WriteLine();
            }
        }
    }
}
