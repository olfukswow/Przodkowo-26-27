using System;

namespace NotatkiKonsola
{
    public class Notatka
    {
        public string Tytul;
        public string Tresc;
        public bool Priorytet;
        public DateTime DataDodania;

        public Notatka(string tytul, string tresc, bool priorytet)
        {
            Tytul = tytul;
            Tresc = tresc;
            Priorytet = priorytet;
            DataDodania = DateTime.Now;
        }

        public Notatka(string tytul)
        {
            Tytul = tytul;
            Tresc = "";
            Priorytet = false;
            DataDodania = DateTime.Now;
        }

        public void WyswietlNotatke()
        {
            Console.WriteLine("______________________________");

            if (Priorytet)
            {
                Console.WriteLine("Notatka WAŻNA! " + Tytul);
            }
            else
            {
                Console.WriteLine("Notatka " + Tytul);
            }

            Console.WriteLine(Tresc);
            Console.WriteLine(DataDodania.ToString("dd.MM.yyyy HH:mm:ss"));
            Console.WriteLine("______________________________");
        }
    }
}