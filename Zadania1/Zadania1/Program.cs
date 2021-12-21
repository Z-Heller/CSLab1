using System;

namespace Zadania1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ZADANIE 1");

            Licz ob1 = new Licz(3);

            ob1.Wypisz();

            Console.WriteLine("dodaj : " + ob1.Dodaj(12));
            Console.WriteLine("dodaj : " + ob1.Dodaj(2));
            Console.WriteLine("odejmij : " + ob1.Odejmij(3));
            Console.WriteLine("dodaj : " + ob1.Dodaj(5));



            Console.WriteLine("\n\nZADANIE 2");

            int[] tab = { 12, 44, 17, 3, 7, 24, 17, 66, 4, 80 };

            Sumator Sumator = new Sumator(tab);

            Console.Write("Wszystkie elementy: ");
            Sumator.Wypisz();

            Console.Write("\nOd 2 do 6: ");
            Sumator.WypiszPrzedzial(2, 6);

            Console.Write("\nIlość elementów: ");
            Console.Write(Sumator.IleElementow());

            Console.Write("\nSuma elementów: ");
            Console.Write(Sumator.Suma());

            Console.Write("\nSuma elementów podzielnych przez 2: ");
            Console.Write(Sumator.SumaPodziel2());



            Console.WriteLine("\n\nZADANIE 3");
            DateTime dzisiaj = DateTime.Now;
            Data data = new Data(dzisiaj);

            data.DzisiajWypisz();
            Console.WriteLine("Dodaj tydzień: "+data.DodajTydzien().ToString("d"));
            Console.WriteLine("Odejmij tydzień: " + data.OdejmijTydzien().ToString("d"));



            Console.WriteLine("\n\nZADANIE 4");
            String l = "135";
            Liczba liczba = new Liczba(l);

            Console.Write("Liczba: ");
            liczba.Wypisz();

            Console.Write("\nMnożenie przez 5: ");
            liczba.Mnoz(5);
            liczba.Wypisz();

            Console.Write("\nSilnia liczby 7: "+liczba.Silnia(7)+"\n");

        }
    }
}
