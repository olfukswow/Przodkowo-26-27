using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;

namespace Desktopowa
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SzyfrujButton_Click(object sender, RoutedEventArgs e)
        {
            string tekstJawny = TekstJawnyTextBox.Text;
            int klucz;

            if (!int.TryParse(KluczTextBox.Text, out klucz))
            {
                klucz = 0;
            }

            TekstZaszyfrowanyTextBox.Text = Szyfruj(tekstJawny, klucz);
        }

        private string Szyfruj(string tekstJawny, int klucz)
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

        private void ZapiszButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog oknoZapisu = new SaveFileDialog
            {
                Title = "Zapisz zaszyfrowany tekst",
                Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*",
                FileName = "szyfr.txt"
            };

            if (oknoZapisu.ShowDialog() == true)
            {
                File.WriteAllText(
                    oknoZapisu.FileName,
                    TekstZaszyfrowanyTextBox.Text
                );
            }
        }
    }
}