using System;
using System.Threading;

namespace Cv4_TimeDate_test
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.DayOfWeek);

            //2
            //DateTime Dob;
            Console.WriteLine("Napiš rok: ");
            //Dob = DateTime.Parse(Console.ReadLine());
            int vstup = Int32.Parse(Console.ReadLine());
            if (vstup > DateTime.Now.Year)
            {
                int cas = vstup - DateTime.Now.Year;
                Console.WriteLine("Zbývající roky: " + cas);
            }

            //string line = Console.ReadLine();
            //DateTime dt;
            //while (!DateTime.TryParseExact(line, "DD/MM/YYYY", null, System.Globalization.DateTimeStyles.None, out dt))
            //{
            //    Console.WriteLine("Neplatné datum.");
            //    line = Console.ReadLine();
            //}

            //Console.WriteLine($"Do času zbývá: {dt.Year - DateTime.Now.Year}");

            //3
            while (true)
            {
                Console.WriteLine(DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second);
                Thread.Sleep(1000);
            }
        }
    }
}
