    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Parduotuve
    {
        class Parduotuve
        {
            public string Pavadinimas { get; }
            public List<Preke> PrekiuSarasas { get; }

            public Parduotuve(string pavadinimas)
            {
                Pavadinimas = pavadinimas;


                PrekiuSarasas = new List<Preke>
                {
                    new Preke("Cipsai", 0.1, 0.9, 142),
                    new Preke("Vanduo", 0.1, 0.4, 332),
                    new Preke("PS5 Konsole", 0.1, 799, 135),
                    new Preke("Sasiuvinys", 0.1, 0.1, 223),
                    new Preke("PC pele", 0.1, 8.99, 532),
                };
            }

            public void Isvedimas()
            {
                Console.WriteLine("Parduotuve: " + Pavadinimas);
                Console.WriteLine("Visos prekes: " );

                foreach (var preke in PrekiuSarasas)
                {
                    preke.Isvedimas();
                }

           
            

                Console.WriteLine();
            }

            public double Savikainos()
            {
                //Console.WriteLine("Visu prekiu bendra savikaina: "); - perkelti i main

                double sumaSavikaina = 0;

                foreach (var Savikaina in PrekiuSarasas)
                {
                    sumaSavikaina += Savikaina.Savikaina;
                }

                return sumaSavikaina;
            }

            public double KainaBendra()
            {
                double BendraKaina = 0;

                foreach (var KainaBendra in PrekiuSarasas)
                {
                    BendraKaina += BendraKaina.KainaBendra;
                }

                return sumaBendra;
            }

            public double Pelnas()
            {
                var savikaina = Savikainos();
                var kaina BendraKaina();
                return kaina - savikaina;
            }
        }
    }
