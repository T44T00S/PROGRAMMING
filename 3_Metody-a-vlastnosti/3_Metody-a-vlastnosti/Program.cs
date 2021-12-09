using System;

namespace _3_Metody_a_vlastnosti
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto skoda = new Auto("Škoda", "sedan", "Modrá");

            Auto tesla = new Auto("Tesla", "electric", "bílá");

            tesla.UdelatZvuk("vruum");

            Console.WriteLine();
            Console.WriteLine(skoda.nazev);
            Console.WriteLine(tesla.nazev);
            Console.WriteLine(tesla.barva);
            Console.WriteLine("Název je {0}, jméno je {1}, barva je {2}", skoda.nazev, skoda.typ, skoda.barva);

            Console.ReadLine();
        }
    }
}
