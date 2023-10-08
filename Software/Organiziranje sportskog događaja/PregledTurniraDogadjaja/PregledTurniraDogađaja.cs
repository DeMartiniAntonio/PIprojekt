using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organiziranje_sportskog_događaja.PregledTurniraDogadjaja
{
    public partial class PregledTurniraDogađaja : Form
    {
        PI2231_DBEntities entities = new PI2231_DBEntities();
        dogadaj d = new dogadaj();

        public PregledTurniraDogađaja(dogadaj prosljedeniDogadaj)
        {
            InitializeComponent();
            d = prosljedeniDogadaj;
            if (PrijavljeniKorisnik.pk == null)
            {
                prijaviTim.Enabled = false;
                samostalnaPrijava.Enabled= false;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void pretraziBTN_Click(object sender, EventArgs e)
        {
            if (nogometCB.Checked == false && rukometCB.Checked == false && kosarkaCB.Checked == false && pretrazivanjeTXB.Text.Length == 0)
            {
                PrikaziSveTurnire();
                return;
            }

            List<turnir> listSportova = new List<turnir>();

            pregledDTG.DataSource = null;

            using (var db = new PI2231_DBEntities())
            {

                

                if (nogometCB.Checked == true)
                    {

                        var q = from p in db.turnirs.Include("Sport").Include("dogadaj")
                                where p.id_sport == 1 && p.id_dogadaj == d.Id_dogadaj
                                select p;
                    listSportova.AddRange(q.ToList());

                    }

                    if (kosarkaCB.Checked == true)
                    {

                        var q = from p in db.turnirs.Include("Sport").Include("dogadaj")
                                where p.id_sport == 2 && p.id_dogadaj == d.Id_dogadaj

                                select p;
                    listSportova.AddRange(q.ToList());


                    }
                    if (rukometCB.Checked == true)
                    {

                        var q = from p in db.turnirs.Include("Sport").Include("dogadaj")
                                where p.id_sport == 3 && p.id_dogadaj == d.Id_dogadaj
                                select p;
                    listSportova.AddRange(q.ToList());

                    }

                if (nogometCB.Checked == false && rukometCB.Checked == false && kosarkaCB.Checked == false && pretrazivanjeTXB.Text.Length != 0)
                 {
                    

                    var q = from p in db.turnirs.Include("Sport").Include("dogadaj")
                            where  p.id_dogadaj == d.Id_dogadaj && p.naziv.Contains(pretrazivanjeTXB.Text)
                           
                                select p;
                    listSportova.AddRange(q.ToList());


                }

                if ((nogometCB.Checked == true || rukometCB.Checked == true || kosarkaCB.Checked == true) && pretrazivanjeTXB.Text.Length != 0)
                {
                    var q = from p in listSportova
                            where p.naziv.Contains(pretrazivanjeTXB.Text)

                            select p;
                    listSportova=q.ToList();
                }

                
                    var qu= from p in listSportova
                            
                            select p;
                    pregledDTG.DataSource = qu.ToList();
                    pregledDTG.Columns[0].Visible = false;
                    pregledDTG.Columns[4].Visible = false;
                    pregledDTG.Columns[5].Visible = false;
                    pregledDTG.Columns[6].Visible = false;
                    pregledDTG.Columns[7].Visible = false;
                    pregledDTG.Columns[8].Visible = false;
                    pregledDTG.Columns[9].Visible = true;
                    pregledDTG.Columns[10].Visible = false;
                    pregledDTG.Columns[11].Visible = false;
                
            }
        }
    
        

        private void natragBTN_Click(object sender, EventArgs e)
        {
            if (PrijavljeniKorisnik.pk == null)
            {
                this.Hide();
                PočetnaNeregistrirani pocetna = new PočetnaNeregistrirani();
                pocetna.Show();
                this.Close();
            }

            else
            {
                if (PrijavljeniKorisnik.pk.id_uloga == 2)
                {
                    this.Hide();
                    PočetnaModerator pocetna = new PočetnaModerator();
                    pocetna.Show();
                    this.Close();

                }
                else if (PrijavljeniKorisnik.pk.id_uloga == 1)
                {

                    this.Hide();
                    PočetnaRegistrirani pocetna = new PočetnaRegistrirani();
                    pocetna.Show();
                    this.Close();


                }
                else if (PrijavljeniKorisnik.pk.id_uloga == 3)
                {
                    this.Hide();
                    PočetnaAdministrator pocetna = new PočetnaAdministrator();
                    pocetna.Show();
                    this.Close();

                }
                else
                {
                    this.Hide();
                    PočetnaNeregistrirani pocetna = new PočetnaNeregistrirani();
                    pocetna.Show();
                    this.Close();

                }
            }

        }

        private void PregledTurniraDogađaja_Load(object sender, EventArgs e)
        {
            PrikaziSveTurnire();
            
        }

        private void PrikaziSveTurnire()
        {
            pregledDTG.DataSource = null;

            using (var db = new PI2231_DBEntities())
            {
                var q = from p in db.turnirs.Include("Sport").Include("dogadaj")
                        where p.id_dogadaj == d.Id_dogadaj
                        select p;
            pregledDTG.DataSource = q.ToList();
            pregledDTG.Columns[0].Visible = false;
            pregledDTG.Columns[4].Visible = false;
            pregledDTG.Columns[5].Visible = false;
            pregledDTG.Columns[6].Visible = false;
            pregledDTG.Columns[7].Visible = false;
            pregledDTG.Columns[8].Visible = false;
            pregledDTG.Columns[9].Visible = true;
            pregledDTG.Columns[10].Visible = false;
            pregledDTG.Columns[11].Visible = false;
            
            }

        }

        private void detaljiBTN_Click(object sender, EventArgs e)
        {

        }

        private void pregledDTG_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void prijaviTim_Click(object sender, EventArgs e)
        {
            this.Hide();

            PrijaviTimNaTurnir prijaviTimNaTurnir = new PrijaviTimNaTurnir(pregledDTG.CurrentRow.DataBoundItem as turnir);
            prijaviTimNaTurnir.ShowDialog();
        }

        private void samostalnaPrijava_Click(object sender, EventArgs e)
        {

            this.Hide();

            PrijaviSeSamostalnoNaTurnir prijaviSeSamostalnoNaTurnir = new PrijaviSeSamostalnoNaTurnir(pregledDTG.CurrentRow.DataBoundItem as turnir);
            prijaviSeSamostalnoNaTurnir.ShowDialog();
            
        }
    }
}
