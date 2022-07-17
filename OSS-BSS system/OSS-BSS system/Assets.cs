using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;
using ExcelObj = Microsoft.Office.Interop.Excel;
using GemBox.Spreadsheet;

namespace OSS_BSS_system
{
    public partial class Assets : Form
    {
        public Assets()
        {
            InitializeComponent();
        }

        private void Assets_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_OSS_BSSDataSet2.Equipment". При необходимости она может быть перемещена или удалена.
            this.equipmentTableAdapter1.Fill(this._OSS_BSSDataSet2.Equipment);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "_OSS_BSSDataSet.TypeOfEquipment". При необходимости она может быть перемещена или удалена.
            this.typeOfEquipmentTableAdapter.Fill(this._OSS_BSSDataSet.TypeOfEquipment);
           
            this.WindowState = FormWindowState.Maximized;
        }

        private void SubscrButton_Click(object sender, EventArgs e) //открытие страницы "Абоненты"
        {
            this.Close(); //Закрытие активной формы
            Subscribers f2 = new Subscribers();
            f2.Show();
        }

        private void EquipmentManagementBut_Click(object sender, EventArgs e) //Открытие страницы "Управление оборудованием"
        {
            this.Close(); //Закрытие активной формы
            EquipmentManagement f3 = new EquipmentManagement();
            f3.Show();
        }

        private void ButtonAssets_Click(object sender, EventArgs e) //Открытие страницы "Активы"
        {
            this.Close(); //Закрытие активной формы
            Assets f5 = new Assets();
            f5.Show();
        }

        private void ButtonEquipmentManagement_Click(object sender, EventArgs e) //Открытие страницы "Активы"
        {
            this.Close(); //Закрытие активной формы
            Support f4 = new Support();
            f4.Show();
        }

        private void LogOut_Click(object sender, EventArgs e) //Выход из системы
        {
            System.Windows.Forms.Application.Exit(); 
        }

        private void button27_Click(object sender, EventArgs e)
        {
        }

        private void generateBtn_Click(object sender, EventArgs e) //Создать штрихкод (генерация)
        {
            String code = codeText.Text;
            try
            {
                Zen.Barcode.Code128BarcodeDraw barCode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                pbPhotoCanvas.Image = barCode.Draw(code, 60);
            }
            catch (Exception)
            {
            }
        }

