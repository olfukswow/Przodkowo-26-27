using System;

namespace KonsolaPesel
{
    internal class Program
    {
        /// <summary>
        /// nazwa funkcji: OkreslPlec
        /// opis funkcji: Okresla plec osoby na podstawie dziesiatej cyfry numeru PESEL.
        /// parametry: numerPesel - tekst zawierajacy jedenastocyfrowy numer PESEL
        /// zwracany typ i opis: char - K dla kobiety albo M dla mezczyzny
        /// autor: numer zdajacego
        /// </summary>
        static char OkreslPlec(string numerPesel)
        {
            int cyfraPlci = int.Parse(numerPesel[9].ToString());

            if (cyfraPlci % 2 == 0)
            {
                return 'K';
            }

            return 'M';
        }

        static bool SprawdzSumeKontrolna(string numerPesel)
        {
            int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int suma = 0;

            for (int i = 0; i < 10; i++)
            {
                suma += int.Parse(numerPesel[i].ToString()) * wagi[i];
            }

            int modulo = suma % 10;
            int cyfraKontrolna;

            if (modulo == 0)
            {
                cyfraKontrolna = 0;
            }
            else
            {
                cyfraKontrolna = 10 - modulo;
            }

            return cyfraKontrolna == int.Parse(numerPesel[10].ToString());
        }

        static bool CzyPeselJestPoprawnyFormatowo(string numerPesel)
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
            Console.Write("Podaj numer PESEL: ");
            string numerPesel = Console.ReadLine();

            while (!CzyPeselJestPoprawnyFormatowo(numerPesel))
            {
                Console.WriteLine("Numer PESEL musi skladac sie z 11 cyfr.");
                Console.Write("Podaj numer PESEL: ");
                numerPesel = Console.ReadLine();
            }

            char plec = OkreslPlec(numerPesel);

            if (plec == 'K')
            {
                Console.WriteLine("Plec: Kobieta");
            }
            else
            {
                Console.WriteLine("Plec: Mezczyzna");
            }

            if (SprawdzSumeKontrolna(numerPesel))
            {
                Console.WriteLine("Suma kontrolna numeru PESEL jest zgodna.");
            }
            else
            {
                Console.WriteLine("Suma kontrolna numeru PESEL jest niezgodna.");
            }

            Console.WriteLine();
            Console.WriteLine("Nacisnij dowolny klawisz, aby zakonczyc.");
            Console.ReadKey();
        }
    }
}