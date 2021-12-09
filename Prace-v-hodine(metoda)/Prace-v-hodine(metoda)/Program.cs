using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prace_v_hodine_metoda_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Red;
            Vozidlo skoda = new Vozidlo("69-LOL", "kabriolet", "modrá");

            Vozidlo tesla = new Vozidlo("55AAGG", "sedan", "bílá");

            tesla.Zatrub("tuuut");

            //Console.WriteLine(tesla.Zatrub + Console.Beep());

            skoda.UtekPolicii();
            tesla.UtekPolicii();

            //Console.WriteLine(skoda.barva);
            //Console.WriteLine(tesla.barva);
            //Console.WriteLine(skoda.spz);
            Console.WriteLine("Typ auta je {0}, jeho SPZ - {1} a barva je {2}.", skoda.spz, skoda.typ, skoda.barva);

            Console.ReadLine();
        }
    }
}
