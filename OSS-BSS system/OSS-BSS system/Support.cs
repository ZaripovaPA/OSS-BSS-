using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSS_BSS_system
{
    public partial class Support : Form
    {
        public Support()
        {
            InitializeComponent();
        }

        private void Support_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_OSS_BSSDataSet.Application". При необходимости она может быть перемещена или удалена.
            this.applicationTableAdapter.Fill(this._OSS_BSSDataSet.Application);
            this.WindowState = FormWindowState.Maximized;
        }

        
            private void ButtonSubscr_Click(object sender, EventArgs e)
        {
            this.Close(); //закрытие активной формы
            Subscribers f2 = new Subscribers();
            f2.Show();
        }

        private void ButtonEquipMan_Click(object sender, EventArgs e)
        {
            this.Close(); //закрытие активной формы
            EquipmentManagement f3 = new EquipmentManagement();
            f3.Show();
        }

        private void ButtonAssets_Click(object sender, EventArgs e)
        {
            this.Close(); //закрытие активной формы
            Assets f5 = new Assets();
            f5.Show();
        }

        private void ButtonSupport_Click(object sender, EventArgs e)
        {
            this.Close(); //закрытие активной формы
            Support f4 = new Support();
            f4.Show();
        }

        private void ButtonSearch_Click(object sender, EventArgs e) //поиск в таблице DataGridViewSupport
        {
            for (int i = 0; i < DataGridViewSupport.RowCount; i++)
            {
                DataGridViewSupport.Rows[i].Selected = false;
                for (int j = 0; j < DataGridViewSupport.ColumnCount; j++)
                    if (DataGridViewSupport.Rows[i].Cells[j].Value != null)
                        if (DataGridViewSupport.Rows[i].Cells[j].Value.ToString().Contains(TextBoxSearch.Text))
                        {
                            DataGridViewSupport.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void LogOut_Click(object sender, EventArgs e) //выход из системы
        {
            System.Windows.Forms.Application.Exit();
        }

        private void reference_Click(object sender, EventArgs e)
        {
            
        }

        private void reference_Click_1(object sender, EventArgs e) //подсказка
        {
            MessageBox.Show("Для работы с заявками абонентов перейдите в приложение NevaCommunication");
        }
    }
}
