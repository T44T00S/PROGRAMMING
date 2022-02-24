using System;
using System.Threading;

namespace Trenik2_Budik
{
    class Program
    {
        static void Main(string[] args)
        {
            var ts = new ThreadStart(alarm.Alarm);
            var bt = new Thread(ts);
            bt.Start();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Zadejte příkaz:");
                Console.WriteLine("  - pro vypsání možných příkazů zadejte 'help'");
                string vstup = Console.ReadLine();
                switch (vstup)
                {
                    case "help":
                        Console.WriteLine("Možné příkazy: ");
                        Console.WriteLine("'help'; 'add'; 'remove'; 'show'; 'exit'");
                        Console.ReadKey();
                        continue;
                    case "add":
                        alarm.Add();
                        continue;
                    case "remove":
                        alarm.Remove();
                        continue;
                    case "show":
                        alarm.Show();
                        Console.ReadKey();
                        continue;
                    case "exit":
                        Console.WriteLine("BYE!");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Neznámý příkaz..");
                        Console.ReadKey();
                        continue;
                }
            }
        }
    }
}
