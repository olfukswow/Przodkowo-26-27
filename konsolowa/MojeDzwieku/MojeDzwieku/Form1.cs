using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Wspolne;

namespace MojeDzwieki
{
    public class OknoGlowne : Form
    {
        private readonly List<Album> albumy = new List<Album>();

        private readonly Label etykietaWykonawca = new Label();
        private readonly Label etykietaTytul = new Label();
        private readonly Label etykietaUtwory = new Label();
        private readonly Label etykietaRok = new Label();
        private readonly Label etykietaPobrania = new Label();

        private readonly Button przyciskPoprzedni = new Button();
        private readonly Button przyciskNastepny = new Button();
        private readonly Button przyciskPobierz = new Button();

        private readonly PictureBox obrazPlyty = new PictureBox();

        private int indeksAlbumu = 0;

        public OknoGlowne()
        {
            UtworzInterfejs();
            WczytajGrafiki();

            try
            {
                string sciezka = Path.Combine(
                    AppContext.BaseDirectory,
                    "Dane.txt"
                );

                albumy.AddRange(
                    ObslugaAlbumow.WczytajAlbumy(sciezka)
                );

                if (albumy.Count == 0)
                {
                    UstawDostepnoscPrzyciskow(false);
                    MessageBox.Show("Plik nie zawiera albumów.");
                }
                else
                {
                    WyswietlAktualnyAlbum();
                }
            }
            catch (Exception blad)
            {
                UstawDostepnoscPrzyciskow(false);

                MessageBox.Show(
                    "Nie uda³o siê wczytaæ albumów: " + blad.Message,
                    "B³¹d",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void UtworzInterfejs()
        {
            Text = "MojeDŸwiêki, Wykona³: numer zdaj¹cego";
            ClientSize = new Size(1400, 400);
            BackColor = ColorTranslator.FromHtml("#2E8B57");
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            AutoScaleMode = AutoScaleMode.None;

            przyciskPoprzedni.SetBounds(25, 155, 100, 70);
            przyciskPoprzedni.FlatStyle = FlatStyle.Flat;
            przyciskPoprzedni.FlatAppearance.BorderSize = 0;
            przyciskPoprzedni.BackColor = BackColor;
            przyciskPoprzedni.BackgroundImageLayout = ImageLayout.Stretch;
            przyciskPoprzedni.Click += PoprzedniAlbum_Click;

            przyciskNastepny.SetBounds(1275, 155, 100, 70);
            przyciskNastepny.FlatStyle = FlatStyle.Flat;
            przyciskNastepny.FlatAppearance.BorderSize = 0;
            przyciskNastepny.BackColor = BackColor;
            przyciskNastepny.BackgroundImageLayout = ImageLayout.Stretch;
            przyciskNastepny.Click += NastepnyAlbum_Click;

            obrazPlyty.SetBounds(165, 35, 240, 240);
            obrazPlyty.SizeMode = PictureBoxSizeMode.Zoom;

            etykietaWykonawca.SetBounds(440, 45, 810, 100);
            etykietaWykonawca.Font = new Font(
                "Arial",
                50,
                FontStyle.Regular
            );
            etykietaWykonawca.ForeColor = Color.White;

            etykietaTytul.SetBounds(440, 150, 810, 65);
            etykietaTytul.Font = new Font(
                "Arial",
                30,
                FontStyle.Italic
            );
            etykietaTytul.ForeColor = Color.White;

            etykietaUtwory.SetBounds(440, 225, 200, 45);
            etykietaUtwory.Font = new Font("Arial", 20);
            etykietaUtwory.ForeColor =
                ColorTranslator.FromHtml("#61D918");

            etykietaRok.SetBounds(650, 225, 150, 45);
            etykietaRok.Font = new Font("Arial", 20);
            etykietaRok.ForeColor =
                ColorTranslator.FromHtml("#61D918");

            etykietaPobrania.SetBounds(155, 315, 250, 45);
            etykietaPobrania.Font = new Font("Arial", 20);
            etykietaPobrania.ForeColor =
                ColorTranslator.FromHtml("#61D918");
            etykietaPobrania.TextAlign = ContentAlignment.MiddleCenter;

            przyciskPobierz.SetBounds(440, 310, 135, 50);
            przyciskPobierz.Text = "Pobierz";
            przyciskPobierz.Font = new Font(
                "Arial",
                20,
                FontStyle.Bold
            );
            przyciskPobierz.BackColor =
                ColorTranslator.FromHtml("#61D918");
            przyciskPobierz.ForeColor = Color.Black;
            przyciskPobierz.FlatStyle = FlatStyle.Flat;
            przyciskPobierz.FlatAppearance.BorderSize = 0;
            przyciskPobierz.Click += PobierzAlbum_Click;

            Controls.Add(przyciskPoprzedni);
            Controls.Add(przyciskNastepny);
            Controls.Add(obrazPlyty);
            Controls.Add(etykietaWykonawca);
            Controls.Add(etykietaTytul);
            Controls.Add(etykietaUtwory);
            Controls.Add(etykietaRok);
            Controls.Add(etykietaPobrania);
            Controls.Add(przyciskPobierz);
        }

        private void WczytajGrafiki()
        {
            try
            {
                obrazPlyty.Image = WczytajObraz("obraz.png");

                przyciskPoprzedni.BackgroundImage =
                    WczytajObraz("obraz2.png");

                przyciskNastepny.BackgroundImage =
                    WczytajObraz("obraz3.png");
            }
            catch (Exception blad)
            {
                MessageBox.Show(
                    "Nie uda³o siê wczytaæ grafik: " + blad.Message,
                    "B³¹d grafik",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private Image WczytajObraz(string nazwaPliku)
        {
            string sciezka = Path.Combine(
                AppContext.BaseDirectory,
                nazwaPliku
            );

            using (Image obraz = Image.FromFile(sciezka))
            {
                return new Bitmap(obraz);
            }
        }

        private void WyswietlAktualnyAlbum()
        {
            Album album = albumy[indeksAlbumu];

            etykietaWykonawca.Text = album.Wykonawca;
            etykietaTytul.Text = album.Tytul;
            etykietaUtwory.Text = album.LiczbaUtworow + " utworów";
            etykietaRok.Text = album.RokWydania.ToString();
            etykietaPobrania.Text = album.LiczbaPobran.ToString();
        }

        private void PoprzedniAlbum_Click(object sender, EventArgs e)
        {
            indeksAlbumu--;

            if (indeksAlbumu < 0)
            {
                indeksAlbumu = albumy.Count - 1;
            }

            WyswietlAktualnyAlbum();
        }

        private void NastepnyAlbum_Click(object sender, EventArgs e)
        {
            indeksAlbumu++;

            if (indeksAlbumu >= albumy.Count)
            {
                indeksAlbumu = 0;
            }

            WyswietlAktualnyAlbum();
        }

        private void PobierzAlbum_Click(object sender, EventArgs e)
        {
            albumy[indeksAlbumu].LiczbaPobran++;
            WyswietlAktualnyAlbum();
        }

        private void UstawDostepnoscPrzyciskow(bool dostepne)
        {
            przyciskPoprzedni.Enabled = dostepne;
            przyciskNastepny.Enabled = dostepne;
            przyciskPobierz.Enabled = dostepne;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                obrazPlyty.Image?.Dispose();
                przyciskPoprzedni.BackgroundImage?.Dispose();
                przyciskNastepny.BackgroundImage?.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}