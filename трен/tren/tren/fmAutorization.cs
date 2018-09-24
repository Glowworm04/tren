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
    public partial class fmAutorization : Form
    {
        SqlConnection connect = new SqlConnection(Properties.Settings.Default.trenConnectionString);
        SqlCommand cmd;
        SqlDataReader read;


        public fmAutorization()
        {
            InitializeComponent();
        }

        private void btnVhod_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLogin.Text))
            {
                MessageBox.Show("Введите данные!");
                tbLogin.Focus();
            }
            else if (string.IsNullOrEmpty(tbPwd.Text))
            {
                MessageBox.Show("Введите данные!");
                tbPwd.Focus();
            }
            else
            {
                connect.Open();
                cmd = new SqlCommand(@"Select [Password],[Role] from [Users] where Login='" + tbLogin.Text + "'", connect);

                try
                {
                    read = cmd.ExecuteReader();
                    read.Read();

                    if (tbPwd.Text == read[0].ToString())
                    {
                        Program.Login = tbLogin.Text;
                        Program.Pwd = tbPwd.Text;
                        Program.Role = read[1].ToString();

                        switch (Program.Role)
                        {
                            case "Администратор":
                                this.Visible = false;
                                fmAdmin go = new fmAdmin();
                                go.ShowDialog();
                                tbLogin.Clear();
                                tbPwd.Clear();
                                this.Visible = true;
                                break;

                            case "Директор":
                                this.Visible = false;
                                fmDirector go1 = new fmDirector();
                                go1.ShowDialog();
                                tbLogin.Clear();
                                tbPwd.Clear();
                                this.Visible = true;
                                break;

                            case "Менеджер":
                                this.Visible = false;
                                fmManager go2 = new fmManager();
                                go2.ShowDialog();
                                tbLogin.Clear();
                                tbPwd.Clear();
                                this.Visible = true;
                                break;

                            case "Мастер":
                                this.Visible = false;
                                fmMaster go3 = new fmMaster();
                                go3.ShowDialog();
                                tbLogin.Clear();
                                tbPwd.Clear();
                                this.Visible = true;
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введенные данные неверные!");
                        tbPwd.Clear();
                        tbLogin.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Пользователь не зарегистрирован!");
                    tbLogin.Clear();
                    tbPwd.Clear();
                    tbLogin.Focus();
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            fmReg go = new fmReg();
            go.ShowDialog();
            this.Visible = true;
        }
    }
}
