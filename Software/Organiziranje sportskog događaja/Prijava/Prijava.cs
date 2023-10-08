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
    public partial class Prijava : Form
    {
        PI2231_DBEntities entities = new PI2231_DBEntities();
        

        public Prijava()
        {
            InitializeComponent();
        }

        private void prijaviSeBTN_Click(object sender, EventArgs e)
        {
            if (korisnickoImeTXB.Text.Length == 0 || lozinkaTBX.Text.Length == 0)
            {
                MessageBox.Show("Nedostaje korisničko ime ili lozinka");
                return;
            }

            korisnik resK = ProvjeraKorisnika(korisnickoImeTXB.Text, lozinkaTBX.Text);
            organizacija resO= ProvjeraOrganizaciju(korisnickoImeTXB.Text, lozinkaTBX.Text);

            if(resK == null && resO== null)
            {
                MessageBox.Show("Korisnik ne postoji");
                return;
            }
            else
            {
                
                prijava(resK,resO);
            }
            
           
        }

        private void prijava(korisnik resK, organizacija resO)
        {
            if (resK != null)
            {
                PrijavljeniKorisnik.pk=resK;


                if (resK.id_uloga == 3)
                {

                    
                    PočetnaAdministrator pAdmin = new PočetnaAdministrator();
                    this.Hide();
                    pAdmin.ShowDialog();
                    
                }
                else if (resK.id_uloga == 2)
                {

                    PočetnaModerator pModerator=new PočetnaModerator();

                    this.Hide();
                    pModerator.ShowDialog();
                    
                }
                else if(resK.id_uloga == 1)
                {
                   
                    PočetnaRegistrirani pKorisnik=new PočetnaRegistrirani();
                    this.Hide();
                    pKorisnik.ShowDialog();
                    
                }
            }
            else
            {
                PrijavljeniKorisnik.pk = resK;
                this.Hide();
                PočetnaOrganizacija pOrganizacija =new PočetnaOrganizacija();
                
                pOrganizacija.ShowDialog();
                
            }
        }

        private organizacija ProvjeraOrganizaciju(string korisnickoIme, string lozinka)
        {
            organizacija o;
            using (var context = new PI2231_DBEntities())
            {
                var query = from u in context.organizacijas
                            where u.korisnicko_ime == korisnickoIme && u.lozinka == lozinka
                            select u;

                o = query.SingleOrDefault();



            };
            if (o == null)
            {
                return null;

            }
            else
            {
                return o;
            }

        }

        private korisnik ProvjeraKorisnika(string korisnickoIme, string lozinka)
        {
            korisnik k;
            
            using (var context = new PI2231_DBEntities())
            {
                var query = from u in context.korisniks
                            where u.korisnicko_ime == korisnickoIme && u.lozinka == lozinka
                            select u;

                k = query.SingleOrDefault();



            };
            if (k == null)
            {
                return null;

            }
            else
            {
                return k;
            }
            


        }

        private void natragBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            PočetnaNeregistrirani pocetna = new PočetnaNeregistrirani();
            pocetna.Show();
        }
    }
}
