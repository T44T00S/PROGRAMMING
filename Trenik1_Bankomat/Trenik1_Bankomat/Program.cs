using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trenik1_Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            user user1 = new user("Michal");
            user user2 = new user("Lukas");
            user user3 = new user("Filip");
            List <user> uzivatele = new List<user> { user1, user2, user3 };

            bool loggedIn = false;

            while (true)
            {
                while (!loggedIn)
                {
                    
                }
            }
        }
    }
}
