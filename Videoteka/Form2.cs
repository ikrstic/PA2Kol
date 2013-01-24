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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void kaseteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kaseteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.videotekaDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'videotekaDataSet.kasete' table. You can move, or remove it, as needed.
            this.kaseteTableAdapter.Fill(this.videotekaDataSet.kasete);

        }
    }
}
