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
    public partial class OdabirFormataTurnira : Form
    {
        turnir turnir = new turnir();
        public OdabirFormataTurnira(turnir prosljedeniTurnir)
        {
            InitializeComponent();
            turnir = prosljedeniTurnir;
        }

        private void OdabirFormataTurnira_Load(object sender, EventArgs e)
        {
            prolaziTXB.Enabled = false;
            brGrupaTXB.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (knockoutCB.Checked == true)
            {
                this.Hide();
                ModeratorGenerirajKnockout generiraj = new ModeratorGenerirajKnockout(turnir);
                generiraj.Show();

            }
            else if (grupnafazaCB.Checked == true)
            {
                if (brGrupaTXB.Text.Length==0 || prolaziTXB.Text.Length == 0)
                {
                    MessageBox.Show("Unesite sve potrebne podatke");
                }
                else if(brGrupaTXB.Text.Length != 0 || prolaziTXB.Text.Length != 0)
                {
                    this.Hide();
                    ModeratorTurnirGrupnaFaza generiraj = new ModeratorTurnirGrupnaFaza(int.Parse(prolaziTXB.Text), int.Parse(brGrupaTXB.Text));
                    generiraj.Show();
                }
                

            }
        }

        private void knockoutCB_CheckedChanged(object sender, EventArgs e)
        {
            if (knockoutCB.Checked == true)
            {
                brGrupaTXB.Enabled = false;
                prolaziTXB.Enabled = false;
                grupnafazaCB.Enabled = false;

            }
            else if(knockoutCB.Checked == false)
            {
                brGrupaTXB.Enabled = false;
                prolaziTXB.Enabled = false;
                grupnafazaCB.Enabled = true;

            }
        }

        private void grupnafazaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (grupnafazaCB.Checked == true)
            {
                brGrupaTXB.Enabled = true;
                prolaziTXB.Enabled = true;
                knockoutCB.Enabled = false;

            }
            else if (grupnafazaCB.Checked == false)
            {
                brGrupaTXB.Enabled = false;
                prolaziTXB.Enabled = false;
                knockoutCB.Enabled = true;
            }
        }
    }
}
