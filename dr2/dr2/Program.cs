using System;
using System.Collections.Generic;

namespace dr2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odaberite akciju:\n1 - Ispis cijele liste\n2 - Ispis imena pjesme unosom pripadajućeg rednog broja\n3 - Ispis rednog broja pjesme unosom pripadajućeg imena");
            Console.WriteLine("4 - Unos nove pjesme\n5 - Brisanje pjesme po rednom broju\n6 - Brisanje pjesme po imenu\n7 - Brisanje cijele liste");
            Console.WriteLine("8 - Uređivanje imena pjesme\n9 - Uređivanje rednog broja pjesme, odnosno premještanje pjesme na novi redni broj u listi\n0 - Izlaz iz aplikacije");
            var a = -1;
            var playlist = new Dictionary<int, string>()
        {
                { 1,"Work Song"},
                { 2,"Almost (Sweet Music)"},
                { 3,"Movement"},
                { 4,"Like Real People Do"},
                { 5,"Wasteland Baby!" }

            };

            while (a == -1)
            {
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Jeste li sigurni? y/n");
                var yn = Console.ReadLine();
                if (yn != "y")
                    a = -1;
                //0
                if (a == 0)
                    a = 10;
                //1
                else if (a == 1)
                {
                    foreach (var song in playlist)

                        Console.WriteLine(song.Key + " " + song.Value);
                    a = -1;
                    Console.WriteLine("Opet ste na početnom izborniku");

                }
                //2
                else if (a == 2)
                
                    while (a == 2)
                    {
                        Console.WriteLine("Unesite redni broj pjesme koju želite ispisati. Playlista sadrži " + playlist.Count + " pjesama");
                        var br = int.Parse(Console.ReadLine());
                        if (br > playlist.Count || br < 1)
                        {
                            Console.WriteLine("Neispravan unos");
                            Console.WriteLine("Želite li se vratiti na početni izbornik? y/n");
                            yn = Console.ReadLine();
                            if (yn == "y")
                            {
                                a = -1;
                                Console.WriteLine("Opet ste na početnom izborniku");
                            }
                            else
                                a = 2;


                        }
                        else
                        {
                            foreach (var song in playlist)

                                if (br == song.Key)

                                    Console.WriteLine(song.Value);

                            a = -1;
                            Console.WriteLine("Opet ste na početnom izborniku");
                        }
                    }


                
                //3
                else if (a == 3)
                
                    while (a == 3)
                    {
                        var i = 0;
                        Console.WriteLine("Unesite ime pjesme čiji redni broj želite ispisati");
                        var ime = Console.ReadLine();
                        foreach (var song in playlist)

                            if (ime.ToLower() == song.Value.ToLower())
                            {
                                Console.WriteLine(song.Key);
                                i++;
                                a = -1;
                                Console.WriteLine("Opet ste na početnom izborniku");

                            }
                        if (i == 0)
                        {
                            Console.WriteLine("Pjesma ne pripada playlisti");
                            Console.WriteLine("Želite li se vratiti na početni izbornik? y/n");
                            yn = Console.ReadLine();
                            if (yn == "y")
                            {
                                a = -1;
                                Console.WriteLine("Opet ste na početnom izborniku");
                            }
                            else
                                a = 3;
                        }

                    }


                

                //4
                else if (a == 4)
                    while(a==4)
                    {
                        var i = 0;
                        Console.WriteLine("Unesite ime nove pjesme");
                        var newSong = Console.ReadLine();
                        foreach(var song in playlist)
                            if(newSong.ToLower()==song.Value.ToLower())
                            {
                                i++;
                                Console.WriteLine("Pjesma već pripada playlisti");
                                Console.WriteLine("Želite li se vratiti na početni izbornik? y/n");
                                yn = Console.ReadLine();
                                if (yn == "y")
                                {
                                    a = -1;
                                    Console.WriteLine("Opet ste na početnom izborniku");
                                }
                                else
                                    a = 4;
                            }
                        if (i == 0)
                        {
                            playlist.Add(playlist.Count + 1, newSong);
                            Console.WriteLine("Opet ste na početnom izborniku");
                            a = -1;
                        }

                        

                    }
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
                {
                    Console.WriteLine("Krivi unos, vraceni ste na izbornik");
                    a = -1;
                }
           
        }



        }
    }
}
