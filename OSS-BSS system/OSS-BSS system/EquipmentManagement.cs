using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;

namespace OSS_BSS_system
{
    public partial class EquipmentManagement : Form
    {
        public EquipmentManagement()
        {
            InitializeComponent();
        }

        private void EquipmentManagement_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_OSS_BSSDataSet2.Equipment". При необходимости она может быть перемещена или удалена.
            this.equipmentTableAdapter1.Fill(this._OSS_BSSDataSet2.Equipment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_OSS_BSSDataSet.Discount". При необходимости она может быть перемещена или удалена.
            this.discountTableAdapter.Fill(this._OSS_BSSDataSet.Discount);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_OSS_BSSDataSet.TypeOfEquipment". При необходимости она может быть перемещена или удалена.
            this.typeOfEquipmentTableAdapter.Fill(this._OSS_BSSDataSet.TypeOfEquipment);
            this.WindowState = FormWindowState.Maximized;
        }


        private void buttonSubscrEquipMan_Click(object sender, EventArgs e)
        {
            this.Close(); //закрытие активной формы
            Subscribers f2 = new Subscribers();
            f2.Show();
        }

        private void buttonEquipMan_Click(object sender, EventArgs e)
        {
            this.Close(); //закрытие активной формы
            EquipmentManagement f3 = new EquipmentManagement();
            f3.Show();
        }

        private void buttonAssetsEquipMan_Click(object sender, EventArgs e)
        {
            this.Close(); //закрытие активной формы
            Assets f5 = new Assets();
            f5.Show();
        }

