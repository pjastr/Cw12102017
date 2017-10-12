using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication27
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.marka = "Skoda";
            car1.UstawRokProdukcji(2012);
            car1.srednieSpalanie = 3;
            Console.WriteLine(car1.ObliczKosztSpalania(200, 5));

            //Car car2 = new Car();
            //car2.marka = "Ford";
            //car2.UstawRokProdukcji(2015);

            //Console.WriteLine(car2.Info());

            //car2 = car1;

            Console.ReadKey();

        }
    }

    
}
