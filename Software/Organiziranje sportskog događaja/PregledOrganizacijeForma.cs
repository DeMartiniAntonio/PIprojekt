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
    public partial class PregledOrganizacijeForma : Form
    {
        organizacija organizacija = new organizacija();
        public PregledOrganizacijeForma(organizacija prosljedenaOrganizacija)
        {
            InitializeComponent();
            organizacija=prosljedenaOrganizacija;
        }

        private void PregledOrganizacijeForma_Load(object sender, EventArgs e)
        {
            nazivTxt.Text = organizacija.naziv;
            korimeTxt.Text = organizacija.korisnicko_ime;
            kontaktTxt.Text = organizacija.kontakt_broj;
            oibTxt.Text = organizacija.OIB;
            opisTxt.Text = organizacija.opis;
            adresaTxt.Text = organizacija.adresa;
            emailTxt.Text = organizacija.email;
            using (var context = new PI2231_DBEntities())
            {
                var dogadaji = from d in context.dogadajs where d.organizator == organizacija.id_organizacija select d;
                dogadajiDgv.DataSource = dogadaji.ToList();
            }
            dogadajiDgv.Columns[0].Visible = false;
            dogadajiDgv.Columns["organizator"].Visible = false;
            dogadajiDgv.Columns["status"].Visible = false;
            dogadajiDgv.Columns["organizacija"].Visible = false;
            dogadajiDgv.Columns["korisniks"].Visible = false;
            dogadajiDgv.Columns["turnirs"].Visible = false;
            dogadajiDgv.Columns["status_dogadaja"].Visible = false;


        }

        private void pocetnaBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
