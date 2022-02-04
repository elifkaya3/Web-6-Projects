using System;

namespace Proje_10_Metotlar2
{
    class Program
    {
        
        
            /*int Topla(int sayi1,int sayi2)// bir metodun imzası nedir:::
                                          // 1-metodun adı,2- metodun parametre sayısı
                                          // 3- metodun parametrelerinin tipleri
            {
              int sonuc = sayi1 + sayi2;
              return sonuc;

            }
            Topla(50, 60); 
            Console.WriteLine(Topla(50, 60));
            Console.WriteLine(Topla(Topla(Topla(50, 60), 70),90));
            Console.ReadLine();*/
            
            static int Topla(int sayi1, int sayi2, int sayi3)
            {   int sonuc = sayi1 + sayi2+sayi3;
                return sonuc;

            }

            static int Topla(int sayi1, int sayi2)
            {
                int sonuc = sayi1 + sayi2;
                return sonuc;

            }
            static void main(string[] args)
            {
                Topla(50, 60);
                Console.WriteLine(Topla(50, 60));
                Console.WriteLine(Topla(50, 60, 90));
                Console.ReadLine();
            }
        
    }
}
