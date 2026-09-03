using System;
using System.Drawing;
using System.Windows.Forms;

namespace Desktopowa
{
    public partial class Form1 : Form
    {
        private Panel duzyProstokat;
        private Panel malyProstokat;

        private TrackBar suwakR;
        private TrackBar suwakG;
        private TrackBar suwakB;

        private Label wartoscR;
        private Label wartoscG;
        private Label wartoscB;
        private Label pobranyKolor;

        private Button przyciskPobierz;

        public Form1()
        {
            UtworzInterfejs();
        }

        private void UtworzInterfejs()
        {
            Text = "Wzornik kolorów RGB. Wykona³: CWL";
            ClientSize = new Size(800, 480);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.FromArgb(255, 248, 220);

            duzyProstokat = new Panel();
            duzyProstokat.Location = new Point(40, 30);
            duzyProstokat.Size = new Size(720, 85);
            duzyProstokat.BackColor = Color.White;
            Controls.Add(duzyProstokat);

            Label instrukcja = new Label();
            instrukcja.Text = "Dobierz kolor suwakami i zapisz przyciskiem:";
            instrukcja.Location = new Point(40, 145);
            instrukcja.AutoSize = true;
            Controls.Add(instrukcja);

            Label napisR = new Label();
            napisR.Text = "R";
            napisR.Location = new Point(40, 190);
            napisR.AutoSize = true;
            Controls.Add(napisR);

            Label napisG = new Label();
            napisG.Text = "G";
            napisG.Location = new Point(40, 240);
            napisG.AutoSize = true;
            Controls.Add(napisG);

            Label napisB = new Label();
            napisB.Text = "B";
            napisB.Location = new Point(40, 290);
            napisB.AutoSize = true;
            Controls.Add(napisB);

            suwakR = new TrackBar();
            suwakR.Minimum = 0;
            suwakR.Maximum = 255;
            suwakR.Value = 255;
            suwakR.TickFrequency = 15;
            suwakR.Location = new Point(80, 180);
            suwakR.Size = new Size(570, 45);
            suwakR.ValueChanged += ZmienKolor;
            Controls.Add(suwakR);

            suwakG = new TrackBar();
            suwakG.Minimum = 0;
            suwakG.Maximum = 255;
            suwakG.Value = 255;
            suwakG.TickFrequency = 15;
            suwakG.Location = new Point(80, 230);
            suwakG.Size = new Size(570, 45);
            suwakG.ValueChanged += ZmienKolor;
            Controls.Add(suwakG);

            suwakB = new TrackBar();
            suwakB.Minimum = 0;
            suwakB.Maximum = 255;
            suwakB.Value = 255;
            suwakB.TickFrequency = 15;
            suwakB.Location = new Point(80, 280);
            suwakB.Size = new Size(570, 45);
            suwakB.ValueChanged += ZmienKolor;
            Controls.Add(suwakB);

            wartoscR = new Label();
            wartoscR.Text = "255";
            wartoscR.Location = new Point(680, 190);
            wartoscR.AutoSize = true;
            Controls.Add(wartoscR);

            wartoscG = new Label();
            wartoscG.Text = "255";
            wartoscG.Location = new Point(680, 240);
            wartoscG.AutoSize = true;
            Controls.Add(wartoscG);

            wartoscB = new Label();
            wartoscB.Text = "255";
            wartoscB.Location = new Point(680, 290);
            wartoscB.AutoSize = true;
            Controls.Add(wartoscB);

            przyciskPobierz = new Button();
            przyciskPobierz.Text = "Pobierz";
            przyciskPobierz.Location = new Point(320, 340);
            przyciskPobierz.Size = new Size(160, 36);
            przyciskPobierz.BackColor = Color.FromArgb(205, 133, 79);
            przyciskPobierz.UseVisualStyleBackColor = false;
            przyciskPobierz.Click += PobierzKolor;
            Controls.Add(przyciskPobierz);

            malyProstokat = new Panel();
            malyProstokat.Location = new Point(320, 400);
            malyProstokat.Size = new Size(160, 35);
            malyProstokat.BackColor = Color.White;
            Controls.Add(malyProstokat);

            pobranyKolor = new Label();
            pobranyKolor.Text = "255, 255, 255";
            pobranyKolor.Location = new Point(500, 410);
            pobranyKolor.AutoSize = true;
            Controls.Add(pobranyKolor);
        }

        private void ZmienKolor(object sender, EventArgs e)
        {
            int r = suwakR.Value;
            int g = suwakG.Value;
            int b = suwakB.Value;

            duzyProstokat.BackColor = Color.FromArgb(r, g, b);

            wartoscR.Text = r.ToString();
            wartoscG.Text = g.ToString();
            wartoscB.Text = b.ToString();
        }

        private void PobierzKolor(object sender, EventArgs e)
        {
            int r = suwakR.Value;
            int g = suwakG.Value;
            int b = suwakB.Value;

            malyProstokat.BackColor = Color.FromArgb(r, g, b);
            pobranyKolor.Text = r + ", " + g + ", " + b;
        }
    }
}