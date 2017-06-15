using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaujaPrograma
{
    class Telefonas
    {
        public string Pavadinimas { get; protected set; }
        public string Firma { get; protected set; }
        protected int Ram { get; set; }
        protected int MegaPixels { get; set; }
        public double Kaina { get; protected set; }

        public Telefonas(string pavadinimas, string firma, int ram, int megaPixels,
            double kaina)
        {
            Pavadinimas = pavadinimas;
            Firma = firma;
            Ram = ram;
            MegaPixels = megaPixels;
            Kaina = kaina;
        }

        public virtual void Isvedimas()
        {
            Console.WriteLine("Telefono pavadinimas: {0}", Pavadinimas);
            Console.WriteLine("Firma: {0}", Firma);
            Console.WriteLine("Telefono RAM: {0} GB", Ram);
            Console.WriteLine("Kameros mega pikseliai: {0} MP", MegaPixels);
            Console.WriteLine("Irenginio kaina: {0} EUR", Kaina);
        }
    }

    class PapildomsFunkcijos : Telefonas
    { 
        public string DvigubaKamera { get; private set; } 

        public PapildomsFunkcijos(string pavadinimas, string firma, int ram, int megaPixels, int kaina, 
            string dvigubaKamera)
            :base(pavadinimas, firma, ram, megaPixels, kaina)
        {
            DvigubaKamera = dvigubaKamera;
        }


        public override void Isvedimas()
        {
            base.Isvedimas();
            Console.WriteLine("Yra ir papildoma funkcija, vardu: " + DvigubaKamera);
            Console.WriteLine();
        }

    }

    class PapildomaFunkcija2 : Telefonas
    {
        public string VirtualiSaugykla { get; private set; }

        public PapildomaFunkcija2 (string pavadinimas, string firma, int ram, int megaPixels, int kaina,
            string virtualiSaugykla)
            :base(pavadinimas, firma, ram, megaPixels, kaina)
        {
            VirtualiSaugykla = virtualiSaugykla;
        }

        public override void Isvedimas()
        {
            base.Isvedimas();
            Console.WriteLine("Irenginys taippat turi {0}", VirtualiSaugykla);
            Console.WriteLine();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            PapildomsFunkcijos funkcijos = new PapildomsFunkcijos("OnePlus 5", "OnePlus", 8, 16, 500, 
                "Double Lens");
            funkcijos.Isvedimas();

            PapildomaFunkcija2 funkcijos2 = new PapildomaFunkcija2("Pixel XL", "Google", 4, 14, 950,
                "Google Cloud");
            funkcijos2.Isvedimas();

            Program p = new Program();
            var sum = p.VidSuma(funkcijos, funkcijos2);
            Console.WriteLine("Visu irenginiu vidutine kaina: " + sum);

            Console.WriteLine("Visu firmu pavadinimai:");
            List<string> Sarasas = new List<string>
            {
                funkcijos.Firma,
                funkcijos2.Firma
            };

            foreach (var Firma in Sarasas)
            {
                Console.WriteLine(Firma);
            }




            Console.WriteLine("Visi telefonu pavadinimai:");
            List<string> SarasasTelefonu = new List<string>
            {
                funkcijos.Pavadinimas,
                funkcijos2.Pavadinimas
            };

            foreach (var Pavadinimas in SarasasTelefonu)
            {
                Console.WriteLine(Pavadinimas);
            }



            Console.ReadLine();

        }

        public double VidSuma(PapildomsFunkcijos funkcijos, PapildomaFunkcija2 funkcijos2)
        {
            var suma = funkcijos.Kaina + funkcijos2.Kaina;
            var dalyba = suma / 2;

            return dalyba;
        }

    }



}
