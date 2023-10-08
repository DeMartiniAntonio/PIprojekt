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
    public partial class PregledIgracaForm : Form
    {   korisnik igrac =new korisnik();
        public PregledIgracaForm( korisnik prosljedeniIgrac)
        {
            InitializeComponent();
            igrac = prosljedeniIgrac as korisnik;
        }

        private void PregledIgracaForm_Load(object sender, EventArgs e)
        {
            imeTxt.Text = igrac.ime;
            prezimeTxt.Text = igrac.prezime;
            korimeTxt.Text = igrac.korisnicko_ime;
        }

        private void nazadBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
