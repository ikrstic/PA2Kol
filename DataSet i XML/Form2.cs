using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSet_i_XML
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private DataSet ds = new DataSet();

        private void button1_Click(object sender, EventArgs e)
        {
            ds.ReadXmlSchema(@"C:/temp/Korisnici.xsd");
            dataGridView1.DataSource = ds.Tables["Customers"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ds.ReadXml(@"C:\temp\Korisnici.xml");
        }
    }
}
