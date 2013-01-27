using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoKlubWin
{
    public class Clan
    {
        public int ClanID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Jmbg { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string PunoIme
        {
            get
            {
                return Ime + " " + Prezime;
            }
        }
    }
}
