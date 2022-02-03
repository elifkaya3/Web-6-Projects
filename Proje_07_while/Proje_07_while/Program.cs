using System;

namespace Proje_07_while
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int sayi =1;
             while (sayi<=5)
             {
                 Console.WriteLine($"Hello World!-{sayi}");
                 sayi = sayi + 1;//sayı++;

             }
             Console.WriteLine( sayi);
             Console.ReadLine();
 */
            /* int sayac = 1;
             int toplam = 0;
             while (sayac <= 5)
             {
                 Console.WriteLine(sayac);
                 toplam = toplam + sayac;

                 sayac++;
             }
             Console.WriteLine($"Toplam: {toplam}");
             Console.ReadLine();
 */
            /*string girilecek =" " ;
            while (girilecek!="exit")
            {
                 Console.WriteLine($"Hello World!");

              girilecek=  Console.ReadLine();

            }*/

            /*string girilecek;

            do
            {
                Console.WriteLine($"Hello World!");

                girilecek = Console.ReadLine();

            } while (girilecek != "exit");
*/

            //kullancı admin 123 şifre

            /*            string kullanıcıAdı="Admin";
                        string sifre = "123";


                        do
                        {
                            Console.WriteLine("Kullanıcı Adınızı giriniz");
                            kullanıcıAdı = Console.ReadLine();
                            Console.WriteLine("Şifrenizi giriniz");
                            sifre = Console.ReadLine();
                            Console.WriteLine("yanlış kullanıcı");



                        } while (kullanıcıAdı!="Admin" || sifre!="123");
                        Console.Clear();
                        Console.ReadLine();*/

            /* string kullanıcıAdı = "Admin";
             string gkullanıcıAdı;
             string sifre = "123";
             string gsifre;
             byte durum = 0;

             do
             {
                 if (durum==1)
                 {
                     Console.WriteLine("hatalı kullanıcı girişi");
                     Console.Clear();
                     Console.ReadLine();
                 }
                 Console.WriteLine("Kullanıcı Adınızı giriniz");
                 gkullanıcıAdı = Console.ReadLine();
                 Console.WriteLine("Şifrenizi giriniz");
                 gsifre = Console.ReadLine();
                 durum = 1;


             } while (kullanıcıAdı != "gkullanıcıAdı" || sifre != "gsifre");
             Console.WriteLine("Giriş başarılı");
             Console.ReadLine();*/



            //klavyeden ardarda sayı girişi yapılmasını sağlayan ve girilen sayıların toplamı 1000i geçene kadar ya da 10 adet sayı girilene kadar
            //sayı girilmesine devam eden ve sonunda toplamı ve girilen sayı adedini ekrana yazan program


            int girilecekSayılar = 0;
            int toplam = 0;
            int Adet = 0;

            do
            {
                Adet++;
                Console.WriteLine($"{Adet }   girilecek sayı: ");

                toplam += girilecekSayılar;
                girilecekSayılar =int.Parse (Console.ReadLine());
            } while (Adet>10 && toplam>=1000 );
           
                Console.WriteLine($"Toplam: {toplam}");
            Console.WriteLine($"sayı adedi: {Adet}");

            Console.ReadLine();
           
        }
       

        }
    }
}
