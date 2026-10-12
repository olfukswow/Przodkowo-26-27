using System;

namespace NwdApp
{
    internal class Program
    {
        /*
        nazwa funkcji: ObliczNWD
        opis funkcji: Oblicza najwiekszy wspolny dzielnik dwoch dodatnich liczb calkowitych algorytmem odejmowania.
        parametry: a - pierwsza dodatnia liczba calkowita; b - druga dodatnia liczba calkowita
        zwracany typ i opis: int - najwiekszy wspolny dzielnik liczb a i b
        autor: numer zdajacego
        */
        static int ObliczNWD(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }

            return a;
        }

        static int WczytajDodatniaLiczbe(string komunikat)
        {
            int liczba;
            Console.Write(komunikat);
            string tekst = Console.ReadLine();

            while (!int.TryParse(tekst, out liczba) || liczba <= 0)
            {
                Console.Write("Wpisz dodatnia liczbe calkowita: ");
                tekst = Console.ReadLine();
            }

            return liczba;
        }

        static void Main(string[] args)
        {
            int a = WczytajDodatniaLiczbe("Podaj dodatnia liczbe a: ");
            int b = WczytajDodatniaLiczbe("Podaj dodatnia liczbe b: ");
            int wynik = ObliczNWD(a, b);

            Console.WriteLine("NWD({0}, {1}) = {2}", a, b, wynik);
            Console.WriteLine("Nacisnij dowolny klawisz, aby zakonczyc.");
            Console.ReadKey();
        }
    }
}