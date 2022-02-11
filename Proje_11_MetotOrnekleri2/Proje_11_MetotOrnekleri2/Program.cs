using System;

namespace Proje_11_MetotOrnekleri2
{
    /*class Program
    {
       static int enbuyuk(int sayi1,int sayi2)
        {
           
            if (sayi1>=sayi2)
            {
                Console.WriteLine("sayi 1 enbuyuk");
                return sayi1;
            }
            else
            {
                return sayi2;
            }
        }
        
        static void Main(string[] args)
        {
            int sayi1=  20;
            int sayi2 = 50;
            int buyuk=enbuyuk(sayi1,sayi2);
            Console.WriteLine();
            Console.ReadLine();
        }
        
    }*/
    class Program
    {


        /*static int enbuyuk(int[] sayilar)
        {

            int enb = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] > enb)
                {
                    enb = sayilar[i];
                }
            }
            return enb;
        }

        static void Main(string[] args)
        {
            int[] sayilar = { 80, 80, 60, 40 };
            int buyuk = enbuyuk(sayilar);
            Console.WriteLine(buyuk);
            Console.ReadLine();

        }*/

        Console.WriteLine("Yaricap giriniz:");
        double yaricap = Convert.ToInt32(Console.ReadLine());
        const double PI = 3.14;
        double alan = 0;

        static double dairealani(double yaricap, double PI)
        {

            double alan = PI * yaricap * yaricap;
            Console.WriteLine(alan);

            return alan;
        }
        dairealani(yaricap, PI);
        Console.ReadLine();
    }
}
