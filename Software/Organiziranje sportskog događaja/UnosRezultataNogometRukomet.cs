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
    public partial class UnosRezultataNogometRukomet : Form
    {
        PI2231_DBEntities entities = new PI2231_DBEntities();
        public int IdUtakmice { get; set; }
        
        
        private tim Tim1 { get; set; }
        private tim Tim2 { get; set; }
        private List<korisnik> ClanoviTima1 = new List<korisnik>();
        private List<korisnik> ClanoviTima2 = new List<korisnik>();
        private statistika_igraca StatIgraca = null;
        private korisnik OdabraniIgrac = null;
        public int brojPogodakaTim1 = 0;
        public int brojPogodakaTim2 = 0;

        public raspored_utakmica Utakmica { get; set; }
        public UnosRezultataNogometRukomet(int idUtakmice)
        {
            InitializeComponent();
            IdUtakmice = idUtakmice;
        }

        private void UnosRezultataNogometRukomet_Load(object sender, EventArgs e)
        {
            using (var db = new PI2231_DBEntities())
            {
                var qu = from p in db.raspored_utakmica
                         where IdUtakmice == p.id_utakmica
                         select p;
                raspored_utakmica utakmica = qu.FirstOrDefault();
                Utakmica = utakmica;

                var quTim1 = from t in db.tims
                          where Utakmica.tim_jedan == t.naziv
                          select t;
                Tim1 = quTim1.FirstOrDefault();

                var quTim2 = from t in db.tims
                          where Utakmica.tim_dva == t.naziv
                          select t;
                Tim2 = quTim2.FirstOrDefault();

                foreach (var tim in entities.tims)
                {
                    if (tim.naziv == Tim1.naziv)
                    {
                        foreach (var clan in tim.korisniks)
                        {
                            ClanoviTima1.Add(clan);
                            
                        }
                        
                    }
                    if (tim.naziv == Tim2.naziv)
                    {
                        foreach (var clan in tim.korisniks)
                        {
                            ClanoviTima2.Add(clan);

                        }
                        
                    }
                    
                }
                dataGridView1.DataSource =ClanoviTima1;
                dataGridView2.DataSource = ClanoviTima2;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[12].Visible = false;
                dataGridView2.Columns[0].Visible = false;
                dataGridView2.Columns[4].Visible = false;
                dataGridView2.Columns[5].Visible = false;
                dataGridView2.Columns[6].Visible = false;
                dataGridView2.Columns[7].Visible = false;
                dataGridView2.Columns[8].Visible = false;
                dataGridView2.Columns[9].Visible = false;
                dataGridView2.Columns[10].Visible = false;
                dataGridView2.Columns[11].Visible = false;
                dataGridView2.Columns[12].Visible = false;
                

                
            }
            
            tim1Label.Text = Utakmica.tim_jedan;
            tim2Label.Text = Utakmica.tim_dva;

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var OdabraniIgrac = dataGridView1.CurrentRow.DataBoundItem as korisnik;

            IgracTima1Label.Text = OdabraniIgrac.ime + " " + OdabraniIgrac.prezime;
            using (var context = new PI2231_DBEntities())
            {
                var upit = from s in context.statistika_igraca where s.igrac_id == OdabraniIgrac.id_korisnik select s;
                if (upit.Count() == 0)
                {
                    statistika_igraca statistika_Igraca = new statistika_igraca
                    {
                        igrac_id = OdabraniIgrac.id_korisnik,
                        pogodak=0,
                        asistencija=0
                       
                        

                    };
                    context.statistika_igraca.Add(statistika_Igraca);
                    context.SaveChanges();
                }
                var sql = from s in context.statistika_igraca where s.igrac_id == OdabraniIgrac.id_korisnik select s;
                StatIgraca = sql.Single();
                ukupnoPogodakaIgracTim1Txt.Text = StatIgraca.pogodak.ToString();
                ukupnoAsistencijaIgracTim1Txt.Text = StatIgraca.asistencija.ToString();
            }


        }

       

        private void zavrsiBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PovecajPogodakIgracaTim1Btn_Click(object sender, EventArgs e)
        {
            var OdabraniIgrac = dataGridView1.CurrentRow.DataBoundItem as korisnik;
            using (var context = new PI2231_DBEntities())
            {
                var sql = from s in context.statistika_igraca where s.igrac_id == OdabraniIgrac.id_korisnik select s;
                StatIgraca = sql.Single();
                StatIgraca.pogodak += 1;
                context.SaveChanges();
            }
            brojPogodakaTim1 += 1;
            brojPogodakaTim1Label.Text = brojPogodakaTim1.ToString();
        }

        private void smanjiPogodakIgracaTim1Btn_Click(object sender, EventArgs e)
        {
            var OdabraniIgrac = dataGridView1.CurrentRow.DataBoundItem as korisnik;
            using (var context = new PI2231_DBEntities())
            {
                var sql = from s in context.statistika_igraca where s.igrac_id == OdabraniIgrac.id_korisnik select s;
                StatIgraca = sql.Single();
                StatIgraca.pogodak -= 1;
                context.SaveChanges();
            }
            brojPogodakaTim1 -= 1;
            brojPogodakaTim1Label.Text = brojPogodakaTim1.ToString();
        }

        private void povecajAsistencijuTim1Btn_Click(object sender, EventArgs e)
        {
            var OdabraniIgrac = dataGridView1.CurrentRow.DataBoundItem as korisnik;
            using (var context = new PI2231_DBEntities())
            {
                var sql = from s in context.statistika_igraca where s.igrac_id == OdabraniIgrac.id_korisnik select s;
                StatIgraca = sql.Single();
                StatIgraca.asistencija += 1;
                context.SaveChanges();
            }
           
        }

        private void smanjiAsistencijuTim1Btn_Click(object sender, EventArgs e)
        {
            var OdabraniIgrac = dataGridView1.CurrentRow.DataBoundItem as korisnik;
            using (var context = new PI2231_DBEntities())
            {
                var sql = from s in context.statistika_igraca where s.igrac_id == OdabraniIgrac.id_korisnik select s;
                StatIgraca = sql.Single();
                StatIgraca.asistencija -= 1;
                context.SaveChanges();
            }
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var OdabraniIgrac = dataGridView2.CurrentRow.DataBoundItem as korisnik;

            igracTima2Label.Text = OdabraniIgrac.ime + " " + OdabraniIgrac.prezime;
            using (var context = new PI2231_DBEntities())
            {
                var upit = from s in context.statistika_igraca where s.igrac_id == OdabraniIgrac.id_korisnik select s;
                if (upit.Count() == 0)
                {
                    statistika_igraca statistika_Igraca = new statistika_igraca
                    {
                        igrac_id = OdabraniIgrac.id_korisnik,
                        pogodak = 0,
                        asistencija = 0



                    };
                    context.statistika_igraca.Add(statistika_Igraca);
                    context.SaveChanges();
                }
                var sql = from s in context.statistika_igraca where s.igrac_id == OdabraniIgrac.id_korisnik select s;
                StatIgraca = sql.Single();
                ukupnoPogodakaIgracTim2Txt.Text = StatIgraca.pogodak.ToString();
                ukupnoAsistencijaIgracTim2Txt.Text = StatIgraca.asistencija.ToString();
            }

        }

        private void povecajPogodakIgracaTim2Btn_Click(object sender, EventArgs e)
        {
            var OdabraniIgrac = dataGridView2.CurrentRow.DataBoundItem as korisnik;
            using (var context = new PI2231_DBEntities())
            {
                var sql = from s in context.statistika_igraca where s.igrac_id == OdabraniIgrac.id_korisnik select s;
                StatIgraca = sql.Single();
                StatIgraca.pogodak += 1;
                context.SaveChanges();
            }
            brojPogodakaTim2 += 1;
            brojPogodakaTim2Label.Text = brojPogodakaTim2.ToString();
        }

        private void smanjiPogodakIgracaTim2Btn_Click(object sender, EventArgs e)
        {
            var OdabraniIgrac = dataGridView2.CurrentRow.DataBoundItem as korisnik;
            using (var context = new PI2231_DBEntities())
            {
                var sql = from s in context.statistika_igraca where s.igrac_id == OdabraniIgrac.id_korisnik select s;
                StatIgraca = sql.Single();
                StatIgraca.pogodak -= 1;
                context.SaveChanges();
            }
            brojPogodakaTim2 -= 1;
            brojPogodakaTim2Label.Text = brojPogodakaTim2.ToString();
        }

        private void povecajAsistencijeIgracaTim2Btn_Click(object sender, EventArgs e)
        {
            var OdabraniIgrac = dataGridView2.CurrentRow.DataBoundItem as korisnik;
            using (var context = new PI2231_DBEntities())
            {
                var sql = from s in context.statistika_igraca where s.igrac_id == OdabraniIgrac.id_korisnik select s;
                StatIgraca = sql.Single();
                StatIgraca.asistencija += 1;
                context.SaveChanges();
            }
        }

        private void smanjiAsistencijeIgracaTim2Btn_Click(object sender, EventArgs e)
        {
            var OdabraniIgrac = dataGridView2.CurrentRow.DataBoundItem as korisnik;
            using (var context = new PI2231_DBEntities())
            {
                var sql = from s in context.statistika_igraca where s.igrac_id == OdabraniIgrac.id_korisnik select s;
                StatIgraca = sql.Single();
                StatIgraca.asistencija -= 1;
                context.SaveChanges();
            }
        }
    }
}
