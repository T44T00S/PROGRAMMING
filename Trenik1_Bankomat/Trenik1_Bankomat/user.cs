using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trenik1_Bankomat
{
    class user
    {
        public user(string jmeno)
        {
            this.jmeno = jmeno;
            this.pin = 1234;
            this.zustatek = 10000;
        }

        public static void ziskatPin()
        {
            user user1 = new user("Michal");
            user user2 = new user("Lukas");
            user user3 = new user("Filip");
            List<user> uzivatele = new List<user> { user1, user2, user3 };

            bool loggedIn = false;

            while (true)
            {
                while (!loggedIn)
                {
                    Console.Write("Zadejte jméno: ");
                    string JMENO = Console.ReadLine();

                    if (uzivatele.Exists(u => u.jmeno == JMENO))
                    {
                        Console.WriteLine("Zadejte PIN: ");
                        int PIN = int.Parse(Console.ReadLine());

                        if (uzivatele.Find(u => u.jmeno == JMENO).pin == PIN)
                        {
                            user uziv = uzivatele.Find(u => u.jmeno == JMENO);
                        }
                    }
                }
            }
        }

        public static void vypsatZustatek()
        {
            Console.WriteLine(uziv.zustatek);
        }

        public string jmeno { get; set; }
        public int pin { get; set; }
        public int zustatek { get; set; }

    }
}
