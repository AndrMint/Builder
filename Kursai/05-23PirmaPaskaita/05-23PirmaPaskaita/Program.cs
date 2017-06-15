using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_23PirmaPaskaita
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> vardai = new List<string>();
            vardai.Add("Adomas");
            vardai.Add("Abdryius");
            vardai.Add("Simas");

            foreach (var vardas in vardai)
            {
                Console.Write(vardas + " ");
            }

            Modulis pirmas = new Modulis();
            pirmas.Isvedimas();

            Modulis antras = new Modulis("Matematika", 6, "e3adasda", 5, "Adomas", "Dundevicius" );
            antras.Isvedimas();


            List<Modulis> moduliai = new List<Modulis>();
            moduliai.Add(new Modulis("Taikomoji matematika", 6, "cbae", 21, "Jonas", "Jonauskas"));
            moduliai.Add(new Modulis("NoriuPicos", 2, "cebe", 31, "Vytautas", "Jonauskalas"));
            moduliai.Add(new Modulis("Geresne ateitis", 33, "kOD01", 62, "Arvydas", "Arvydauskas"));
            moduliai.Add(new Modulis("Peles visur", 5, "cbae", 12, "Tautas", "Janas"));

            //isvesti moduliu info

            foreach (var modulis in moduliai)
            {
                Console.WriteLine(modulis.Pavadinimas);
                modulis.Isvedimas();
            }

            Program p = new Program();
            Console.WriteLine("=============");
            Console.WriteLine("Rezultatai");
            Console.WriteLine("=============");


            var maziausiaiStudentu = p.MaziausiaiStudentu(moduliai);
            Console.WriteLine("Maziausiai studentu turincio modulio duomenyse yra: ");
            maziausiaiStudentu.Isvedimas();

            var daugiausiaiKreditu = p.DaugiausiaiKreditu(moduliai);
            Console.WriteLine("Daugiausiai kreditu turintis modulis:");
            daugiausiaiKreditu.Isvedimas();

            var studentuVidurkis = p.StudentuVidurkis(moduliai);

            Console.ReadLine();
        }


        public Modulis MaziausiaiStudentu(List<Modulis> moduliai)
        {
            var studentuSkaicius = moduliai[0].StudentuSkaicius;

            Modulis rastas = moduliai[0];

            foreach (var modulis in moduliai)
            {
                if (modulis.StudentuSkaicius < studentuSkaicius)
                {
                    studentuSkaicius = modulis.StudentuSkaicius;
                    rastas = modulis;
                }
            }

            return rastas;
        }

        public Modulis DaugiausiaiKreditu(List<Modulis> moduliai)
        {
            var daugiausiaiKreditu = moduliai[0].KredituSkaicius;
            var rastasModulis = moduliai[0];

            foreach (var modulis in moduliai)
            {
                if (modulis.KredituSkaicius > daugiausiaiKreditu)
                {
                    daugiausiaiKreditu = modulis.KredituSkaicius;
                    rastasModulis = modulis;
                }
            }
        }
        public double StudentuVidurkis(List<Modulis> moduliai)
        {
            var suma = 0;

            foreach (var mod int moduliai) {
                suma += mod.StudentuSkaicius;
            }

            var vidurkis = (double) suma / moduliai.Count;

            return Math.Round(vidurkis);
        }
    }
}

       



//esme naudoti metodus
//vyriausio pazymys
