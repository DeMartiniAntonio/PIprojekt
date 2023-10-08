using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Organiziranje_sportskog_događaja.Prijava_na_turnir;

namespace Organiziranje_sportskog_događaja
{
    public partial class PrijaviSeSamostalnoNaTurnir : Form
    {
        PI2231_DBEntities entities = new PI2231_DBEntities();
        public turnir OdabraniTurnir { get; set; }
        public PrijaviSeSamostalnoNaTurnir(turnir odabraniTurnir)
        {
            InitializeComponent();
            OdabraniTurnir = odabraniTurnir;
        }

        private void PrijaviSeSamostalnoNaTurnir_Load(object sender, EventArgs e)
        {
            uiNazivTurnira.Text = OdabraniTurnir.naziv;
            uiKategorijaSporta.Text = OdabraniTurnir.sport.ToString();
            uiMjestoOdrzavanja.Text = OdabraniTurnir.dogadaj.lokacija.ToString();
            uiRokPrijave.Text = OdabraniTurnir.dogadaj.rok_prijave.Date.ToString();
        }

        private void uiOdustani_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void uiPrijavi_Click(object sender, EventArgs e)
        {
            try
            {
                ProvjeriPodatkePotencijalnogClana(); 
                PrivjeriJeLiPrijavljenSamostalno();
                PrivjeriJeLiPrijavljenuTimu(); 
                DodajSamostalnimPrijavama(); 

            }
            catch (PrijavaNaTurnirException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }

        public void DodajSamostalnimPrijavama()
        {
            korisnik prijavljeni = PrijavljeniKorisnik.pk;
            turnir odabrani = null; 
            foreach(var turnir in entities.turnirs)
            {
                if (turnir.id_turnir == OdabraniTurnir.id_turnir)
                    odabrani = turnir;
            }

            entities.turnirs.Attach(odabrani); 
            entities.korisniks.Attach(prijavljeni);
            odabrani.korisniks.Add(prijavljeni);
            entities.SaveChanges();
            MessageBox.Show($"Uspješno ste se samostalno prijavili na turnir {OdabraniTurnir.naziv}");
        }
        public void PrivjeriJeLiPrijavljenuTimu()
        {
            foreach (var tim in OdabraniTurnir.tims)
            {
                foreach (var clan in tim.korisniks)
                {
                    if (clan.id_korisnik == PrijavljeniKorisnik.pk.id_korisnik)
                    {
                        throw new PrijavaNaTurnirException($"Već ste prijavljeni na ovaj turnir kao član tima {tim.naziv}");
                    }
                }
            }
        }

        public void PrivjeriJeLiPrijavljenSamostalno()
        {
            foreach (var korisnik in OdabraniTurnir.korisniks)
            {
                if (korisnik.id_korisnik == PrijavljeniKorisnik.pk.id_korisnik)
                {
                    throw new PrijavaNaTurnirException("Već ste samostalno prijavljeni na ovaj turnir!"); 
                }
            }
        }

        public void ProvjeriPodatkePotencijalnogClana()
        {

            if (uiUnosImena.Text == ""|| uiUnosPrezimena.Text== "")
            {
                throw new PrijavaNaTurnirException("Ime i prezime moraju biti uneseni!");
            }

            if (uiUnosImena.Text != PrijavljeniKorisnik.pk.ime || uiUnosPrezimena.Text != PrijavljeniKorisnik.pk.prezime)
            {
                throw new PrijavaNaTurnirException("Ne možete prijavljivati druge osobe na turnir!");
            }
        }
    }
}
