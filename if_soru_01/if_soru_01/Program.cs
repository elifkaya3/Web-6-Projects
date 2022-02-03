using System;

namespace if_soru_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //bir üniveristede bir öğrencinin not ortalaması 60 ve üzerinde ise öğrenci başarılı değilse başarısız
            //öğrencinin ort vize ve final notalrı üzerinden şu şkeilde hesaplanıyor
            //vizenin %40 finalin %60ı toplanıyor:
            //vize ve final notları klavyeden girilen bir öğrencinin not ortalaması ve başarı durumunu yazdıran programı hazırlayın.
            
            /*Console.WriteLine("vize notunuzu giriniz");
            int vize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("final notunuzu giriniz");
            int final = Convert.ToInt32(Console.ReadLine());



            double ortalama = (vize * 0.4 + final * 0.6 );//ondalıklı

            if(ortalama>60)
            {
                Console.WriteLine("geçti");

            }
            else
            {
                Console.WriteLine("kaldı");
            }


            Console.ReadLine()*/;

            //mağazadan alınan ürünn fiyatı 100 liradan büyük ya da eşitse kargo ücreti alınmamaktadır
            //ürünün fiyatı girildiğinde toplam ödenmesi gereken tutarı bulup ekrana yazdırn programı hazırlayınız
            /*
                        Console.WriteLine("ürününfiyatını girimiz");
                        int fiyat = Convert.ToInt32(Console.ReadLine());
                        if(fiyat > 100)

                        {
                         Console.WriteLine("kargo bedava");
                        }
                        else
                        {
                            Console.WriteLine("+5 tl kargo ücreti ödenir");
                        }
                       */




            /* Console.WriteLine("1. ürünün fiyatını giriniz");
             int fiyat1 = Convert.ToInt32(Console.ReadLine());
             if (fiyat1 >= 200)
             {
                 Console.WriteLine("2. ürüne %30 indirim aldınız");
                 Console.WriteLine("2. ürünün fiyatını giriniz");

                 int fiyat2 = Convert.ToInt32(Console.ReadLine());
                 double toplamfiyat = (fiyat1 + fiyat2 * 0.3);
                 Console.ReadLine();
 *//*


             }
             else
             {
                 Console.WriteLine("fiyat1 ödenecek");

             }
 *//*

             Console.WriteLine("vize notunuzu giriniz");
             int vize = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("final notunuzu giriniz");
             int final = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("devamsızlık sayısını giriniz");
             int devamsızlık= Convert.ToInt32(Console.ReadLine());

             double ortalama = (vize * 0.4 + final * 0.6);//ondalıklı

             if (ortalama > 60 && devamsızlık <= 10)
             {
                 Console.WriteLine("geçti");

             }
             else
             {
                 Console.WriteLine("kaldı");
             }


             Console.ReadLine() ;*/

            /*Console.WriteLine("ürünün fiyatını giriniz");
            int fiyat1 = Convert.ToInt32(Console.ReadLine());
            int fiyat2 = Convert.ToInt32(Console.ReadLine());
            double indirimlitutar = 0;
            int toplamtutar = Convert.ToInt32(Console.ReadLine());




            if (fiyat1 > 200 && toplamtutar >250  )

            {
                Console.WriteLine("ikinci ürünün fiyatını giriniz");
                indirimlitutar = (fiyat1 + fiyat2 * 0.35);

            }
            else
            {
                Console.WriteLine("+25 tl kargo ücreti ödenir");
                toplamtutar = (fiyat1 + 25);
            }
            Console.ReadLine();*/
            double indirimliTutar = 0;
            double kargoUcreti = 25;
            Console.Write("ürün 1 in fiyatı:");
            double urun1= double.Parse(Console.ReadLine());
            Console.Write("ürün 2 nin fiyatı:");
            double urun2 = double.Parse(Console.ReadLine());
            double genelTutar = urun1 + urun2;
           


            if (genelTutar>=200)
            {
               indirimliTutar = genelTutar - urun2 * 0.35;

            }
            else
            {
                indirimliTutar = genelTutar;

            }
            if(indirimliTutar>=250)
            {
                kargoUcreti = 0;
            }
            double odenecekTutar = indirimliTutar + kargoUcreti;

            Console.WriteLine("******************************* ");

            Console.WriteLine($"Ürün 1 Fiyatı      :  {urun1} ");
            Console.WriteLine($"Ürün 2 Fiyatı       :  {urun2} ");
            Console.WriteLine($"Genel Tutar      :  {genelTutar} ");
            Console.WriteLine($"İndirimli Tutar      :  {indirimliTutar} ");
            Console.WriteLine($"Kargo Bedeli      :  {kargoUcreti} ");
            Console.WriteLine($"Ödenecek Tutar      :  {odenecekTutar} ");

            Console.ReadLine();
        }

    }
}
