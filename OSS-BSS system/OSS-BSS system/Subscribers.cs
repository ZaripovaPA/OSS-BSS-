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
    public partial class Subscribers : Form
    {
        public Subscribers()
        {
            InitializeComponent();
            
        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (DataGridViewSubscr.CurrentCell.ColumnIndex == 1)
            {
                ComboBox comboBox = e.Control as ComboBox;
                comboBox.DropDownStyle = ComboBoxStyle.DropDown;
                comboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            }
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
           
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_OSS_BSSDataSet.Event". При необходимости она может быть перемещена или удалена.
            this.eventTableAdapter.Fill(this._OSS_BSSDataSet.Event);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_OSS_BSSDataSet.Customer". При необходимости она может быть перемещена или удалена.
            this.customerTableAdapter.Fill(this._OSS_BSSDataSet.Customer);
            this.WindowState = FormWindowState.Maximized;

        }

       

        private void LogOut_Click(object sender, EventArgs e) //выход из системы
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ButtonAssets_Click(object sender, EventArgs e)
        {
            this.Close(); //закрытие активной формы
            Assets f5 = new Assets();
            f5.Show();
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

        private void ButtonSupport_Click(object sender, EventArgs e)
        {
            this.Close(); //закрытие активной формы
            Support f4 = new Support();
            f4.Show();
        }

 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ButtonSearchSubscr_Click(object sender, EventArgs e) //поиск в таблице DataGridViewSubscr
        {
            for (int i = 0; i < DataGridViewSubscr.RowCount; i++)
            {
                DataGridViewSubscr.Rows[i].Selected = false;
                for (int j = 0; j < DataGridViewSubscr.ColumnCount; j++)
                    if (DataGridViewSubscr.Rows[i].Cells[j].Value != null)
                        if (DataGridViewSubscr.Rows[i].Cells[j].Value.ToString().Contains(TextBoxSearchSubscr.Text))
                        {
                            DataGridViewSubscr.Rows[i].Selected = true;
                            break;
                        }
            }
        }
    }
}
