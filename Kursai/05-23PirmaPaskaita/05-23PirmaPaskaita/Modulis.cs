using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_23PirmaPaskaita
{
    class Modulis
    {
        public string Pavadinimas { get; private set; }
        public int KredituSkaicius { get; private set; }
        public string Kodas { get; private set; }
        public int StudentuSkaicius { get; private set; }
        public string KoordVardas { get; private set; }
        public string KoordPavarde { get; private set; }

        public Modulis ()
        {
            Console.Write("Pavadinimas: ");
            Pavadinimas = Console.ReadLine();
            Console.Write("Kreditu skaicius: ");
            KredituSkaicius = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kodas: ");
            Kodas = Console.ReadLine();
            Console.WriteLine("Studentu skaicius: ");
            StudentuSkaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Koordinatoriaus vardas: ");
            KoordVardas = Console.ReadLine();
            Console.WriteLine("Koordinatoriaus pavarde: ");
            KoordPavarde = Console.ReadLine();

        }

        public Modulis(string pavadinimas, int kreditai, string kodas, int studentai, 
            string koordVardas, string koordPavarde)
        {
            Pavadinimas = pavadinimas;
            KredituSkaicius = kreditai;
            Kodas = kodas;
            StudentuSkaicius = studentai;
            KoordVardas = koordVardas;
            KoordPavarde = koordPavarde;

        }

        public void Isvedimas()
        {
            Console.WriteLine("Modulis: {0} (kodas: {1})", Pavadinimas, Kodas);
            Console.WriteLine("Kreditu skaicius: {0}", KredituSkaicius);
            Console.WriteLine("Studentu skaicius: {0}", StudentuSkaicius);
            Console.WriteLine("Koordinatoriaus vardas: {0}", KoordVardas);
            Console.WriteLine("Koordinatoriaus pavarde: {0}", KoordPavarde);
        }

        
    }
}
