using System;
using System.Collections.Generic;
using System.Text;

namespace _5_Filmova_databaze
{
    class film
    {
        public film(string jmeno, string autor, string zanr, int rok)
        {
            Jmeno = jmeno;
            Autor = autor;
            Zanr = zanr;
            Rok = rok;

        }

        public string Jmeno { get; set; }
        public int Rok { get; set; }
        public string Autor { get; set; }
        public string Zanr { get; set; }
    }
}
