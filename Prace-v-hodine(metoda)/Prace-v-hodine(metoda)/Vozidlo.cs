using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prace_v_hodine_metoda_
{
    class Vozidlo
    {
        public Vozidlo(string typ, string spz, string barva)
        {
            this.spz = spz;
            this.typ = typ;
            this.barva = barva;
        }

        public void Zatrub(string zvuk)
        {
            Console.Beep();
            //this.zvuk + Console.Beep());
        }

        public void UtekPolicii()
        {


            string[] barvy = { "červená", "modrá", "černá", "žlutá", "bílá" };
            Random rnd = new Random();
            barva = barvy[rnd.Next(0, barvy.Length)];
            //var randomIndex = barvy.Next(0, barvy.Length);
            //Console.Write(barvy[randomIndex]);
        }

        public string spz { get; set; }

        public string typ { get; set; }

        public string barva { get; set; }
    }
}
