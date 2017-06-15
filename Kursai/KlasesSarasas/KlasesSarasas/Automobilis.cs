using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasesSarasas
{
    public class Automobilis
    {
        public string Marke { get; }
        public string Modelis { get; }
        public int Metai { get; }
        public double DarbinisTuris { get; }
        public string KuroTipas { get; }


        public Automobilis(string marke, string modelis,
            int metai, double darbinisTuris, string kuras)
        {
            Marke = marke;
            Modelis = modelis;
            Metai = metai;
            DarbinisTuris = darbinisTuris;
            KuroTipas = kuras;
        }
    }
}
