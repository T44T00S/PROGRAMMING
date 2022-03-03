using System;
using System.Collections.Generic;
using System.Text;

namespace Cv5_Smoothie
{
    class Smoothie
    {
        public Smoothie(string ing1, string ing2, string ing3)
        {
            Ingredient1 = ing1;
            Ingredient2 = ing2;
            Ingredient3 = ing3;
        }

        public string Ingredient1 { get; set; }
        public string Ingredient2 { get; set; }
        public string Ingredient3 { get; set; }
    }
}
