using System;
using System.Collections.Generic;
using System.Text;

namespace Trenik2_Budik
{
    class alarm
    {
        static List<DateTime> alarms = new List<DateTime>();

        public static void Alarm()
        {
            while (true)
            {
                for (int i = 0; i < alarms.Count; i++)
                {
                    if (alarms[i].Year == DateTime.Now.Year &&
                        alarms[i].Month == DateTime.Now.Month &&
                        alarms[i].Day == DateTime.Now.Day &&
                        alarms[i].Hour == DateTime.Now.Hour &&
                        alarms[i].Minute == DateTime.Now.Minute &&
                        alarms[i].Second == DateTime.Now.Second)
                    {
                        Console.WriteLine("ZVONÍÍÍÍÍ!!!");
                        Console.Beep(800, 1000);
                        Console.Beep(900, 1000);
                        Console.Beep(1000, 1000);
                        alarms.Remove(alarms[i]);
                        i--;
                    }
                }
            }
        }
        public static void Add()
        {
            Console.WriteLine("Zadejte rok:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadejte měsíc:");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadejte den:");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadejte hodiny:");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadejte minuty:");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadejte sekundy:");
            int seconds = Convert.ToInt32(Console.ReadLine());
            alarms.Add(new DateTime(year, month, day, hours, minutes, seconds));
        }

        public static void Remove()
        {
            Show();
            Console.WriteLine();
            Console.WriteLine("Zadejte číslo budíku, který chcete odebrat..:");
            int index = Convert.ToInt32(Console.ReadLine());
            if (index > alarms.Count ||
                index <= 0)
            {
                alarms.RemoveAt(index);
            }
        }

        public static void Show()
        {
            for (int i = 0; i < alarms.Count; i++)
            {
                Console.WriteLine("{0}.   {1}.{2}.{3} {4}:{5}:{6}", i, alarms[i].Day, alarms[i].Month, alarms[i].Year, alarms[i].Hour, alarms[i].Minute, alarms[i].Second);
            }
        }
    }
}
