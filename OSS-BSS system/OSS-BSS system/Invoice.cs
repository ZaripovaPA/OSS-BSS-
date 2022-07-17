using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelObj = Microsoft.Office.Interop.Excel;
using System.Reflection;


namespace OSS_BSS_system
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void ExportToExcel_Click_1(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < DataGridViewInvoice.Rows.Count; i++)
            {
                for (int j = 0; j < DataGridViewInvoice.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = DataGridViewInvoice.Rows[i].Cells[j].Value;
                }
            }
            //Вызываем созданный файл Excel
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;

        }

        private void ImportToExcel_Click_1(object sender, EventArgs e)
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

                    DataGridViewInvoice.Rows.Clear();
                    DataGridViewInvoice.Columns.Clear();
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

                    DataGridViewInvoice.DataSource = dt;
                    app.Quit();
                }

                int count = 0;
                for (int row = 0; row < DataGridViewInvoice.RowCount; row++)
                {
                    count++;
                    if (DataGridViewInvoice.Rows[row].Cells[0].Value == null)
                    {
                        DataGridViewInvoice.Rows[row].Cells[0].Value = Convert.ToString(count);
                    }
                }
            }
            catch
            {

            }
        }

        private void ButtonSearchInvoice_Click_1(object sender, EventArgs e) //функция поиска в таблице DataGridViewInvoice
        {
            for (int i = 0; i < DataGridViewInvoice.RowCount; i++)
            {
                DataGridViewInvoice.Rows[i].Selected = false;
                for (int j = 0; j < DataGridViewInvoice.ColumnCount; j++)
                    if (DataGridViewInvoice.Rows[i].Cells[j].Value != null)
                        if (DataGridViewInvoice.Rows[i].Cells[j].Value.ToString().Contains(TextBoxSearchInvoice.Text))
                        {
                            DataGridViewInvoice.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void SaveToolStripButton_Click_1(object sender, EventArgs e)
        {
            this.invoiceTableAdapter.Update(this._OSS_BSSDataSet1.Invoice);
            this._OSS_BSSDataSet1.AcceptChanges();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_OSS_BSSDataSet1.Invoice". При необходимости она может быть перемещена или удалена.
            this.invoiceTableAdapter.Fill(this._OSS_BSSDataSet1.Invoice);
        }
    }
}
