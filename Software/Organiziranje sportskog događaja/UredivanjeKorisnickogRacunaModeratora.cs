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
    public partial class UredivanjeKorisnickogRacunaModeratora : Form
    {
        private korisnik Korisnik;
        public UredivanjeKorisnickogRacunaModeratora(korisnik potreban)
        {
            InitializeComponent();
            Korisnik = potreban;
        }

        private void UredivanjeKorisnickogRacunaModeratora_Load(object sender, EventArgs e)
        {
            uiIme.Text = PrijavljeniKorisnik.pk.ime;
            uiPrezime.Text = PrijavljeniKorisnik.pk.prezime;
            uiKontakt.Text = PrijavljeniKorisnik.pk.kontakt_broj;
            uiEmail.Text = PrijavljeniKorisnik.pk.email;
            uiKorisn.Text = PrijavljeniKorisnik.pk.korisnicko_ime;
            uiLozinka.Text = PrijavljeniKorisnik.pk.lozinka;
            PopuniUloge();
            PopuniPripadneTimove();
            PopuniDogadaje();
        }
        private void PopuniUloge()
        {
            List<uloga_korisnika> uloga;
            using (var context = new PI2231_DBEntities())
            {
                uloga = context.uloga_korisnika.ToList();
            }
            uiUloga.DataSource = uloga;
        }
        private void PopuniPripadneTimove()
        {
            List<tim> Tim;
            using (var context = new PI2231_DBEntities())
            {
                Tim = context.tims.ToList();
            }
            uiTimovi.DataSource = Tim;
        }
        private void PopuniDogadaje()
        {
            List<dogadaj> Dogadaj;
            using (var context = new PI2231_DBEntities())
            {
                Dogadaj = context.dogadajs.ToList();
            }
            uiPrijavljeniDogadaji.DataSource = Dogadaj;
        }

        private void uiOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiSpremiPromjene_Click(object sender, EventArgs e)
        {
            using (var context = new PI2231_DBEntities())
            {
                PrijavljeniKorisnik.pk.ime = uiIme.Text;
                PrijavljeniKorisnik.pk.prezime = uiPrezime.Text;
                PrijavljeniKorisnik.pk.kontakt_broj = uiKontakt.Text;
                PrijavljeniKorisnik.pk.email = uiEmail.Text;
                PrijavljeniKorisnik.pk.korisnicko_ime = uiKorisn.Text;
                PrijavljeniKorisnik.pk.lozinka = uiLozinka.Text;

                context.korisniks.Attach(Korisnik);

                Korisnik.ime = PrijavljeniKorisnik.pk.ime;
                Korisnik.prezime = PrijavljeniKorisnik.pk.prezime;
                Korisnik.kontakt_broj = PrijavljeniKorisnik.pk.kontakt_broj;
                Korisnik.email = PrijavljeniKorisnik.pk.email;
                Korisnik.korisnicko_ime = PrijavljeniKorisnik.pk.korisnicko_ime;
                Korisnik.lozinka = PrijavljeniKorisnik.pk.lozinka;

                context.SaveChanges();
            }
            Close();
        }
    }
}
