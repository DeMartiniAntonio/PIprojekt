using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organiziranje_sportskog_događaja
{
    public static class GeneriranjePristupnogKoda
    {
        public static string GenerirajPristupniKod()
        {
            string mogucnosti = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPRSTUVWXYZ";
            string kod = "";
            Random rand = new Random();
            int duzina = rand.Next(6, 10);
            for (int i = 0; i < duzina; i++)
            {
                kod += mogucnosti[rand.Next(0, mogucnosti.Length)];
            }
            return kod;
        }
    }
}
