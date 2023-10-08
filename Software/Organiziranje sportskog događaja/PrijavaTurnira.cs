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
    public partial class PrijavaTurnira : Form
    {
        PI2231_DBEntities entities = new PI2231_DBEntities();
        public PrijavaTurnira()
        {
            InitializeComponent();
        }

        private void PrijavaTurnira_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DodajDogadaje();
            dataGridView1.Columns["organizacija"].Visible = false;
            dataGridView1.Columns["status_dogadaja"].Visible = false;
            dataGridView1.Columns["turnirs"].Visible = false;
            dataGridView1.Columns["korisniks"].Visible = false;
            PopuniKategorije();
        }
        private object DodajDogadaje()
        {
            return entities.dogadajs.ToList();
        }
        private void PopuniKategorije()
        {
            List<sport> sportovi;
            using (var context = new PI2231_DBEntities())
            {
                sportovi = context.sports.ToList();
            }
            uiKategorije.DataSource = sportovi;
        }
        private dogadaj DohvatiOdabrani()
        {
            return dataGridView1.CurrentRow.DataBoundItem as dogadaj;
        }
        private void uiSpremiTurnir_Click(object sender, EventArgs e)
        {
            using (var context = new PI2231_DBEntities())
            {
                string Naziv = uiNaziv.Text;
                string Kotizacija = uiKotizacija.Text;
                string maxbroj = uiMaxBroj.Text;
                sport Sport = uiKategorije.SelectedItem as sport;
                context.sports.Attach(Sport);

                turnir newTurnir = new turnir
                {
                    naziv = Naziv,
                    kotizacija = int.Parse(Kotizacija),
                    max_clanova_tima = int.Parse(maxbroj),
                    sport = Sport,
                    id_dogadaj = DohvatiOdabrani().Id_dogadaj
                };
                context.turnirs.Add(newTurnir);
                context.SaveChanges();
            }
            dataGridView1.DataSource = DodajDogadaje();
            Close();
        }
        string opcija;
        private void uiKategorije_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uiKategorije.SelectedIndex == 0)
                opcija = uiKategorije.Items[0].ToString();
            if (uiKategorije.SelectedIndex == 1)
                opcija = uiKategorije.Items[1].ToString();
            if (uiKategorije.SelectedIndex == 2)
                opcija = uiKategorije.Items[2].ToString();
            using (var context = new PI2231_DBEntities())
            {
                var query = from s in context.sports
                            where (opcija == s.naziv)
                            select s;
                sport odabrani = query.Single();
                uiMinBroj.Text = odabrani.min_clanova_tima.ToString();
            }
        }
      
    }
}
