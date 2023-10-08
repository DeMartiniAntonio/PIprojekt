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
    public partial class AdministratorOdobriDogađaje : Form
    {
        PI2231_DBEntities entites = new PI2231_DBEntities();
        public AdministratorOdobriDogađaje()
        {
            InitializeComponent();
        }

        private void AdministratorOdobriDogađaje_Load(object sender, EventArgs e)
        {
            DohvatiDogadajeNaCekanju();
            DohvatiPrihvaceneDogadaje();
        }

        private void DohvatiPrihvaceneDogadaje()
        {
            using (var context = new PI2231_DBEntities())
            {
                var dogadaji = from d in context.dogadajs.Include("organizacija").Include("korisniks") where d.status_dogadaja.status == "Nadolazeci" select d;
                prihvaceniDogadajiDgv.DataSource = dogadaji.ToList();
            }

            prihvaceniDogadajiDgv.Columns["korisniks"].Visible = false;
            prihvaceniDogadajiDgv.Columns["organizator"].Visible = false;
            prihvaceniDogadajiDgv.Columns["turnirs"].Visible = false;
            prihvaceniDogadajiDgv.Columns["status_dogadaja"].Visible = false;
            prihvaceniDogadajiDgv.Columns["status"].Visible = false;
        }

        private void DohvatiDogadajeNaCekanju()
        {
            using (var context = new PI2231_DBEntities())
            {
                var dogadaji = from d in context.dogadajs.Include("organizacija") where d.status_dogadaja.status == "Na čekanju" select d;
                dogadajiNaCekanjuDgv.DataSource = dogadaji.ToList();
            }

            dogadajiNaCekanjuDgv.Columns["korisniks"].Visible = false;
            dogadajiNaCekanjuDgv.Columns["organizator"].Visible = false;
            dogadajiNaCekanjuDgv.Columns["turnirs"].Visible = false;
            dogadajiNaCekanjuDgv.Columns["status_dogadaja"].Visible = false;
            dogadajiNaCekanjuDgv.Columns["status"].Visible = false;

        }

        private void pregledajBtn_Click(object sender, EventArgs e)
        {
            Close();
            AdminPregledajDogadaj adminDodijeljivanjeModeratoraDogađaju = new AdminPregledajDogadaj(dogadajiNaCekanjuDgv.CurrentRow.DataBoundItem as dogadaj);
            adminDodijeljivanjeModeratoraDogađaju.ShowDialog();
        }

        private void dodajModeratoraBtn_Click(object sender, EventArgs e)
        {
            DodajModeratoraDogadajuForma dodajModeratoraDogadajuForma = new DodajModeratoraDogadajuForma(prihvaceniDogadajiDgv.CurrentRow.DataBoundItem as dogadaj);
            dodajModeratoraDogadajuForma.ShowDialog();
        }
    }
}
