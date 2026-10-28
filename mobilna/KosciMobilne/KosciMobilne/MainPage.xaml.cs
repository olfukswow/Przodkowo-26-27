using System;
using Microsoft.Maui.Controls;
using Wspolne;

namespace KosciMobilne
{
    public partial class MainPage : ContentPage
    {
        private readonly Random generator = new Random();
        private readonly Image[] obrazyKosci;
        private long wynikGry = 0;

        public MainPage()
        {
            InitializeComponent();

            obrazyKosci = new Image[]
            {
                Kostka1,
                Kostka2,
                Kostka3,
                Kostka4,
                Kostka5
            };
        }

        private void RzucKoscmi_Clicked(object sender, EventArgs e)
        {
            int[] wyniki = LogikaGry.LosujKosci(5, generator);

            for (int indeks = 0; indeks < wyniki.Length; indeks++)
            {
                obrazyKosci[indeks].Source =
                    "kostka" + wyniki[indeks] + ".jpg";
            }

            int wynikLosowania = LogikaGry.ObliczPunkty(wyniki);

            wynikGry += wynikLosowania;

            WynikLosowaniaLabel.Text =
                "Wynik tego losowania: " + wynikLosowania;

            WynikGryLabel.Text =
                "Wynik gry: " + wynikGry;
        }

        private void ResetujWynik_Clicked(object sender, EventArgs e)
        {
            wynikGry = 0;

            for (int indeks = 0; indeks < obrazyKosci.Length; indeks++)
            {
                obrazyKosci[indeks].Source = "question.jpg";
            }

            WynikLosowaniaLabel.Text = "Wynik tego losowania: 0";
            WynikGryLabel.Text = "Wynik gry: 0";
        }

        private void RzadKosci_SizeChanged(object sender, EventArgs e)
        {
            if (obrazyKosci == null)
            {
                return;
            }

            double dostepnaSzerokosc =
                RzadKosci.Width
                - RzadKosci.Padding.Left
                - RzadKosci.Padding.Right
                - RzadKosci.Spacing * 4;

            if (dostepnaSzerokosc <= 0)
            {
                return;
            }

            double szerokoscKostki = dostepnaSzerokosc / 5;

            for (int indeks = 0; indeks < obrazyKosci.Length; indeks++)
            {
                obrazyKosci[indeks].WidthRequest = szerokoscKostki;
            }
        }
    }
}