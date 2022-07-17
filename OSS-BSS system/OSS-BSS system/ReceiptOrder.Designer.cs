namespace OSS_BSS_system
{
    partial class ReceiptOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptOrder));
            this.dataGridViewReceiptOrder = new System.Windows.Forms.DataGridView();
            this.personnelNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._OSS_BSSDataSet1 = new OSS_BSS_system._OSS_BSSDataSet1();
            this.tableAdapterManager = new OSS_BSS_system._OSS_BSSDataSet1TableAdapters.TableAdapterManager();
            this.receiptOrderTableAdapter = new OSS_BSS_system._OSS_BSSDataSet1TableAdapters.ReceiptOrderTableAdapter();
            this.ImportToExcel = new System.Windows.Forms.PictureBox();
            this.ExportToExcel = new System.Windows.Forms.PictureBox();
            this.bindingNavigatorReceiptOrder = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.buttonSearchReceiptOrder = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceiptOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._OSS_BSSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportToExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportToExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorReceiptOrder)).BeginInit();
            this.bindingNavigatorReceiptOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewReceiptOrder
            // 
            this.dataGridViewReceiptOrder.AutoGenerateColumns = false;
            this.dataGridViewReceiptOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReceiptOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceiptOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personnelNumberDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn,
            this.recipientDataGridViewTextBoxColumn});
            this.dataGridViewReceiptOrder.DataSource = this.receiptOrderBindingSource;
            this.dataGridViewReceiptOrder.Location = new System.Drawing.Point(1, 137);
            this.dataGridViewReceiptOrder.Name = "dataGridViewReceiptOrder";
            this.dataGridViewReceiptOrder.RowHeadersVisible = false;
            this.dataGridViewReceiptOrder.RowHeadersWidth = 51;
            this.dataGridViewReceiptOrder.RowTemplate.Height = 24;
            this.dataGridViewReceiptOrder.Size = new System.Drawing.Size(929, 370);
            this.dataGridViewReceiptOrder.TabIndex = 0;
            // 
            // personnelNumberDataGridViewTextBoxColumn
            // 
            this.personnelNumberDataGridViewTextBoxColumn.DataPropertyName = "PersonnelNumber";
            this.personnelNumberDataGridViewTextBoxColumn.HeaderText = "Табельный номер";
            this.personnelNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personnelNumberDataGridViewTextBoxColumn.Name = "personnelNumberDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.supplierDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            // 
            // recipientDataGridViewTextBoxColumn
            // 
            this.recipientDataGridViewTextBoxColumn.DataPropertyName = "Recipient";
            this.recipientDataGridViewTextBoxColumn.HeaderText = "Принял";
            this.recipientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.recipientDataGridViewTextBoxColumn.Name = "recipientDataGridViewTextBoxColumn";
            // 
            // receiptOrderBindingSource
            // 
            this.receiptOrderBindingSource.DataMember = "ReceiptOrder";
            this.receiptOrderBindingSource.DataSource = this._OSS_BSSDataSet1;
            // 
            // _OSS_BSSDataSet1
            // 
            this._OSS_BSSDataSet1.DataSetName = "_OSS_BSSDataSet1";
            this._OSS_BSSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.ReceiptOrderTableAdapter = this.receiptOrderTableAdapter;
            this.tableAdapterManager.SalesInvoiceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OSS_BSS_system._OSS_BSSDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // receiptOrderTableAdapter
            // 
            this.receiptOrderTableAdapter.ClearBeforeFill = true;
            // 
            // ImportToExcel
            // 
            this.ImportToExcel.Image = ((System.Drawing.Image)(resources.GetObject("ImportToExcel.Image")));
            this.ImportToExcel.Location = new System.Drawing.Point(83, 41);
            this.ImportToExcel.Name = "ImportToExcel";
            this.ImportToExcel.Size = new System.Drawing.Size(48, 39);
            this.ImportToExcel.TabIndex = 24;
            this.ImportToExcel.TabStop = false;
            this.ImportToExcel.Click += new System.EventHandler(this.ImportToExcel_Click);
            // 
            // ExportToExcel
            // 
            this.ExportToExcel.Image = ((System.Drawing.Image)(resources.GetObject("ExportToExcel.Image")));
            this.ExportToExcel.Location = new System.Drawing.Point(13, 41);
            this.ExportToExcel.Name = "ExportToExcel";
            this.ExportToExcel.Size = new System.Drawing.Size(48, 39);
            this.ExportToExcel.TabIndex = 23;
            this.ExportToExcel.TabStop = false;
            this.ExportToExcel.Click += new System.EventHandler(this.ExportToExcel_Click);
            // 
            // bindingNavigatorReceiptOrder
            // 
            this.bindingNavigatorReceiptOrder.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorReceiptOrder.BindingSource = this.receiptOrderBindingSource;
            this.bindingNavigatorReceiptOrder.CountItem = null;
            this.bindingNavigatorReceiptOrder.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorReceiptOrder.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorReceiptOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.SaveToolStripButton});
            this.bindingNavigatorReceiptOrder.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorReceiptOrder.MoveFirstItem = null;
            this.bindingNavigatorReceiptOrder.MoveLastItem = null;
            this.bindingNavigatorReceiptOrder.MoveNextItem = null;
            this.bindingNavigatorReceiptOrder.MovePreviousItem = null;
            this.bindingNavigatorReceiptOrder.Name = "bindingNavigatorReceiptOrder";
            this.bindingNavigatorReceiptOrder.PositionItem = null;
            this.bindingNavigatorReceiptOrder.Size = new System.Drawing.Size(942, 27);
            this.bindingNavigatorReceiptOrder.TabIndex = 26;
            this.bindingNavigatorReceiptOrder.Text = "bindingNavigator1";
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
            // buttonSearchReceiptOrder
            // 
            this.buttonSearchReceiptOrder.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearchReceiptOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSearchReceiptOrder.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearchReceiptOrder.Image")));
            this.buttonSearchReceiptOrder.Location = new System.Drawing.Point(506, 38);
            this.buttonSearchReceiptOrder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearchReceiptOrder.Name = "buttonSearchReceiptOrder";
            this.buttonSearchReceiptOrder.Size = new System.Drawing.Size(53, 49);
            this.buttonSearchReceiptOrder.TabIndex = 28;
            this.buttonSearchReceiptOrder.UseVisualStyleBackColor = false;
            this.buttonSearchReceiptOrder.Click += new System.EventHandler(this.buttonSearchReceiptOrder_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(228, 44);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(255, 36);
            this.textBoxSearch.TabIndex = 27;
            // 
            // ReceiptOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 536);
            this.Controls.Add(this.buttonSearchReceiptOrder);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.bindingNavigatorReceiptOrder);
            this.Controls.Add(this.ImportToExcel);
            this.Controls.Add(this.ExportToExcel);
            this.Controls.Add(this.dataGridViewReceiptOrder);
            this.Name = "ReceiptOrder";
            this.Text = "Приходный ордер";
            this.Load += new System.EventHandler(this.ReceiptOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceiptOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._OSS_BSSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportToExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportToExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorReceiptOrder)).EndInit();
            this.bindingNavigatorReceiptOrder.ResumeLayout(false);
            this.bindingNavigatorReceiptOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReceiptOrder;
        private _OSS_BSSDataSet1 _OSS_BSSDataSet1;
        private _OSS_BSSDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox ImportToExcel;
        private System.Windows.Forms.PictureBox ExportToExcel;
        private _OSS_BSSDataSet1TableAdapters.ReceiptOrderTableAdapter receiptOrderTableAdapter;
        private System.Windows.Forms.BindingSource receiptOrderBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigatorReceiptOrder;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton SaveToolStripButton;
        private System.Windows.Forms.Button buttonSearchReceiptOrder;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipientDataGridViewTextBoxColumn;
    }
}