using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania1
{
    class Liczba
    {
        int[] Cyfry = new int[0];

        public void Wypisz()
        {
            for(int i=0; i < Cyfry.Length; i++)
            {
                Console.Write(Cyfry[i]);
            }
        }

        public Liczba(String wart)
        {
            char[] WartArr = wart.ToArray();
            
            int[] WartInt=new int[WartArr.Length];
            for(int n=0; n<WartArr.Length; n++)
            {
                WartInt[n] = int.Parse(WartArr[n].ToString());
            }

            Cyfry = new int[WartInt.Length];
            WartInt.CopyTo(this.Cyfry, 0);
        }

        public void Mnoz(int n)
        {
            String liczba = string.Join("", Cyfry);
            int val = int.Parse(liczba);

            val *= n;

            liczba = val.ToString();
            char[] liczbaCharArr = liczba.ToCharArray();
            int[] liczbaIntArr = new int[liczbaCharArr.Length];
            for (int p = 0; p < liczbaCharArr.Length; p++)
            {
                liczbaIntArr[p] = int.Parse(liczbaCharArr[p].ToString());
            }

            if (Cyfry.Length < liczbaIntArr.Length)
            {
                int[] temp = new int[liczbaIntArr.Length];
                Cyfry = temp;
                for (int y = 0; y < liczbaIntArr.Length; y++)
                {
                    Cyfry[y] = liczbaIntArr[y];
                }
            }
            else
            {
                liczbaIntArr.CopyTo(Cyfry, 0);
            }

        }

        public int Silnia(int s)
        {
            if (s == 0 || s == 1) return 1;
            else return Silnia(s - 1)*s;
        }

    }
}
