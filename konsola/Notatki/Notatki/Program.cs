using System;

namespace Notatki
{
    /*
****************************************************
* klasa: Notatka
* opis: Klasa przechowuje tytul, tresc i identyfikator notatki oraz udostepnia metody wyswietlania danych.
* pola: licznikNotatek - liczba utworzonych notatek
* pola: identyfikator - unikalny identyfikator notatki
* pola: tytul - tytul notatki
* pola: tresc - tresc notatki
* autor: numer zdajacego
****************************************************
*/
    public class Notatka
    {
        private static int licznikNotatek = 0;
        private readonly int identyfikator;
        private string tytul;
        private string tresc;

        public Notatka(string tytul, string tresc)
        {
            licznikNotatek++;
            identyfikator = licznikNotatek;
            this.tytul = tytul;
            this.tresc = tresc;
        }

        public void WyswietlNotatke()
        {
            Console.WriteLine("Tytul: " + tytul);
            Console.WriteLine("Tresc: " + tresc);
        }

        public void WyswietlWartosciPol()
        {
            Console.WriteLine(
                identyfikator + ";" +
                licznikNotatek + ";" +
                tytul + ";" +
                tresc
            );
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Notatka pierwszaNotatka = new Notatka(
                "Zakupy",
                "Chleb, maslo, ser"
            );

            Notatka drugaNotatka = new Notatka(
                "Zadania",
                "Napisac program i wykonac testy"
            );

            Console.WriteLine("Pierwsza notatka:");
            pierwszaNotatka.WyswietlNotatke();

            Console.WriteLine();
            Console.WriteLine("Druga notatka:");
            drugaNotatka.WyswietlNotatke();

            Console.WriteLine();
            Console.WriteLine("Wartosci pol pierwszej notatki:");
            pierwszaNotatka.WyswietlWartosciPol();

            Console.WriteLine("Wartosci pol drugiej notatki:");
            drugaNotatka.WyswietlWartosciPol();

            Console.WriteLine();
            Console.WriteLine("Nacisnij dowolny klawisz, aby zakonczyc.");
            Console.ReadKey();
        }
    }
}