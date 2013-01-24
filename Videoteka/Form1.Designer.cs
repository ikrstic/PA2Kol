namespace Videoteka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kupciBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.kupciBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kupciDataGridView = new System.Windows.Forms.DataGridView();
            this.btnKaseta = new System.Windows.Forms.Button();
            this.btnIznajmljivanje = new System.Windows.Forms.Button();
            this.fillByKupacIDToolStrip = new System.Windows.Forms.ToolStrip();
            this.kupacIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.kupacIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByKupacIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kupciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videotekaDataSet = new Videoteka.VideotekaDataSet();
            this.kupciTableAdapter = new Videoteka.VideotekaDataSetTableAdapters.kupciTableAdapter();
            this.tableAdapterManager = new Videoteka.VideotekaDataSetTableAdapters.TableAdapterManager();
            this.izdavanjaTableAdapter1 = new Videoteka.VideotekaDataSetTableAdapters.izdavanjaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kupciBindingNavigator)).BeginInit();
            this.kupciBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kupciDataGridView)).BeginInit();
            this.fillByKupacIDToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kupciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videotekaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // kupciBindingNavigator
            // 
            this.kupciBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kupciBindingNavigator.BindingSource = this.kupciBindingSource;
            this.kupciBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kupciBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kupciBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.kupciBindingNavigatorSaveItem});
            this.kupciBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kupciBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kupciBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kupciBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kupciBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kupciBindingNavigator.Name = "kupciBindingNavigator";
            this.kupciBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kupciBindingNavigator.Size = new System.Drawing.Size(476, 25);
            this.kupciBindingNavigator.TabIndex = 0;
            this.kupciBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // kupciBindingNavigatorSaveItem
            // 
            this.kupciBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kupciBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kupciBindingNavigatorSaveItem.Image")));
            this.kupciBindingNavigatorSaveItem.Name = "kupciBindingNavigatorSaveItem";
            this.kupciBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.kupciBindingNavigatorSaveItem.Text = "Save Data";
            this.kupciBindingNavigatorSaveItem.Click += new System.EventHandler(this.kupciBindingNavigatorSaveItem_Click);
            // 
            // kupciDataGridView
            // 
            this.kupciDataGridView.AutoGenerateColumns = false;
            this.kupciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kupciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.kupciDataGridView.DataSource = this.kupciBindingSource;
            this.kupciDataGridView.Location = new System.Drawing.Point(12, 87);
            this.kupciDataGridView.Name = "kupciDataGridView";
            this.kupciDataGridView.Size = new System.Drawing.Size(444, 306);
            this.kupciDataGridView.TabIndex = 1;
            // 
            // btnKaseta
            // 
            this.btnKaseta.Location = new System.Drawing.Point(12, 53);
            this.btnKaseta.Name = "btnKaseta";
            this.btnKaseta.Size = new System.Drawing.Size(75, 23);
            this.btnKaseta.TabIndex = 2;
            this.btnKaseta.Text = "Kaseta";
            this.btnKaseta.UseVisualStyleBackColor = true;
            this.btnKaseta.Click += new System.EventHandler(this.btnKaseta_Click);
            // 
            // btnIznajmljivanje
            // 
            this.btnIznajmljivanje.Location = new System.Drawing.Point(128, 53);
            this.btnIznajmljivanje.Name = "btnIznajmljivanje";
            this.btnIznajmljivanje.Size = new System.Drawing.Size(81, 23);
            this.btnIznajmljivanje.TabIndex = 3;
            this.btnIznajmljivanje.Text = "Iznajmljivanje";
            this.btnIznajmljivanje.UseVisualStyleBackColor = true;
            this.btnIznajmljivanje.Click += new System.EventHandler(this.btnIznajmljivanje_Click);
            // 
            // fillByKupacIDToolStrip
            // 
            this.fillByKupacIDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kupacIDToolStripLabel,
            this.kupacIDToolStripTextBox,
            this.fillByKupacIDToolStripButton});
            this.fillByKupacIDToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByKupacIDToolStrip.Name = "fillByKupacIDToolStrip";
            this.fillByKupacIDToolStrip.Size = new System.Drawing.Size(476, 25);
            this.fillByKupacIDToolStrip.TabIndex = 4;
            this.fillByKupacIDToolStrip.Text = "fillByKupacIDToolStrip";
            // 
            // kupacIDToolStripLabel
            // 
            this.kupacIDToolStripLabel.Name = "kupacIDToolStripLabel";
            this.kupacIDToolStripLabel.Size = new System.Drawing.Size(53, 22);
            this.kupacIDToolStripLabel.Text = "kupacID:";
            // 
            // kupacIDToolStripTextBox
            // 
            this.kupacIDToolStripTextBox.Name = "kupacIDToolStripTextBox";
            this.kupacIDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByKupacIDToolStripButton
            // 
            this.fillByKupacIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByKupacIDToolStripButton.Name = "fillByKupacIDToolStripButton";
            this.fillByKupacIDToolStripButton.Size = new System.Drawing.Size(83, 22);
            this.fillByKupacIDToolStripButton.Text = "FillByKupacID";
            this.fillByKupacIDToolStripButton.Click += new System.EventHandler(this.fillByKupacIDToolStripButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "kupacID";
            this.dataGridViewTextBoxColumn1.HeaderText = "kupacID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ImePrezime";
            this.dataGridViewTextBoxColumn2.HeaderText = "ImePrezime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Telefon";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "lk";
            this.dataGridViewTextBoxColumn4.HeaderText = "lk";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // kupciBindingSource
            // 
            this.kupciBindingSource.DataMember = "kupci";
            this.kupciBindingSource.DataSource = this.videotekaDataSet;
            // 
            // videotekaDataSet
            // 
            this.videotekaDataSet.DataSetName = "VideotekaDataSet";
            this.videotekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kupciTableAdapter
            // 
            this.kupciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.izdavanjaTableAdapter = null;
            this.tableAdapterManager.kaseteTableAdapter = null;
            this.tableAdapterManager.kupciTableAdapter = this.kupciTableAdapter;
            this.tableAdapterManager.UpdateOrder = Videoteka.VideotekaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // izdavanjaTableAdapter1
            // 
            this.izdavanjaTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 413);
            this.Controls.Add(this.fillByKupacIDToolStrip);
            this.Controls.Add(this.btnIznajmljivanje);
            this.Controls.Add(this.btnKaseta);
            this.Controls.Add(this.kupciDataGridView);
            this.Controls.Add(this.kupciBindingNavigator);
            this.Name = "Form1";
            this.Text = "Kupci";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kupciBindingNavigator)).EndInit();
            this.kupciBindingNavigator.ResumeLayout(false);
            this.kupciBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kupciDataGridView)).EndInit();
            this.fillByKupacIDToolStrip.ResumeLayout(false);
            this.fillByKupacIDToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kupciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videotekaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VideotekaDataSet videotekaDataSet;
        private System.Windows.Forms.BindingSource kupciBindingSource;
        private VideotekaDataSetTableAdapters.kupciTableAdapter kupciTableAdapter;
        private VideotekaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kupciBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton kupciBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView kupciDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnKaseta;
        private System.Windows.Forms.Button btnIznajmljivanje;
        private VideotekaDataSetTableAdapters.izdavanjaTableAdapter izdavanjaTableAdapter1;
        private System.Windows.Forms.ToolStrip fillByKupacIDToolStrip;
        private System.Windows.Forms.ToolStripLabel kupacIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox kupacIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByKupacIDToolStripButton;
    }
}

