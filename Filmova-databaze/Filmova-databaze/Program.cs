using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmova_databaze
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
                Console.WriteLine("Zadejte název filmu: ");
                string JMENO = Console.ReadLine();

                if (filmy.Exists(u => u.Jmeno == JMENO))
                {
                    film fm = filmy.Find(u => u.Jmeno == JMENO);
                    Console.WriteLine(filmy);
                    string cmd = "";
                    do
                    {
                        Console.Write("Zadejte příkaz: ");
                        cmd = Console.ReadLine();

                        switch (cmd)
                        {
                            case "vypsat":
                                Console.WriteLine(filmy);
                                continue;

                            //case "vybrat":
                            //    Console.WriteLine("Kolik peněz si chcete vybrat?");
                            //    uziv.zustatek -= int.Parse(Console.ReadLine());
                            //    continue;

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

                            default:
                                Console.WriteLine(@"vypsat, pridat");
                                break;
                        }
                    } while (true);
                }
            }
        }
    }
}
