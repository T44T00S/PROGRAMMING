using System;
using System.Threading;

namespace Coords
{
    class Program
    {
        static void Main(string[] args)
        {
            Pos[] grid = new Pos[16 * 16];

            for (int x = 1; x <= 16; x++)
            {
                grid[x].x = x;

                for (int y = 1; y <= 16; y++)
                {
                    grid[y].y = y;
                }
            }

            foreach (var item in grid)
            {
                Console.WriteLine(item.x + " " + item.y);
            }

            //


            //Pos poziceHrace = new Pos(2, 2);

            //int y = 3;
            //Console.WriteLine(y % 2 == 0 ? "jo" : "ne");
            ////Console.WriteLine($"X:  { poziceHrace.x} Y:  { poziceHrace.y}");

            //while (true)
            //{
            //    ConsoleKey znak = Console.ReadKey().Key;

            //    if (znak == ConsoleKey.W)
            //    {
            //        if (poziceHrace.y - 1 >= 0)
            //        {
            //            poziceHrace.y--;
            //            Console.WriteLine(poziceHrace.y);
            //        }

            //        Thread.Sleep(100);
            //    }
            //    else if (znak == ConsoleKey.S)
            //    {
            //        if (poziceHrace.y + 1 <= 3)
            //        {
            //            poziceHrace.y++;
            //            Console.WriteLine(poziceHrace.y);

            //            Thread.Sleep(100);
            //        }
            //    }
            //    else if (znak == ConsoleKey.A)
            //    {
            //        if (poziceHrace.y - 1 >= 0)
            //        {
            //            poziceHrace.y++;
            //            Console.WriteLine(poziceHrace.y);

            //            Thread.Sleep(100);
            //        }
            //    }
            //    else if (znak == ConsoleKey.D)
            //    {
            //        if (poziceHrace.y + 1 <= 3)
            //        {
            //            poziceHrace.y++;
            //            Console.WriteLine(poziceHrace.y);

            //            Thread.Sleep(100);
            //        }
            //    }
            //    string outputString = $@" {poziceHrace.getChar(1, 1)} {poziceHrace.getChar(2, 1)} {poziceHrace.getChar(3, 1)} {poziceHrace.getChar(2, 1)} {poziceHrace.getChar(2, 2)} {poziceHrace.getChar(3, 2)} {poziceHrace.getChar(1, 3)} {poziceHrace.getChar(2, 3)} {poziceHrace.getChar(3, 3)}";
            //    Thread.Sleep(100);
            }
        }
    }
}
