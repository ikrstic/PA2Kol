using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSet_i_XML2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private DataSet ds = new DataSet();

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet2.Kategorije' table. You can move, or remove it, as needed.
            this.kategorijeTableAdapter.Fill(this.testDataSet2.Kategorije);
            if (File.Exists(@"Kategorije.xml"))
            {
                ds.ReadXmlSchema("Kategorije.xsd");
                ds.ReadXml(@"Kategorije.xml");
            }
            else
            {
                ds.ReadXmlSchema("Kategorije.xsd");
            }
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow vrsta = ds.Tables[0].NewRow();
            vrsta[0] = textID.Text;
            vrsta[1] = textIme.Text;
            vrsta[2] = textOpis.Text;
            ds.Tables[0].Rows.Add(vrsta);
            ds.WriteXml(@"Kategorije.xml");
            MessageBox.Show("Vrsta dodata", "Obavestenje");
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selRed = dataGridView1.SelectedRows[0];
                textID.Text = selRed.Cells[0].Value.ToString();
                textIme.Text = selRed.Cells[1].Value.ToString();
                textOpis.Text = selRed.Cells[2].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selRed = dataGridView1.SelectedRows[0];
                selRed.Cells[0].Value = textID.Text;
                selRed.Cells[1].Value = textIme.Text;
                selRed.Cells[2].Value = textOpis.Text;
                ds.WriteXml(@"Kategorije.xml");
                MessageBox.Show("Vrsta promenjena", "Obavestenje");
            }
        }

        private void resetuj()
        {
            textID.Text = "";
            textIme.Text = "";
            textOpis.Text = "";
            dataGridView1.ClearSelection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                ds.WriteXml(@"Kategorije.xml");
                MessageBox.Show("Red je obrisan", "Poruka");
                dataGridView1.DataSource = ds.Tables[0];
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[0].Selected = true;
                }
                else
                {
                    resetuj();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resetuj();
        }
    }
}
