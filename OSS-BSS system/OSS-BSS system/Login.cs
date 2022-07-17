using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data.Entity;
using Twilio.TwiML.Voice;

namespace OSS_BSS_system
{
    public partial class Login : Form
    {
      
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-EQG24S41;Initial Catalog=OSS-BSS;User ID=sa;Password=1234"); //подключение к базе данных
            string query = "Select * from Staff Where PhoneNumber = '" + txtUserId.Text.Trim() + "' and Password = '" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                
                Subscribers f2 = new Subscribers(); //открытие формы "Абоненты", если номер телефона и пароль совпал
                f2.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }

        }
        

    

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserId.Text = string.Empty; //очистка поля для ввода номера телефона
            txtPassword.Text = string.Empty; // очистка поля для ввода пароля
        }
    }
}
