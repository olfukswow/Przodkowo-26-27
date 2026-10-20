using System;
using System.Text;

namespace NotatkiKonsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Notatka pierwszaNotatka = new Notatka(
                "tenis",
                "Gra z Ewą w poniedziałek",
                true
            );

            Console.WriteLine("Podaj tytuł notatki:");
            string tytul = Console.ReadLine() ?? "";

            Notatka drugaNotatka = new Notatka(tytul);

            Console.WriteLine();
            pierwszaNotatka.WyswietlNotatke();

            Console.WriteLine();
            drugaNotatka.WyswietlNotatke();

            Console.WriteLine();
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć.");
            Console.ReadKey();
        }
    }
}