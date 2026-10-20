using System;
using Microsoft.Maui.Controls;

namespace WlasciwosciCzcionki
{
    public partial class MainPage : ContentPage
    {
        private readonly string[] cytaty =
        {
            "Dzień dobry",
            "Good morning",
            "Buenos dias"
        };

        private int indeksCytatu = 0;

        public MainPage()
        {
            InitializeComponent();
            CytatLabel.Text = cytaty[indeksCytatu];
        }

        private void RozmiarSlider_ValueChanged(
            object sender,
            ValueChangedEventArgs e)
        {
            if (RozmiarLabel == null || CytatLabel == null)
            {
                return;
            }

            int rozmiar = (int)e.NewValue;

            RozmiarLabel.Text = "Rozmiar: " + rozmiar;
            CytatLabel.FontSize = rozmiar;
        }

        private void ZmienCytat_Clicked(object sender, EventArgs e)
        {
            indeksCytatu++;

            if (indeksCytatu >= cytaty.Length)
            {
                indeksCytatu = 0;
            }

            CytatLabel.Text = cytaty[indeksCytatu];
        }
    }
}