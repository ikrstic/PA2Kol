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

namespace _2Kol_Vezbe
{
    public partial class frmPredmetKonektovani : Form
    {
        public frmPredmetKonektovani()
        {
            InitializeComponent();
        }
        class Konekcija
        {
            public static string konString = "Data Source=EMEDIAPC;Initial Catalog=Studenti;Integrated Security=True";
        }

        SqlDataAdapter da = null;
        DataSet ds = null;
        SqlConnection kon = new SqlConnection(Konekcija.konString);
        int x;

        private void frmPredmetKonektovani_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentiDataSet11.Predmet' table. You can move, or remove it, as needed.
            this.predmetTableAdapter.Fill(this.studentiDataSet11.Predmet);
            da = new SqlDataAdapter("select * from predmet", Konekcija.konString);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            ds = new DataSet();
            da.Fill(ds, "Predmet");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Predmet";
        }

        //Pamti vrednost PredmetID selektovane celije pre njene promene
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            x = int.Parse(dataGridView1[0, e.RowIndex].Value.ToString());
        }

        private void dataGridView1_CellValueChanged(object sender,DataGridViewCellEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Da li želite da sačuvate promene?", "Poruka", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                try
                {
                    //otvaranje konekcije
                    kon.Open();
                    //kreiranje upadate upita
                    StringBuilder upit = new StringBuilder();
                    upit.Append("UPDATE [Predmet]");
                    upit.Append("SET " + dataGridView1.Columns[e.ColumnIndex].Name + "=N'" + dataGridView1[e.ColumnIndex, e.RowIndex].Value + x);

                    //kreiranje update komande
                    SqlCommand updateKomanda = new SqlCommand(upit.ToString(), kon);

                    //izvrsavanje komande, odnosno update baze
                    updateKomanda.ExecuteNonQuery();

                    MessageBox.Show("Podaci su uspešno izmenjeni");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    //zatvaranje konekcije
                    kon.Close();
                }
            }
            else
            {
                //Vracanje dataGridView na predhodno stanje
                this.da.Fill(this.ds, "Predmet");
            }
        }
        private void noviPredmetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            try
            {
                //Otvaranje konekcije
                kon.Open();

                //kreiranje insert upita
                string upit = String.Format("insert into predmet(predmetid,naziv,profesor) values ('{0}','{1}','{2}');", tbPredmetID.Text, tbNaziv.Text, tbProfesor.Text);

                //kreiranje insert komande
                SqlCommand insertKomanda = new SqlCommand(upit, kon);

                //izvrsavanje komande, ondnosno upit u bazu
                insertKomanda.ExecuteNonQuery();

                MessageBox.Show("Novi predmet je uspešno dodat");

                //ubacivanje u dataGridView
                this.da.Fill(this.ds, "Predmet");

                //Brisanje sadržaja iz textBox kontrole
                tbPredmetID.Clear();
                tbNaziv.Clear();
                tbProfesor.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //zatvaranje konekcije
                kon.Close();
            }
        }

        private void zatvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pronadjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;

            //kreiranje SqlDataReader objekta
            SqlDataReader dr = null;

            try
            {
                //otvaranje konekcije
                kon.Open();

                //kreiranje delete upita
                string upit = String.Format("select distinct Profesor from Predmet");

                //kreiranje delete komande
                SqlCommand selectKomanda = new SqlCommand(upit, kon);

                //izvršavanje komande odnosno brisanje iz baze
                dr = selectKomanda.ExecuteReader();
                
                //brisanje sadržaja combobox kontrole
                cbProfesori.Items.Clear();

                //citanje podataka iz sqldatareadera i dodavanje u combobox
                while (dr.Read())
                {
                    cbProfesori.Items.Add(dr["Profesor"].ToString());
                }

                //zatvaranje sqldatareadera
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //zatvaranje konekcije
                kon.Close();
            }
        }

        private void cbProfesori_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Praznjenje sadržaja RichTextBox-a
            rtbPredmeti.Clear();

            //otvaranje konekcije
            kon.Open();

            //Kreiranj Sql parametarskog upita
            using (SqlCommand command = new SqlCommand("SELECT Naziv FROM Predmet WHERE Profesor = @Profesor", kon))
            {
                //definisanje parametara
                command.Parameters.Add(new SqlParameter("Profesor", cbProfesori.SelectedItem.ToString()));

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

        private void brisiToolStripMenuItem_Click(object sender, EventArgs e)
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
                    //otvaranje konekcije
                    kon.Open();

                    //kreiranje delete upita
                    string upit = String.Format("delete from predmet where predmetid={0}", predmetID);

                    //kreiranje delete komande
                    SqlCommand deleteKomanda = new SqlCommand(upit, kon);

                    //izvrsavanje komande, odnosno brisanje iz baze
                    deleteKomanda.ExecuteNonQuery();

                    //brisanje selektovanog reda iz datagridviewa
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    MessageBox.Show("Brisanje je uspešno obavljeno");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    //zatvaranje konekcije
                    kon.Close();
                }
            }
        }
    }
}
