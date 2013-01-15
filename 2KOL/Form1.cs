using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2KOL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'imenikDataSet.Osoba' table. You can move, or remove it, as needed.
            this.osobaTableAdapter.Fill(this.imenikDataSet.Osoba);
            dozvoliIzmenu(false);

        }

        private void dozvoliIzmenu(bool dozvoli)
        {
            groupBox1.Enabled = dozvoli;

            buttonDodaj.Enabled = !dozvoli;
            buttonIzmeni.Enabled = !dozvoli;
            buttonObrisi.Enabled = !dozvoli;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            dozvoliIzmenu(true);
            osobaBindingSource.AddNew();
        }

        private void buttonSacuvaj_Click(object sender, EventArgs e)
        {
            dozvoliIzmenu(false);
            osobaBindingSource.EndEdit();
            osobaTableAdapter.Update(imenikDataSet.Osoba);
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            dozvoliIzmenu(false);
            osobaBindingSource.CancelEdit();
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            dozvoliIzmenu(true);
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite da obrišete red?", "Poruka", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                osobaBindingSource.RemoveCurrent();
                osobaTableAdapter.Update(imenikDataSet.Osoba);
            }
        }
    }
}
