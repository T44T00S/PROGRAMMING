using System;
using System.Collections.Generic;
using System.Text;

namespace Filmova_databaze2
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
