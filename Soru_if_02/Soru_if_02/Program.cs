using System;

namespace Soru_if_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan iki adet sayı iste
            //bu sayıların toplamını,farkını,çarpımı,bölümü yazın

            Console.WriteLine("toplama:+");
            Console.WriteLine("çıkarma:-");
            Console.WriteLine("çarpma:*");
            Console.WriteLine("bölme:/");
            Console.WriteLine("hangi işlemi yapmak istiyorsunuz:");
            string islemTuru = Console.ReadLine();
            Console.Write("1. sayıyı giriniz:");
            int sayı1 = int.Parse(Console.ReadLine());
            Console.Write("2. sayıyı giriniz:");
            int sayı2 = int.Parse(Console.ReadLine());

            int islemSonucu = 0;


            if (islemTuru == "+")
            {
                int islemSonucu = sayı1 + sayı2;
            }
            else if (islemTuru == "-")
            {
                int islemSonucu = sayı1 - sayı2;
            }
            else if (islemTuru == "*")
            {
                int islemSonucu = sayı1 * sayı2;
            }
            else if(islemTuru=="/")
            {
                int islemSonucu = sayı1 / sayı2;
            }
            Console.WriteLine($"{ sayı1}{ islemTuru}{ sayı2}={ islemSonucu}");
            
           



            Console.ReadLine();
        }
    }
}
