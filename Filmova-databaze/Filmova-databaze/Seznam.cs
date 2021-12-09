using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmova_databaze
{
    class film
    {
        public film(string jmeno, string autor, string zanr, int rok)
        {
            this.Jmeno = jmeno;
            this.Autor = autor;
            this.Zanr = zanr;
            this.Rok = rok;

        }

        public string Jmeno { get; set; }
        public int Rok { get; set; }
        public string Autor { get; set; }
        public string Zanr { get; set; }
    }
}
