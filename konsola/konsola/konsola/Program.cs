using System;

namespace Sortowanie
{
    public class TablicaLiczb
    {
        private int[] elementy;

        public TablicaLiczb(int[] elementy)
        {
            this.elementy = elementy;
        }

        /*
        * nazwa funkcji: SortujMalejaco
        * parametry wejściowe: brak - funkcja korzysta z tablicy zapisanej w obiekcie klasy
        * wartość zwracana: brak - funkcja sortuje tablicę zapisaną w obiekcie klasy
        * autor: numer PESEL zdającego
        */
        public void SortujMalejaco()
        {
            for (int pozycja = 0; pozycja < elementy.Length - 1; pozycja++)
            {
                int indeksNajwiekszego = SzukajNajwiekszejWartosci(pozycja);

                int tymczasowa = elementy[pozycja];
                elementy[pozycja] = elementy[indeksNajwiekszego];
                elementy[indeksNajwiekszego] = tymczasowa;
            }
        }

        /*
        * nazwa funkcji: SzukajNajwiekszejWartosci
        * parametry wejściowe: indeksStartowy - indeks pierwszego elementu przeszukiwanego fragmentu tablicy
        * wartość zwracana: int - indeks najwiekszego elementu w przeszukiwanym fragmencie tablicy
        * autor: numer PESEL zdającego
        */
        public int SzukajNajwiekszejWartosci(int indeksStartowy)
        {
            int indeksNajwiekszego = indeksStartowy;

            for (int i = indeksStartowy + 1; i < elementy.Length; i++)
            {
                if (elementy[i] > elementy[indeksNajwiekszego])
                {
                    indeksNajwiekszego = i;
                }
            }

            return indeksNajwiekszego;
        }

        public void Wyswietl()
        {
            for (int i = 0; i < elementy.Length; i++)
            {
                Console.Write(elementy[i]);

                if (i < elementy.Length - 1)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] liczby = new int[10];

            Console.WriteLine("Podaj 10 liczb calkowitych.");

            for (int i = 0; i < liczby.Length; i++)
            {
                Console.Write("Podaj liczbe " + (i + 1) + ": ");
                string tekst = Console.ReadLine();

                while (!int.TryParse(tekst, out liczby[i]))
                {
                    Console.Write("Podaj poprawna liczbe calkowita: ");
                    tekst = Console.ReadLine();
                }
            }

            TablicaLiczb tablica = new TablicaLiczb(liczby);
            tablica.SortujMalejaco();

            Console.WriteLine("Tablica posortowana malejaco:");
            tablica.Wyswietl();

            Console.WriteLine("Nacisnij dowolny klawisz, aby zakonczyc.");
            Console.ReadKey();
        }
    }
}