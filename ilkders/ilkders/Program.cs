using System;

namespace ilkders
{
    class Program
    {
        static void Main(string[] args)
        {
            int vize, final;
            double ortalama;

            Console.WriteLine("vize notu giriniz.");
            vize = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("final notu giriniz.");
            final = Convert.ToInt32(Console.ReadLine());

            ortalama = (vize*40/100) + (final*40/100);;

            if (ortalama > 60 || ortalama == 60 )
            {
                Console.WriteLine("geçti");
            }
            else
            {
                Console.WriteLine("kaldı");
            }

            Console.ReadLine();



        }
    }
}
