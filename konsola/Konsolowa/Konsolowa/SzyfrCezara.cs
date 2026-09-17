namespace Konsolowa
{
    public class SzyfrCezara
    {
        public string Szyfruj(string tekstJawny, int klucz)
        {
            string tekstZaszyfrowany = "";

            foreach (char znak in tekstJawny)
            {
                if (znak >= 'a' && znak <= 'z')
                {
                    int kodZnaku = znak - 'a';
                    int przesunietyKod = (kodZnaku + klucz) % 26;

                    if (przesunietyKod < 0)
                    {
                        przesunietyKod += 26;
                    }

                    tekstZaszyfrowany += (char)('a' + przesunietyKod);
                }
                else
                {
                    tekstZaszyfrowany += znak;
                }
            }

            return tekstZaszyfrowany;
        }
    }
}