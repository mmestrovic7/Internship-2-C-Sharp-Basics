using System;

namespace dr2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odaberite akciju:\n1 - Ispis cijele liste\n2 - Ispis imena pjesme unosom pripadajućeg rednog broja\n3 - Ispis rednog broja pjesme unosom pripadajućeg imena");
            Console.WriteLine("4 - Unos nove pjesme\n5 - Brisanje pjesme po rednom broju\n6 - Brisanje pjesme po imenu\n7 - Brisanje cijele liste");
            Console.WriteLine("8 - Uređivanje imena pjesme\n9 - Uređivanje rednog broja pjesme, odnosno premještanje pjesme na novi redni broj u listi\n0 - Izlaz iz aplikacije");
            var a = int.Parse(Console.ReadLine());

            if (a == 0)
                ;
            else if (a == 1)
                ;
            else if (a == 2)
                ;
            else if (a == 3)
                ;
            else if (a == 4)
                ;
            else if (a == 5)
                ;
            else if (a == 6)
                ;
            else if (a == 7)
                ;
            else if (a == 8)
                ;
            else if (a == 9)
                ;
            else
                Console.WriteLine("Neispravan unos");



        }
    }
}
