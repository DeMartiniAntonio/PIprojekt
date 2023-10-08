using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Organiziranje_sportskog_događaja.Kreiranje_tima;

namespace Organiziranje_sportskog_događaja
{
    public partial class KreiranjeTima : Form
    {
        PI2231_DBEntities entities = new PI2231_DBEntities();
        public KreiranjeTima()
        {
            InitializeComponent();
        }

        private void KreiranjeTima_Load(object sender, EventArgs e)
        {
            List<string> listaOpcija = new List<string>();
            listaOpcija.Add("Kreiraj tim");
            listaOpcija.Add("Pristupi timu"); 
            uiOdaberiteOpciju.DataSource = listaOpcija; 

            List<int> moguceVelicine = new List<int> { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            uiOdaberiteVelicinu.DataSource = moguceVelicine; 

            zaKreiranjeTima.Visible = false;
            zaPristupTimu.Visible = false;
        }

        private void uiOdaberiteOpciju_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(uiOdaberiteOpciju.SelectedItem.ToString() == "Kreiraj tim")
            {
                zaKreiranjeTima.Visible = true;
                zaPristupTimu.Visible = false;
                uiPrikazPristupnogKoda.Visible = false;
                labelaPrikazKoda.Visible = false;
                uiKopiraj.Visible = false;
            }
            else if (uiOdaberiteOpciju.SelectedItem.ToString() == "Pristupi timu")
            {
                zaKreiranjeTima.Visible = false;
                zaPristupTimu.Visible = true; 
            }
        }

        private void uiKreiraj_Click(object sender, EventArgs e)
        {
            if (uiUnosNaziva.Text.Length == 0 )
            {
                MessageBox.Show("Naziv tima mora biti unesen!");
                return;
            }

            try
            {
                if (provjeraNazivaTima(uiUnosNaziva.Text))
                {
                    korisnik prijavljeni = PrijavljeniKorisnik.pk; 
                    using (var context = new PI2231_DBEntities())
                    {
                        if(provjeraNazivaTima(uiUnosNaziva.Text))
                        {
                            string generiraniKod = GeneriranjePristupnogKoda.GenerirajPristupniKod();
                            tim noviTim = new tim()
                            {
                                naziv = uiUnosNaziva.Text,
                                pristupni_kod = generiraniKod,
                                broj_clanova = (int)uiOdaberiteVelicinu.SelectedItem,
                            };

                            context.korisniks.Attach(prijavljeni);
                            prijavljeni.tims.Add(noviTim);
                            context.SaveChanges();

                            MessageBox.Show("Uspješno ste kreirali novi tim i postali njegovim članom!");
                            labelaPrikazKoda.Visible = true;
                            uiPrikazPristupnogKoda.Visible = true;
                            uiKopiraj.Visible = true;
                            uiPrikazPristupnogKoda.Text = generiraniKod;
                        }
                    }
                }
            }
            catch (KreiranjeTimaException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }

        private bool provjeraNazivaTima(string naziv )
        {
            foreach (var item in entities.tims)
            {
                if (item.naziv == naziv)
                {
                    throw new KreiranjeTimaException($"Tim s nazivom {naziv} već postoji!");
                }
            }
            return true;
        }

        private void uiPristupi_Click(object sender, EventArgs e)
        {
            try
            {
                DodajClana(uiUnosPristupnogKoda.Text);
            }
            catch (KreiranjeTimaException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }

        public void DodajClana(string kod)
        {
            if (kod == "")
            {

                throw new KreiranjeTimaException($"Morate unijeti pristupni kod!");
            }
            korisnik prijavljeni = PrijavljeniKorisnik.pk;
            tim zeljeniTim = null;
            foreach (var tim in entities.tims)
            {
                if (tim.pristupni_kod == kod)
                {
                    zeljeniTim = tim;
                }
            }
            if (zeljeniTim != null)
            {
                if(!VecJeClan(zeljeniTim) && ProvjeraBrojaClanova(kod, zeljeniTim))
                {
                   entities.korisniks.Attach(prijavljeni);
                   entities.tims.Attach(zeljeniTim);
                   prijavljeni.tims.Add(zeljeniTim);
                   entities.SaveChanges();

                   MessageBox.Show($"Uspješno ste postali članom tima {zeljeniTim.naziv}");
                }
            }
            else
            {
                throw new KreiranjeTimaException($"Tim s pristupnim kodom {kod} ne postoji!");
            }
        }

        public bool ProvjeraBrojaClanova(string kod, tim zeljeni )
        {
            if (zeljeni.broj_clanova > zeljeni.korisniks.Count())
            {
                return true; 
            }
            else
            {
                throw new KreiranjeTimaException($"Tim {zeljeni.naziv} već ima maksimalan broj članova!");
            }
        }

        public bool VecJeClan(tim zeljeni)
        {
            foreach (var clan in zeljeni.korisniks)
            {
                if (clan.id_korisnik == PrijavljeniKorisnik.pk.id_korisnik)
                {
                    throw new KreiranjeTimaException($"Već ste član tima {zeljeni.naziv}!");
                }
            }
            return false;
        }

        private void uiNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiKopiraj_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(uiPrikazPristupnogKoda.Text);
        }
    }
}
