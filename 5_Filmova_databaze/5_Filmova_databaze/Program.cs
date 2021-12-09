using System;
using System.Collections.Generic;

namespace _5_Filmova_databaze
{
    class Program
    {
        static void Main(string[] args)
        {
            film film1 = new film("Utek z vezeni", "Shakespeare", "drama", 1999);
            film film2 = new film("Smrt", "Poirot", "komedie", 2005);
            film film3 = new film("Laska na vlasku", "Sablik", "poezie", 2022);
            List<film> filmy = new List<film> { film1, film2, film3 };



            while (true)
            {
                string cmd = "";
                do
                {
                    Console.Write("Zadejte příkaz: ");
                    cmd = Console.ReadLine();

                    switch (cmd)
                    {
                        case "vypsat":
                            foreach (var item in filmy)
                            {
                                Console.WriteLine("{0}, {1}, {2}, {3}", item.Jmeno, item.Autor, item.Zanr, item.Rok);
                            }
                            continue;

                        case "pridat":
                            Console.Write("Zadejte název filmu: ");
                            string film = Console.ReadLine();

                            if (filmy.Exists(u => u.Jmeno != film))
                            {
                                Console.Write("Zadejte název filmu: ");
                                string vstupNazev = Console.ReadLine();
                                Console.WriteLine("Zadejte jméno autora: ");
                                string vstupAutor = Console.ReadLine();
                                Console.WriteLine("Zadejte žánr: ");
                                string vstupZanr = Console.ReadLine();
                                Console.WriteLine("Zadejte rok vydání: ");
                                int vstupRok = Console.Read();

                                filmy.Add(new film(vstupNazev, vstupAutor, vstupZanr, vstupRok));
                            }
                            continue;

                        case "odstranit":
                            Console.Write("Zadejte název filmu: ");
                            string del = Console.ReadLine();
                            filmy.Remove(filmy.Find(m => m.Jmeno == del));
                            continue;

                        default:
                            Console.WriteLine(@"vypsat, pridat, odstranit");
                            break;
                    }
                } while (true);
            }
        }
    }
}
