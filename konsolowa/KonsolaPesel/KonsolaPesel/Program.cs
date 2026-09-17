using System;

namespace KonsolaPesel
{
    internal class Program
    {
        /*
        nazwa funkcji: OkreslPlec
        opis funkcji: Funkcja okresla plec osoby na podstawie dziesiatej cyfry numeru PESEL.
        parametry: numerPesel - zmienna tekstowa zawierajaca numer PESEL
        zwracany typ i opis: char - znak K oznaczajacy kobiete albo M oznaczajacy mezczyzne
        autor: numer zdajacego
        */
        static char OkreslPlec(string numerPesel)
        {
            int cyfraPlci = int.Parse(numerPesel[9].ToString());

            if (cyfraPlci % 2 == 0)
            {
                return 'K';
            }

            return 'M';
        }

        /*
        nazwa funkcji: SprawdzSumeKontrolna
        opis funkcji: Funkcja sprawdza zgodnosc sumy kontrolnej numeru PESEL.
        parametry: numerPesel - zmienna tekstowa zawierajaca numer PESEL
        zwracany typ i opis: bool - wartosc true oznacza zgodna sume kontrolna
        autor: numer zdajacego
        */
        static bool SprawdzSumeKontrolna(string numerPesel)
        {
            int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int suma = 0;

            for (int i = 0; i < 10; i++)
            {
                int cyfra = int.Parse(numerPesel[i].ToString());
                suma += cyfra * wagi[i];
            }

            int modulo = suma % 10;
            int r;

            if (modulo == 0)
            {
                r = 0;
            }
            else
            {
                r = 10 - modulo;
            }

            int cyfraKontrolna = int.Parse(numerPesel[10].ToString());

            return r == cyfraKontrolna;
        }

        static bool CzyNumerPeselJestPoprawny(string numerPesel)
        {
            if (numerPesel.Length != 11)
            {
                return false;
            }

            for (int i = 0; i < numerPesel.Length; i++)
            {
                if (!char.IsDigit(numerPesel[i]))
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            string numerPesel;

            Console.Write("Podaj numer PESEL: ");
            numerPesel = Console.ReadLine();

            while (!CzyNumerPeselJestPoprawny(numerPesel))
            {
                Console.WriteLine("Numer PESEL musi byc 11-cyfrowym identyfikatorem numerycznym.");
                Console.Write("Podaj numer PESEL: ");
                numerPesel = Console.ReadLine();
            }

            char plec = OkreslPlec(numerPesel);

            if (plec == 'K')
            {
                Console.WriteLine("Kobieta");
            }
            else
            {
                Console.WriteLine("Mezczyzna");
            }

            if (SprawdzSumeKontrolna(numerPesel))
            {
                Console.WriteLine("Suma kontrolna numeru PESEL jest zgodna.");
            }
            else
            {
                Console.WriteLine("Suma kontrolna numeru PESEL jest niezgodna.");
            }

            Console.WriteLine("Nacisnij dowolny klawisz, aby zakonczyc.");
            Console.ReadKey();
        }
    }
}