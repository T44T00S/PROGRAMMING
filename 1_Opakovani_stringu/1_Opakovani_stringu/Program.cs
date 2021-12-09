using System;

namespace _1_Opakovani_stringu
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] emails = { "petr.martinek", "gmail.com" };
            //string spojeni = String.Join("@", emails);
            //Console.WriteLine(spojeni);
            //Console.ReadKey();

            //

            //string[] text = { "Z té naší hospody", "vedou jen tři schody", "to je ten důvod má milá", "proč já se nevracím brzy."};
            //string veta = string.Join(",\n", text);
            //Console.WriteLine(veta);
            //Console.ReadKey();

            //

            string text = "petr.martinek@gmail.com";
            if (text.Contains("@"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("String je gmail.");
                Console.ReadKey();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("String není gmail.");
                Console.ReadKey();
            }
        }
    }
}
