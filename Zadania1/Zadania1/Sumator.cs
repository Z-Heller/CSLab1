using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania1
{
    class Sumator
    {
        //public int[] Liczby;
        private int[] Liczby;

        public Sumator()
        {
        }

        public int Suma()
        {
            int sum = 0;
            foreach (int el in Liczby)
            {
                sum += el;
            }

            return sum;
        }

        public int SumaPodziel2()
        {
            int sum = 0;
            for(int i=0; i<Liczby.Length; i++)
            {
                if (Liczby[i] % 2 == 0) sum += Liczby[i];
            }
            return sum;
        }

        public Sumator(int[] liczby)
        {
            this.Liczby = liczby;
        }

        public int IleElementow()
        {
            return Liczby.Length;

        }

        public void Wypisz()
        {
            for (int i = 0; i < Liczby.Length; i++)
            {
                Console.Write(Liczby[i] + ", ");
            }
        }

        public void WypiszPrzedzial(int lowIndex, int highIndex)
        {
            for (int i = 0; i < Liczby.Length; i++)
            {
                if (i >= lowIndex && i <= highIndex) Console.Write(Liczby[i]+", ");
            }
        }



    }
}
