using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vezba___Diskonektovan
{
    public partial class frmPredmetDiskonektovani : Form
    {
        public frmPredmetDiskonektovani()
        {
            InitializeComponent();
        }

        class Konekcija
        {
            public static string konString = "Data Source = EMEDIAPC; Initial Catalog = Studenti; Integrated Security = True";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentiDataSet.Predmet' table. You can move, or remove it, as needed.
            this.predmetTableAdapter.Fill(this.studentiDataSet.Predmet);

        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Da li želite da sačuvate promene?", "Poruka", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    //ubacivanje promena u bazu
                    this.predmetTableAdapter.Update(studentiDataSet.Predmet);

                    //osvezavanje datagridviewa
                    dataGridView1.Refresh();

                    MessageBox.Show("Izmene su sačuvane");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ne mozete promeniti sifru predmeta koji su studenti vec polozili\n\n" + ex.Message);
                }
            }

        }

        private void zatvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void noviPredmetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            if (tbPredmetID.Text != "" && tbNaziv.Text != "" && tbProfesor.Text != "")
            {
                try
                {
                    //ubacivanje predmeta u bazu
                    predmetTableAdapter.Insert(Convert.ToInt32(tbPredmetID.Text), tbNaziv.Text, tbProfesor.Text);
                    MessageBox.Show("Unos novog predmeta je uspešno obavljen.");

                    // ubacivanej promena u datagridview
                    this.predmetTableAdapter.Fill(studentiDataSet.Predmet);

                    //brisanje sadrzaja iz textbox'a
                    tbPredmetID.Clear();
                    tbNaziv.Clear();
                    tbProfesor.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Polja ne mogu biti prazna.");
            }
        }

        SqlConnection kon = new SqlConnection(Konekcija.konString);

        private void pronadjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select distinct Profesor from Predmet", kon);

                //kreiranje DataTable
                DataTable dt = new DataTable();

                //Punjenje dataTable sa adapterom
                da.Fill(dt);

                //Povezivanje ComboBox kontrole sa tabelom
                cbProfesor.DataSource = dt;

                //definisanje kolone koja ce biti prikazana u Combobox-u
                cbProfesor.DisplayMember = "Profesor";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void brišiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Brisanje selektovanog reda
            //prvo se proverava da li postoji selektovani red
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //pamti se index selektovanog reda
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                //Za selektovani red se čitaju atributi :PredmetID, Naziv i Profesor
                int predmetID = int.Parse(dataGridView1[0, selectedIndex].Value.ToString());
                string naziv = dataGridView1[1, selectedIndex].Value.ToString();
                string profesor = dataGridView1[2, selectedIndex].Value.ToString();

                try
                {
                    //brisanje selektovanog reda iz baze
                    predmetTableAdapter.Delete(predmetID, naziv, profesor);

                    //brisanje slektovanog reda iz datagridview'a
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                    MessageBox.Show("brisanje je uspešno obavljeno");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cbProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Praznjenje sadržaja RichTextBox-a
            rtbPredmeti.Clear();

            //otvaranje konekcije
            kon.Open();

            //Kreiranj Sql parametarskog upita
            using (SqlCommand command = new SqlCommand("SELECT Naziv FROM Predmet WHERE Profesor = @Profesor", kon))
            {
                //definisanje parametara
                command.Parameters.Add(new SqlParameter("Profesor", cbProfesor.Text));

                //izvrsavanje sql upita pomocu sqldatareadera
                SqlDataReader reader = command.ExecuteReader();

                //citanje sadržaja sqldatareadera i upis u richtextbox kontrolu
                while (reader.Read())
                {
                    rtbPredmeti.AppendText(reader.GetString(0));
                    rtbPredmeti.AppendText("\r\n");
                }
            }

            //zatvaranje konekcije
            kon.Close();
        }

          
    }
}
