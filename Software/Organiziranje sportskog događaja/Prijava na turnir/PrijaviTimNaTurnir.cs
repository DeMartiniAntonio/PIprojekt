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
    public partial class PrijaviTimNaTurnir : Form
    {
        PI2231_DBEntities entities = new PI2231_DBEntities();

        public turnir OdabraniTurnir { get; set; }
        private tim odabraniTim { get; set; }
        public PrijaviTimNaTurnir( turnir odabraniTurnir)
        {
            InitializeComponent();
            OdabraniTurnir = odabraniTurnir;
        }

        private void PrijaviTimNaTurnir_Load(object sender, EventArgs e)
        {
            uiNazivTurnira.Text = OdabraniTurnir.naziv; 
            uiKategorijaSporta.Text = OdabraniTurnir.sport.ToString();
            uiMjestoOdrzavanja.Text = OdabraniTurnir.dogadaj.lokacija.ToString();
            uiRokPrijave.Text = OdabraniTurnir.dogadaj.rok_prijave.Date.ToString();

            var timovi = from t in entities.tims
                         select t.naziv;

            uiOdabirNazivaTima.DataSource = timovi.ToList(); 
        }

        private void uiOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiPrijavi_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var tim in entities.tims)
                {
                    if (tim.naziv == uiOdabirNazivaTima.SelectedItem.ToString())
                    {
                        odabraniTim = tim; 
                    }
                }
                ProvjeriJeLiKorisnikClanTima(); 
                PrivjeriJeLiTimVecPrijavljen();
                PrivjeriJeLiNekiClanPrijavljenSamostalno();
                ProvjeriBrojClanova(); 
                PrijaviTim();
            }
            catch (PrijavaNaTurnirException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }

        public void ProvjeriBrojClanova()
        {
            if (odabraniTim.korisniks.Count() != odabraniTim.broj_clanova)
            {
                throw new PrijavaNaTurnirException("Timu moraju pristupiti svi članovi kako bi se mogao prijaviti na turnir!");
            }

            if (odabraniTim.broj_clanova > OdabraniTurnir.max_clanova_tima)
            {
                throw new PrijavaNaTurnirException($"Tim koji želite prijaviti ima prevelik broj članova, maksimalan broj članova za ovaj turnir { OdabraniTurnir.max_clanova_tima}"); 
            }

            int minClanova = 0; 
            foreach( var sport in entities.sports)
            {
                if (sport.id_sport == OdabraniTurnir.sport.id_sport)
                {
                    minClanova = sport.min_clanova_tima; 
                }
            }

            if (odabraniTim.broj_clanova < minClanova)
            {
                throw new PrijavaNaTurnirException($"Tim koji želite prijaviti ima premalo članova, minimalan broj članova za ovu vrstu sporta iznosi {minClanova}");
            }
        }

        public void ProvjeriJeLiKorisnikClanTima()
        {
            bool clanJe = false; 
            foreach(var clan in odabraniTim.korisniks)
            {
                if (clan.id_korisnik == PrijavljeniKorisnik.pk.id_korisnik)
                {
                    clanJe = true; 
                }
            }
            if (!clanJe)
            {
                throw new PrijavaNaTurnirException("Možete prijaviti samo tim u kojem ste vi član!"); 
            }
        }

        public void PrivjeriJeLiNekiClanPrijavljenSamostalno()
        {
            foreach(var clan in odabraniTim.korisniks)
            {
                foreach(var samostalno in OdabraniTurnir.korisniks)
                {
                    if (samostalno.id_korisnik == clan.id_korisnik)
                    {
                        throw new PrijavaNaTurnirException("Tim nije moguće prijaviti na turnir jer su se neki od članova tima samostalno prijavili!"); 
                    }
                }
            }
        }

        public void PrivjeriJeLiTimVecPrijavljen()
        {
            turnir odabrani=null; 
            foreach (var turnir in entities.turnirs)
            {
                if(turnir.id_turnir == OdabraniTurnir.id_turnir)
                {
                    odabrani = turnir;
                }
            }
            foreach (var tim in odabrani.tims)
            {
                if (tim.id_tim == odabraniTim.id_tim)
                {
                    throw new PrijavaNaTurnirException($" Tim {odabraniTim.naziv} je već prijavljen na turnir {odabrani.naziv}"); 
                }
            }
        }

        public void PrijaviTim()
        {
            turnir odabrani = null;
            foreach (var turnir in entities.turnirs)
            {
                if (turnir.id_turnir == OdabraniTurnir.id_turnir)
                    odabrani = turnir;
            }

            entities.turnirs.Attach(odabrani);
            entities.tims.Attach(odabraniTim);
            odabrani.tims.Add(odabraniTim);
            entities.SaveChanges();
            MessageBox.Show($"Uspješno ste prijavili tim {odabraniTim.naziv} na turnir {OdabraniTurnir.naziv}");
        }
    }
}
