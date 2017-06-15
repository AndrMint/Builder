using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parduotuve
{
    class Preke
    {
        public string Pavadinimas { get; }
        public double Savikaina { get; }
        public double Kaina { get; }
        public int Kodas { get; }

        public Preke() { }

        public Preke(string pavadinimas, double savikaina, double kaina,
            int kodas)
        {
            Pavadinimas = pavadinimas;
            Savikaina = savikaina;
            Kaina = kaina;
            Kodas = kodas;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Pavadinimas: " + Pavadinimas);
            Console.WriteLine("Savikaina: " + Savikaina + "eur");
            Console.WriteLine("Kaina: " + Kaina + "eur");
            Console.WriteLine("Kodas: " + Kodas);
        }
    }
}
