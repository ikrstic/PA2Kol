namespace _2Kol_Vezbe
{
    partial class frmPredmetKonektovani
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviPredmetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zatvoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pronadjiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.tbProfesor = new System.Windows.Forms.TextBox();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.tbPredmetID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbPredmeti = new System.Windows.Forms.RichTextBox();
            this.cbProfesori = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentiDataSet = new _2Kol_Vezbe.StudentiDataSet();
            this.studentiDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentiDataSet1 = new _2Kol_Vezbe.StudentiDataSet();
            this.studentiDataSet11 = new _2Kol_Vezbe.StudentiDataSet1();
            this.predmetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.predmetTableAdapter = new _2Kol_Vezbe.StudentiDataSet1TableAdapters.PredmetTableAdapter();
            this.predmetIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.brisi1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetBindingSource)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.pronadjiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(504, 24);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviPredmetToolStripMenuItem,
            this.zatvoriToolStripMenuItem});
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.unosToolStripMenuItem.Text = "Unos";
            // 
            // noviPredmetToolStripMenuItem
            // 
            this.noviPredmetToolStripMenuItem.Name = "noviPredmetToolStripMenuItem";
            this.noviPredmetToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.noviPredmetToolStripMenuItem.Text = "Novi Predmet";
            this.noviPredmetToolStripMenuItem.Click += new System.EventHandler(this.noviPredmetToolStripMenuItem_Click);
            // 
            // zatvoriToolStripMenuItem
            // 
            this.zatvoriToolStripMenuItem.Name = "zatvoriToolStripMenuItem";
            this.zatvoriToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.zatvoriToolStripMenuItem.Text = "Zatvori";
            this.zatvoriToolStripMenuItem.Click += new System.EventHandler(this.zatvoriToolStripMenuItem_Click);
            // 
            // pronadjiToolStripMenuItem
            // 
            this.pronadjiToolStripMenuItem.Name = "pronadjiToolStripMenuItem";
            this.pronadjiToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.pronadjiToolStripMenuItem.Text = "Pronadji";
            this.pronadjiToolStripMenuItem.Click += new System.EventHandler(this.pronadjiToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUnos);
            this.groupBox1.Controls.Add(this.tbProfesor);
            this.groupBox1.Controls.Add(this.tbNaziv);
            this.groupBox1.Controls.Add(this.tbPredmetID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 198);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos novog predmeta";
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(132, 136);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 23);
            this.btnUnos.TabIndex = 6;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // tbProfesor
            // 
            this.tbProfesor.Location = new System.Drawing.Point(107, 96);
            this.tbProfesor.Name = "tbProfesor";
            this.tbProfesor.Size = new System.Drawing.Size(100, 20);
            this.tbProfesor.TabIndex = 5;
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(107, 64);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(100, 20);
            this.tbNaziv.TabIndex = 4;
            // 
            // tbPredmetID
            // 
            this.tbPredmetID.Location = new System.Drawing.Point(107, 33);
            this.tbPredmetID.Name = "tbPredmetID";
            this.tbPredmetID.Size = new System.Drawing.Size(100, 20);
            this.tbPredmetID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Profesor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PredmetID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbPredmeti);
            this.groupBox2.Controls.Add(this.cbProfesori);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(260, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 198);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prikazi po profesoru";
            // 
            // rtbPredmeti
            // 
            this.rtbPredmeti.Location = new System.Drawing.Point(9, 80);
            this.rtbPredmeti.Name = "rtbPredmeti";
            this.rtbPredmeti.Size = new System.Drawing.Size(209, 96);
            this.rtbPredmeti.TabIndex = 3;
            this.rtbPredmeti.Text = "";
            // 
            // cbProfesori
            // 
            this.cbProfesori.FormattingEnabled = true;
            this.cbProfesori.Location = new System.Drawing.Point(88, 25);
            this.cbProfesori.Name = "cbProfesori";
            this.cbProfesori.Size = new System.Drawing.Size(130, 21);
            this.cbProfesori.TabIndex = 2;
            this.cbProfesori.SelectedIndexChanged += new System.EventHandler(this.cbProfesori_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Predmeti:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Profesor:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.predmetIDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.profesorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.predmetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(456, 169);
            this.dataGridView1.TabIndex = 4;
            // 
            // studentiDataSetBindingSource
            // 
            this.studentiDataSetBindingSource.DataSource = this.studentiDataSet;
            this.studentiDataSetBindingSource.Position = 0;
            // 
            // studentiDataSet
            // 
            this.studentiDataSet.DataSetName = "StudentiDataSet";
            this.studentiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentiDataSetBindingSource1
            // 
            this.studentiDataSetBindingSource1.DataSource = this.studentiDataSet;
            this.studentiDataSetBindingSource1.Position = 0;
            // 
            // studentiDataSet1
            // 
            this.studentiDataSet1.DataSetName = "StudentiDataSet";
            this.studentiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentiDataSet11
            // 
            this.studentiDataSet11.DataSetName = "StudentiDataSet1";
            this.studentiDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // predmetBindingSource
            // 
            this.predmetBindingSource.DataMember = "Predmet";
            this.predmetBindingSource.DataSource = this.studentiDataSet11;
            // 
            // predmetTableAdapter
            // 
            this.predmetTableAdapter.ClearBeforeFill = true;
            // 
            // predmetIDDataGridViewTextBoxColumn
            // 
            this.predmetIDDataGridViewTextBoxColumn.DataPropertyName = "PredmetID";
            this.predmetIDDataGridViewTextBoxColumn.HeaderText = "PredmetID";
            this.predmetIDDataGridViewTextBoxColumn.Name = "predmetIDDataGridViewTextBoxColumn";
            this.predmetIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.Width = 130;
            // 
            // profesorDataGridViewTextBoxColumn
            // 
            this.profesorDataGridViewTextBoxColumn.DataPropertyName = "Profesor";
            this.profesorDataGridViewTextBoxColumn.HeaderText = "Profesor";
            this.profesorDataGridViewTextBoxColumn.Name = "profesorDataGridViewTextBoxColumn";
            this.profesorDataGridViewTextBoxColumn.Width = 150;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brisi1ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 24);
            this.menuStrip2.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(46, 24);
            this.menuStrip2.Stretch = false;
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // brisi1ToolStripMenuItem
            // 
            this.brisi1ToolStripMenuItem.Name = "brisi1ToolStripMenuItem";
            this.brisi1ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.brisi1ToolStripMenuItem.Text = "Briši";
            this.brisi1ToolStripMenuItem.Click += new System.EventHandler(this.brisiToolStripMenuItem_Click);
            // 
            // frmPredmetKonektovani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 457);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPredmetKonektovani";
            this.Text = "frmPredmetKonektovani";
            this.Load += new System.EventHandler(this.frmPredmetKonektovani_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetBindingSource)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviPredmetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zatvoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pronadjiToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.TextBox tbProfesor;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.TextBox tbPredmetID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource studentiDataSetBindingSource;
        private StudentiDataSet studentiDataSet;
        private System.Windows.Forms.RichTextBox rtbPredmeti;
        private System.Windows.Forms.ComboBox cbProfesori;
        private System.Windows.Forms.BindingSource studentiDataSetBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private StudentiDataSet studentiDataSet1;
        private StudentiDataSet1 studentiDataSet11;
        private System.Windows.Forms.BindingSource predmetBindingSource;
        private StudentiDataSet1TableAdapters.PredmetTableAdapter predmetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn predmetIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profesorDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem brisi1ToolStripMenuItem;
    }
}