using System;
using System.Text;

namespace SortowanieBabelkowe
{
    internal class Program
    {
        static void SortujBabelkowo(int[] tablica)
        {
            for (int przebieg = 0; przebieg < tablica.Length - 1; przebieg++)
            {
                bool wykonanoZamiane = false;

                for (int indeks = 0; indeks < tablica.Length - 1 - przebieg; indeks++)
                {
                    if (tablica[indeks] > tablica[indeks + 1])
                    {
                        int tymczasowa = tablica[indeks];
                        tablica[indeks] = tablica[indeks + 1];
                        tablica[indeks + 1] = tymczasowa;

                        wykonanoZamiane = true;
                    }
                }

                if (!wykonanoZamiane)
                {
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] liczby = new int[100];
            Random generator = new Random();

            for (int indeks = 0; indeks < liczby.Length; indeks++)
            {
                liczby[indeks] = generator.Next(0, 1001);
            }

            SortujBabelkowo(liczby);

            Console.WriteLine("Tablica 100 liczb posortowana rosnąco:");
            Console.WriteLine();

            for (int indeks = 0; indeks < liczby.Length; indeks++)
            {
                Console.Write(liczby[indeks]);

                if (indeks < liczby.Length - 1)
                {
                    Console.Write("; ");
                }

                if ((indeks + 1) % 10 == 0)
                {
                    Console.WriteLine();
                }
            }

            bool poprawnaKolejnosc = true;

            for (int indeks = 0; indeks < liczby.Length - 1; indeks++)
            {
                if (liczby[indeks] > liczby[indeks + 1])
                {
                    poprawnaKolejnosc = false;
                    break;
                }
            }

            Console.WriteLine();

            if (poprawnaKolejnosc)
            {
                Console.WriteLine("Wynik testu: sortowanie zakończone poprawnie.");
            }
            else
            {
                Console.WriteLine("Wynik testu: tablica nie jest posortowana rosnąco.");
            }

            Console.WriteLine();
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć.");
            Console.ReadKey();
        }
    }
}