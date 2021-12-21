using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania1
{
    class Licz
    {
        //public float wartosc;

        float wartosc;

        public Licz(float wartosc)
        {
            this.wartosc = wartosc;
        }

        public float Dodaj(float a)
        {
            return wartosc += a;
        }

        public float Odejmij(float a)
        {
            return wartosc -= a;
        }

        public void Wypisz()
        {
            Console.WriteLine("Wartosc: " + wartosc);
        }
    }
}
