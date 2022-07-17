using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelObj = Microsoft.Office.Interop.Excel;
using PagedList;
using System.Reflection;
using System.Drawing.Printing;

namespace OSS_BSS_system
{
    public partial class ReceiptOrder : Form
    {
        
        public ReceiptOrder()
        {
            InitializeComponent();
        }

        private void ReceiptOrder_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_OSS_BSSDataSet1.ReceiptOrder". При необходимости она может быть перемещена или удалена.
            this.receiptOrderTableAdapter.Fill(this._OSS_BSSDataSet1.ReceiptOrder);
            

        }

        private void ExportToExcel_Click(object sender, EventArgs e) //экспорт таблицы в Excel
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < dataGridViewReceiptOrder.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewReceiptOrder.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = dataGridViewReceiptOrder.Rows[i].Cells[j].Value;
                }
            }
            //Вызываем созданный файл Excel
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;            
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            this.receiptOrderTableAdapter.Update(this._OSS_BSSDataSet1.ReceiptOrder);
            this._OSS_BSSDataSet1.AcceptChanges();
        }

        private void buttonSearchReceiptOrder_Click(object sender, EventArgs e) //функция поиска в таблице dataGridViewReceiptOrder
        {
            for(int i = 0; i < dataGridViewReceiptOrder.RowCount; i++)
            {
                dataGridViewReceiptOrder.Rows[i].Selected = false;
                for (int j = 0; j < dataGridViewReceiptOrder.ColumnCount; j++)
                    if (dataGridViewReceiptOrder.Rows[i].Cells[j].Value != null)
                        if (dataGridViewReceiptOrder.Rows[i].Cells[j].Value.ToString().Contains(textBoxSearch.Text))
                        {
                            dataGridViewReceiptOrder.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void ImportToExcel_Click(object sender, EventArgs e) //импорт данных в таблицу
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.DefaultExt = "*.xls;*.xlsx";
                ofd.Filter = "Выберите файл Excel для загрузки данных(*.xlsx)|*.xlsx";
                ofd.Title = "Выберите документ для загрузки данных";

                ExcelObj.Application app = new ExcelObj.Application();
                ExcelObj.Workbook workbook;
                ExcelObj.Worksheet NwSheet;
                ExcelObj.Range ShtRange;
                DataTable dt = new DataTable();
                if (ofd.ShowDialog() == DialogResult.OK)
                {

                    dataGridViewReceiptOrder.Rows.Clear();
                    dataGridViewReceiptOrder.Columns.Clear();
                    workbook = app.Workbooks.Open(ofd.FileName, Missing.Value,
                    Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                    Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                    Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                    Missing.Value);

                    NwSheet = (ExcelObj.Worksheet)workbook.Sheets.get_Item(1);
                    ShtRange = NwSheet.UsedRange;
                    for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                    {
                        dt.Columns.Add(
                        new DataColumn((ShtRange.Cells[1, Cnum] as ExcelObj.Range).Value2.ToString()));
                    }
                    dt.AcceptChanges();

                    string[] columnNames = new String[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        columnNames[0] = dt.Columns[i].ColumnName;
                    }

                    for (int Rnum = 2; Rnum <= ShtRange.Rows.Count; Rnum++)
                    {
                        DataRow dr = dt.NewRow();
                        for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                        {
                            if ((ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2 != null)
                            {
                                dr[Cnum - 1] =
                                (ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2.ToString();
                            }
                        }
                        dt.Rows.Add(dr);
                        dt.AcceptChanges();
                    }

                    dataGridViewReceiptOrder.DataSource = dt;
                    app.Quit();
                }

                int count = 0;
                for (int row = 0; row < dataGridViewReceiptOrder.RowCount; row++)
                {
                    count++;
                    if (dataGridViewReceiptOrder.Rows[row].Cells[0].Value == null)
                    {
                        dataGridViewReceiptOrder.Rows[row].Cells[0].Value = Convert.ToString(count);
                    }
                }
            }
            catch
            {

            }
        }
    }
}
