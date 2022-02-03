using System;

namespace Proje_06_if
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int sayi = 10;
            if (sayi>5)
            {//true ise yapılacaklar
                Console.WriteLine("BÜYÜK");


            }
            else
            {
                //false ile yapılacaklar
                Console.WriteLine("KÜÇÜK");

            }
            Console.ReadLine();*/

            Console.WriteLine("bir sayı giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            if (sayi > 50)
            {
                Console.WriteLine("büyük");
            }
            else if(sayi<50)
            {
                Console.WriteLine("küçük");
            }
            else
            {
                Console.WriteLine("eşit");
            }
            Console.ReadLine(); 

        }
    }

}