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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Dozvoli(bool dozvola)
        {
            groupBoxClan.Enabled = dozvola;
            buttonPotvrdi.Visible = dozvola;
            buttonOdustani.Visible = dozvola;
            buttonDodaj.Visible = !dozvola;
            buttonIzmeni.Visible = !dozvola;
            buttonBrisi.Visible = !dozvola;
        }
        private List<Clan> listaClanova = new List<Clan>();
        private ClanProvider cp = new ClanProvider();
        private void napuniListuClanova()
        {
            listaClanova = cp.IscitajListuClanova();
            listBox1.DataSource = listaClanova;
            listBox1.DisplayMember = "PunoIme";
            listBox1.ValueMember = "ClanID";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            napuniListuClanova();
            if (listBox1.Items.Count > 0)
                listBox1.SelectedIndex = 0;
            else
                listBox1.SelectedIndex = -1;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                int poz = listBox1.SelectedIndex;
                textBoxIme.Text = listaClanova[poz].Ime;
                textBoxPrezime.Text = listaClanova[poz].Prezime;
                textBoxJmbg.Text = listaClanova[poz].Jmbg;
                textBoxAdresa.Text = listaClanova[poz].Adresa;
                textBoxTelefon.Text = listaClanova[poz].Telefon;
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            frmDodajClana frm = new frmDodajClana();
            Dozvoli(false);
            frm.ShowDialog();
            frm.Dispose();
            napuniListuClanova();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            Dozvoli(true);
        }

        private void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            Clan cl = new Clan();
            cl.ClanID = Convert.ToInt32(listBox1.SelectedValue);
            cl.Ime = textBoxIme.Text;
            cl.Prezime = textBoxPrezime.Text;
            cl.Jmbg = textBoxJmbg.Text;
            cl.Adresa = textBoxAdresa.Text;
            cl.Telefon = textBoxTelefon.Text;
            int rez = cp.IzmeniClana(cl);
            if (rez == 0)
            {
                napuniListuClanova();
                listBox1.SelectedValue = cl.ClanID;
                MessageBox.Show("Uspesno ste izmenili clana", "Clan promenjen");
                Dozvoli(false);
            }
            else
            {
                MessageBox.Show("Greska pri izmeni clana", "Clan nije promenjen");
                return;
            }
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            Dozvoli(false);
        }

        private void buttonBrisi_Click(object sender, EventArgs e)
        {
            int poz = listBox1.SelectedIndex;
            if (MessageBox.Show("Da li ste siguran da zelite brisanje?", "Upozorenje",
            MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int rez = cp.IzbrisiClana(listaClanova[poz]);
                if (rez == 0)
                {
                    napuniListuClanova();
                    if (listBox1.Items.Count > 0)
                    {
                        listBox1.SelectedIndex = 0;
                    }
                    else
                    {
                        listBox1.SelectedIndex = -1;
                        textBoxIme.Clear();
                        textBoxPrezime.Clear();
                        textBoxJmbg.Clear();
                        textBoxAdresa.Clear();
                        textBoxTelefon.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Ne mozete obrisati clana");
                }
            }
        }
    }
}
