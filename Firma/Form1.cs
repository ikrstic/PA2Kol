using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radnikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.radnikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.firmaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'firmaDataSet.Radnik' table. You can move, or remove it, as needed.
            this.radnikTableAdapter.Fill(this.firmaDataSet.Radnik);
            PrikaziRadnike();

        }
         //prikazuje radnike uListView kontroli
        private void PrikaziRadnike()
        {
           listViewRadnici.Items.Clear();

           //prikazuje podatke o radnicima u ListView-u pomocu tipiziranog DataSet-a
           foreach (FirmaDataSet.RadnikRow vrsta in firmaDataSet1.Radnik.Rows)
           {
               ListViewItem lvi = new ListViewItem(vrsta.Ime);
               lvi.SubItems.Add(vrsta.Prezime);
               lvi.SubItems.Add(vrsta.datumZaposlenja.ToString());
               //U Tag smeštamo Id Radnika
               lvi.Tag = vrsta.Id;
               listViewRadnici.Items.Add(lvi);
            }
        }

        private void listViewRadnici_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewRadnici.SelectedItems.Count > 0)
            {
                FirmaDataSet.RadnikRow red = firmaDataSet1.Radnik.FindById((int)listViewRadnici.SelectedItems[0].Tag);
                imeTextBox.Text = red.Ime;
                prezimeTextBox.Text = red.Prezime;
                dtDatumZaposlenja.Value = red.datumZaposlenja;
            }
        }

        private void Resetuj()
        {
            imeTextBox.Clear();
            prezimeTextBox.Clear();
            dtDatumZaposlenja.Value = DateTime.Now;
        }

        private void btnResetu_Click(object sender, EventArgs e)
        {
            Resetuj();
        }

        private void btnUbaci_Click(object sender, EventArgs e)
        {
            //Provera da li je korisnik uneo Ime i/ili Prezime
            if (String.IsNullOrEmpty(imeTextBox.Text.Trim()) || (String.IsNullOrEmpty(prezimeTextBox.Text.Trim())))
            {
                MessageBox.Show("Unesite ime i/ili prezime", "Obaveštenje", MessageBoxButtons.OK);
                return;
            }
        FirmaDataSet.RadnikRow novaVrsta = firmaDataSet1.Radnik.NewRadnikRow();
            novaVrsta.Ime = imeTextBox.Text;
            novaVrsta.Prezime = prezimeTextBox.Text;
            novaVrsta.datumZaposlenja = dtDatumZaposlenja.Value;

        //Dodavanje nove vrste u tabelu radnik u datasetu
            firmaDataSet1.Radnik.AddRadnikRow(novaVrsta);

            try
            {
                //Snimanje izmene u bazu
                radnikTableAdapter1.Update(firmaDataSet1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška prilikom snimanja");
            }

            PrikaziRadnike();
        }

        private void btnPromeni_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(imeTextBox.Text.Trim()) || (String.IsNullOrEmpty(prezimeTextBox.Text.Trim())))
            {
                MessageBox.Show("Unesite ime i/ili prezime", "Obaveštenje", MessageBoxButtons.OK);
                return;
            }
        //Provera da li je korisnik selektovao neku stavku u ListView kontroli
            if (listViewRadnici.SelectedItems.Count > 0)
            {
                int idRadnika = (int)listViewRadnici.SelectedItems[0].Tag;
                FirmaDataSet.RadnikRow vrstaZaPromenu = firmaDataSet1.Radnik.FindById(idRadnika);
                vrstaZaPromenu.Ime = imeTextBox.Text;
                vrstaZaPromenu.Prezime = prezimeTextBox.Text;
                vrstaZaPromenu.datumZaposlenja = dtDatumZaposlenja.Value;

                try
                {
                    radnikTableAdapter1.Update(firmaDataSet1);    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Greška prilikom izmene podataka");
                }

            PrikaziRadnike();
            }
        else
            {
                MessageBox.Show("Odaberite radnika", "Obaveštenje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            //Provera da li je korisnik selektovao neku stavku ListView kontrole
            if (listViewRadnici.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Brisanje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int idRadnika = (int)listViewRadnici.SelectedItems[0].Tag;
                    FirmaDataSet.RadnikRow vrstaZaBrisanje = firmaDataSet1.Radnik.FindById(idRadnika);
                    try
                    {
                        vrstaZaBrisanje.Delete();
                        radnikTableAdapter1.Update(firmaDataSet1);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Greška tokom brisanja");
                    }
                    PrikaziRadnike();
                    Resetuj();
                }
            }
            else
            {
                MessageBox.Show("Odaberite radnika", "Obaveštenje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
    }
}
