using System;

namespace Konsolowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SzyfrCezara szyfrCezara = new SzyfrCezara();

            Console.WriteLine("SZYFR CEZARA");
            Console.WriteLine();

            Console.Write("Podaj tekst jawny: ");
            string tekstJawny = Console.ReadLine() ?? "";

            Console.Write("Podaj klucz: ");
            string tekstKlucza = Console.ReadLine() ?? "";

            int klucz;

            if (!int.TryParse(tekstKlucza, out klucz))
            {
                klucz = 0;
            }

            string tekstZaszyfrowany = szyfrCezara.Szyfruj(tekstJawny, klucz);

            Console.WriteLine();
            Console.WriteLine("Tekst zaszyfrowany: " + tekstZaszyfrowany);
        }
    }
}