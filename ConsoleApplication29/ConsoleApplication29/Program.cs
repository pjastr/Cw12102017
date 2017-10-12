using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication29
{
    class Program
    {
        static void Main(string[] args)
        {
            Koszyk koszykJana = new Koszyk();

            koszykJana.DodajeProdukt("Jabłko", 3);
            koszykJana.DodajeProdukt("Chleb", 3);
            koszykJana.DodajeProdukt("Mleko", 2);
            koszykJana.DodajeProdukt("Sok", 4);
            koszykJana.Ilosc();
            koszykJana.Suma();
            Console.ReadKey();
        }
    }
}
