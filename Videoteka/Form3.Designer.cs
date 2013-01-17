namespace Videoteka
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.videotekaDataSet = new Videoteka.VideotekaDataSet();
            this.izdavanjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.izdavanjaTableAdapter = new Videoteka.VideotekaDataSetTableAdapters.izdavanjaTableAdapter();
            this.tableAdapterManager = new Videoteka.VideotekaDataSetTableAdapters.TableAdapterManager();
            this.izdavanjaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.izdavanjaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.izdavanjaDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.kaseteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kaseteTableAdapter = new Videoteka.VideotekaDataSetTableAdapters.kaseteTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.videotekaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdavanjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdavanjaBindingNavigator)).BeginInit();
            this.izdavanjaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.izdavanjaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaseteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // videotekaDataSet
            // 
            this.videotekaDataSet.DataSetName = "VideotekaDataSet";
            this.videotekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // izdavanjaBindingSource
            // 
            this.izdavanjaBindingSource.DataMember = "izdavanja";
            this.izdavanjaBindingSource.DataSource = this.videotekaDataSet;
            // 
            // izdavanjaTableAdapter
            // 
            this.izdavanjaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.izdavanjaTableAdapter = this.izdavanjaTableAdapter;
            this.tableAdapterManager.kaseteTableAdapter = null;
            this.tableAdapterManager.kupciTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Videoteka.VideotekaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // izdavanjaBindingNavigator
            // 
            this.izdavanjaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.izdavanjaBindingNavigator.BindingSource = this.izdavanjaBindingSource;
            this.izdavanjaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.izdavanjaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.izdavanjaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.izdavanjaBindingNavigatorSaveItem});
            this.izdavanjaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.izdavanjaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.izdavanjaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.izdavanjaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.izdavanjaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.izdavanjaBindingNavigator.Name = "izdavanjaBindingNavigator";
            this.izdavanjaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.izdavanjaBindingNavigator.Size = new System.Drawing.Size(470, 25);
            this.izdavanjaBindingNavigator.TabIndex = 0;
            this.izdavanjaBindingNavigator.Text = "bindingNavigator1";
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
            // izdavanjaBindingNavigatorSaveItem
            // 
            this.izdavanjaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.izdavanjaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("izdavanjaBindingNavigatorSaveItem.Image")));
            this.izdavanjaBindingNavigatorSaveItem.Name = "izdavanjaBindingNavigatorSaveItem";
            this.izdavanjaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.izdavanjaBindingNavigatorSaveItem.Text = "Save Data";
            this.izdavanjaBindingNavigatorSaveItem.Click += new System.EventHandler(this.izdavanjaBindingNavigatorSaveItem_Click);
            // 
            // izdavanjaDataGridView
            // 
            this.izdavanjaDataGridView.AutoGenerateColumns = false;
            this.izdavanjaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.izdavanjaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.izdavanjaDataGridView.DataSource = this.izdavanjaBindingSource;
            this.izdavanjaDataGridView.Location = new System.Drawing.Point(12, 86);
            this.izdavanjaDataGridView.Name = "izdavanjaDataGridView";
            this.izdavanjaDataGridView.Size = new System.Drawing.Size(447, 270);
            this.izdavanjaDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // kaseteBindingSource
            // 
            this.kaseteBindingSource.DataMember = "kasete";
            this.kaseteBindingSource.DataSource = this.videotekaDataSet;
            // 
            // kaseteTableAdapter
            // 
            this.kaseteTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "iznajmljivanjeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "iznajmljivanjeID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "kupacID";
            this.dataGridViewTextBoxColumn2.HeaderText = "kupacID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "kasetaID";
            this.dataGridViewTextBoxColumn3.DataSource = this.kaseteBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Naziv";
            this.dataGridViewTextBoxColumn3.HeaderText = "NazivKasete";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "kasetaID";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DatumUzimanja";
            this.dataGridViewTextBoxColumn4.HeaderText = "DatumUzimanja";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DatumVracanja";
            this.dataGridViewTextBoxColumn5.HeaderText = "DatumVracanja";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Placeno";
            this.dataGridViewTextBoxColumn6.HeaderText = "Placeno";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 368);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.izdavanjaDataGridView);
            this.Controls.Add(this.izdavanjaBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videotekaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdavanjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdavanjaBindingNavigator)).EndInit();
            this.izdavanjaBindingNavigator.ResumeLayout(false);
            this.izdavanjaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.izdavanjaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaseteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VideotekaDataSet videotekaDataSet;
        private System.Windows.Forms.BindingSource izdavanjaBindingSource;
        private VideotekaDataSetTableAdapters.izdavanjaTableAdapter izdavanjaTableAdapter;
        private VideotekaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator izdavanjaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton izdavanjaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView izdavanjaDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource kaseteBindingSource;
        private VideotekaDataSetTableAdapters.kaseteTableAdapter kaseteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn6;
    }
}