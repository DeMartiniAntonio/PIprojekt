namespace Organiziranje_sportskog_događaja
{
    partial class PrijavaSportskogDogadaja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiPrijaviDogadaj = new System.Windows.Forms.Button();
            this.datumPrijave = new System.Windows.Forms.DateTimePicker();
            this.uiLokacija = new System.Windows.Forms.TextBox();
            this.datumIzvodenja = new System.Windows.Forms.DateTimePicker();
            this.uiOpis = new System.Windows.Forms.TextBox();
            this.uiNazivDogadaja = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uiOrganizacija = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // uiPrijaviDogadaj
            // 
            this.uiPrijaviDogadaj.Location = new System.Drawing.Point(393, 506);
            this.uiPrijaviDogadaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiPrijaviDogadaj.Name = "uiPrijaviDogadaj";
            this.uiPrijaviDogadaj.Size = new System.Drawing.Size(129, 42);
            this.uiPrijaviDogadaj.TabIndex = 36;
            this.uiPrijaviDogadaj.Text = "Prijavi događaj";
            this.uiPrijaviDogadaj.UseVisualStyleBackColor = true;
            this.uiPrijaviDogadaj.Click += new System.EventHandler(this.uiPrijaviDogadaj_Click);
            // 
            // datumPrijave
            // 
            this.datumPrijave.Location = new System.Drawing.Point(191, 457);
            this.datumPrijave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datumPrijave.Name = "datumPrijave";
            this.datumPrijave.Size = new System.Drawing.Size(203, 26);
            this.datumPrijave.TabIndex = 32;
            // 
            // uiLokacija
            // 
            this.uiLokacija.Location = new System.Drawing.Point(191, 391);
            this.uiLokacija.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiLokacija.Name = "uiLokacija";
            this.uiLokacija.Size = new System.Drawing.Size(203, 26);
            this.uiLokacija.TabIndex = 31;
            // 
            // datumIzvodenja
            // 
            this.datumIzvodenja.Location = new System.Drawing.Point(191, 321);
            this.datumIzvodenja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datumIzvodenja.Name = "datumIzvodenja";
            this.datumIzvodenja.Size = new System.Drawing.Size(203, 26);
            this.datumIzvodenja.TabIndex = 30;
            // 
            // uiOpis
            // 
            this.uiOpis.Location = new System.Drawing.Point(191, 104);
            this.uiOpis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiOpis.Multiline = true;
            this.uiOpis.Name = "uiOpis";
            this.uiOpis.Size = new System.Drawing.Size(321, 118);
            this.uiOpis.TabIndex = 28;
            // 
            // uiNazivDogadaja
            // 
            this.uiNazivDogadaja.Location = new System.Drawing.Point(191, 52);
            this.uiNazivDogadaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiNazivDogadaja.Name = "uiNazivDogadaja";
            this.uiNazivDogadaja.Size = new System.Drawing.Size(203, 26);
            this.uiNazivDogadaja.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Opis događaja";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Rok prijave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Lokacija događaja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Datum izvođenja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Organizator događaja";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Naziv događaja";
            // 
            // uiOrganizacija
            // 
            this.uiOrganizacija.FormattingEnabled = true;
            this.uiOrganizacija.Location = new System.Drawing.Point(191, 265);
            this.uiOrganizacija.Name = "uiOrganizacija";
            this.uiOrganizacija.Size = new System.Drawing.Size(203, 28);
            this.uiOrganizacija.TabIndex = 37;
            this.uiOrganizacija.SelectedIndexChanged += new System.EventHandler(this.uiOrganizacija_SelectedIndexChanged);
            // 
            // PrijavaSportskogDogadaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 591);
            this.Controls.Add(this.uiOrganizacija);
            this.Controls.Add(this.uiPrijaviDogadaj);
            this.Controls.Add(this.datumPrijave);
            this.Controls.Add(this.uiLokacija);
            this.Controls.Add(this.datumIzvodenja);
            this.Controls.Add(this.uiOpis);
            this.Controls.Add(this.uiNazivDogadaja);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PrijavaSportskogDogadaja";
            this.Text = "PrijavaSportskogDogadaja";
            this.Load += new System.EventHandler(this.PrijavaSportskogDogadaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiPrijaviDogadaj;
        private System.Windows.Forms.DateTimePicker datumPrijave;
        private System.Windows.Forms.TextBox uiLokacija;
        private System.Windows.Forms.DateTimePicker datumIzvodenja;
        private System.Windows.Forms.TextBox uiOpis;
        private System.Windows.Forms.TextBox uiNazivDogadaja;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox uiOrganizacija;
    }
}