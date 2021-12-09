using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Metody_a_vlastnosti
{
    class Auto
    {
        public Auto(string nazev, string typ, string barva)
        {
            this.nazev = nazev;
            this.typ = typ;
            this.barva = barva;
        }

        public void UdelatZvuk(string zvuk)
        {
            Console.WriteLine(zvuk);
        }

        public void UpravitTyp()
        {
            this.typ += "x";
        }

        public string nazev { get; set; }

        public string typ { get; set; }

        public string barva { get; set; }

    }
}
