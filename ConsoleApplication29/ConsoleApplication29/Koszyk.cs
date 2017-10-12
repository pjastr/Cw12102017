using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication29
{
    class Koszyk
    {
        public List<Produkt> lista = new List<Produkt>();

        public void DodajeProdukt(string nazwaP, int cenaP)
        {
            Produkt produktTemp = new Produkt();
            produktTemp.cena = cenaP;
            produktTemp.nazwa = nazwaP;
            lista.Add(produktTemp);
            Console.WriteLine("dodano produkt: {0}, cena: {1}", nazwaP, cenaP);
        }

        public void Ilosc()
        {
            Console.WriteLine(lista.Count);
        }

        public void Suma()
        {
            double suma = 0;
            foreach(var element in lista)
            {
                suma += element.cena;
            }
            Console.WriteLine(suma);
        }
    }
}
