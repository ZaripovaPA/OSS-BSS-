namespace OSS_BSS_system
{
    partial class Act
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Act));
            this.Search = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.ImportToExcel = new System.Windows.Forms.PictureBox();
            this.ExportToExel = new System.Windows.Forms.PictureBox();
            this.dataGridViewAct = new System.Windows.Forms.DataGridView();
            this.actBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._OSS_BSSDataSet1 = new OSS_BSS_system._OSS_BSSDataSet1();
            this.bindingNavigatorAct = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.actTableAdapter = new OSS_BSS_system._OSS_BSSDataSet1TableAdapters.ActTableAdapter();
            this.tableAdapterManager = new OSS_BSS_system._OSS_BSSDataSet1TableAdapters.TableAdapterManager();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ImportToExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportToExel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._OSS_BSSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorAct)).BeginInit();
            this.bindingNavigatorAct.SuspendLayout();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Transparent;
            this.Search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Search.Image = ((System.Drawing.Image)(resources.GetObject("Search.Image")));
            this.Search.Location = new System.Drawing.Point(517, 55);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(53, 49);
            this.Search.TabIndex = 38;
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(239, 61);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(255, 36);
            this.textBoxSearch.TabIndex = 37;
            // 
            // ImportToExcel
            // 
            this.ImportToExcel.Image = ((System.Drawing.Image)(resources.GetObject("ImportToExcel.Image")));
            this.ImportToExcel.Location = new System.Drawing.Point(82, 58);
            this.ImportToExcel.Name = "ImportToExcel";
            this.ImportToExcel.Size = new System.Drawing.Size(48, 39);
            this.ImportToExcel.TabIndex = 36;
            this.ImportToExcel.TabStop = false;
            this.ImportToExcel.Click += new System.EventHandler(this.ImportToExcel_Click);
            // 
            // ExportToExel
            // 
            this.ExportToExel.Image = ((System.Drawing.Image)(resources.GetObject("ExportToExel.Image")));
            this.ExportToExel.Location = new System.Drawing.Point(12, 58);
            this.ExportToExel.Name = "ExportToExel";
            this.ExportToExel.Size = new System.Drawing.Size(48, 39);
            this.ExportToExel.TabIndex = 35;
            this.ExportToExel.TabStop = false;
            this.ExportToExel.Click += new System.EventHandler(this.ExportToExel_Click);
            // 
            // dataGridViewAct
            // 
            this.dataGridViewAct.AutoGenerateColumns = false;
            this.dataGridViewAct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridViewAct.DataSource = this.actBindingSource;
            this.dataGridViewAct.Location = new System.Drawing.Point(12, 154);
            this.dataGridViewAct.Name = "dataGridViewAct";
            this.dataGridViewAct.RowHeadersVisible = false;
            this.dataGridViewAct.RowHeadersWidth = 51;
            this.dataGridViewAct.RowTemplate.Height = 24;
            this.dataGridViewAct.Size = new System.Drawing.Size(918, 370);
            this.dataGridViewAct.TabIndex = 34;
            this.dataGridViewAct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Act_CellContentClick);
            // 
            // actBindingSource
            // 
            this.actBindingSource.DataMember = "Act";
            this.actBindingSource.DataSource = this._OSS_BSSDataSet1;
            // 
            // _OSS_BSSDataSet1
            // 
            this._OSS_BSSDataSet1.DataSetName = "_OSS_BSSDataSet1";
            this._OSS_BSSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorAct
            // 
            this.bindingNavigatorAct.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorAct.BindingSource = this.actBindingSource;
            this.bindingNavigatorAct.CountItem = null;
            this.bindingNavigatorAct.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorAct.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorAct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.SaveToolStripButton});
            this.bindingNavigatorAct.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorAct.MoveFirstItem = null;
            this.bindingNavigatorAct.MoveLastItem = null;
            this.bindingNavigatorAct.MoveNextItem = null;
            this.bindingNavigatorAct.MovePreviousItem = null;
            this.bindingNavigatorAct.Name = "bindingNavigatorAct";
            this.bindingNavigatorAct.PositionItem = null;
            this.bindingNavigatorAct.Size = new System.Drawing.Size(942, 27);
            this.bindingNavigatorAct.TabIndex = 39;
            this.bindingNavigatorAct.Text = "bindingNavigator1";
            this.bindingNavigatorAct.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // SaveToolStripButton
            // 
            this.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripButton.Image")));
            this.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripButton.Name = "SaveToolStripButton";
            this.SaveToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.SaveToolStripButton.Text = "&Сохранить";
            this.SaveToolStripButton.Click += new System.EventHandler(this.SaveToolStripButton_Click);
            // 
            // actTableAdapter
            // 
            this.actTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActTableAdapter = this.actTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.ReceiptOrderTableAdapter = null;
            this.tableAdapterManager.SalesInvoiceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OSS_BSS_system._OSS_BSSDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // Act
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 536);
            this.Controls.Add(this.bindingNavigatorAct);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.ImportToExcel);
            this.Controls.Add(this.ExportToExel);
            this.Controls.Add(this.dataGridViewAct);
            this.Name = "Act";
            this.Text = "Акты о списании";
            this.Load += new System.EventHandler(this.Act_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImportToExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportToExel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._OSS_BSSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorAct)).EndInit();
            this.bindingNavigatorAct.ResumeLayout(false);
            this.bindingNavigatorAct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.PictureBox ImportToExcel;
        private System.Windows.Forms.PictureBox ExportToExel;
        private System.Windows.Forms.DataGridView dataGridViewAct;
        private System.Windows.Forms.BindingNavigator bindingNavigatorAct;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton SaveToolStripButton;
        private _OSS_BSSDataSet1 _OSS_BSSDataSet1;
        private System.Windows.Forms.BindingSource actBindingSource;
        private _OSS_BSSDataSet1TableAdapters.ActTableAdapter actTableAdapter;
        private _OSS_BSSDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}