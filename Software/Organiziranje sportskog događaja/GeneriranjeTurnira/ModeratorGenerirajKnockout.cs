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
    public partial class ModeratorGenerirajKnockout : Form
    {
        
        PI2231_DBEntities entities = new PI2231_DBEntities();
        turnir Turnir = new turnir();
        List<tim> timovi = new List<tim>();
        int idutakmice = 0;
        int zaProlazDalje = 0;
        string pobjednik = "";
        string pobjednik2 = "";
        string krajTrunira = "ne";


        public ModeratorGenerirajKnockout(turnir prosljedeniTurnir)
        {
            InitializeComponent();
            Turnir = prosljedeniTurnir;
            
            slijedecaTekmaBTN.Enabled = true;
            goloviT1TXB.Text = 0.ToString();
            goloviT2TXB.Text = 0.ToString();
            krajBTN.Enabled=false;
        }



        private void ModeratorGenerirajKnockout_Load(object sender, EventArgs e)
        {
            DodajTimove();
            GenerirajParove();
            IspisiUtakmice();
            

        }



        private void IspisiUtakmice()
        {
            using (var db = new PI2231_DBEntities())
            {
                var qu = from p in db.raspored_utakmica

                         select new
                         {
                            p.id_utakmica,
                            p.tim_jedan,
                            p.broj_golova_prvog_tima,
                            p.broj_golova_drugog_tima,
                            p.tim_dva,
                            p.faza
                         };
                
                popisUtakmicaDTG.DataSource = qu.ToList();
                popisUtakmicaDTG.Columns[0].Visible = false;
                idutakmice = qu.ToList().First().id_utakmica;
                
            }



        }

       

        private void GenerirajParove()
        {
            Random random = new Random();
            List<tim> lista = new List<tim>();

            while (timovi.Count > 0)
            {
                int index = random.Next(0, timovi.Count); 
                lista.Add(timovi[index]); 
                timovi.RemoveAt(index);
            }


            using (var context = new PI2231_DBEntities())
            {
                for (int i = 0; i < lista.Count; i+=2)
                {
                    raspored_utakmica novaUtakmica = new raspored_utakmica() 
                    { 
                        id_turnir=Turnir.id_turnir,
                        tim_jedan = lista[i].naziv,
                        tim_dva= lista[i+1].naziv,
                        broj_golova_prvog_tima=0,
                        broj_golova_drugog_tima=0,
                        faza="trenutna faza"
                    };
                    entities.raspored_utakmica.Add(novaUtakmica);
                    entities.SaveChanges();
                }

            };

        }
        private void DodajTimove()
        {
            foreach (var tim in Turnir.tims)
            {
                timovi.Add(tim);
            }


            using (var db = new PI2231_DBEntities())
            {
                foreach (var item in db.raspored_utakmica)
                {
                    db.raspored_utakmica.Attach(item);
                    db.raspored_utakmica.Remove(item);
                }
                db.SaveChanges();

            }


        }

        private void slijedecaTekmaBTN_Click(object sender, EventArgs e)
        {
            List<raspored_utakmica> slijedecaUtakmica = new List<raspored_utakmica>();

            if (krajTrunira == "da")
            {
                ZavrsiTurnir();
            }


            using (var db = new PI2231_DBEntities())
            {
                var qu = from p in db.raspored_utakmica
                         where idutakmice == p.id_utakmica
                         select p;

                tim1DTG.DataSource = qu.ToList();
                tim2DTG.DataSource = qu.ToList();
                tim1DTG.Columns[0].Visible = false;
                tim1DTG.Columns[2].Visible = false;
                tim1DTG.Columns[3].Visible = false;
                tim1DTG.Columns[4].Visible = false;
                tim1DTG.Columns[5].Visible = false;
                tim1DTG.Columns[6].Visible = false;
                tim1DTG.Columns[7].Visible = false;
               // tim1DTG.Columns[8].Visible = false;
                tim2DTG.Columns[0].Visible = false;
                tim2DTG.Columns[1].Visible = false;
                tim2DTG.Columns[3].Visible = false;
                tim2DTG.Columns[4].Visible = false;
                tim2DTG.Columns[5].Visible = false;
                tim2DTG.Columns[6].Visible = false;
                tim2DTG.Columns[7].Visible = false;
                //tim2DTG.Columns[8].Visible = false;

            }


            int goloviPrvogTima = int.Parse(goloviT1TXB.Text);
            int goloviDrugogTima = int.Parse(goloviT2TXB.Text);


            zaProlazDalje += 1;


            using (var db = new PI2231_DBEntities())
                {
                    foreach (var item in entities.raspored_utakmica)
                    {
                        if (idutakmice == item.id_utakmica+1)
                        {
                            item.broj_golova_prvog_tima = goloviPrvogTima;
                            item.broj_golova_drugog_tima = goloviDrugogTima;
                            item.faza = "Odigrana";

                            if (goloviPrvogTima > goloviDrugogTima)
                            {
                                pobjednik = item.tim_jedan;
                            }
                            else if (goloviPrvogTima < goloviDrugogTima)
                            {
                                pobjednik = item.tim_dva;
                            }

                            break;
                        }
                    }
                    entities.SaveChanges();

            }

            if (zaProlazDalje==2)
            {
                pobjednik2 = pobjednik;

            }
            else if (zaProlazDalje == 3)
            {

                using (var context = new PI2231_DBEntities())
                {

                    raspored_utakmica novaUtakmica = new raspored_utakmica()
                    {
                        id_turnir = 10,
                        tim_jedan = pobjednik2,
                        tim_dva = pobjednik,
                        broj_golova_prvog_tima = 0,
                        broj_golova_drugog_tima = 0,
                        faza = "slijedeca faza"
                    };
                    entities.raspored_utakmica.Add(novaUtakmica);
                    entities.SaveChanges();


                };
                zaProlazDalje = 1;
            }

            pokreniUtakmicuBtn.Enabled=true;
            Osvjezi();

            idutakmice += 1;
        }

        private void ZavrsiTurnir()
        {
            int goloviPrvogTima = int.Parse(goloviT1TXB.Text);
            int goloviDrugogTima = int.Parse(goloviT2TXB.Text);

            using (var db = new PI2231_DBEntities())
            {
                foreach (var item in entities.raspored_utakmica)
                {
                    if (idutakmice == item.id_utakmica + 1)
                    {
                        item.broj_golova_prvog_tima = goloviPrvogTima;
                        item.broj_golova_drugog_tima = goloviDrugogTima;
                        
                        break;
                    }
                }
                entities.SaveChanges();

            }

            using (var db = new PI2231_DBEntities())
            {
                var qu = from p in db.raspored_utakmica
                         where idutakmice == p.id_utakmica+1
                         select new
                         {
                             p.id_utakmica,
                             p.tim_jedan,
                             p.broj_golova_prvog_tima,
                             p.broj_golova_drugog_tima,
                             p.tim_dva,
                             p.faza
                         };

                finaleDTG.DataSource = qu.ToList();
                finaleDTG.Columns[0].Visible = false;

            }
            slijedecaTekmaBTN.Enabled = false;
            krajBTN.Enabled = true;


        }

        private void Osvjezi()
        {
            string slijedecaFaza = "da";
            using (var db = new PI2231_DBEntities())
            {
                foreach (var item in entities.raspored_utakmica)
                {
                    if (item.faza == "trenutna faza")
                    {
                        slijedecaFaza = "ne";
                    }

                }
            }

            if (slijedecaFaza == "da")
            {
                int brojac = 0;
                using (var db = new PI2231_DBEntities())
                {
                    foreach (var item in entities.raspored_utakmica)
                    {
                        if (item.faza == "slijedeca faza")
                        {
                            item.faza = "trenutna faza";
                            brojac += 1;
                        }

                    }

                    entities.SaveChanges();
                    if (brojac==1)
                    {
                        ZavrsnicaNatjecanja();
                    }
                }

            }



        
            using (var db = new PI2231_DBEntities())
            {
                var qu = from p in db.raspored_utakmica
                         select new
                         {
                             p.id_utakmica,
                             p.tim_jedan,
                             p.broj_golova_prvog_tima,
                             p.broj_golova_drugog_tima,
                             p.tim_dva,
                             p.faza
                         };

                popisUtakmicaDTG.DataSource = qu.ToList();
                popisUtakmicaDTG.Columns[0].Visible = false;
                
                
            }
            goloviT1TXB.Text = 0.ToString();
            goloviT2TXB.Text = 0.ToString();

        }

        private void ZavrsnicaNatjecanja()
        {
            int goloviPrvogTima = int.Parse(goloviT1TXB.Text);
            int goloviDrugogTima = int.Parse(goloviT2TXB.Text);

      

           using (var db = new PI2231_DBEntities())
                {
                    var qu = from p in db.raspored_utakmica
                             where idutakmice == p.id_utakmica
                             select new
                             {
                                 p.id_utakmica,
                                 p.tim_jedan,
                                 p.broj_golova_prvog_tima,
                                 p.broj_golova_drugog_tima,
                                 p.tim_dva,
                                 p.faza
                             };

                    finaleDTG.DataSource = qu.ToList();
                    finaleDTG.Columns[0].Visible = false;


            }
            goloviT1TXB.Text = 0.ToString();
            goloviT2TXB.Text = 0.ToString();
            Finale();
            
                
        }

        private void Finale()
        {

            using (var db = new PI2231_DBEntities())
            {
                var qu = from p in db.raspored_utakmica
                         where idutakmice == p.id_utakmica
                         select p;

                tim1DTG.DataSource = qu.ToList();
                tim2DTG.DataSource = qu.ToList();
                tim1DTG.Columns[0].Visible = false;
                tim1DTG.Columns[2].Visible = false;
                tim1DTG.Columns[3].Visible = false;
                tim1DTG.Columns[4].Visible = false;
                tim1DTG.Columns[5].Visible = false;
                tim1DTG.Columns[6].Visible = false;
                tim1DTG.Columns[7].Visible = false;
                //tim1DTG.Columns[8].Visible = false;
                tim2DTG.Columns[0].Visible = false;
                tim2DTG.Columns[1].Visible = false;
                tim2DTG.Columns[3].Visible = false;
                tim2DTG.Columns[4].Visible = false;
                tim2DTG.Columns[5].Visible = false;
                tim2DTG.Columns[6].Visible = false;
                tim2DTG.Columns[7].Visible = false;
                //tim2DTG.Columns[8].Visible = false;

                int goloviPrvogTima = int.Parse(goloviT1TXB.Text);
                int goloviDrugogTima = int.Parse(goloviT2TXB.Text);

                using (var db2 = new PI2231_DBEntities())
                {
                    foreach (var item in entities.raspored_utakmica)
                    {
                        if (idutakmice == item.id_utakmica + 1)
                        {
                            item.broj_golova_prvog_tima = goloviPrvogTima;
                            item.broj_golova_drugog_tima = goloviDrugogTima;
                            item.faza = "Odigrana";

                            if (goloviPrvogTima > goloviDrugogTima)
                            {
                                pobjednik = item.tim_jedan;
                            }
                            else if (goloviPrvogTima < goloviDrugogTima)
                            {
                                pobjednik = item.tim_dva;
                            }

                            break;
                        }
                    }
                    entities.SaveChanges();

                }
            }


            using (var db = new PI2231_DBEntities())
            {
                var qu = from p in db.raspored_utakmica
                          select new
                          {
                              p.id_utakmica,
                              p.tim_jedan,
                              p.broj_golova_prvog_tima,
                              p.broj_golova_drugog_tima,
                              p.tim_dva,
                              p.faza
                          };

                popisUtakmicaDTG.DataSource = qu.ToList();
                popisUtakmicaDTG.Columns[0].Visible = false;
            }

            using (var db = new PI2231_DBEntities())
            {
                var qu = from p in db.raspored_utakmica
                         where idutakmice == p.id_utakmica
                         select new
                         {
                             p.id_utakmica,
                             p.tim_jedan,
                             p.broj_golova_prvog_tima,
                             p.broj_golova_drugog_tima,
                             p.tim_dva,
                             p.faza
                         };

                finaleDTG.DataSource = qu.ToList();
                finaleDTG.Columns[0].Visible = false;


            }

            krajTrunira = "da";
        }

        private void krajBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            

            using (var db = new PI2231_DBEntities())
            {
                foreach (var item in db.raspored_utakmica)
                {
                    db.raspored_utakmica.Attach(item);
                    db.raspored_utakmica.Remove(item);
                }
                db.SaveChanges();

            }


            this.Hide();

            IzvjestajTurnir izvjestaj = new IzvjestajTurnir();
            izvjestaj.Show();
        }

        private void pokreniUtakmicuBtn_Click(object sender, EventArgs e)
        {
            if (Turnir.sport.naziv == "Košarka")
            {
                Hide();
                UnosRezultataKošarka unosRezultataKošarka = new UnosRezultataKošarka(idutakmice-1);
                unosRezultataKošarka.ShowDialog();
                Show();
                goloviT1TXB.Text = unosRezultataKošarka.brojPogodakaTim1.ToString();
                goloviT2TXB.Text = unosRezultataKošarka.brojPogodakaTim2.ToString();
                pokreniUtakmicuBtn.Enabled = false;
                goloviT1TXB.Enabled = false;
                goloviT2TXB.Enabled = false;
            }
            else
            {
                Hide();
                
                UnosRezultataNogometRukomet unosRezultataNogometRukomet = new UnosRezultataNogometRukomet(idutakmice-1);
                unosRezultataNogometRukomet.ShowDialog();
                Show();
                goloviT1TXB.Text = unosRezultataNogometRukomet.brojPogodakaTim1.ToString();
                goloviT2TXB.Text = unosRezultataNogometRukomet.brojPogodakaTim2.ToString();
                pokreniUtakmicuBtn.Enabled = false;
                goloviT1TXB.Enabled = false;
                goloviT2TXB.Enabled = false;
            }
        }

        
    }
    
}
