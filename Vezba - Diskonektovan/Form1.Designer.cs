namespace Vezba___Diskonektovan
{
    partial class frmPredmetDiskonektovani
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.predmetIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predmetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentiDataSet = new Vezba___Diskonektovan.StudentiDataSet();
            this.predmetTableAdapter = new Vezba___Diskonektovan.StudentiDataSetTableAdapters.PredmetTableAdapter();
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
            this.cbProfesor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.brišiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.pronadjiToolStripMenuItem,
            this.brišiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(458, 24);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.predmetIDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.profesorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.predmetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(349, 181);
            this.dataGridView1.TabIndex = 2;
            // 
            // predmetIDDataGridViewTextBoxColumn
            // 
            this.predmetIDDataGridViewTextBoxColumn.DataPropertyName = "PredmetID";
            this.predmetIDDataGridViewTextBoxColumn.HeaderText = "PredmetID";
            this.predmetIDDataGridViewTextBoxColumn.Name = "predmetIDDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // profesorDataGridViewTextBoxColumn
            // 
            this.profesorDataGridViewTextBoxColumn.DataPropertyName = "Profesor";
            this.profesorDataGridViewTextBoxColumn.HeaderText = "Profesor";
            this.profesorDataGridViewTextBoxColumn.Name = "profesorDataGridViewTextBoxColumn";
            // 
            // predmetBindingSource
            // 
            this.predmetBindingSource.DataMember = "Predmet";
            this.predmetBindingSource.DataSource = this.studentiDataSet;
            // 
            // studentiDataSet
            // 
            this.studentiDataSet.DataSetName = "StudentiDataSet";
            this.studentiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // predmetTableAdapter
            // 
            this.predmetTableAdapter.ClearBeforeFill = true;
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
            this.groupBox1.Location = new System.Drawing.Point(13, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 174);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos novog predmeta";
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(98, 137);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 23);
            this.btnUnos.TabIndex = 6;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // tbProfesor
            // 
            this.tbProfesor.Location = new System.Drawing.Point(74, 93);
            this.tbProfesor.Name = "tbProfesor";
            this.tbProfesor.Size = new System.Drawing.Size(100, 20);
            this.tbProfesor.TabIndex = 5;
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(74, 57);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(100, 20);
            this.tbNaziv.TabIndex = 4;
            // 
            // tbPredmetID
            // 
            this.tbPredmetID.Location = new System.Drawing.Point(74, 29);
            this.tbPredmetID.Name = "tbPredmetID";
            this.tbPredmetID.Size = new System.Drawing.Size(100, 20);
            this.tbPredmetID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Profesor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PredmetID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbPredmeti);
            this.groupBox2.Controls.Add(this.cbProfesor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(232, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 174);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prikazi po profesoru";
            // 
            // rtbPredmeti
            // 
            this.rtbPredmeti.Location = new System.Drawing.Point(7, 65);
            this.rtbPredmeti.Name = "rtbPredmeti";
            this.rtbPredmeti.Size = new System.Drawing.Size(182, 96);
            this.rtbPredmeti.TabIndex = 3;
            this.rtbPredmeti.Text = "";
            // 
            // cbProfesor
            // 
            this.cbProfesor.FormattingEnabled = true;
            this.cbProfesor.Location = new System.Drawing.Point(68, 17);
            this.cbProfesor.Name = "cbProfesor";
            this.cbProfesor.Size = new System.Drawing.Size(121, 21);
            this.cbProfesor.TabIndex = 2;
            this.cbProfesor.SelectedIndexChanged += new System.EventHandler(this.cbProfesor_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Predmet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Profesor";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(369, 184);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(75, 23);
            this.btnIzmeni.TabIndex = 5;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // brišiToolStripMenuItem
            // 
            this.brišiToolStripMenuItem.Name = "brišiToolStripMenuItem";
            this.brišiToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.brišiToolStripMenuItem.Text = "Briši";
            this.brišiToolStripMenuItem.Click += new System.EventHandler(this.brišiToolStripMenuItem_Click);
            // 
            // frmPredmetDiskonektovani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 433);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPredmetDiskonektovani";
            this.Text = "Lista predmeta Diskonektovani scenario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviPredmetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zatvoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pronadjiToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private StudentiDataSet studentiDataSet;
        private System.Windows.Forms.BindingSource predmetBindingSource;
        private StudentiDataSetTableAdapters.PredmetTableAdapter predmetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn predmetIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profesorDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.TextBox tbProfesor;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.TextBox tbPredmetID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbPredmeti;
        private System.Windows.Forms.ComboBox cbProfesor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.ToolStripMenuItem brišiToolStripMenuItem;
    }
}

