using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication28
{
    class Osoba
    {
        public string imie;
        public string nazwisko;
        public int rokUrodzenia;
        public int waga;
        public int wzrost;
        public bool okulary;
        public string plec;

        public int ObliczWiek()
        {
            return DateTime.Now.Year - rokUrodzenia;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine("Dane osoby: {0} {1}", imie, nazwisko);
            Console.WriteLine("Wiek: {0}", ObliczWiek());
        }
        public void Plec()
        {
            if (plec == "Kobieta")
            {
                Console.WriteLine("Dyrektorem jest Pani {0} {1}", imie, nazwisko);
            }
            else
            {
                Console.WriteLine("Dyrektorem jest Pan {0} {1}", imie, nazwisko);
            }
        }
    }
}
