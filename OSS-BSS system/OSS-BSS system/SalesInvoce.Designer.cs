namespace OSS_BSS_system
{
    partial class SalesInvoce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesInvoce));
            this.buttonSalesInvoice = new System.Windows.Forms.Button();
            this.textBoxSalesInvoice = new System.Windows.Forms.TextBox();
            this.ImportToExcel = new System.Windows.Forms.PictureBox();
            this.ExportToExcel = new System.Windows.Forms.PictureBox();
            this.dataGridViewSalesinvoice = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfEquipmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._OSS_BSSDataSet1 = new OSS_BSS_system._OSS_BSSDataSet1();
            this.bindingNavigatorSalesInvoice = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.salesInvoiceTableAdapter = new OSS_BSS_system._OSS_BSSDataSet1TableAdapters.SalesInvoiceTableAdapter();
            this.tableAdapterManager = new OSS_BSS_system._OSS_BSSDataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.ImportToExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportToExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesinvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._OSS_BSSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorSalesInvoice)).BeginInit();
            this.bindingNavigatorSalesInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSalesInvoice
            // 
            this.buttonSalesInvoice.BackColor = System.Drawing.Color.Transparent;
            this.buttonSalesInvoice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSalesInvoice.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalesInvoice.Image")));
            this.buttonSalesInvoice.Location = new System.Drawing.Point(517, 55);
            this.buttonSalesInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSalesInvoice.Name = "buttonSalesInvoice";
            this.buttonSalesInvoice.Size = new System.Drawing.Size(53, 49);
            this.buttonSalesInvoice.TabIndex = 43;
            this.buttonSalesInvoice.UseVisualStyleBackColor = false;
            this.buttonSalesInvoice.Click += new System.EventHandler(this.buttonSalesInvoice_Click);
            // 
            // textBoxSalesInvoice
            // 
            this.textBoxSalesInvoice.Location = new System.Drawing.Point(239, 61);
            this.textBoxSalesInvoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSalesInvoice.Multiline = true;
            this.textBoxSalesInvoice.Name = "textBoxSalesInvoice";
            this.textBoxSalesInvoice.Size = new System.Drawing.Size(255, 36);
            this.textBoxSalesInvoice.TabIndex = 42;
            // 
            // ImportToExcel
            // 
            this.ImportToExcel.Image = ((System.Drawing.Image)(resources.GetObject("ImportToExcel.Image")));
            this.ImportToExcel.Location = new System.Drawing.Point(82, 58);
            this.ImportToExcel.Name = "ImportToExcel";
            this.ImportToExcel.Size = new System.Drawing.Size(48, 39);
            this.ImportToExcel.TabIndex = 41;
            this.ImportToExcel.TabStop = false;
            this.ImportToExcel.Click += new System.EventHandler(this.ImportToExcel_Click);
            // 
            // ExportToExcel
            // 
            this.ExportToExcel.Image = ((System.Drawing.Image)(resources.GetObject("ExportToExcel.Image")));
            this.ExportToExcel.Location = new System.Drawing.Point(12, 58);
            this.ExportToExcel.Name = "ExportToExcel";
            this.ExportToExcel.Size = new System.Drawing.Size(48, 39);
            this.ExportToExcel.TabIndex = 40;
            this.ExportToExcel.TabStop = false;
            this.ExportToExcel.Click += new System.EventHandler(this.ExportToExcel_Click);
            // 
            // dataGridViewSalesinvoice
            // 
            this.dataGridViewSalesinvoice.AutoGenerateColumns = false;
            this.dataGridViewSalesinvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSalesinvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalesinvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.consumerDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn,
            this.typeOfEquipmentDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.sumDataGridViewTextBoxColumn});
            this.dataGridViewSalesinvoice.DataSource = this.salesInvoiceBindingSource;
            this.dataGridViewSalesinvoice.Location = new System.Drawing.Point(12, 154);
            this.dataGridViewSalesinvoice.Name = "dataGridViewSalesinvoice";
            this.dataGridViewSalesinvoice.RowHeadersVisible = false;
            this.dataGridViewSalesinvoice.RowHeadersWidth = 51;
            this.dataGridViewSalesinvoice.RowTemplate.Height = 24;
            this.dataGridViewSalesinvoice.Size = new System.Drawing.Size(918, 370);
            this.dataGridViewSalesinvoice.TabIndex = 39;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Номенклатурный номер";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // consumerDataGridViewTextBoxColumn
            // 
            this.consumerDataGridViewTextBoxColumn.DataPropertyName = "Consumer";
            this.consumerDataGridViewTextBoxColumn.HeaderText = "Потребитель";
            this.consumerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.consumerDataGridViewTextBoxColumn.Name = "consumerDataGridViewTextBoxColumn";
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.supplierDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            // 
            // typeOfEquipmentDataGridViewTextBoxColumn
            // 
            this.typeOfEquipmentDataGridViewTextBoxColumn.DataPropertyName = "TypeOfEquipment";
            this.typeOfEquipmentDataGridViewTextBoxColumn.HeaderText = "Тип оборудования";
            this.typeOfEquipmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeOfEquipmentDataGridViewTextBoxColumn.Name = "typeOfEquipmentDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // sumDataGridViewTextBoxColumn
            // 
            this.sumDataGridViewTextBoxColumn.DataPropertyName = "Sum";
            this.sumDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.sumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
            // 
            // salesInvoiceBindingSource
            // 
            this.salesInvoiceBindingSource.DataMember = "SalesInvoice";
            this.salesInvoiceBindingSource.DataSource = this._OSS_BSSDataSet1;
            // 
            // _OSS_BSSDataSet1
            // 
            this._OSS_BSSDataSet1.DataSetName = "_OSS_BSSDataSet1";
            this._OSS_BSSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorSalesInvoice
            // 
            this.bindingNavigatorSalesInvoice.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorSalesInvoice.BindingSource = this.salesInvoiceBindingSource;
            this.bindingNavigatorSalesInvoice.CountItem = null;
            this.bindingNavigatorSalesInvoice.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorSalesInvoice.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorSalesInvoice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.SaveToolStripButton});
            this.bindingNavigatorSalesInvoice.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorSalesInvoice.MoveFirstItem = null;
            this.bindingNavigatorSalesInvoice.MoveLastItem = null;
            this.bindingNavigatorSalesInvoice.MoveNextItem = null;
            this.bindingNavigatorSalesInvoice.MovePreviousItem = null;
            this.bindingNavigatorSalesInvoice.Name = "bindingNavigatorSalesInvoice";
            this.bindingNavigatorSalesInvoice.PositionItem = null;
            this.bindingNavigatorSalesInvoice.Size = new System.Drawing.Size(942, 27);
            this.bindingNavigatorSalesInvoice.TabIndex = 44;
            this.bindingNavigatorSalesInvoice.Text = "bindingNavigator1";
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
            // salesInvoiceTableAdapter
            // 
            this.salesInvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.ReceiptOrderTableAdapter = null;
            this.tableAdapterManager.SalesInvoiceTableAdapter = this.salesInvoiceTableAdapter;
            this.tableAdapterManager.UpdateOrder = OSS_BSS_system._OSS_BSSDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // SalesInvoce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 536);
            this.Controls.Add(this.bindingNavigatorSalesInvoice);
            this.Controls.Add(this.buttonSalesInvoice);
            this.Controls.Add(this.textBoxSalesInvoice);
            this.Controls.Add(this.ImportToExcel);
            this.Controls.Add(this.ExportToExcel);
            this.Controls.Add(this.dataGridViewSalesinvoice);
            this.Name = "SalesInvoce";
            this.Text = "Расходные накладные";
            this.Load += new System.EventHandler(this.SalesInvoce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImportToExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportToExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesinvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._OSS_BSSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorSalesInvoice)).EndInit();
            this.bindingNavigatorSalesInvoice.ResumeLayout(false);
            this.bindingNavigatorSalesInvoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSalesInvoice;
        private System.Windows.Forms.TextBox textBoxSalesInvoice;
        private System.Windows.Forms.PictureBox ImportToExcel;
        private System.Windows.Forms.PictureBox ExportToExcel;
        private System.Windows.Forms.DataGridView dataGridViewSalesinvoice;
        private System.Windows.Forms.BindingNavigator bindingNavigatorSalesInvoice;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton SaveToolStripButton;
        private _OSS_BSSDataSet1 _OSS_BSSDataSet1;
        private System.Windows.Forms.BindingSource salesInvoiceBindingSource;
        private _OSS_BSSDataSet1TableAdapters.SalesInvoiceTableAdapter salesInvoiceTableAdapter;
        private _OSS_BSSDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfEquipmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
    }
}