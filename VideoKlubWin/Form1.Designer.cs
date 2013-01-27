namespace VideoKlubWin
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
            this.videoKlubDataSet1 = new VideoKlubWin.VideoKlubDataSet();
            this.clanTableAdapter1 = new VideoKlubWin.VideoKlubDataSetTableAdapters.ClanTableAdapter();
            this.groupBoxClan = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonPotvrdi = new System.Windows.Forms.Button();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxJmbg = new System.Windows.Forms.TextBox();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.buttonBrisi = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.videoKlubDataSet1)).BeginInit();
            this.groupBoxClan.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoKlubDataSet1
            // 
            this.videoKlubDataSet1.DataSetName = "VideoKlubDataSet";
            this.videoKlubDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clanTableAdapter1
            // 
            this.clanTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBoxClan
            // 
            this.groupBoxClan.Controls.Add(this.textBoxTelefon);
            this.groupBoxClan.Controls.Add(this.textBoxAdresa);
            this.groupBoxClan.Controls.Add(this.textBoxJmbg);
            this.groupBoxClan.Controls.Add(this.textBoxPrezime);
            this.groupBoxClan.Controls.Add(this.textBoxIme);
            this.groupBoxClan.Controls.Add(this.buttonOdustani);
            this.groupBoxClan.Controls.Add(this.buttonPotvrdi);
            this.groupBoxClan.Controls.Add(this.label5);
            this.groupBoxClan.Controls.Add(this.label4);
            this.groupBoxClan.Controls.Add(this.label3);
            this.groupBoxClan.Controls.Add(this.label2);
            this.groupBoxClan.Controls.Add(this.label1);
            this.groupBoxClan.Location = new System.Drawing.Point(13, 13);
            this.groupBoxClan.Name = "groupBoxClan";
            this.groupBoxClan.Size = new System.Drawing.Size(258, 324);
            this.groupBoxClan.TabIndex = 0;
            this.groupBoxClan.TabStop = false;
            this.groupBoxClan.Text = "Član";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "JMBG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adresa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon:";
            // 
            // buttonPotvrdi
            // 
            this.buttonPotvrdi.Location = new System.Drawing.Point(21, 274);
            this.buttonPotvrdi.Name = "buttonPotvrdi";
            this.buttonPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.buttonPotvrdi.TabIndex = 5;
            this.buttonPotvrdi.Text = "Potvrdi";
            this.buttonPotvrdi.UseVisualStyleBackColor = true;
            this.buttonPotvrdi.Click += new System.EventHandler(this.buttonPotvrdi_Click);
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.Location = new System.Drawing.Point(157, 274);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(75, 23);
            this.buttonOdustani.TabIndex = 6;
            this.buttonOdustani.Text = "Otkaži";
            this.buttonOdustani.UseVisualStyleBackColor = true;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(116, 37);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(116, 20);
            this.textBoxIme.TabIndex = 7;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(116, 82);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(116, 20);
            this.textBoxPrezime.TabIndex = 8;
            // 
            // textBoxJmbg
            // 
            this.textBoxJmbg.Location = new System.Drawing.Point(116, 123);
            this.textBoxJmbg.Name = "textBoxJmbg";
            this.textBoxJmbg.Size = new System.Drawing.Size(116, 20);
            this.textBoxJmbg.TabIndex = 9;
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Location = new System.Drawing.Point(116, 170);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(116, 20);
            this.textBoxAdresa.TabIndex = 10;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(116, 215);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(116, 20);
            this.textBoxTelefon.TabIndex = 11;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(41, 352);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 1;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Location = new System.Drawing.Point(209, 352);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(75, 23);
            this.buttonIzmeni.TabIndex = 2;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // buttonBrisi
            // 
            this.buttonBrisi.Location = new System.Drawing.Point(369, 352);
            this.buttonBrisi.Name = "buttonBrisi";
            this.buttonBrisi.Size = new System.Drawing.Size(75, 23);
            this.buttonBrisi.TabIndex = 3;
            this.buttonBrisi.Text = "Obriši";
            this.buttonBrisi.UseVisualStyleBackColor = true;
            this.buttonBrisi.Click += new System.EventHandler(this.buttonBrisi_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(287, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(222, 303);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 387);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonBrisi);
            this.Controls.Add(this.buttonIzmeni);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.groupBoxClan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoKlubDataSet1)).EndInit();
            this.groupBoxClan.ResumeLayout(false);
            this.groupBoxClan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private VideoKlubDataSet videoKlubDataSet1;
        private VideoKlubDataSetTableAdapters.ClanTableAdapter clanTableAdapter1;
        private System.Windows.Forms.GroupBox groupBoxClan;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.TextBox textBoxJmbg;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Button buttonOdustani;
        private System.Windows.Forms.Button buttonPotvrdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.Button buttonBrisi;
        private System.Windows.Forms.ListBox listBox1;
    }
}

