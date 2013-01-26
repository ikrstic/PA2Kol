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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            customersTableAdapter1.Fill(tsqL2012DataSet1.Customers);
            dataGridView1.DataSource = tsqL2012DataSet1.Customers;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                tsqL2012DataSet1.WriteXml(@"C:\temp\Korisnici.xml");
                MessageBox.Show("Podaci sačuvani u fajl Korisnici.xml", "Obaveštenje");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSema_Click(object sender, EventArgs e)
        {
            try
            {
                tsqL2012DataSet1.WriteXmlSchema(@"C:\temp\Korisnici.xsd");
                MessageBox.Show("Šema sačuvana u fajl Korisnici.xsd");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
