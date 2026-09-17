using Konsolowa;
using Xunit;

namespace Testy
{
    public class SzyfrCezaraTests
    {
        [Fact]
        public void SzyfrowaniePodstawowegoTekstu()
        {
            SzyfrCezara szyfrCezara = new SzyfrCezara();

            string wynik = szyfrCezara.Szyfruj("abc", 3);

            Assert.Equal("def", wynik);
        }

        [Fact]
        public void ZawijanieLiterWTekscie()
        {
            SzyfrCezara szyfrCezara = new SzyfrCezara();

            string wynik = szyfrCezara.Szyfruj("xyz", 3);

            Assert.Equal("abc", wynik);
        }

        [Fact]
        public void OdszyfrowanieKluczemUjemnym()
        {
            SzyfrCezara szyfrCezara = new SzyfrCezara();

            string wynik = szyfrCezara.Szyfruj("def", -3);

            Assert.Equal("abc", wynik);
        }

        [Fact]
        public void KluczWiekszyNizDlugoscAlfabetu()
        {
            SzyfrCezara szyfrCezara = new SzyfrCezara();

            string wynik = szyfrCezara.Szyfruj("abc", 29);

            Assert.Equal("def", wynik);
        }

        [Fact]
        public void SpacjaWTeksciePozostajeBezZmian()
        {
            SzyfrCezara szyfrCezara = new SzyfrCezara();

            string wynik = szyfrCezara.Szyfruj("ab cd", 2);

            Assert.Equal("cd ef", wynik);
        }
    }
}