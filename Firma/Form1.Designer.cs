namespace Firma
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label prezimeLabel;
            System.Windows.Forms.Label datumZaposlenjaLabel;
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("");
            this.listViewRadnici = new System.Windows.Forms.ListView();
            this.columnIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.radnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmaDataSet = new Firma.FirmaDataSet();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.dtDatumZaposlenja = new System.Windows.Forms.DateTimePicker();
            this.btnUbaci = new System.Windows.Forms.Button();
            this.btnPromeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnResetu = new System.Windows.Forms.Button();
            this.radnikTableAdapter = new Firma.FirmaDataSetTableAdapters.RadnikTableAdapter();
            this.tableAdapterManager = new Firma.FirmaDataSetTableAdapters.TableAdapterManager();
            this.firmaDataSet1 = new Firma.FirmaDataSet();
            this.radnikTableAdapter1 = new Firma.FirmaDataSetTableAdapters.RadnikTableAdapter();
            this.tableAdapterManager1 = new Firma.FirmaDataSetTableAdapters.TableAdapterManager();
            imeLabel = new System.Windows.Forms.Label();
            prezimeLabel = new System.Windows.Forms.Label();
            datumZaposlenjaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Location = new System.Drawing.Point(417, 129);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(27, 13);
            imeLabel.TabIndex = 1;
            imeLabel.Text = "Ime:";
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.Location = new System.Drawing.Point(417, 179);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(47, 13);
            prezimeLabel.TabIndex = 3;
            prezimeLabel.Text = "Prezime:";
            // 
            // datumZaposlenjaLabel
            // 
            datumZaposlenjaLabel.AutoSize = true;
            datumZaposlenjaLabel.Location = new System.Drawing.Point(417, 230);
            datumZaposlenjaLabel.Name = "datumZaposlenjaLabel";
            datumZaposlenjaLabel.Size = new System.Drawing.Size(96, 13);
            datumZaposlenjaLabel.TabIndex = 5;
            datumZaposlenjaLabel.Text = "Datum Zaposlenja:";
            // 
            // listViewRadnici
            // 
            this.listViewRadnici.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIme,
            this.columnPrezime,
            this.columnDatum});
            this.listViewRadnici.FullRowSelect = true;
            this.listViewRadnici.GridLines = true;
            this.listViewRadnici.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.listViewRadnici.Location = new System.Drawing.Point(13, 13);
            this.listViewRadnici.MultiSelect = false;
            this.listViewRadnici.Name = "listViewRadnici";
            this.listViewRadnici.Size = new System.Drawing.Size(389, 317);
            this.listViewRadnici.TabIndex = 0;
            this.listViewRadnici.UseCompatibleStateImageBehavior = false;
            this.listViewRadnici.View = System.Windows.Forms.View.Details;
            this.listViewRadnici.SelectedIndexChanged += new System.EventHandler(this.listViewRadnici_SelectedIndexChanged);
            // 
            // columnIme
            // 
            this.columnIme.Text = "Ime";
            this.columnIme.Width = 109;
            // 
            // columnPrezime
            // 
            this.columnPrezime.Text = "Prezime";
            this.columnPrezime.Width = 136;
            // 
            // columnDatum
            // 
            this.columnDatum.Text = "Datum zaposlenja";
            this.columnDatum.Width = 140;
            // 
            // imeTextBox
            // 
            this.imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radnikBindingSource, "Ime", true));
            this.imeTextBox.Location = new System.Drawing.Point(420, 145);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(100, 20);
            this.imeTextBox.TabIndex = 2;
            // 
            // radnikBindingSource
            // 
            this.radnikBindingSource.DataMember = "Radnik";
            this.radnikBindingSource.DataSource = this.firmaDataSet;
            // 
            // firmaDataSet
            // 
            this.firmaDataSet.DataSetName = "FirmaDataSet";
            this.firmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radnikBindingSource, "Prezime", true));
            this.prezimeTextBox.Location = new System.Drawing.Point(420, 195);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.prezimeTextBox.TabIndex = 4;
            // 
            // dtDatumZaposlenja
            // 
            this.dtDatumZaposlenja.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.radnikBindingSource, "datumZaposlenja", true));
            this.dtDatumZaposlenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDatumZaposlenja.Location = new System.Drawing.Point(420, 246);
            this.dtDatumZaposlenja.Name = "dtDatumZaposlenja";
            this.dtDatumZaposlenja.Size = new System.Drawing.Size(100, 20);
            this.dtDatumZaposlenja.TabIndex = 6;
            // 
            // btnUbaci
            // 
            this.btnUbaci.Location = new System.Drawing.Point(420, 307);
            this.btnUbaci.Name = "btnUbaci";
            this.btnUbaci.Size = new System.Drawing.Size(75, 23);
            this.btnUbaci.TabIndex = 7;
            this.btnUbaci.Text = "Ubaci";
            this.btnUbaci.UseVisualStyleBackColor = true;
            this.btnUbaci.Click += new System.EventHandler(this.btnUbaci_Click);
            // 
            // btnPromeni
            // 
            this.btnPromeni.Location = new System.Drawing.Point(557, 307);
            this.btnPromeni.Name = "btnPromeni";
            this.btnPromeni.Size = new System.Drawing.Size(75, 23);
            this.btnPromeni.TabIndex = 8;
            this.btnPromeni.Text = "Promeni";
            this.btnPromeni.UseVisualStyleBackColor = true;
            this.btnPromeni.Click += new System.EventHandler(this.btnPromeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(557, 243);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 9;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnResetu
            // 
            this.btnResetu.Location = new System.Drawing.Point(557, 174);
            this.btnResetu.Name = "btnResetu";
            this.btnResetu.Size = new System.Drawing.Size(75, 23);
            this.btnResetu.TabIndex = 10;
            this.btnResetu.Text = "Resetuj";
            this.btnResetu.UseVisualStyleBackColor = true;
            this.btnResetu.Click += new System.EventHandler(this.btnResetu_Click);
            // 
            // radnikTableAdapter
            // 
            this.radnikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RadnikTableAdapter = this.radnikTableAdapter;
            this.tableAdapterManager.UpdateOrder = Firma.FirmaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // firmaDataSet1
            // 
            this.firmaDataSet1.DataSetName = "FirmaDataSet";
            this.firmaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radnikTableAdapter1
            // 
            this.radnikTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.RadnikTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Firma.FirmaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 350);
            this.Controls.Add(this.btnResetu);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnPromeni);
            this.Controls.Add(this.btnUbaci);
            this.Controls.Add(datumZaposlenjaLabel);
            this.Controls.Add(this.dtDatumZaposlenja);
            this.Controls.Add(prezimeLabel);
            this.Controls.Add(this.prezimeTextBox);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(this.listViewRadnici);
            this.Name = "Form1";
            this.Text = "Radnici";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewRadnici;
        private FirmaDataSet firmaDataSet;
        private System.Windows.Forms.BindingSource radnikBindingSource;
        private FirmaDataSetTableAdapters.RadnikTableAdapter radnikTableAdapter;
        private FirmaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.DateTimePicker dtDatumZaposlenja;
        private System.Windows.Forms.Button btnUbaci;
        private System.Windows.Forms.Button btnPromeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnResetu;
        private System.Windows.Forms.ColumnHeader columnIme;
        private System.Windows.Forms.ColumnHeader columnPrezime;
        private System.Windows.Forms.ColumnHeader columnDatum;
        private FirmaDataSet firmaDataSet1;
        private FirmaDataSetTableAdapters.RadnikTableAdapter radnikTableAdapter1;
        private FirmaDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}