        private void buttonSupportEquipMan_Click(object sender, EventArgs e)
        {
            this.Close(); //закрытие активной формы
            Support f4 = new Support();
            f4.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button14_Click(object sender, EventArgs e)
        {
        }

        private void ButtonSearchControl_Click(object sender, EventArgs e) //функция поиска в таблице dataGridViewControl
        {
            for (int i = 0; i < dataGridViewControl.RowCount; i++)
            {
                dataGridViewControl.Rows[i].Selected = false;
                for (int j = 0; j < dataGridViewControl.ColumnCount; j++)
                    if (dataGridViewControl.Rows[i].Cells[j].Value != null)
                        if (dataGridViewControl.Rows[i].Cells[j].Value.ToString().Contains(textBoxSearchControl.Text))
                        {
                            dataGridViewControl.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void equipmentBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void ButtonCatalogSearch_Click(object sender, EventArgs e) //функция поиска в таблице DataGridViewCatalog
        {
            for (int i = 0; i < DataGridViewCatalog.RowCount; i++)
            {
                DataGridViewCatalog.Rows[i].Selected = false;
                for (int j = 0; j < DataGridViewCatalog.ColumnCount; j++)
                    if (DataGridViewCatalog.Rows[i].Cells[j].Value != null)
                        if (DataGridViewCatalog.Rows[i].Cells[j].Value.ToString().Contains(TextBoxCatalogSearch.Text))
                        {
                            DataGridViewCatalog.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void ButtonSearchSklad_Click(object sender, EventArgs e) // функция поиска в таблице DataGridViewSklad
        {
            for (int i = 0; i < DataGridViewSklad.RowCount; i++)
            {
                DataGridViewSklad.Rows[i].Selected = false;
                for (int j = 0; j < DataGridViewSklad.ColumnCount; j++)
                    if (DataGridViewSklad.Rows[i].Cells[j].Value != null)
                        if (DataGridViewSklad.Rows[i].Cells[j].Value.ToString().Contains(TextBoxSearchSklad.Text))
                        {
                            DataGridViewSklad.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        //private void ButtonDiscount_Click(object sender, EventArgs e) //функция поиска в таблице DataGridViewDiscount
        //{
        //    for (int i = 0; i < DataGridViewDiscount.RowCount; i++)
        //    {
        //        DataGridViewDiscount.Rows[i].Selected = false;
        //        for (int j = 0; j < DataGridViewDiscount.ColumnCount; j++)
        //            if (DataGridViewDiscount.Rows[i].Cells[j].Value != null)
        //                if (DataGridViewDiscount.Rows[i].Cells[j].Value.ToString().Contains(TextBoxDiscount.Text))
        //                {
        //                    DataGridViewDiscount.Rows[i].Selected = true;
        //                    break;
        //                }
        //    }
        //}

        private void LogOut_Click(object sender, EventArgs e) //выход из системы
        {
            System.Windows.Forms.Application.Exit();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ButtonDiscount_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < DataGridViewDiscount.RowCount; i++)
            {
                DataGridViewDiscount.Rows[i].Selected = false;
                for (int j = 0; j < DataGridViewDiscount.ColumnCount; j++)
                    if (DataGridViewDiscount.Rows[i].Cells[j].Value != null)
                        if (DataGridViewDiscount.Rows[i].Cells[j].Value.ToString().Contains(TextBoxDiscount.Text))
                        {
                            DataGridViewDiscount.Rows[i].Selected = true;
                            break;
                        }
            }
        }


        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SaveEquipment_Click(object sender, EventArgs e)
        {
        }
        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void SaveToolStripButtonDisc_Click(object sender, EventArgs e)
        {
            discountTableAdapter.Update(_OSS_BSSDataSet.Discount);

        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ButtonControl_Click_1(object sender, EventArgs e) //контроль оборудования
        {
            foreach (DataGridViewRow Myrow in dataGridViewControl.Rows)
            {
                if (Convert.ToInt32(Myrow.Cells[3].Value) < 1)
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Red; //подсветить красным оборудование с неисправностями
                }
                else
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Green; //подсветить зеленым рабочее оборудование
                }
            }
        }

        private void buttonReceiptOrder_Click(object sender, EventArgs e)
        {
            ReceiptOrder a2 = new ReceiptOrder();
            a2.Show();
        }

        private void SaveToolStripButton1_Click(object sender, EventArgs e)
        {
            this.equipmentTableAdapter1.Update(this._OSS_BSSDataSet2.Equipment);
            this._OSS_BSSDataSet2.AcceptChanges();
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            this.discountTableAdapter.Update(this._OSS_BSSDataSet.Discount);
            this._OSS_BSSDataSet.AcceptChanges();
        }

        private void ButtonInvoice_Click(object sender, EventArgs e)
        {
            Invoice a4 = new Invoice();
            a4.Show();
        }

        private void ButtonAct_Click_1(object sender, EventArgs e)
        {
            Act a5 = new Act();
            a5.Show();
        }

        private void ButtonSalesInvoice_Click(object sender, EventArgs e)
        {
            SalesInvoce a6 = new SalesInvoce();
            a6.Show();
        }

        private void Zakupka_Click(object sender, EventArgs e)
        {
            //При нажатии на кнопку выделяются все нужные строки

            foreach (DataGridViewRow r in DataGridViewSklad.Rows)
                r.Selected = Convert.ToBoolean(r.Cells[3].Value);
            if (DataGridViewSklad.SelectedRows.Count != 0)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // создается новая книга  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // создается новый лист  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                              
                worksheet = workbook.ActiveSheet;
                // изменение имени листа 
                worksheet.Name = "Выгрузка данных для закупки";

                DataGridViewRow row = this.DataGridViewSklad.SelectedRows[0];
                

                // сохранение заголовков 
                for (int i = 1; i < DataGridViewSklad.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = DataGridViewSklad.Columns[i - 1].HeaderText;
                }

                int rowIndex = 2;
                foreach (DataGridViewRow r in DataGridViewSklad.SelectedRows)
                {
                    for (int j = 0; j < r.Cells.Count; j++)
                    {
                        worksheet.Cells[rowIndex, j + 1] = r.Cells[j].Value.ToString();
                    }

                    rowIndex++;
                }

                workbook.SaveAs("F:\\output.xls", Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing);                             
                app.Quit();
            }

        }
    }
}




