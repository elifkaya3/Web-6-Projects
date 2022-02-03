using System;

namespace Proje_03_data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------VERİ TİPLERİ---------------");
            Console.WriteLine("A) Tamsayılar(integral)");
            Console.WriteLine("a) İşaretsiz (unsigned) Tamsayılar");

            Console.WriteLine("1) Byte:");
            Console.WriteLine($"min deger: {Byte.MinValue}");
            Console.WriteLine($"max deger: {Byte.MaxValue}");
            Console.WriteLine($"bellekteki boyutu: {sizeof(Byte)}byte");
            //Console.ReadLine();


            Console.WriteLine("2) ushort:");
            Console.WriteLine($"min deger: {ushort.MinValue}");
            Console.WriteLine($"max deger: {ushort.MaxValue:0,00}");
            Console.WriteLine($"bellekteki boyutu: {sizeof(ushort)}byte");
           // Console.ReadLine();



            Console.WriteLine("3) uint:");
            Console.WriteLine($"min deger: {uint.MinValue}");
            Console.WriteLine($"max deger: {uint.MaxValue:0,00}");
            Console.WriteLine($"bellekteki boyutu: {sizeof(uint)}byte");
            //Console.ReadLine();


            Console.WriteLine("4) ulong:");
            Console.WriteLine($"min deger: {ulong.MinValue}");
            Console.WriteLine($"max deger: {ulong.MaxValue:0,00}");
            Console.WriteLine($"bellekteki boyutu: {sizeof(ulong)}byte");
           // Console.ReadLine();

            Console.WriteLine("b) İşaretli (signed) Tamsayılar");

            Console.WriteLine("1) sbyte:");
            Console.WriteLine($"min deger: {sbyte.MinValue}");
            Console.WriteLine($"max deger: {sbyte.MaxValue}");
            Console.WriteLine($"bellekteki boyutu: {sizeof(sbyte)}byte");
           // Console.ReadLine();

            Console.WriteLine("2) short:");
            Console.WriteLine($"min deger: {short.MinValue:0,00}");
            Console.WriteLine($"max deger: {short.MaxValue:0,00}");
            Console.WriteLine($"bellekteki boyutu: {sizeof(short)}byte");
            //Console.ReadLine();

            Console.WriteLine("3) int:");
            Console.WriteLine($"min deger: {int.MinValue:0,00}");
            Console.WriteLine($"max deger: {int.MaxValue:0,00}");
            Console.WriteLine($"bellekteki boyutu: {sizeof(int)}byte");
            //Console.ReadLine();

            Console.WriteLine("4) long:");
            Console.WriteLine($"min deger: {long.MinValue:0,00}");
            Console.WriteLine($"max deger: {long.MaxValue:0,00}");
            Console.WriteLine($"bellekteki boyutu: {sizeof(long)}byte");
           // Console.ReadLine();

            Console.WriteLine("B) Ondalıklı(decimal) Sayılar");

            Console.WriteLine("1)float");
            Console.WriteLine($"min deger: {float.MinValue}");
            Console.WriteLine($"max deger: {float.MaxValue}");
            Console.WriteLine($"bellekteki boyutu: {sizeof(float)}");

            Console.WriteLine("2)double");
            Console.WriteLine($"min deger: {double.MinValue}");
            Console.WriteLine($"max deger: {double.MaxValue}");
            Console.WriteLine($"bellekteki boyutu: {sizeof(double)}");

            Console.WriteLine("3)decimal");
            Console.WriteLine($"min deger: {decimal.MinValue}");
            Console.WriteLine($"max deger: {decimal.MaxValue}");
            Console.WriteLine($"bellekteki boyutu: {sizeof(decimal)}");

            Console.WriteLine("C) Karakter(char) veri tipi" );

            Console.WriteLine("1)char");
            Console.WriteLine($"min deger: {(int)char.MinValue}");
            Console.WriteLine($"max deger: {(int)char.MaxValue}");
            Console.WriteLine($"bellekteki boyutu: {sizeof(char)}");

            Console.WriteLine("D) Mantıksal(bool) veri tipi");

            Console.WriteLine("1)bool");
            Console.WriteLine($"min deger: {true}");
            Console.WriteLine($"max deger: {false}");
            Console.WriteLine($"bellekteki boyutu: {sizeof(bool)}");

            Console.WriteLine("E) Tarih(Date) veri tipi");

            Console.WriteLine("1)DateTime");
            Console.WriteLine($"min deger: {DateTime.MinValue}");
            Console.WriteLine($"max deger: {DateTime.MaxValue}");
            unsafe
            {
                Console.WriteLine($"bellekteki boyutu: {sizeof(DateTime)}byte");
            }


            Console.ReadLine();
        }
    }
}
