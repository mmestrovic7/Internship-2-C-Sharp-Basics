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
                            Console.WriteLine("Ime pjesme: "+playlist[br]);
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
                                Console.WriteLine("Redni broj pjesme: "+song.Key);
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
                    while (a == 4)
                    {
                        var i = 0;
                        Console.WriteLine("Unesite ime nove pjesme");
                        var newSong = Console.ReadLine();
                        foreach (var song in playlist)
                            if (newSong.ToLower() == song.Value.ToLower())
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
                            Console.WriteLine("Dodali ste pjesmu. Opet ste na početnom izborniku");
                            a = -1;
                        }



                    }
                //5
                else if (a == 5)
                    while (a == 5)
                    {
                        Console.WriteLine("Unesite redni broj pjesme koju želite izbrisati. Playlista sadrži " + playlist.Count + " pjesama");
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
                                a = 5;



                        }
                        else
                        {
                            int i, x;
                            playlist.Remove(br);
                            x = playlist.Count;
                            for (i = 1; i <= x; i++)
                                if (i >= br)
                                {
                                    playlist.Add(i, playlist[i + 1]);
                                    playlist.Remove(i + 1);
                                }


                            a = -1;
                            Console.WriteLine("Izbrisali ste pjesmu. Opet ste na početnom izborniku");
                        }

                    }
                //6
                else if (a == 6)
                    while (a == 6)
                    {
                        var i = 0;
                        var br = 0;

                        Console.WriteLine("Unesite ime pjesme koju želite izbrisati");
                        var ime = Console.ReadLine();
                        foreach (var song in playlist)

                            if (ime.ToLower() == song.Value.ToLower())
                            {
                                br = song.Key;
                                playlist.Remove(song.Key);
                                i++;
                                a = -1;
                                Console.WriteLine("Izbrisali ste pjesmu.Opet ste na početnom izborniku");

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

                                a = 6;


                        }
                        else
                        {
                            var j = 0;
                            var x = playlist.Count;
                            for (j = 1; j <= x; j++)
                                if (j >= br)
                                {
                                    playlist.Add(j, playlist[j + 1]);
                                    playlist.Remove(j + 1);
                                }
                        }
                    }
                //7
                else if (a == 7)
                {
                    playlist.Clear();
                    Console.WriteLine("Obrisali ste cijelu playlistu.Opet ste na početnom izborniku");
                    a = -1;
                }
                //8
                else if (a == 8)
               while(a==8)
                    {
                        Console.WriteLine("Unesite redni broj pjesme čije ime želite promjeniti");
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
                                a = 8;


                        }
                        else
                        {
                            Console.WriteLine("Unesite kako želite da se pjesma sada zove");
                            string newSong = Console.ReadLine();
                            playlist[br] = newSong;

                                   

                            a = -1;
                            Console.WriteLine("Promjenili ste ime pjesme. Opet ste na početnom izborniku");
                        }


                    }
                //9
                else if (a == 9)
                    while(a==9)
                    {
                        Console.WriteLine("Unesite redni broj pjesme koju želite premjestiti. Playlista sadrži " + playlist.Count + " pjesama");
                        var rb1 = int.Parse(Console.ReadLine());
                        

                        if (rb1 > playlist.Count || rb1 < 1)
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
                                a = 9;


                        }
                        else
                        {
                            Console.WriteLine("Unesite redni broj na koji želite premjestiti pjesmu. Playlista sadrži " + playlist.Count + " pjesama");
                            var rb2 = int.Parse(Console.ReadLine());
                            if (rb2 > playlist.Count || rb2 < 1)
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
                                    a = 9;


                            }
                            else
                            {


                                var s = playlist[rb1];
                                var i=0;
                                if(rb1>rb2)
                                for(i=rb1;i>=rb2;i--)
                                {
                                     if (i == rb2)
                                        playlist[i] = s;
                                     else
                                    playlist[i] = playlist[i - 1];
                                   



                                }
                                else
                                    for (i = rb1; i <=rb2; i++)
                                    {
                                        if (i == rb2)
                                            playlist[i] = s;
                                        else
                                        playlist[i] = playlist[i +1];
                                        



                                    }

                                a = -1;
                                Console.WriteLine("Premjestili ste pjesmu.Opet ste na početnom izborniku");
                               

                            }


                        }
                    }
                //NEISPRAVAN UNOS
                else
                {
                    Console.WriteLine("Krivi unos, vraceni ste na izbornik");
                    a = -1;
                }
           
        }



        }
    }
}
