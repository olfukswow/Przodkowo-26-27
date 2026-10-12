using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace HasloPracownika
{
    public partial class Form1 : Form
    {
        private string wygenerowaneHaslo = "";
        private const string MaleLitery = "abcdefghijklmnopqrstuvwxyz";
        private const string WielkieLitery = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string Cyfry = "0123456789";
        private const string ZnakiSpecjalne = "!@#$%^&*()_+-=";

        public Form1()
        {
            InitializeComponent();
            checkBoxLitery.Checked = true;
        }

        private void buttonGeneruj_Click(object sender, EventArgs e)
        {
            int dlugosc;

            if (!int.TryParse(textBoxDlugosc.Text, out dlugosc) || dlugosc <= 0)
            {
                dlugosc = 0;
            }

            string dostepneZnaki = "";
            string haslo = "";

            if (checkBoxLitery.Checked)
            {
                dostepneZnaki += MaleLitery + WielkieLitery;
                haslo += LosowyZnak(MaleLitery + WielkieLitery);
            }

            if (checkBoxCyfry.Checked)
            {
                dostepneZnaki += Cyfry;
                haslo += LosowyZnak(Cyfry);
            }

            if (checkBoxSpecjalne.Checked)
            {
                dostepneZnaki += ZnakiSpecjalne;
                haslo += LosowyZnak(ZnakiSpecjalne);
            }

            if (dostepneZnaki.Length == 0 || dlugosc == 0)
            {
                wygenerowaneHaslo = "";
                MessageBox.Show("Podaj poprawn¹ d³ugoœæ i wybierz przynajmniej jeden rodzaj znaków.");
                return;
            }

            while (haslo.Length < dlugosc)
            {
                haslo += LosowyZnak(dostepneZnaki);
            }

            char[] znakiHasla = haslo.ToCharArray();

            for (int i = znakiHasla.Length - 1; i > 0; i--)
            {
                int indeks = RandomNumberGenerator.GetInt32(i + 1);
                char tymczasowy = znakiHasla[i];
                znakiHasla[i] = znakiHasla[indeks];
                znakiHasla[indeks] = tymczasowy;
            }

            wygenerowaneHaslo = new string(znakiHasla);
            MessageBox.Show(wygenerowaneHaslo, "Wygenerowane has³o");
        }

        private char LosowyZnak(string zestaw)
        {
            int indeks = RandomNumberGenerator.GetInt32(zestaw.Length);
            return zestaw[indeks];
        }

        private void buttonZatwierdz_Click(object sender, EventArgs e)
        {
            string imie = textBoxImie.Text;
            string nazwisko = textBoxNazwisko.Text;
            string stanowisko = comboBoxStanowisko.Text;

            MessageBox.Show(
                "Dane pracownika: " + imie + " " + nazwisko + " " + stanowisko +
                " Has³o: " + wygenerowaneHaslo,
                "Dane pracownika"
            );
        }
    }
}