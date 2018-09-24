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

namespace tren
{
    public partial class fmReg : Form
    {

        SqlConnection connect = new SqlConnection(Properties.Settings.Default.trenConnectionString);
        SqlCommand cmd;
        SqlDataReader read;

        public fmReg()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            string pwd = tbPwd.Text;
            string zagl = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string mal = "qwertyuiopasdfghjklzxcvbnm";



            if (string.IsNullOrEmpty(tbFIO.Text))
            {
                MessageBox.Show("Введите данные!");
                tbFIO.Focus();
            }
            else if (string.IsNullOrEmpty(tbLogin.Text))
            {
                MessageBox.Show("Введите данные!");
                tbLogin.Focus();
            }
            else if (string.IsNullOrEmpty(tbPwd.Text))
            {
                MessageBox.Show("Введите данные!");
                tbPwd.Focus();
            }
            else if (string.IsNullOrEmpty(tbPwd2.Text))
            {
                MessageBox.Show("Введите данные!");
                tbPwd2.Focus();
            }
            else if (tbPwd.Text.Length < 5 || tbPwd.Text.Length > 20)
            {
                MessageBox.Show("Длина пароля должна быть от 5 до 20 символов!");
                tbPwd2.Clear();
                tbPwd.Focus();
            }
            else if (pwd.Contains(tbLogin.Text))
            {
                MessageBox.Show("Пароль содержит логин!");
                tbPwd2.Clear();
                tbPwd.Focus();
            }
            else if (pwd.IndexOfAny(zagl.ToCharArray()) == -1)
            {
                MessageBox.Show("Пароль не содержит заглавные буквы!");
                tbPwd2.Clear();
                tbPwd.Focus();
            }
            else if (pwd.IndexOfAny(mal.ToCharArray()) == -1)
            {
                MessageBox.Show("Пароль не содержит заглавные буквы!");
                tbPwd2.Clear();
                tbPwd.Focus();
            }
            else if (tbPwd2.Text != tbPwd.Text)
            {
                MessageBox.Show("Пароли не совпадают!");
                tbPwd2.Clear();
                tbPwd2.Focus();
            }
            else
            {
                try
                {
                    connect.Open();
                    cmd = new SqlCommand("Insert into [Users](FIO,Login,Password,Role) values (@FIO,@Login,@Password,@Role)", connect);
                    cmd.Parameters.AddWithValue("FIO", tbFIO.Text);
                    cmd.Parameters.AddWithValue("Login", tbLogin.Text);
                    cmd.Parameters.AddWithValue("Password", tbPwd.Text);
                    cmd.Parameters.AddWithValue("Role", "Мастер");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Успешно!");
                    tbFIO.Clear();
                    tbLogin.Clear();
                    tbPwd.Clear();
                    tbPwd2.Clear();
                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void fmReg_Load(object sender, EventArgs e)
        {
            
        }
    }
}
