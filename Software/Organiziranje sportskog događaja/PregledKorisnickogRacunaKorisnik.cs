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
    public partial class PregledKorisnickogRacunaKorisnik : Form
    {
        private korisnik potrebanKorisnik;
        public PregledKorisnickogRacunaKorisnik()
        {
            InitializeComponent();
        }

        private void PregledKorisnickogRacunaKorisnik_Load(object sender, EventArgs e)
        {
            using (var context = new PI2231_DBEntities())
            {
                var query = from k in context.korisniks
                            where k.korisnicko_ime == PrijavljeniKorisnik.pk.korisnicko_ime && k.lozinka == PrijavljeniKorisnik.pk.lozinka
                            select k;
                potrebanKorisnik = query.Single();
            }
            PopuniPodatke();
            PopuniUloge();
            PopuniPripadneTimove();
            PopuniDogadaje();
        }
        private void PopuniPodatke()
        {
            uiIme.Text = PrijavljeniKorisnik.pk.ime;
            uiPrezime.Text = PrijavljeniKorisnik.pk.prezime;
            uiKontakt.Text = PrijavljeniKorisnik.pk.kontakt_broj;
            uiEmail.Text = PrijavljeniKorisnik.pk.email;
            uiKorisn.Text = PrijavljeniKorisnik.pk.korisnicko_ime;
            uiLozinka.Text = PrijavljeniKorisnik.pk.lozinka;
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

        private void uiPrijavaZaTim_Click(object sender, EventArgs e)
        {
            KreiranjeTima form = new KreiranjeTima();
            form.ShowDialog();
        }

        private void uiPrijavaNaDogadaj_Click(object sender, EventArgs e)
        {
            PrijavaNaTurnir form = new PrijavaNaTurnir();
            form.ShowDialog();
        }

        private void uiUrediPodatke_Click(object sender, EventArgs e)
        {
            UredivanjeKorisnickogRacunaKorisnik form = new UredivanjeKorisnickogRacunaKorisnik(potrebanKorisnik);
            form.ShowDialog();
            PopuniPodatke();
        }
    }
}
