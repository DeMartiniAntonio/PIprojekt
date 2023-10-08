using Organiziranje_sportskog_događaja.PregledTurniraDogadjaja;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organiziranje_sportskog_događaja
{
    public partial class PočetnaModerator : Form
    {
        
        

        public PočetnaModerator()
        {
            InitializeComponent();
            
        }

        
        private void DohvatiDogadaje()
        {
            using (var context = new PI2231_DBEntities())
            {
                var dogadaji = from d in context.dogadajs.Include("status_dogadaja") where d.status!=3 && d.status!=4 select d;
                dogadajiDgv.DataSource = dogadaji.ToList();
                dogadajiDgv.Columns["organizator"].Visible = false;
                dogadajiDgv.Columns["status"].Visible = false;

                dogadajiDgv.Columns["organizacija"].Visible = false;
                dogadajiDgv.Columns["korisniks"].Visible = false;
                dogadajiDgv.Columns["turnirs"].Visible = false;
                dogadajiDgv.Columns["status_dogadaja"].Visible = true;
            }
            
            
            
        }

        private void DohvatiOrganizacije()
        {
            using (var context = new PI2231_DBEntities())
            {
                var organizacije = from o in context.organizacijas select o.naziv;
                organizacijeCmb.DataSource = organizacije.ToList();
                organizacijeCmb.SelectedIndex = -1;
            }
        }

        private void DohvatiTimove()
        {
            using (var context = new PI2231_DBEntities())
            {
                var timovi = from t in context.tims select t.naziv;
                timoviCmb.DataSource = timovi.ToList();
                timoviCmb.SelectedIndex = -1;
            }
        }

        private void DohvatiIgrace()
        {
            using (var context = new PI2231_DBEntities())
            {
                var igraci = from i in context.korisniks where i.id_uloga == 1 select i.korisnicko_ime;
                igraciCmb.DataSource = igraci.ToList();
                igraciCmb.SelectedIndex = -1;
            }
        }
        private void PočetnaModerator_Load(object sender, EventArgs e)
        {
            Osvjezi();
            

            
        }

        private void Osvjezi()
        {
            DohvatiIgrace();
            DohvatiTimove();
            DohvatiOrganizacije();
            DohvatiDogadaje();
        }

        private void kreirajTimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            KreiranjeTima kreiranjeTima = new KreiranjeTima();
            kreiranjeTima.ShowDialog();

        }

        private void prijavaNaTurnirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            PrijavaNaTurnir prijavaNaTurnir = new PrijavaNaTurnir();
            prijavaNaTurnir.ShowDialog();
        }

        private void igracBtn_Click(object sender, EventArgs e)
        {
            string odabraniIgrac = igraciCmb.Text;


            using (var context = new PI2231_DBEntities())
            {
                var igracSql = from i in context.korisniks where i.korisnicko_ime == odabraniIgrac select i;
                var igracLista = igracSql.ToList();
                PregledIgracaForm pregledIgracaForm = new PregledIgracaForm(igracLista[0]);
                pregledIgracaForm.ShowDialog();
            }
        }

        private void orgBtn_Click(object sender, EventArgs e)
        {
            var odabranaOrg = organizacijeCmb.Text;
            using (var context = new PI2231_DBEntities())
            {
                var orgSql = from o in context.organizacijas where o.naziv == odabranaOrg select o;
                var orgLista = orgSql.ToList();
                this.Hide();

                PregledOrganizacijeForma pregledOrganizacijeForma = new PregledOrganizacijeForma(orgLista[0]);
                pregledOrganizacijeForma.ShowDialog();
            }
        }

        private void timBtn_Click(object sender, EventArgs e)
        {
            string odabraniTim = timoviCmb.Text;

            using (var context = new PI2231_DBEntities())
            {
                var timoviSql = from t in context.tims where t.naziv == odabraniTim select t;
                var timoviLista = timoviSql.ToList();
                this.Hide();

                PregledTimaForma pregledTimaForma = new PregledTimaForma(timoviLista[0]);
                pregledTimaForma.ShowDialog();
            }
        }

        private void dogadajBtn_Click(object sender, EventArgs e)
        {
            
            dogadaj odabraniDogadaj = dogadajiDgv.CurrentRow.DataBoundItem as dogadaj;
            PregledTurniraDogađaja turniri = new PregledTurniraDogađaja(odabraniDogadaj);
            this.Hide();
            turniri.ShowDialog();
            
        }

        private void dodijeljeniDogađajiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            ModeratorDodijeljeniDogađaji moderatorDodijeljeniDogađaji = new ModeratorDodijeljeniDogađaji();
            moderatorDodijeljeniDogađaji.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PregledKorisnickogRacunaModeratora pregledRacuna = new PregledKorisnickogRacunaModeratora();
            pregledRacuna.ShowDialog();
        }

        private void odigranoRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (odigranoRadio.Checked)
            {
                using (var context = new PI2231_DBEntities())
                {


                    var dogadaji = from d in context.dogadajs.Include("status_dogadaja") where d.status == 1 select d;
                    dogadajiDgv.DataSource = dogadaji.ToList();
                    dogadajiDgv.Columns["organizator"].Visible = false;
                    dogadajiDgv.Columns["status"].Visible = false;

                    dogadajiDgv.Columns["organizacija"].Visible = false;
                    dogadajiDgv.Columns["korisniks"].Visible = false;
                    dogadajiDgv.Columns["turnirs"].Visible = false;
                    dogadajiDgv.Columns["status_dogadaja"].Visible = true;
                }
            }
        }

        private void slobodnoRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (slobodnoRadio.Checked)
            {
                using (var context = new PI2231_DBEntities())
                {


                    var dogadaji = from d in context.dogadajs.Include("status_dogadaja") where d.status == 2 select d;
                    dogadajiDgv.DataSource = dogadaji.ToList();
                    dogadajiDgv.Columns["organizator"].Visible = false;
                    dogadajiDgv.Columns["status"].Visible = false;

                    dogadajiDgv.Columns["organizacija"].Visible = false;
                    dogadajiDgv.Columns["korisniks"].Visible = false;
                    dogadajiDgv.Columns["turnirs"].Visible = false;
                    dogadajiDgv.Columns["status_dogadaja"].Visible = true;
                }

            }
        }
    }
}
