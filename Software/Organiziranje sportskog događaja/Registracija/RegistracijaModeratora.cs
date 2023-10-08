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
    public partial class RegistracijaModeratora : Form
    {

        PI2231_DBEntities entities =new PI2231_DBEntities();

        public RegistracijaModeratora()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (imeModeratoraTXB.Text.Length == 0 || prezimeModeratoraTXB.Text.Length == 0 || korisnickoImeModeratoraTXB.Text.Length == 0 || emailModeratoraTXB.Text.Length == 0 || kontaktBrojModeratoraTXB.Text.Length == 0 || lozinkaModeratoraTXB.Text.Length == 0)
            {
                MessageBox.Show("Nisu svi potrebni podatci uneseni!");
                return;
            }

            korisnik noviKorisnik = new korisnik()
            {
                ime = imeModeratoraTXB.Text,
                prezime = prezimeModeratoraTXB.Text,
                korisnicko_ime = korisnickoImeModeratoraTXB.Text,
                email = emailModeratoraTXB.Text,
                lozinka = lozinkaModeratoraTXB.Text,
                kontakt_broj = kontaktBrojModeratoraTXB.Text,

                id_uloga = 2,
            };

            try
            {

                provjeraPodataka(noviKorisnik.korisnicko_ime, noviKorisnik.email, noviKorisnik.lozinka, ponovljenaLozinkaModeratoraTXB.Text);
                entities.korisniks.Add(noviKorisnik);
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

        private void provjeraPodataka(string korisnicko_ime, string email, string lozinka, string ponovljenaLozinka)
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

            foreach (var item in entities.korisniks)
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

        private void natragBTN_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            PočetnaNeregistrirani pocetna = new PočetnaNeregistrirani();
            pocetna.Show();
            this.Close();


        }
    }
    
}
