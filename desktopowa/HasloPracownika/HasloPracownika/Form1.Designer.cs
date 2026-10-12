namespace HasloPracownika
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBoxPracownik;
        private System.Windows.Forms.GroupBox groupBoxHaslo;
        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.Label labelStanowisko;
        private System.Windows.Forms.Label labelDlugosc;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.TextBox textBoxDlugosc;
        private System.Windows.Forms.ComboBox comboBoxStanowisko;
        private System.Windows.Forms.CheckBox checkBoxLitery;
        private System.Windows.Forms.CheckBox checkBoxCyfry;
        private System.Windows.Forms.CheckBox checkBoxSpecjalne;
        private System.Windows.Forms.Button buttonGeneruj;
        private System.Windows.Forms.Button buttonZatwierdz;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupBoxPracownik = new System.Windows.Forms.GroupBox();
            this.groupBoxHaslo = new System.Windows.Forms.GroupBox();
            this.labelImie = new System.Windows.Forms.Label();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.labelStanowisko = new System.Windows.Forms.Label();
            this.labelDlugosc = new System.Windows.Forms.Label();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxDlugosc = new System.Windows.Forms.TextBox();
            this.comboBoxStanowisko = new System.Windows.Forms.ComboBox();
            this.checkBoxLitery = new System.Windows.Forms.CheckBox();
            this.checkBoxCyfry = new System.Windows.Forms.CheckBox();
            this.checkBoxSpecjalne = new System.Windows.Forms.CheckBox();
            this.buttonGeneruj = new System.Windows.Forms.Button();
            this.buttonZatwierdz = new System.Windows.Forms.Button();
            this.groupBoxPracownik.SuspendLayout();
            this.groupBoxHaslo.SuspendLayout();
            this.SuspendLayout();

            this.groupBoxPracownik.Controls.Add(this.labelImie);
            this.groupBoxPracownik.Controls.Add(this.labelNazwisko);
            this.groupBoxPracownik.Controls.Add(this.labelStanowisko);
            this.groupBoxPracownik.Controls.Add(this.textBoxImie);
            this.groupBoxPracownik.Controls.Add(this.textBoxNazwisko);
            this.groupBoxPracownik.Controls.Add(this.comboBoxStanowisko);
            this.groupBoxPracownik.Location = new System.Drawing.Point(25, 25);
            this.groupBoxPracownik.Size = new System.Drawing.Size(285, 220);
            this.groupBoxPracownik.Text = "Dane pracownika";

            this.labelImie.AutoSize = true;
            this.labelImie.Location = new System.Drawing.Point(20, 45);
            this.labelImie.Text = "Imię";

            this.textBoxImie.Location = new System.Drawing.Point(105, 40);
            this.textBoxImie.Size = new System.Drawing.Size(155, 23);

            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Location = new System.Drawing.Point(20, 90);
            this.labelNazwisko.Text = "Nazwisko";

            this.textBoxNazwisko.Location = new System.Drawing.Point(105, 85);
            this.textBoxNazwisko.Size = new System.Drawing.Size(155, 23);

            this.labelStanowisko.AutoSize = true;
            this.labelStanowisko.Location = new System.Drawing.Point(20, 135);
            this.labelStanowisko.Text = "Stanowisko";

            this.comboBoxStanowisko.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStanowisko.Items.AddRange(new object[]
            {
                "Kierownik",
                "Starszy programista",
                "Młodszy programista",
                "Tester"
            });
            this.comboBoxStanowisko.Location = new System.Drawing.Point(105, 130);
            this.comboBoxStanowisko.Size = new System.Drawing.Size(155, 23);

            this.groupBoxHaslo.Controls.Add(this.labelDlugosc);
            this.groupBoxHaslo.Controls.Add(this.textBoxDlugosc);
            this.groupBoxHaslo.Controls.Add(this.checkBoxLitery);
            this.groupBoxHaslo.Controls.Add(this.checkBoxCyfry);
            this.groupBoxHaslo.Controls.Add(this.checkBoxSpecjalne);
            this.groupBoxHaslo.Controls.Add(this.buttonGeneruj);
            this.groupBoxHaslo.Location = new System.Drawing.Point(340, 25);
            this.groupBoxHaslo.Size = new System.Drawing.Size(300, 220);
            this.groupBoxHaslo.Text = "Generowanie hasła";

            this.labelDlugosc.AutoSize = true;
            this.labelDlugosc.Location = new System.Drawing.Point(20, 45);
            this.labelDlugosc.Text = "Ile znaków?";

            this.textBoxDlugosc.Location = new System.Drawing.Point(125, 40);
            this.textBoxDlugosc.Size = new System.Drawing.Size(145, 23);

            this.checkBoxLitery.AutoSize = true;
            this.checkBoxLitery.Location = new System.Drawing.Point(25, 80);
            this.checkBoxLitery.Text = "Małe i wielkie litery";

            this.checkBoxCyfry.AutoSize = true;
            this.checkBoxCyfry.Location = new System.Drawing.Point(25, 110);
            this.checkBoxCyfry.Text = "Cyfry";

            this.checkBoxSpecjalne.AutoSize = true;
            this.checkBoxSpecjalne.Location = new System.Drawing.Point(25, 140);
            this.checkBoxSpecjalne.Text = "Znaki specjalne";

            this.buttonGeneruj.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
            this.buttonGeneruj.ForeColor = System.Drawing.Color.White;
            this.buttonGeneruj.Location = new System.Drawing.Point(100, 175);
            this.buttonGeneruj.Size = new System.Drawing.Size(125, 28);
            this.buttonGeneruj.Text = "Generuj hasło";
            this.buttonGeneruj.UseVisualStyleBackColor = false;
            this.buttonGeneruj.Click += new System.EventHandler(this.buttonGeneruj_Click);

            this.buttonZatwierdz.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
            this.buttonZatwierdz.ForeColor = System.Drawing.Color.White;
            this.buttonZatwierdz.Location = new System.Drawing.Point(170, 270);
            this.buttonZatwierdz.Size = new System.Drawing.Size(320, 38);
            this.buttonZatwierdz.Text = "Zatwierdź";
            this.buttonZatwierdz.UseVisualStyleBackColor = false;
            this.buttonZatwierdz.Click += new System.EventHandler(this.buttonZatwierdz_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(176, 196, 222);
            this.ClientSize = new System.Drawing.Size(670, 330);
            this.Controls.Add(this.groupBoxPracownik);
            this.Controls.Add(this.groupBoxHaslo);
            this.Controls.Add(this.buttonZatwierdz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj pracownika. Wykonał: numer zdającego";
            this.groupBoxPracownik.ResumeLayout(false);
            this.groupBoxPracownik.PerformLayout();
            this.groupBoxHaslo.ResumeLayout(false);
            this.groupBoxHaslo.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}