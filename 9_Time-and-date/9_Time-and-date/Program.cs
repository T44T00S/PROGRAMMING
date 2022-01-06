using System;
using System.Collections.Generic;
using System.Threading;

namespace _9_Time_and_date
{
    class Program
    {
        static List<DateTime> budiky;

        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.DayOfWeek);

            DateTime dt = new DateTime(2022, 10, 30);
            Console.WriteLine($"Do tvých narozenin zbývá: {dt.Month - DateTime.Now.Month}" + $" měsíců {dt.Day - DateTime.Now.Day} " +
                $"dnů {dt.Hour - DateTime.Now.Hour} hodin {dt.Hour - DateTime.Now.Hour} minut {dt.Minute - DateTime.Now.Minute} " +
                $"sekund {dt.Second - DateTime.Now.Second}");

            budiky = new List<DateTime>();
            var ts = new ThreadStart(Budik);
            var bt = new Thread(ts);
            bt.Start();
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                ConsoleKey klic = Console.ReadKey().Key;

                if (klic == ConsoleKey.Escape)
                {
                    break;
                }
                else if (klic == ConsoleKey.Enter)
                {
                    bt.Abort();

                    Console.Write("Napiš hodinu: ");
                    int hodina = int.Parse(Console.ReadLine());
                    Console.Write("Napiš minuty: ");
                    int minuty = int.Parse(Console.ReadLine());

                    budiky.Add(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hodina, minuty, 0));

                    bt.Start();
                }
            }
        }

        static void Budik()
        {
            while (true)
            {
                if (budiky.Count != 0)
                {
                    foreach (var item in budiky)
                    {
                        if (item == DateTime.Now)
                        {
                            Console.WriteLine("ZVUK");
                            Console.Beep();
                        }
                    }
                }
            }
        }
    }
}
