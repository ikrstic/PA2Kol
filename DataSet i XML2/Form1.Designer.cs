namespace DataSet_i_XML2
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
            this.testDataSet1 = new DataSet_i_XML2.TestDataSet();
            this.kategorijeTableAdapter1 = new DataSet_i_XML2.TestDataSetTableAdapters.KategorijeTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.testDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet11 = new DataSet_i_XML2.TestDataSet1();
            this.kategorijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorijeTableAdapter = new DataSet_i_XML2.TestDataSet1TableAdapters.KategorijeTableAdapter();
            this.idKategorijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // testDataSet1
            // 
            this.testDataSet1.DataSetName = "TestDataSet";
            this.testDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategorijeTableAdapter1
            // 
            this.kategorijeTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKategorijeDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kategorijeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 232);
            this.dataGridView1.TabIndex = 0;
            // 
            // testDataSet1BindingSource
            // 
            this.testDataSet1BindingSource.DataSource = this.testDataSet1;
            this.testDataSet1BindingSource.Position = 0;
            // 
            // testDataSet11
            // 
            this.testDataSet11.DataSetName = "TestDataSet1";
            this.testDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategorijeBindingSource
            // 
            this.kategorijeBindingSource.DataMember = "Kategorije";
            this.kategorijeBindingSource.DataSource = this.testDataSet11;
            // 
            // kategorijeTableAdapter
            // 
            this.kategorijeTableAdapter.ClearBeforeFill = true;
            // 
            // idKategorijeDataGridViewTextBoxColumn
            // 
            this.idKategorijeDataGridViewTextBoxColumn.DataPropertyName = "IdKategorije";
            this.idKategorijeDataGridViewTextBoxColumn.HeaderText = "IdKategorije";
            this.idKategorijeDataGridViewTextBoxColumn.Name = "idKategorijeDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sačuvaj šemu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 303);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TestDataSet testDataSet1;
        private TestDataSetTableAdapters.KategorijeTableAdapter kategorijeTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource testDataSet1BindingSource;
        private TestDataSet1 testDataSet11;
        private System.Windows.Forms.BindingSource kategorijeBindingSource;
        private TestDataSet1TableAdapters.KategorijeTableAdapter kategorijeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKategorijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}

