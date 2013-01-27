using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoKlubWin
{
    public partial class frmDodajClana : Form
    {
        private ClanProvider cp = new ClanProvider();

        public frmDodajClana()
        {
            InitializeComponent();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            Clan cl = new Clan();
            int rez = -1;
            try
            {
                cl.Ime = textBoxIme.Text;
                cl.Prezime = textBoxPrezime.Text;
                cl.Jmbg = textBoxJmbg.Text;
                cl.Adresa = textBoxAdresa.Text;
                cl.Telefon = textBoxTelefon.Text;
                rez = cp.UbaciClana(cl);
            }
            catch
            {
                MessageBox.Show("Greska pri unosu podataka", "Greska");
                return;
            }
            if (rez == 0)
            {
                MessageBox.Show("Uspesno ste ubacili clana", "Poruka");
            }
            this.Close();
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
