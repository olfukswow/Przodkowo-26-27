using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DesktopowaPaszport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButtonNiebieskie.Checked = true;
        }

        private void textBoxNumer_TextChanged(object sender, EventArgs e)
        {
            string numer = textBoxNumer.Text;
            string folderObrazow = Path.Combine(Application.StartupPath, "obrazy");

            string sciezkaZdjecia = Path.Combine(
                folderObrazow,
                numer + "-zdjecie.jpg"
            );

            string sciezkaOdcisku = Path.Combine(
                folderObrazow,
                numer + "-odcisk.jpg"
            );

            WyswietlObraz(sciezkaZdjecia, pictureBoxZdjecie);
            WyswietlObraz(sciezkaOdcisku, pictureBoxOdcisk);
        }

        private void WyswietlObraz(string sciezka, PictureBox kontrolka)
        {
            if (kontrolka.Image != null)
            {
                kontrolka.Image.Dispose();
                kontrolka.Image = null;
            }

            if (!File.Exists(sciezka))
            {
                return;
            }

            using (Image obraz = Image.FromFile(sciezka))
            {
                kontrolka.Image = new Bitmap(obraz);
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string imie = textBoxImie.Text;
            string nazwisko = textBoxNazwisko.Text;
            string kolorOczu = "";

            if (radioButtonNiebieskie.Checked)
            {
                kolorOczu = "niebieskie";
            }
            else if (radioButtonZielone.Checked)
            {
                kolorOczu = "zielone";
            }
            else if (radioButtonPiwne.Checked)
            {
                kolorOczu = "piwne";
            }

            if (imie == "" || nazwisko == "")
            {
                MessageBox.Show(
                    "Wprowadz dane",
                    "Informacja",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            MessageBox.Show(
                imie + " " + nazwisko + " kolor oczu " + kolorOczu,
                "Informacja",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}