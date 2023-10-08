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
    public partial class PregledTimaForma : Form
    {
        PI2231_DBEntities entities = new PI2231_DBEntities();
        public tim Tim = new tim();
        public PregledTimaForma(tim prosljedeniTim)
        {
            InitializeComponent();
            Tim = prosljedeniTim;
        }

        private void PregledTimaForma_Load(object sender, EventArgs e)
        {
            List<string> clanovi = new List<string>();
            nazivTxt.Text = Tim.naziv;
            foreach (var item in Tim.korisniks)
            {
                clanovi.Add(item.korisnicko_ime);
            }
            
            clanoviTimaDgv.DataSource = clanovi.Select(x=> new {Value=x }).ToList();
            

            
            
        }

        private void pocetnaBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