        private void PrintBarcode_Click_1(object sender, EventArgs e) //Печать штрихкода
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();

            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }
        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(pbPhotoCanvas.Width, pbPhotoCanvas.Height);
            pbPhotoCanvas.DrawToBitmap(bm, new System.Drawing.Rectangle(0, 0, pbPhotoCanvas.Width, pbPhotoCanvas.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void SearchUchet_Click(object sender, EventArgs e) // Поиск в таблице "Учёт оборудования"
        {
            for (int i = 0; i < DataGridViewUchet.RowCount; i++)
            {
                DataGridViewUchet.Rows[i].Selected = false;
                for (int j = 0; j < DataGridViewUchet.ColumnCount; j++)
                    if (DataGridViewUchet.Rows[i].Cells[j].Value != null)
                        if (DataGridViewUchet.Rows[i].Cells[j].Value.ToString().Contains(TextBoxSearchUchet.Text))
                        {
                            DataGridViewUchet.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void SearchInform_Click(object sender, EventArgs e) //Поиск в таблице "Подробная информация по оборудованию"
        {
            for (int i = 0; i < DataGridViewPodrInf.RowCount; i++)
            {
                DataGridViewPodrInf.Rows[i].Selected = false;
                for (int j = 0; j < DataGridViewPodrInf.ColumnCount; j++)
                    if (DataGridViewPodrInf.Rows[i].Cells[j].Value != null)
                        if (DataGridViewPodrInf.Rows[i].Cells[j].Value.ToString().Contains(TextBoxSearchInfo.Text))
                        {
                            DataGridViewPodrInf.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void SearchButPaspAssets_Click(object sender, EventArgs e) //Поиск в таблице "Учет и паспортизация активов"
        {
            for (int i = 0; i < DataGridViewPaspAssets.RowCount; i++)
            {
                DataGridViewPaspAssets.Rows[i].Selected = false;
                for (int j = 0; j < DataGridViewPaspAssets.ColumnCount; j++)
                    if (DataGridViewPaspAssets.Rows[i].Cells[j].Value != null)
                        if (DataGridViewPaspAssets.Rows[i].Cells[j].Value.ToString().Contains(TextBoxSearchPaspAssets.Text))
                        {
                            DataGridViewPaspAssets.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        

        private void ButtonSearchInventory_Click(object sender, EventArgs e) //Поиск в таблице "Инвентаризация"
        {
            for (int i = 0; i < DataGridViewInventory.RowCount; i++)
            {
                DataGridViewInventory.Rows[i].Selected = false;
                for (int j = 0; j < DataGridViewInventory.ColumnCount; j++)
                    if (DataGridViewInventory.Rows[i].Cells[j].Value != null)
                        if (DataGridViewInventory.Rows[i].Cells[j].Value.ToString().Contains(SearchInventory.Text))
                        {
                            DataGridViewInventory.Rows[i].Selected = true;
                            break;
                        }
            }
        }

      


        private void ExportToCSV_Click(object sender, EventArgs e) //Выгрузка в csv "Учет оборудования"
        {
            string fileCSV = "";
            for (int i = 0; i < DataGridViewUchet.RowCount - 1; i++)
            {
                for (int j = 0; j < DataGridViewUchet.ColumnCount; j++)
                {
                    fileCSV += (DataGridViewUchet[j, i].Value) + ";";
                }
                fileCSV += "\t\n";
            }
            StreamWriter wr = new StreamWriter("Equipment accounting.csv", false, Encoding.GetEncoding("windows-1251"));
            wr.Write(fileCSV);
            wr.Close();
            

        }

        private void ExportToXLS_Click(object sender, EventArgs e) //выгрузка в Excel "Учет оборудования"
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < DataGridViewUchet.Rows.Count; i++)
            {
                for (int j = 0; j < DataGridViewUchet.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = DataGridViewUchet.Rows[i].Cells[j].Value;
                }
            }
            //Вызываем созданный файл Excel
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void ExportToPDF_Click(object sender, EventArgs e) //Выгрузка pdf "Учет оборудования"
        {
            //Создание таблицы iTextSharp из данных DataTable
            PdfPTable pdfTable = new PdfPTable(DataGridViewUchet.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Добавление строки заголовка
            foreach (DataGridViewColumn column in DataGridViewUchet.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTable.AddCell(cell);
            }

            int row = DataGridViewUchet.Rows.Count;
            int cell2 = DataGridViewUchet.Rows[1].Cells.Count;
            for (int i = 0; i < row - 1; i++)
            {
                for (int j = 0; j < cell2; j++)
                {
                    if (DataGridViewUchet.Rows[i].Cells[j].Value == null)
                    {
                     DataGridViewUchet.Rows[i].Cells[j].Value = "null";
                    }
                    pdfTable.AddCell(DataGridViewUchet.Rows[i].Cells[j].Value.ToString());
                }
            }

            //Экспорт в PDF
            string folderPath = @"F:\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "Equipment accounting.pdf", FileMode.Create))
            {
                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
            MessageBox.Show("Успешно!");
        }

        private void TzZakupka_Click(object sender, EventArgs e)
        {
            //При нажатии на кнопку выделяются все нужные строки

            foreach (DataGridViewRow r in DataGridViewUchet.Rows)
                r.Selected = Convert.ToBoolean(r.Cells[4].Value);
            if (DataGridViewUchet.SelectedRows.Count != 0)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // Книга  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // Лист  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                

                worksheet = workbook.ActiveSheet;
                // изменение названия листа  
                worksheet.Name = "Выгрузка данных для закупки";

                DataGridViewRow row = this.DataGridViewUchet.SelectedRows[0];
                
                for (int i = 1; i < DataGridViewUchet.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = DataGridViewUchet.Columns[i - 1].HeaderText;
                }

                int rowIndex = 2;
                foreach (DataGridViewRow r in DataGridViewUchet.SelectedRows)
                {
                    for (int j = 0; j < r.Cells.Count; j++)
                    {
                        worksheet.Cells[rowIndex, j + 1] = r.Cells[j].Value.ToString();
                    }

                    rowIndex++;
                }

                workbook.SaveAs("F:\\Output.xls", Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                // Exit from the application  
                app.Quit();
            }
        }

        private void ExportCSV_Click(object sender, EventArgs e) // Выгрузка в csv "Подробная информация по оборудованию"
        {
            string fileCSV = "";
            for (int i = 0; i < DataGridViewPodrInf.RowCount - 1; i++)
            {
                for (int j = 0; j < DataGridViewPodrInf.ColumnCount; j++)
                {
                    fileCSV += (DataGridViewPodrInf[j, i].Value) + ";";
                }
                fileCSV += "\t\n";
            }
            StreamWriter wr = new StreamWriter("Detailed information.csv", false, Encoding.GetEncoding("windows-1251"));
            wr.Write(fileCSV);
            wr.Close();
        }

        private void ExportXLS_Click(object sender, EventArgs e) //Выгрузить в Excel "Подробная информация по оборудованию"
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < DataGridViewPodrInf.Rows.Count; i++)
            {
                for (int j = 0; j < DataGridViewPodrInf.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = DataGridViewPodrInf.Rows[i].Cells[j].Value;
                }
            }
            //Вызываем созданный файл Excel
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void ExportPDF_Click(object sender, EventArgs e) //Выгрузить в pdf "Побробная информация по оборудованию"
        {
            //Создание таблицы iTextSharp из данных DataTable
            PdfPTable pdfTable = new PdfPTable(DataGridViewPodrInf.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Добавление строки заголовка
            foreach (DataGridViewColumn column in DataGridViewPodrInf.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTable.AddCell(cell);
            }

            int row = DataGridViewPodrInf.Rows.Count;
            int cell2 = DataGridViewPodrInf.Rows[1].Cells.Count;
            for (int i = 0; i < row - 1; i++)
            {
                for (int j = 0; j < cell2; j++)
                {
                    if (DataGridViewPodrInf.Rows[i].Cells[j].Value == null)
                    {

                        DataGridViewPodrInf.Rows[i].Cells[j].Value = "null";
                    }
                    pdfTable.AddCell(DataGridViewPodrInf.Rows[i].Cells[j].Value.ToString());
                }
            }

            //Экспорт в PDF
            string folderPath = @"F:\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "Detailed information.pdf", FileMode.Create))
            {
                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
            MessageBox.Show("Успешно!");
        }


        private readonly string TemplateFileNameexl = @"F:\\Диплом\\Последний вариант\\Itog\\OSS-BSS system\\Inventory.xlsx";
        private void ButtonIzlNed_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Open(TemplateFileNameexl);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < DataGridViewInventory.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = DataGridViewInventory.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < DataGridViewInventory.Rows.Count - 1; i++)
            {
                for (int j = 0; j < DataGridViewInventory.Columns.Count; j++)
                {
                    if (DataGridViewInventory.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = DataGridViewInventory.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
            

        }

        private void textBox_search_uchet_TextChanged(object sender, EventArgs e)
        {
        }

        private void pbPhotoCanvas_Click(object sender, EventArgs e)
        {

        }

        private void codeText_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


