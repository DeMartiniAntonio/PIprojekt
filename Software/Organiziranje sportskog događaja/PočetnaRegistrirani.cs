using Organiziranje_sportskog_događaja.PregledTurniraDogadjaja;
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
    public partial class PočetnaRegistrirani : Form
    {
        PI2231_DBEntities entities = new PI2231_DBEntities();
        

        public PočetnaRegistrirani()
        {
            InitializeComponent();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            dogadaj dogadaj = dogadajiDgv.CurrentRow.DataBoundItem as dogadaj;
            PregledTurniraDogađaja pregledTurniraDogađaja = new PregledTurniraDogađaja(dogadaj);
            pregledTurniraDogađaja.ShowDialog();
        }

        private void kreirajTimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KreiranjeTima kreiranjeTima = new KreiranjeTima();
            kreiranjeTima.ShowDialog();
        }

        private void prijavaNaTurnirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrijavaNaTurnir prijavaNaTurnir = new PrijavaNaTurnir();
            prijavaNaTurnir.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PregledKorisnickogRacunaKorisnik pregledRacuna = new PregledKorisnickogRacunaKorisnik();
            pregledRacuna.ShowDialog();
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

        private void odigranoRadio_CheckedChanged_1(object sender, EventArgs e)
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
    }
}
