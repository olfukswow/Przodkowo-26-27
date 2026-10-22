using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Wspolne
{
    public static class ObslugaAlbumow
    {
        /*
        ****************************************
        nazwa metody: WczytajAlbumy
        opis metody: Wczytuje wszystkie rekordy albumow muzycznych z pliku.
        parametry: sciezka - sciezka do pliku z danymi albumow
        zwracany typ i opis: List<Album> - kolekcja wszystkich wczytanych albumow
        autor: numer zdajacego
        ****************************************
        */
        public static List<Album> WczytajAlbumy(string sciezka)
        {
            List<Album> albumy = new List<Album>();

            using (StreamReader czytnik = new StreamReader(
                sciezka,
                Encoding.UTF8))
            {
                while (!czytnik.EndOfStream)
                {
                    string wykonawca = czytnik.ReadLine() ?? "";

                    if (string.IsNullOrWhiteSpace(wykonawca))
                    {
                        continue;
                    }

                    Album album = new Album
                    {
                        Wykonawca = wykonawca,
                        Tytul = czytnik.ReadLine() ?? "",
                        LiczbaUtworow = int.Parse(czytnik.ReadLine() ?? ""),
                        RokWydania = int.Parse(czytnik.ReadLine() ?? ""),
                        LiczbaPobran = long.Parse(czytnik.ReadLine() ?? "")
                    };

                    albumy.Add(album);
                }
            }

            return albumy;
        }

        public static void WyswietlAlbumy(List<Album> albumy)
        {
            foreach (Album album in albumy)
            {
                Console.WriteLine(album.Wykonawca);
                Console.WriteLine(album.Tytul);
                Console.WriteLine(album.LiczbaUtworow);
                Console.WriteLine(album.RokWydania);
                Console.WriteLine(album.LiczbaPobran);
                Console.WriteLine();
            }
        }
    }
}