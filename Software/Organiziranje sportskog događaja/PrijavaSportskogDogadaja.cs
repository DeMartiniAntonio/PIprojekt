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
    public partial class PrijavaSportskogDogadaja : Form
    {
        PI2231_DBEntities entities = new PI2231_DBEntities();
        public dogadaj noviDogadaj;
        public PrijavaSportskogDogadaja()
        {
            InitializeComponent();
            Popuniorganizacije();
        }
        private void uiPrijaviDogadaj_Click(object sender, EventArgs e)
        {
           using ( var context = new PI2231_DBEntities())
            {
                string Naziv = uiNazivDogadaja.Text;
                string Opis = uiOpis.Text;
                string Lokacija = uiLokacija.Text;
                DateTime odabraniDatum = datumIzvodenja.Value.Date;
                DateTime rokPrijave = datumPrijave.Value.Date;
                organizacija org = uiOrganizacija.SelectedItem as organizacija;
                context.organizacijas.Attach(org);
                dogadaj newDogadaj = new dogadaj 
               { 
                   naziv = Naziv,
                   opis = Opis,
                   organizacija = org,
                   lokacija = Lokacija,
                   datum_izvodenja = odabraniDatum,
                   rok_prijave = rokPrijave,
                   status = 2
                };
                context.dogadajs.Add(newDogadaj);
                context.SaveChanges();
            }
            this.Hide();
            PrijavaSportskogDogađajaPotvrda form = new PrijavaSportskogDogađajaPotvrda();
            form.ShowDialog();
        }
        private void PrijavaSportskogDogadaja_Load(object sender, EventArgs e)
        {
        }
        private void Popuniorganizacije()
        {
            List<organizacija> org;
            using( var context = new PI2231_DBEntities())
            {
                org = context.organizacijas.ToList();
            }
            uiOrganizacija.DataSource = org;
        }

        private void uiOrganizacija_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
