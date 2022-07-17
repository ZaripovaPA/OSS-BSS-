
namespace OSS_BSS_system
{
    partial class Subscribers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subscribers));
            this.RectangleMenu = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.ButtonSubscr = new System.Windows.Forms.Button();
            this.ButtonEquipMan = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.ButtonAssets = new System.Windows.Forms.Button();
            this.ButtonSupport = new System.Windows.Forms.Button();
            this.SubscrHeader = new System.Windows.Forms.Label();
            this.LlabelSearchSubscr = new System.Windows.Forms.Label();
            this.label_Event = new System.Windows.Forms.Label();
            this.dataGridViewEvent = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._OSS_BSSDataSet = new OSS_BSS_system._OSS_BSSDataSet();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DataGridViewSubscr = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.TextBoxSearchSubscr = new System.Windows.Forms.TextBox();
            this.ButtonSearchSubscr = new System.Windows.Forms.Button();
            this.customerTableAdapter = new OSS_BSS_system._OSS_BSSDataSetTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new OSS_BSS_system._OSS_BSSDataSetTableAdapters.TableAdapterManager();
            this.eventTableAdapter = new OSS_BSS_system._OSS_BSSDataSetTableAdapters.EventTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RectangleMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._OSS_BSSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSubscr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // RectangleMenu
            // 
            this.RectangleMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RectangleMenu.BackgroundImage")));
            this.RectangleMenu.Location = new System.Drawing.Point(1, 1);
            this.RectangleMenu.Margin = new System.Windows.Forms.Padding(4);
            this.RectangleMenu.Name = "RectangleMenu";
            this.RectangleMenu.Size = new System.Drawing.Size(149, 1036);
            this.RectangleMenu.TabIndex = 0;
            this.RectangleMenu.TabStop = false;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Red;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(15, 14);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(107, 100);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // ButtonSubscr
            // 
            this.ButtonSubscr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ButtonSubscr.Location = new System.Drawing.Point(1, 132);
            this.ButtonSubscr.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSubscr.Name = "ButtonSubscr";
            this.ButtonSubscr.Size = new System.Drawing.Size(149, 48);
            this.ButtonSubscr.TabIndex = 3;
            this.ButtonSubscr.Text = "Абоненты";
            this.ButtonSubscr.UseVisualStyleBackColor = true;
            this.ButtonSubscr.Click += new System.EventHandler(this.ButtonSubscr_Click);
            // 
            // ButtonEquipMan
            // 
            this.ButtonEquipMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ButtonEquipMan.Location = new System.Drawing.Point(1, 187);
            this.ButtonEquipMan.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonEquipMan.Name = "ButtonEquipMan";
            this.ButtonEquipMan.Size = new System.Drawing.Size(149, 48);
            this.ButtonEquipMan.TabIndex = 5;
            this.ButtonEquipMan.Text = "Управление оборудованием";
            this.ButtonEquipMan.UseVisualStyleBackColor = true;
            this.ButtonEquipMan.Click += new System.EventHandler(this.ButtonEquipMan_Click);
            // 
            // LogOut
            // 
            this.LogOut.Image = ((System.Drawing.Image)(resources.GetObject("LogOut.Image")));
            this.LogOut.Location = new System.Drawing.Point(29, 886);
            this.LogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(69, 66);
            this.LogOut.TabIndex = 11;
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // ButtonAssets
            // 
            this.ButtonAssets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ButtonAssets.Location = new System.Drawing.Point(1, 242);
            this.ButtonAssets.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAssets.Name = "ButtonAssets";
            this.ButtonAssets.Size = new System.Drawing.Size(149, 48);
            this.ButtonAssets.TabIndex = 12;
            this.ButtonAssets.Text = "Активы";
            this.ButtonAssets.UseVisualStyleBackColor = true;
            this.ButtonAssets.Click += new System.EventHandler(this.ButtonAssets_Click);
            // 
            // ButtonSupport
            // 
            this.ButtonSupport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ButtonSupport.Location = new System.Drawing.Point(1, 299);
            this.ButtonSupport.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSupport.Name = "ButtonSupport";
            this.ButtonSupport.Size = new System.Drawing.Size(149, 48);
            this.ButtonSupport.TabIndex = 13;
            this.ButtonSupport.Text = "Поддержка пользователей";
            this.ButtonSupport.UseVisualStyleBackColor = true;
            this.ButtonSupport.Click += new System.EventHandler(this.ButtonSupport_Click);
            // 
            // SubscrHeader
            // 
            this.SubscrHeader.AutoSize = true;
            this.SubscrHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.SubscrHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SubscrHeader.Location = new System.Drawing.Point(188, 43);
            this.SubscrHeader.Name = "SubscrHeader";
            this.SubscrHeader.Size = new System.Drawing.Size(271, 48);
            this.SubscrHeader.TabIndex = 14;
            this.SubscrHeader.Text = "АБОНЕНТЫ ";
            // 
            // LlabelSearchSubscr
            // 
            this.LlabelSearchSubscr.AutoSize = true;
            this.LlabelSearchSubscr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LlabelSearchSubscr.Location = new System.Drawing.Point(173, 130);
            this.LlabelSearchSubscr.Name = "LlabelSearchSubscr";
            this.LlabelSearchSubscr.Size = new System.Drawing.Size(166, 25);
            this.LlabelSearchSubscr.TabIndex = 15;
            this.LlabelSearchSubscr.Text = "Поиск абонента:";
            // 
            // label_Event
            // 
            this.label_Event.AutoSize = true;
            this.label_Event.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Event.Location = new System.Drawing.Point(1526, 142);
            this.label_Event.Name = "label_Event";
            this.label_Event.Size = new System.Drawing.Size(95, 25);
            this.label_Event.TabIndex = 18;
            this.label_Event.Text = "События";
            // 
            // dataGridViewEvent
            // 
            this.dataGridViewEvent.AutoGenerateColumns = false;
            this.dataGridViewEvent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewEvent.DataSource = this.eventBindingSource1;
            this.dataGridViewEvent.Location = new System.Drawing.Point(1347, 186);
            this.dataGridViewEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewEvent.Name = "dataGridViewEvent";
            this.dataGridViewEvent.RowHeadersVisible = false;
            this.dataGridViewEvent.RowHeadersWidth = 51;
            this.dataGridViewEvent.RowTemplate.Height = 24;
            this.dataGridViewEvent.Size = new System.Drawing.Size(465, 687);
            this.dataGridViewEvent.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NameEvent";
            this.dataGridViewTextBoxColumn3.HeaderText = "Наименование события";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // eventBindingSource1
            // 
            this.eventBindingSource1.DataMember = "Event";
            this.eventBindingSource1.DataSource = this._OSS_BSSDataSet;
            // 
            // _OSS_BSSDataSet
            // 
            this._OSS_BSSDataSet.DataSetName = "_OSS_BSSDataSet";
            this._OSS_BSSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataMember = "Event";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            // 
            // DataGridViewSubscr
            // 
            this.DataGridViewSubscr.AutoGenerateColumns = false;
            this.DataGridViewSubscr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewSubscr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewSubscr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.customerIdDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.ServiceId});
            this.DataGridViewSubscr.DataSource = this.customerBindingSource2;
            this.DataGridViewSubscr.Location = new System.Drawing.Point(176, 184);
            this.DataGridViewSubscr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridViewSubscr.Name = "DataGridViewSubscr";
            this.DataGridViewSubscr.RowHeadersVisible = false;
            this.DataGridViewSubscr.RowHeadersWidth = 51;
            this.DataGridViewSubscr.RowTemplate.Height = 24;
            this.DataGridViewSubscr.Size = new System.Drawing.Size(1141, 687);
            this.DataGridViewSubscr.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FIOCustomer";
            this.dataGridViewTextBoxColumn1.HeaderText = "ФИО клиента";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "Абонентский номер";
            this.customerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PersonalAccountCustom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Лицевой счет";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // ServiceId
            // 
            this.ServiceId.DataPropertyName = "ServiceId";
            this.ServiceId.HeaderText = "Услуги";
            this.ServiceId.MinimumWidth = 6;
            this.ServiceId.Name = "ServiceId";
            // 
            // customerBindingSource2
            // 
            this.customerBindingSource2.DataMember = "Customer";
            this.customerBindingSource2.DataSource = this._OSS_BSSDataSet;
            // 
            // TextBoxSearchSubscr
            // 
            this.TextBoxSearchSubscr.Location = new System.Drawing.Point(356, 133);
            this.TextBoxSearchSubscr.Name = "TextBoxSearchSubscr";
            this.TextBoxSearchSubscr.Size = new System.Drawing.Size(145, 22);
            this.TextBoxSearchSubscr.TabIndex = 21;
            // 
            // ButtonSearchSubscr
            // 
            this.ButtonSearchSubscr.BackColor = System.Drawing.Color.Orange;
            this.ButtonSearchSubscr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ButtonSearchSubscr.Location = new System.Drawing.Point(520, 127);
            this.ButtonSearchSubscr.Name = "ButtonSearchSubscr";
            this.ButtonSearchSubscr.Size = new System.Drawing.Size(84, 35);
            this.ButtonSearchSubscr.TabIndex = 22;
            this.ButtonSearchSubscr.Text = "Найти";
            this.ButtonSearchSubscr.UseVisualStyleBackColor = false;
            this.ButtonSearchSubscr.Click += new System.EventHandler(this.ButtonSearchSubscr_Click);
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApplicationStatusTableAdapter = null;
            this.tableAdapterManager.ApplicationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompletedApplicationTableAdapter = null;
            this.tableAdapterManager.ContractTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.DiscountTableAdapter = null;
            this.tableAdapterManager.EquipmentTableAdapter = null;
            this.tableAdapterManager.EventTableAdapter = this.eventTableAdapter;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.ProblemTableAdapter = null;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.ServiceTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.TariffTableAdapter = null;
            this.tableAdapterManager.TypeOfEquipmentTableAdapter = null;
            this.tableAdapterManager.TypeOfServiceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OSS_BSS_system._OSS_BSSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VidOfServiceTableAdapter = null;
            // 
            // eventTableAdapter
            // 
            this.eventTableAdapter.ClearBeforeFill = true;
            // 
            // Subscribers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.ButtonSearchSubscr);
            this.Controls.Add(this.TextBoxSearchSubscr);
            this.Controls.Add(this.DataGridViewSubscr);
            this.Controls.Add(this.dataGridViewEvent);
            this.Controls.Add(this.label_Event);
            this.Controls.Add(this.LlabelSearchSubscr);
            this.Controls.Add(this.SubscrHeader);
            this.Controls.Add(this.ButtonSupport);
            this.Controls.Add(this.ButtonAssets);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.ButtonEquipMan);
            this.Controls.Add(this.ButtonSubscr);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.RectangleMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Subscribers";
            this.Text = "Абоненты";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RectangleMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._OSS_BSSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSubscr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox RectangleMenu;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button ButtonSubscr;
        private System.Windows.Forms.Button ButtonEquipMan;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button ButtonAssets;
        private System.Windows.Forms.Button ButtonSupport;
        private System.Windows.Forms.Label SubscrHeader;
        private System.Windows.Forms.Label LlabelSearchSubscr;
        private System.Windows.Forms.Label label_Event;
        private System.Windows.Forms.DataGridView dataGridViewEvent;
        
        private System.Windows.Forms.BindingSource customerBindingSource;
        
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.DataGridView DataGridViewSubscr;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOCustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalAccountCustomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox TextBoxSearchSubscr;
        private System.Windows.Forms.Button ButtonSearchSubscr;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameEventDataGridViewTextBoxColumn;
        private _OSS_BSSDataSet _OSS_BSSDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource2;
        private _OSS_BSSDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private _OSS_BSSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private _OSS_BSSDataSetTableAdapters.EventTableAdapter eventTableAdapter;
        private System.Windows.Forms.BindingSource eventBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}