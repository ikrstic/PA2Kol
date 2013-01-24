using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Videoteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kupciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kupciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.videotekaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'videotekaDataSet.kupci' table. You can move, or remove it, as needed.
            this.kupciTableAdapter.Fill(this.videotekaDataSet.kupci);

        }

        private void btnKaseta_Click(object sender, EventArgs e)
        {
            Form2 frmkasete = new Form2();
            frmkasete.ShowDialog();
            frmkasete.Dispose();
        }

        private void fillByKupacIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.izdavanjaTableAdapter1.FillByKupacID(this.videotekaDataSet.izdavanja, ((int)(System.Convert.ChangeType(kupacIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnIznajmljivanje_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)kupciBindingSource.Current;
            int kupacid = (int)drv["kupacID"];
            string imePrezime = (string)drv["ImePrezime"];
            Form3 frmIznajmljivanje = new Form3();
            frmIznajmljivanje.KupacID = kupacid;
            frmIznajmljivanje.ImePrezime = imePrezime;
            frmIznajmljivanje.ShowDialog();
            frmIznajmljivanje.Dispose();
        }

    }
}
