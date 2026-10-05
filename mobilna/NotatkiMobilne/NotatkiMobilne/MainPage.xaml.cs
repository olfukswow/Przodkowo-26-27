using System.Collections.ObjectModel;
using System;
namespace NotatkiMobilne
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> Notatki { get; } = new ObservableCollection<string>
        {
            "Zakupy: chleb, maslo, ser",
            "Do zrobienia: obiad, umyc podlogi",
            "weekend: kino, spacer z psem"
        };

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void DodajButton_Clicked(object sender, EventArgs e)
        {
            string nowaNotatka = nowyElementEntry.Text;

            if (string.IsNullOrWhiteSpace(nowaNotatka))
            {
                return;
            }

            Notatki.Add(nowaNotatka);
            nowyElementEntry.Text = "";
        }
    }
}