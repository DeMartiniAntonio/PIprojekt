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
    public partial class DodajModeratoraDogadajuForma : Form
    {
        PI2231_DBEntities entities = new PI2231_DBEntities();
        dogadaj dogadaj = new dogadaj();
        
        public DodajModeratoraDogadajuForma(dogadaj prosljedeniDogadaj)
        {
            InitializeComponent();
            dogadaj = prosljedeniDogadaj;
        }

        private void DodajModeratoraDogadajuForma_Load(object sender, EventArgs e)
        {
            DohvatiModeratore();
            DohvatiModeratoreDogadaja();
        }

        private void DohvatiModeratoreDogadaja()
        {
            List<korisnik> moderatori = new List<korisnik>();
            foreach (var moderator in dogadaj.korisniks)
            {
                moderatori.Add(moderator);
            }
            moderatoriDogadajaDgv.DataSource = moderatori.ToList();
            moderatoriDogadajaDgv.Columns["id_korisnik"].Visible = false;
            moderatoriDogadajaDgv.Columns["lozinka"].Visible = false;
            moderatoriDogadajaDgv.Columns["id_uloga"].Visible = false;
            moderatoriDogadajaDgv.Columns["uloga_korisnika"].Visible = false;
            moderatoriDogadajaDgv.Columns["statistika_igraca"].Visible = false;
            moderatoriDogadajaDgv.Columns["tims"].Visible = false;
            moderatoriDogadajaDgv.Columns["dogadajs"].Visible = false;
            moderatoriDogadajaDgv.Columns["turnirs"].Visible = false;

        }

        private void DohvatiModeratore()
        {
            List<korisnik> moderatoriDogadaja = new List<korisnik>();
            using (var context = new PI2231_DBEntities())
            {
                var moderatori = from m in context.korisniks where m.uloga_korisnika.naziv == "Moderator" select m.korisnicko_ime;
                moderatoriCmb.DataSource = moderatori.ToList();
                moderatoriCmb.SelectedIndex = -1;
            }
        }

        private void dodajModeratoraBtn_Click(object sender, EventArgs e)
        {
            using (var context = new PI2231_DBEntities())
            {
                korisnik odabrani = new korisnik();

                string moderator = moderatoriCmb.SelectedValue.ToString();
                foreach (var item in context.korisniks)
                {
                    if (item.korisnicko_ime == moderator)
                    {
                        odabrani = item;
                        
                    }
                }
                
                context.dogadajs.Attach(dogadaj);
                context.korisniks.Attach(odabrani);
                odabrani.dogadajs.Add(dogadaj);
                dogadaj.korisniks.Add(odabrani);
                context.SaveChanges();
            }
            DohvatiModeratoreDogadaja();
            Close();
        }
    }
}
