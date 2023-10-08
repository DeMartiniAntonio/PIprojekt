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
    public partial class AdminPregledajDogadaj : Form
    {
        PI2231_DBEntities entities = new PI2231_DBEntities();
        dogadaj dogadaj = new dogadaj();
        public AdminPregledajDogadaj(dogadaj prosljedeniDogadaj)
        {
            InitializeComponent();
            dogadaj = prosljedeniDogadaj;
        }

       

        private void AdminDodijeljivanjeModeratoraDogađaju_Load(object sender, EventArgs e)
        {

            PopuniPodatkeODogadaju();
            DohvatiTurnireDogadaja();
          

        }

        private void DohvatiTurnireDogadaja()
        {
            using (var context = new PI2231_DBEntities())
            {
                var turniri = from t in context.turnirs where t.id_dogadaj == dogadaj.Id_dogadaj select t;
                turniriDgv.DataSource = turniri.ToList();
                turniriDgv.Columns[0].Visible = false;
            }
        }

        

        private void PopuniPodatkeODogadaju()
        {
            lokacijaTxt.Text = dogadaj.lokacija;
            nazivTxt.Text = dogadaj.naziv;
            opisTxt.Text = dogadaj.opis;
            organizatorTxt.Text = dogadaj.organizacija.ToString();
            datumIzvDate.Value = dogadaj.datum_izvodenja;
            rokPrijaveDate.Value = dogadaj.rok_prijave;

        }

        private void odbijBtn_Click(object sender, EventArgs e)
        {
            using (var context = new PI2231_DBEntities())
            {
                var upit = from d in context.dogadajs where d.Id_dogadaj == dogadaj.Id_dogadaj select d;
                foreach (dogadaj dogadaj in upit)
                {
                    dogadaj.status = 3;
                }
                context.SaveChanges();
            }
            Close();
            AdministratorOdobriDogađaje administratorOdobriDogađaje = new AdministratorOdobriDogađaje();
            administratorOdobriDogađaje.ShowDialog();
        }

        private void prihvatiBtn_Click(object sender, EventArgs e)
        {
            using (var context = new PI2231_DBEntities())
            {
                var upit = from d in context.dogadajs where d.Id_dogadaj == dogadaj.Id_dogadaj select d;
                foreach (dogadaj dogadaj in upit)
                {
                    dogadaj.status = 2;
                }
                context.SaveChanges();
            }
            Close();
            AdministratorOdobriDogađaje administratorOdobriDogađaje = new AdministratorOdobriDogađaje();
            administratorOdobriDogađaje.ShowDialog();

        }
    }
}
