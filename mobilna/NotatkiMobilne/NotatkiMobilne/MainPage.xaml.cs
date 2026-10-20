using System;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace NotatkiMobilne
{
    public partial class MainPage : ContentPage
    {
        private readonly ObservableCollection<Notatka> notatki =
            new ObservableCollection<Notatka>();

        public MainPage()
        {
            InitializeComponent();

            notatki.Add(new Notatka(
                "tenis",
                "Gra z Ewą w poniedziałek",
                true
            ));

            ListaNotatek.ItemsSource = notatki;
        }

        private void DodajNotatke_Clicked(object sender, EventArgs e)
        {
            string tytul = PoleTytulu.Text ?? "";
            string tresc = PoleTresci.Text ?? "";

            Notatka nowaNotatka = new Notatka(
                tytul,
                tresc,
                false
            );

            notatki.Add(nowaNotatka);
        }
    }
}