using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSet_i_XML2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet11.Kategorije' table. You can move, or remove it, as needed.
            this.kategorijeTableAdapter.Fill(this.testDataSet11.Kategorije);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            testDataSet1.WriteXmlSchema("Kategorije.xsd");
            MessageBox.Show("Šema upisana");
        }
    }
}
