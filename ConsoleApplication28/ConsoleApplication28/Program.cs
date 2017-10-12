using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication28
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba dyrektor = new Osoba();
            dyrektor.imie = "Jan";
            dyrektor.nazwisko = "Nowak";
            dyrektor.rokUrodzenia = 1980;
            
            dyrektor.WyswietlInformacje();
            dyrektor.plec = "Mężczyzna";
            dyrektor.Plec();

            Console.ReadKey();
        }
    }
}
