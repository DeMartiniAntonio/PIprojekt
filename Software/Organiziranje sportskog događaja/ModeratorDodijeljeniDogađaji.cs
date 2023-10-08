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
    public partial class ModeratorDodijeljeniDogađaji : Form
    {
        korisnik moderator = PrijavljeniKorisnik.pk;
        public ModeratorDodijeljeniDogađaji()
        {
            InitializeComponent();
        }

        private void pokreniTurnirBtn_Click(object sender, EventArgs e)
        {
            turnir turnir = turniriDgv.CurrentRow.DataBoundItem as turnir;
            this.Hide();
            ModeratorGenerirajKnockout generiraj = new ModeratorGenerirajKnockout(turnir);
            generiraj.Show();
            //OdabirFormataTurnira odabirFormataTurnira = new OdabirFormataTurnira(turniriDgv.CurrentRow.DataBoundItem as turnir);
            // odabirFormataTurnira.ShowDialog();
        }

        private void ModeratorDodijeljeniDogađaji_Load(object sender, EventArgs e)
        {
            DohvatiDogadajeModeratora();
           

        }

        private void DohvatiTurnire()
        {
            dogadaj odabraniDogadaj = dogadajiDgv.CurrentRow.DataBoundItem as dogadaj;
            
            using (var context= new PI2231_DBEntities())
            {
                var turniri = from t in context.turnirs.Include("tims").Include("sport") where t.id_dogadaj == odabraniDogadaj.Id_dogadaj select t;
                turniriDgv.DataSource = turniri.ToList();
            }
            //foreach (var item in odabraniDogadaj.turnirs)
            //{
            //    turniri.Add(item);
            //}

            turniriDgv.Columns[0].Visible = false;
            turniriDgv.Columns["id_dogadaj"].Visible = false;
            turniriDgv.Columns["id_sport"].Visible = false;
            turniriDgv.Columns["dogadaj"].Visible = false;
            turniriDgv.Columns["grupas"].Visible = false;
            turniriDgv.Columns["raspored_utakmica"].Visible = false;
            turniriDgv.Columns["sport"].Visible = false;
            turniriDgv.Columns["tims"].Visible = false;
            turniriDgv.Columns["korisniks"].Visible = false;
            turniriDgv.Columns["statistika_igraca"].Visible = false;
        }

        private void DohvatiDogadajeModeratora()
        {
            using (var context = new PI2231_DBEntities())
            {
                var dogadajiModeratora = from d in context.dogadajs.Include("turnirs") where d.korisniks.FirstOrDefault().id_korisnik == moderator.id_korisnik select d;
                dogadajiDgv.DataSource = dogadajiModeratora.ToList();
                dogadajiDgv.Columns[0].Visible=false;
                dogadajiDgv.Columns["organizator"].Visible = false;
                dogadajiDgv.Columns["status"].Visible = false;

                dogadajiDgv.Columns["organizacija"].Visible = false;
                dogadajiDgv.Columns["korisniks"].Visible = false;
                dogadajiDgv.Columns["turnirs"].Visible = false;
                dogadajiDgv.Columns["status_dogadaja"].Visible = false;
            }
        }

        private void dogadajiDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DohvatiTurnire();
        }
    }
}
