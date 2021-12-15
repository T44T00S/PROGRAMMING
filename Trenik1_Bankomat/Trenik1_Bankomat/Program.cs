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
            while (true)
            {
                user.ziskatPin();
                string cmd = "";

                do
                {
                    Console.Write("Zadejte příkaz: ");
                    cmd = Console.ReadLine();
                    Console.WriteLine("zustatek, vybrat, poslat, odhlasit");

                    switch (cmd)
                    {
                        case





                        default:
                            break;
                    }




                } while (cmd != "odhlasit");
            }
        }
    }
}
