using System;

namespace RejestracjaMobilna
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ZatwierdzButton_Clicked(object sender, EventArgs e)
        {
            string email = emailEntry.Text ?? "";
            string haslo = hasloEntry.Text ?? "";
            string powtorzoneHaslo = powtorzHasloEntry.Text ?? "";

            if (!email.Contains("@"))
            {
                komunikatLabel.Text = "Nieprawidłowy adres e-mail";
                return;
            }

            if (haslo != powtorzoneHaslo)
            {
                komunikatLabel.Text = "Hasła się różnią";
                return;
            }

            komunikatLabel.Text = "Witaj " + email;
        }
    }
}