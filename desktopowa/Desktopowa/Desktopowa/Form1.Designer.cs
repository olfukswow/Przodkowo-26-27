namespace DesktopowaPaszport
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelNumer;
        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.TextBox textBoxNumer;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.GroupBox groupBoxKolorOczu;
        private System.Windows.Forms.RadioButton radioButtonNiebieskie;
        private System.Windows.Forms.RadioButton radioButtonZielone;
        private System.Windows.Forms.RadioButton radioButtonPiwne;
        private System.Windows.Forms.PictureBox pictureBoxZdjecie;
        private System.Windows.Forms.PictureBox pictureBoxOdcisk;
        private System.Windows.Forms.Button buttonOk;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelNumer = new System.Windows.Forms.Label();
            this.labelImie = new System.Windows.Forms.Label();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.textBoxNumer = new System.Windows.Forms.TextBox();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.groupBoxKolorOczu = new System.Windows.Forms.GroupBox();
            this.radioButtonPiwne = new System.Windows.Forms.RadioButton();
            this.radioButtonZielone = new System.Windows.Forms.RadioButton();
            this.radioButtonNiebieskie = new System.Windows.Forms.RadioButton();
            this.pictureBoxZdjecie = new System.Windows.Forms.PictureBox();
            this.pictureBoxOdcisk = new System.Windows.Forms.PictureBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBoxKolorOczu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZdjecie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOdcisk)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNumer
            // 
            this.labelNumer.AutoSize = true;
            this.labelNumer.Location = new System.Drawing.Point(25, 30);
            this.labelNumer.Name = "labelNumer";
            this.labelNumer.Size = new System.Drawing.Size(45, 15);
            this.labelNumer.TabIndex = 0;
            this.labelNumer.Text = "Numer";
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Location = new System.Drawing.Point(25, 70);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(31, 15);
            this.labelImie.TabIndex = 1;
            this.labelImie.Text = "Imię";
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Location = new System.Drawing.Point(25, 110);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(57, 15);
            this.labelNazwisko.TabIndex = 2;
            this.labelNazwisko.Text = "Nazwisko";
            // 
            // textBoxNumer
            // 
            this.textBoxNumer.Location = new System.Drawing.Point(105, 27);
            this.textBoxNumer.Name = "textBoxNumer";
            this.textBoxNumer.Size = new System.Drawing.Size(190, 23);
            this.textBoxNumer.TabIndex = 3;
            this.textBoxNumer.TextChanged += new System.EventHandler(this.textBoxNumer_TextChanged);
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(105, 67);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(190, 23);
            this.textBoxImie.TabIndex = 4;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(105, 107);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(190, 23);
            this.textBoxNazwisko.TabIndex = 5;
            // 
            // groupBoxKolorOczu
            // 
            this.groupBoxKolorOczu.Controls.Add(this.radioButtonPiwne);
            this.groupBoxKolorOczu.Controls.Add(this.radioButtonZielone);
            this.groupBoxKolorOczu.Controls.Add(this.radioButtonNiebieskie);
            this.groupBoxKolorOczu.Location = new System.Drawing.Point(25, 160);
            this.groupBoxKolorOczu.Name = "groupBoxKolorOczu";
            this.groupBoxKolorOczu.Size = new System.Drawing.Size(270, 130);
            this.groupBoxKolorOczu.TabIndex = 6;
            this.groupBoxKolorOczu.TabStop = false;
            this.groupBoxKolorOczu.Text = "Kolor oczu";
            // 
            // radioButtonPiwne
            // 
            this.radioButtonPiwne.AutoSize = true;
            this.radioButtonPiwne.Location = new System.Drawing.Point(20, 90);
            this.radioButtonPiwne.Name = "radioButtonPiwne";
            this.radioButtonPiwne.Size = new System.Drawing.Size(57, 19);
            this.radioButtonPiwne.TabIndex = 2;
            this.radioButtonPiwne.TabStop = true;
            this.radioButtonPiwne.Text = "piwne";
            this.radioButtonPiwne.UseVisualStyleBackColor = true;
            // 
            // radioButtonZielone
            // 
            this.radioButtonZielone.AutoSize = true;
            this.radioButtonZielone.Location = new System.Drawing.Point(20, 60);
            this.radioButtonZielone.Name = "radioButtonZielone";
            this.radioButtonZielone.Size = new System.Drawing.Size(66, 19);
            this.radioButtonZielone.TabIndex = 1;
            this.radioButtonZielone.TabStop = true;
            this.radioButtonZielone.Text = "zielone";
            this.radioButtonZielone.UseVisualStyleBackColor = true;
            // 
            // radioButtonNiebieskie
            // 
            this.radioButtonNiebieskie.AutoSize = true;
            this.radioButtonNiebieskie.Location = new System.Drawing.Point(20, 30);
            this.radioButtonNiebieskie.Name = "radioButtonNiebieskie";
            this.radioButtonNiebieskie.Size = new System.Drawing.Size(82, 19);
            this.radioButtonNiebieskie.TabIndex = 0;
            this.radioButtonNiebieskie.TabStop = true;
            this.radioButtonNiebieskie.Text = "niebieskie";
            this.radioButtonNiebieskie.UseVisualStyleBackColor = true;
            // 
            // pictureBoxZdjecie
            // 
            this.pictureBoxZdjecie.Location = new System.Drawing.Point(335, 27);
            this.pictureBoxZdjecie.Name = "pictureBoxZdjecie";
            this.pictureBoxZdjecie.Size = new System.Drawing.Size(145, 180);
            this.pictureBoxZdjecie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxZdjecie.TabIndex = 7;
            this.pictureBoxZdjecie.TabStop = false;
            // 
            // pictureBoxOdcisk
            // 
            this.pictureBoxOdcisk.Location = new System.Drawing.Point(500, 27);
            this.pictureBoxOdcisk.Name = "pictureBoxOdcisk";
            this.pictureBoxOdcisk.Size = new System.Drawing.Size(145, 180);
            this.pictureBoxOdcisk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOdcisk.TabIndex = 8;
            this.pictureBoxOdcisk.TabStop = false;
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.FromArgb(240, 255, 255);
            this.buttonOk.Location = new System.Drawing.Point(335, 250);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(310, 40);
            this.buttonOk.TabIndex = 9;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(95, 158, 160);
            this.ClientSize = new System.Drawing.Size(680, 330);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.pictureBoxOdcisk);
            this.Controls.Add(this.pictureBoxZdjecie);
            this.Controls.Add(this.groupBoxKolorOczu);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.textBoxNumer);
            this.Controls.Add(this.labelNazwisko);
            this.Controls.Add(this.labelImie);
            this.Controls.Add(this.labelNumer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wprowadzanie danych do paszportu. Wykonał: numer zdającego";
            this.groupBoxKolorOczu.ResumeLayout(false);
            this.groupBoxKolorOczu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZdjecie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOdcisk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}