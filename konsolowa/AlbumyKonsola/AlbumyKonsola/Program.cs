using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Wspolne;

namespace AlbumyKonsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string sciezka = Path.Combine(
                AppContext.BaseDirectory,
                "Data.txt"
            );

            try
            {
                List<Album> albumy = ObslugaAlbumow.WczytajAlbumy(sciezka);

                ObslugaAlbumow.WyswietlAlbumy(albumy);
            }
            catch (Exception blad)
            {
                Console.WriteLine(
                    "Nie udało się wczytać danych: " + blad.Message
                );
            }

            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć.");
            Console.ReadKey();
        }
    }
}