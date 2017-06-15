using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrekiuSarasas
{
    public class Preke
    {
        public string Pavadinimas { get; private set; }
        public decimal Kaina { get; private set; }
        public string Kodas { get; private set; }
        public decimal Savikaina { get; private set; }

        public Preke(string pavadinimas, decimal kaina, string kodas, decimal savikaina)
        {
            Pavadinimas = pavadinimas;
            Kaina = kaina;
            Kodas = kodas;
            Savikaina = savikaina;
        }
    }
}
