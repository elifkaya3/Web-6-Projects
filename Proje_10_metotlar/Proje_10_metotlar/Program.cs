using System;

namespace Proje_10_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
           void Topla()
            {
                int a = 8;
                int b = 10;
                Console.WriteLine(a+b);
            }
           
            void Yaz()
            {
                Console.WriteLine("Merhaba Wissen");
            }

            void Topla2(int sayi1, int sayi2)
            {
                Console.WriteLine(sayi1+sayi2);
            }
             void Yaz2(string name)
            {
                Console.WriteLine($"Merhaba {name}");
            }

          /*  void Topla3()
            {
                Console.WriteLine("1. sayıyı girin: ");
                int sayi1 = int.Parse(Console.ReadLine());
                Console.WriteLine("2. sayıyı girin: ");
                int sayi2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Sonuç:{sayi1+sayi2}");

            }*//* Yaz();
            Topla();
            Topla2(50, 90);
            Topla2(50, 100);
            Yaz2("Elif");
            Topla3();*/
            void islemYap(string islem )
            {
                Console.WriteLine("1. sayıyı girin: ");
                int sayi1 = int.Parse(Console.ReadLine());
                Console.WriteLine("2. sayıyı girin: ");
                int sayi2 = int.Parse(Console.ReadLine());
                int sonuc = 0;
                if (islem=="+"||islem == "-"|| islem == "*"|| islem == "/")
                {

              
                    if(islem =="+")
                    {
                        sonuc = sayi1 + sayi2;
                    }
                    else if (islem =="-")
                    {
                        sonuc = sayi1 - sayi2;

                    }
                    else if (islem=="*")
                    {
                        sonuc = sayi1 * sayi2;

                    }
                    else
                    {
                        sonuc = sayi1 / sayi2;

                    }
                    Console.WriteLine($"sonuc:{sonuc}");
                   
                } 
                else
                    {
                        Console.WriteLine("lütfen doğru bi islem türü gir");

                    }
            }
            islemYap("+");//islem türünü burdan seçeceğiz
            Console.ReadLine();
        }
    }
}
