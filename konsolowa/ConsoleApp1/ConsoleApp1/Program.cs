using System;
using System.Text;
using Wspolne;

namespace KosciKonsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int liczbaKostek;

            do
            {
                Console.WriteLine("Ile kostek chcesz rzucić? (3 - 10)");

                string wpisanaWartosc = Console.ReadLine() ?? "";

                if (!int.TryParse(wpisanaWartosc, out liczbaKostek))
                {
                    liczbaKostek = 0;
                }
            }
            while (liczbaKostek < 3 || liczbaKostek > 10);

            Random generator = new Random();
            string odpowiedz;

            do
            {
                int[] wyniki = LogikaGry.LosujKosci(
                    liczbaKostek,
                    generator
                );

                for (int indeks = 0; indeks < wyniki.Length; indeks++)
                {
                    Console.WriteLine(
                        "Kostka " + (indeks + 1) + ": " + wyniki[indeks]
                    );
                }

                int punkty = LogikaGry.ObliczPunkty(wyniki);

                Console.WriteLine(
                    "Liczba uzyskanych punktów: " + punkty
                );

                do
                {
                    Console.WriteLine("Jeszcze raz? (t/n)");

                    odpowiedz = (Console.ReadLine() ?? "")
                        .Trim()
                        .ToLowerInvariant();
                }
                while (odpowiedz != "t" && odpowiedz != "n");

                Console.WriteLine();
            }
            while (odpowiedz == "t");
        }
    }
}