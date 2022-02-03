using System;

namespace Proje_04_Referance_Types
{
    class Program
    {
        class Kisi
        {
            public string Ad { get; set; }
            public int Yas { get; set; }

        }
        static void Main(string[] args)
        {
            Kisi person1 = new Kisi();
            person1.Ad = "Elif";
            person1.Yas = 22;

            Console.WriteLine($"{person1.Ad}, sen {person1.Yas} yaşındasın");


            Kisi person2 = new ();
            person2.Ad = "Aybüke";
            person2.Yas = 4;

            Console.WriteLine($"{person2.Ad}, sen {person2.Yas} yaşındasın");

            person2 = person1;

            Console.WriteLine($"{person1.Ad}, sen {person1.Yas} yaşındasın");
            Console.WriteLine($"{person2.Ad}, sen {person2.Yas} yaşındasın");

            Console.ReadLine(  );
        }
    }
}
