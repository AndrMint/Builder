using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parduotuve
{
    class Program
    {
        static void Main(string[] args)
        {


            Parduotuve parduotuve = new Parduotuve("LIDL");
            parduotuve.Isvedimas();
            Console.WriteLine("Visu prekiu bendra savikaina: " + parduotuve.Savikainos());

        }
    }
}
