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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void izdavanjaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.izdavanjaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.videotekaDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'videotekaDataSet.kasete' table. You can move, or remove it, as needed.
            this.kaseteTableAdapter.Fill(this.videotekaDataSet.kasete);
            // TODO: This line of code loads data into the 'videotekaDataSet.izdavanja' table. You can move, or remove it, as needed.
            this.izdavanjaTableAdapter.FillByKupacID(this.videotekaDataSet.izdavanja,KupacID);
            label1.Text = ImePrezime;
            this.videotekaDataSet.izdavanja.kupacIDColumn.DefaultValue = KupacID;
            this.videotekaDataSet.izdavanja.PlacenoColumn.DefaultValue = false;
            this.videotekaDataSet.izdavanja.DatumUzimanjaColumn.DefaultValue = DateTime.Now.Date;

        }

        public int KupacID { get; set; }
        public string ImePrezime { get; set; }
    }
}
