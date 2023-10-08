using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organiziranje_sportskog_događaja
{
    public partial class RegistracijaOrganizacije : Form
    {
        PI2231_DBEntities entities =new PI2231_DBEntities();

        public RegistracijaOrganizacije()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           

            if (imeOrganizacijeTBX.Text.Length == 0 || oibOrganizacijeTBX.Text.Length == 0 || emailOrganizacijeTBX.Text.Length == 0 || KontaktBrojOrganizacijeTBX.Text.Length == 0 || adresaOrganizacijeTBX.Text.Length == 0 || korisnickoImeOrganizacijeTBX.Text.Length == 0 || lozinkaOrganizacijeTBX.Text.Length == 0 || ponovljenaLozinkaOrganizacijeTBX.Text.Length==0 || kratkiOpisOrganizacijeTBX.Text.Length==0)
            {
                MessageBox.Show("Nisu svi potrebni podatci uneseni!");
                return;
            }

           
            organizacija novaOrganizacija = new organizacija
            {
                naziv = imeOrganizacijeTBX.Text,
                OIB = oibOrganizacijeTBX.Text,
                kontakt_broj = KontaktBrojOrganizacijeTBX.Text,
                email = emailOrganizacijeTBX.Text,
                adresa = adresaOrganizacijeTBX.Text,
                korisnicko_ime = korisnickoImeOrganizacijeTBX.Text,
                lozinka = lozinkaOrganizacijeTBX.Text,
                opis = kratkiOpisOrganizacijeTBX.Text

            };
            
            

            try
            {

                provjeraPodataka(novaOrganizacija.korisnicko_ime, novaOrganizacija.email, novaOrganizacija.lozinka, ponovljenaLozinkaOrganizacijeTBX.Text, novaOrganizacija.OIB);
                entities.organizacijas.Add(novaOrganizacija);
                entities.SaveChanges();

                MessageBox.Show("Uspješno ste registrirani ");
                this.Hide();
                Prijava pr = new Prijava();
                pr.ShowDialog();
                this.Close();

            }
            catch (RegistracijaException ex)
            {

                MessageBox.Show(ex.Poruka);
            }


        }

        private void provjeraPodataka(string korisnicko_ime, string email, string lozinka, string ponovljenaLozinka, string oib)
        {
            if (!email.EndsWith("@gmail.com"))
            {
                throw new RegistracijaException("Email nije valjan!");
            }
            else if (lozinka.Length < 8)
            {
                throw new RegistracijaException("Lozinka je pre kratka!");
            }
            else if (lozinka != ponovljenaLozinka)
            {
                throw new RegistracijaException("Ponovljena lozinka ne odgovara lozinci!");
            }
            else if (oib.Length!=11) 
            {
                throw new RegistracijaException("Neispravan OIB!");
            }

            foreach (var item in entities.organizacijas)
            {
                if (item.korisnicko_ime == korisnicko_ime)
                {
                    throw new RegistracijaException($"Korisničko ime  | {korisnicko_ime} | već postoji!");
                }
                else if (item.email == email)
                {
                    throw new RegistracijaException($"Email  | {email} | je već registiran u našoj bazi podataka! ");
                }
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            PočetnaNeregistrirani pocetna = new PočetnaNeregistrirani();
            pocetna.Show();
            this.Close();

        }

        private void RegistracijaOrganizacije_Load(object sender, EventArgs e)
        {

        }
    }
    
}
