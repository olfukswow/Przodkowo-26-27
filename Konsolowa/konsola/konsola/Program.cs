using System;

namespace Konsola
{
    internal class Program
    {
        static Random generator = new Random();
        /*
****************************************
nazwa funkcji: LosujZestaw
opis funkcji: Generuje zestaw sześciu różnych liczb całkowitych z zakresu od 1 do 49.
parametry: brak
zwracany typ i opis: int[] - tablica zawierająca sześć wylosowanych liczb.
autor: NUMER_ZDAJACEGO
****************************************
*/
        static int[] LosujZestaw()
        {
            int[] zestaw = new int[6];
            int liczbaWylosowanych = 0;

            while (liczbaWylosowanych < 6)
            {
                int liczba = generator.Next(1, 50);
                bool wystepuje = false;

                for (int i = 0; i < liczbaWylosowanych; i++)
                {
                    if (zestaw[i] == liczba)
                    {
                        wystepuje = true;
                    }
                }

                if (!wystepuje)
                {
                    zestaw[liczbaWylosowanych] = liczba;
                    liczbaWylosowanych++;
                }
            }

            return zestaw;
        }

        static void WyswietlZestawy(int[,] zestawy)
        {
            for (int i = 0; i < zestawy.GetLength(0); i++)
            {
                Console.Write("Losowanie " + (i + 1) + ": ");

                for (int j = 0; j < zestawy.GetLength(1); j++)
                {
                    Console.Write(zestawy[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        static int[] PoliczWystapienia(int[,] zestawy)
        {
            int[] wystapienia = new int[50];

            for (int i = 0; i < zestawy.GetLength(0); i++)
            {
                for (int j = 0; j < zestawy.GetLength(1); j++)
                {
                    int liczba = zestawy[i, j];
                    wystapienia[liczba]++;
                }
            }

            return wystapienia;
        }

        static void WyswietlWystapienia(int[] wystapienia)
        {
            for (int i = 1; i <= 49; i++)
            {
                Console.WriteLine("Wystąpienia liczby " + i + ": " + wystapienia[i]);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Ile wygenerować losowań? ");
            int liczbaLosowan;

            while (!int.TryParse(Console.ReadLine(), out liczbaLosowan) || liczbaLosowan <= 0)
            {
                Console.Write("Podaj poprawną dodatnią liczbę: ");
            }

            int[,] zestawy = new int[liczbaLosowan, 6];

            for (int i = 0; i < liczbaLosowan; i++)
            {
                int[] zestaw = LosujZestaw();

                for (int j = 0; j < 6; j++)
                {
                    zestawy[i, j] = zestaw[j];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Zestawy wylosowanych liczb:");
            WyswietlZestawy(zestawy);

            int[] wystapienia = PoliczWystapienia(zestawy);

            Console.WriteLine();
            Console.WriteLine("Wystąpienia liczb od 1 do 49:");
            WyswietlWystapienia(wystapienia);

            Console.ReadKey();
        }
    }
}