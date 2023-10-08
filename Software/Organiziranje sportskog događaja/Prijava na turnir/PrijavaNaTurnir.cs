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
    public partial class PrijavaNaTurnir : Form
    {
        PI2231_DBEntities entities = new PI2231_DBEntities();
        private List<turnir> turniriZaPrijavu = new List<turnir>();
        private List<turnir> gotovePrijave = new List<turnir>();

        public PrijavaNaTurnir()
        {
            InitializeComponent();
        }

        private void uiPrijaviTim_Click(object sender, EventArgs e)
        {
            if (turniriZaPrijavu.Count() > 0)
            {
                PrijaviTimNaTurnir prijaviTimNaTurnir = new PrijaviTimNaTurnir(uiPrikazTurniraZaPrijavu.CurrentRow.DataBoundItem as turnir);
                prijaviTimNaTurnir.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ne postoje budući turniri na koje se moguće prijaviti!");
            }
        }

        private void uiPrijaviSeSamostalno_Click(object sender, EventArgs e)
        {
            if (turniriZaPrijavu.Count() > 0)
            {
                PrijaviSeSamostalnoNaTurnir prijaviSeSamostalnoNaTurnir = new PrijaviSeSamostalnoNaTurnir(uiPrikazTurniraZaPrijavu.CurrentRow.DataBoundItem as turnir);
                prijaviSeSamostalnoNaTurnir.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ne postoje budući turniri na koje se moguće prijaviti!!");
            }
        }

        private void PrijavaNaTurnir_Load(object sender, EventArgs e)
        {
            DateTime danasnjiDatum = DateTime.Now;
            foreach (var turnir in entities.turnirs)
            {
                if(turnir.dogadaj.rok_prijave.Date >= danasnjiDatum.Date)
                {
                    turniriZaPrijavu.Add(turnir);
                }
            }

            uiPrikazTurniraZaPrijavu.DataSource = turniriZaPrijavu;
            uiPrikazTurniraZaPrijavu.Columns["korisniks"].Visible = false;
            uiPrikazTurniraZaPrijavu.Columns["tims"].Visible = false;
            uiPrikazTurniraZaPrijavu.Columns["grupas"].Visible = false;
            uiPrikazTurniraZaPrijavu.Columns["raspored_utakmica"].Visible = false;

            foreach (var turnir in entities.turnirs)
            {
                if (turnir.dogadaj.datum_izvodenja.Date >= danasnjiDatum && turnir.dogadaj.rok_prijave.Date < danasnjiDatum.Date)
                {
                    gotovePrijave.Add(turnir);
                }
            }

            foreach (var turnir in gotovePrijave)
            {
                if (turnir.korisniks.Count() != 0 )
                {
                    PokusajGeneriratiTim(turnir); 
                }
            }

            uiPrikazTurniraZavrsenihPrijava.DataSource = gotovePrijave;
            uiPrikazTurniraZavrsenihPrijava.Columns["korisniks"].Visible = false;
            uiPrikazTurniraZavrsenihPrijava.Columns["tims"].Visible = false;
            uiPrikazTurniraZavrsenihPrijava.Columns["grupas"].Visible = false;
            uiPrikazTurniraZavrsenihPrijava.Columns["raspored_utakmica"].Visible = false;

        }

        public void PokusajGeneriratiTim(turnir turnir)
        {
            int minimalno = 0;
            foreach (var sport in entities.sports)
            {
                if (sport.id_sport == turnir.sport.id_sport)
                {
                    minimalno = sport.min_clanova_tima; 
                }
            }
            int maksimalno = turnir.max_clanova_tima;

            if (turnir.korisniks.Count() >= minimalno)
            {
                for (int i = minimalno; i <= maksimalno; i++)
                {
                    if (turnir.korisniks.Count()% i == 0)
                    {
                        KreirajTimove((int)(turnir.korisniks.Count()/i), i, turnir); 
                    }
                }

                if (turnir.korisniks.Count() > maksimalno)
                {
                    KreirajTimove((int)(turnir.korisniks.Count()/ maksimalno), maksimalno, turnir);
                }
            }
            turnir.korisniks.Clear();
            entities.SaveChanges();
        }

        public void KreirajTimove(int brojTimova, int brojClanova, turnir turnir)
        {
            for (int i = 0; i<brojTimova; i++)
            {
                    string generiraniKod = GeneriranjePristupnogKoda.GenerirajPristupniKod();
                string naziv = GenerirajNaziv(); 
                    tim noviTim = new tim()
                    {
                        naziv = naziv,
                        pristupni_kod = generiraniKod,
                        broj_clanova = brojClanova,
                    };
                    entities.tims.Add(noviTim);
                    entities.SaveChanges();
                    
                    for (int j = 0; j < brojClanova; j++)
                    { 
                        korisnik odabrani= null; 
                        foreach (var item in entities.korisniks)
                        {
                            if (item.id_korisnik == turnir.korisniks.First().id_korisnik)
                            {
                                odabrani = item;
                                break; 
                            }
                        }

                        entities.korisniks.Attach(odabrani); 
                        entities.tims.Attach(noviTim);
                        odabrani.tims.Add(noviTim);
                        turnir.korisniks.Remove(odabrani);
                        entities.SaveChanges();
                    }
                        
                    noviTim.turnirs.Add(turnir);
                    entities.SaveChanges();
            }
        }

        private string GenerirajNaziv()
        {
            string naziv = "Tim";
            Random rand = new Random();
            bool postoji;
            do
            {
                postoji = false; 
                int duzina = rand.Next(0, 5);
                for (int i = 0; i < duzina; i++)
                {
                    naziv += rand.Next(0, 9);
                }
                foreach(var tim in entities.tims)
                {
                    if (tim.naziv == naziv)
                    {
                        postoji = true;
                    }
                }
            } while (postoji); 
            return naziv;
        }

        private void uiNatrag_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void uiProvjeriStatus_Click(object sender, EventArgs e)
        {
            turnir odabraniTurnir = null;
            if (gotovePrijave.Count > 0)
            {
                foreach (var turnir in entities.turnirs)
                {
                    if (turnir.id_turnir == (uiPrikazTurniraZavrsenihPrijava.CurrentRow.DataBoundItem as turnir).id_turnir)
                        odabraniTurnir = turnir;
                }
                bool pronaden = false;

                foreach (var tim in odabraniTurnir.tims)
                {
                    if (!pronaden)
                    {
                        foreach (var korisnik in tim.korisniks)
                        {
                            if (korisnik.id_korisnik == PrijavljeniKorisnik.pk.id_korisnik)
                            {
                                MessageBox.Show($"Rezultat za korisnika {PrijavljeniKorisnik.pk.korisnicko_ime}: \nPrijavljeni ste na turnir kao član tima {tim.naziv}");
                                pronaden = true;
                                break;
                            }
                        }
                    }
                }
                if (!pronaden)
                {
                    MessageBox.Show($"Rezultat za korisnika {PrijavljeniKorisnik.pk.korisnicko_ime}: \nŽao nam je ali niste prijavljeni na turnir!");
                }
            }
            else
            {
                MessageBox.Show("Ne postoje budući turniri sa završenim rokom prijave!");
            }

        }
    }
}
