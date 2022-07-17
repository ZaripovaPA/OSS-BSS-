namespace OSS_BSS_system
{
    partial class Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.ButtonSearchInvoice = new System.Windows.Forms.Button();
            this.TextBoxSearchInvoice = new System.Windows.Forms.TextBox();
            this.ImportToExcel = new System.Windows.Forms.PictureBox();
            this.ExportToExcel = new System.Windows.Forms.PictureBox();
            this.DataGridViewInvoice = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._OSS_BSSDataSet1 = new OSS_BSS_system._OSS_BSSDataSet1();
            this.BindingNavigatorInvoice = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.invoiceTableAdapter = new OSS_BSS_system._OSS_BSSDataSet1TableAdapters.InvoiceTableAdapter();
            this.tableAdapterManager = new OSS_BSS_system._OSS_BSSDataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.ImportToExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportToExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._OSS_BSSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorInvoice)).BeginInit();
            this.BindingNavigatorInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonSearchInvoice
            // 
            this.ButtonSearchInvoice.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSearchInvoice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonSearchInvoice.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSearchInvoice.Image")));
            this.ButtonSearchInvoice.Location = new System.Drawing.Point(517, 55);
            this.ButtonSearchInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSearchInvoice.Name = "ButtonSearchInvoice";
            this.ButtonSearchInvoice.Size = new System.Drawing.Size(53, 49);
            this.ButtonSearchInvoice.TabIndex = 33;
            this.ButtonSearchInvoice.UseVisualStyleBackColor = false;
            this.ButtonSearchInvoice.Click += new System.EventHandler(this.ButtonSearchInvoice_Click_1);
            // 
            // TextBoxSearchInvoice
            // 
            this.TextBoxSearchInvoice.Location = new System.Drawing.Point(239, 61);
            this.TextBoxSearchInvoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxSearchInvoice.Multiline = true;
            this.TextBoxSearchInvoice.Name = "TextBoxSearchInvoice";
            this.TextBoxSearchInvoice.Size = new System.Drawing.Size(255, 36);
            this.TextBoxSearchInvoice.TabIndex = 32;
            // 
            // ImportToExcel
            // 
            this.ImportToExcel.Image = ((System.Drawing.Image)(resources.GetObject("ImportToExcel.Image")));
            this.ImportToExcel.Location = new System.Drawing.Point(82, 58);
            this.ImportToExcel.Name = "ImportToExcel";
            this.ImportToExcel.Size = new System.Drawing.Size(48, 39);
            this.ImportToExcel.TabIndex = 31;
            this.ImportToExcel.TabStop = false;
            this.ImportToExcel.Click += new System.EventHandler(this.ImportToExcel_Click_1);
            // 
            // ExportToExcel
            // 
            this.ExportToExcel.Image = ((System.Drawing.Image)(resources.GetObject("ExportToExcel.Image")));
            this.ExportToExcel.Location = new System.Drawing.Point(12, 58);
            this.ExportToExcel.Name = "ExportToExcel";
            this.ExportToExcel.Size = new System.Drawing.Size(48, 39);
            this.ExportToExcel.TabIndex = 30;
            this.ExportToExcel.TabStop = false;
            this.ExportToExcel.Click += new System.EventHandler(this.ExportToExcel_Click_1);
            // 
            // DataGridViewInvoice
            // 
            this.DataGridViewInvoice.AutoGenerateColumns = false;
            this.DataGridViewInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.sumDataGridViewTextBoxColumn});
            this.DataGridViewInvoice.DataSource = this.invoiceBindingSource;
            this.DataGridViewInvoice.Location = new System.Drawing.Point(12, 154);
            this.DataGridViewInvoice.Name = "DataGridViewInvoice";
            this.DataGridViewInvoice.RowHeadersVisible = false;
            this.DataGridViewInvoice.RowHeadersWidth = 51;
            this.DataGridViewInvoice.RowTemplate.Height = 24;
            this.DataGridViewInvoice.Size = new System.Drawing.Size(918, 370);
            this.DataGridViewInvoice.TabIndex = 29;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Номенклатурный номер";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
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
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this._OSS_BSSDataSet1;
            // 
            // _OSS_BSSDataSet1
            // 
            this._OSS_BSSDataSet1.DataSetName = "_OSS_BSSDataSet1";
            this._OSS_BSSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BindingNavigatorInvoice
            // 
            this.BindingNavigatorInvoice.AddNewItem = this.bindingNavigatorAddNewItem;
            this.BindingNavigatorInvoice.BindingSource = this.invoiceBindingSource;
            this.BindingNavigatorInvoice.CountItem = null;
            this.BindingNavigatorInvoice.DeleteItem = this.bindingNavigatorDeleteItem;
            this.BindingNavigatorInvoice.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BindingNavigatorInvoice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.SaveToolStripButton});
            this.BindingNavigatorInvoice.Location = new System.Drawing.Point(0, 0);
            this.BindingNavigatorInvoice.MoveFirstItem = null;
            this.BindingNavigatorInvoice.MoveLastItem = null;
            this.BindingNavigatorInvoice.MoveNextItem = null;
            this.BindingNavigatorInvoice.MovePreviousItem = null;
            this.BindingNavigatorInvoice.Name = "BindingNavigatorInvoice";
            this.BindingNavigatorInvoice.PositionItem = null;
            this.BindingNavigatorInvoice.Size = new System.Drawing.Size(942, 27);
            this.BindingNavigatorInvoice.TabIndex = 34;
            this.BindingNavigatorInvoice.Text = "bindingNavigator1";
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
            this.SaveToolStripButton.Click += new System.EventHandler(this.SaveToolStripButton_Click_1);
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InvoiceTableAdapter = this.invoiceTableAdapter;
            this.tableAdapterManager.ReceiptOrderTableAdapter = null;
            this.tableAdapterManager.SalesInvoiceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OSS_BSS_system._OSS_BSSDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 536);
            this.Controls.Add(this.BindingNavigatorInvoice);
            this.Controls.Add(this.ButtonSearchInvoice);
            this.Controls.Add(this.TextBoxSearchInvoice);
            this.Controls.Add(this.ImportToExcel);
            this.Controls.Add(this.ExportToExcel);
            this.Controls.Add(this.DataGridViewInvoice);
            this.Name = "Invoice";
            this.Text = "Накладные";
            this.Load += new System.EventHandler(this.Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImportToExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportToExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._OSS_BSSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorInvoice)).EndInit();
            this.BindingNavigatorInvoice.ResumeLayout(false);
            this.BindingNavigatorInvoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSearchInvoice;
        private System.Windows.Forms.TextBox TextBoxSearchInvoice;
        private System.Windows.Forms.PictureBox ImportToExcel;
        private System.Windows.Forms.PictureBox ExportToExcel;
        private System.Windows.Forms.DataGridView DataGridViewInvoice;
        private System.Windows.Forms.BindingNavigator BindingNavigatorInvoice;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton SaveToolStripButton;
        private _OSS_BSSDataSet1 _OSS_BSSDataSet1;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private _OSS_BSSDataSet1TableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private _OSS_BSSDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
    }
}