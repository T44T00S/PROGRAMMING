using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            user user1 = new user("Honza");
            user user2 = new user("Karel");
            user user3 = new user("Anna");
            List<user> uzivatele = new List<user> { user1, user2, user3 };

            Console.WriteLine(user2.pin);

            bool loggedIn = false;

            while (true)
            {
                while (!loggedIn)
                {
                    Console.Write("Zadejte jméno: ");
                    string JMENO = Console.ReadLine();

                    if (uzivatele.Exists(u => u.jmeno == JMENO))
                    {
                        Console.WriteLine("Zadejte pin: ");
                        int PIN = int.Parse(Console.ReadLine());

                        // for (int PIN = 999; PIN < 1000; PIN++)
                        // {

                        // }

                        if (uzivatele.Find(u => u.jmeno == JMENO).pin == PIN)
                        {
                            user uziv = uzivatele.Find(u => u.jmeno == JMENO);
                            string cmd = "";
                            do
                            {
                                Console.Write("Zadejte příkaz: ");
                                cmd = Console.ReadLine();

                                switch (cmd)
                                {
                                    case "zustatek":
                                        Console.WriteLine(uziv.zustatek);
                                        continue;

                                    case "vybrat":
                                        Console.WriteLine("Kolik peněz si chcete vybrat?");
                                        uziv.zustatek -= int.Parse(Console.ReadLine());
                                        continue;

                                    case "odhlasit":
                                        break;

                                    case "poslat":
                                        Console.Write("Komu chcete poslat peníze (Honza, Karel, Anna): ");
                                        string prijemce = Console.ReadLine();

                                        if (uzivatele.Exists(u => u.jmeno == prijemce))
                                        {
                                            Console.Write("Jakou částku: ");
                                            int kolikPoslat = int.Parse(Console.ReadLine());

                                            uziv.zustatek -= kolikPoslat;
                                            uzivatele.Find(u => u.jmeno == prijemce).zustatek += kolikPoslat;
                                        }
                                        continue;

                                    default:
                                        Console.WriteLine(@"zustatek, vybrat, poslat, odhlasit");
                                        break;
                                }
                            } while (cmd != "odhlasit");
                        }
                        else
                        {
                            Console.WriteLine("PIN není správný.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Uživatel neexistuje.");
                    }
                }
            }


        }
    }
}
