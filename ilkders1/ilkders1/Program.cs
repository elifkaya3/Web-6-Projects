using System;
using System.Threading;

namespace ilkders1
{
    class Program
    {
        static void Main(string[] args)
        {
            //    double cevre, alan, yarıcap;

            //   const double pi=3.14;

            //    Console.WriteLine("yarıçapı giriniz");
            //    yarıcap = Convert.ToInt32(Console.ReadLine());

            //    alan = pi*yarıcap*yarıcap;
            //    cevre = 2 * pi * yarıcap;

            //    Console.WriteLine("dairenin alanı= " + alan);
            //    Console.WriteLine("dairenin cevresi= " + cevre);

            //    Console.ReadLine();


            //    Console.WriteLine("Hello World!");
            //}
            string kullanici = "admin", sifre = "123";
            string kullaniciadi, kullanicisifresi;
            int hak = 3;
            do
            {
                Console.WriteLine("kullanıcı adı giriniz");
                kullaniciadi = Console.ReadLine();
                Console.WriteLine("kullanıcı sifre giriniz");
                kullanicisifresi = Console.ReadLine();
                if (kullaniciadi == kullanici && kullanicisifresi == sifre
)
                {
                    Console.WriteLine("kullanıcı girişi başarılı");
                    for (int i = 0; i <= 100; i++)
                    {
                        Console.WriteLine($"\ryükleniyor { i}%");
                        Thread.Sleep(100);

                        
                    }
                    Console.Clear();
                    Console.WriteLine("hosgeldiniz");
                }
                else
                {
                    hak--;
                    if(hak==0)
                    {
                        Console.WriteLine("hakkınız doldu");

                    }
                }


            }
            while (true);



        }
    }
}
