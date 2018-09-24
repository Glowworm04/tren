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
    public partial class fmUsers : Form
    {
        SqlConnection connect = new SqlConnection(Properties.Settings.Default.trenConnectionString);
        SqlCommand cmd;
        SqlDataReader read;


        public fmUsers()
        {
            InitializeComponent();
        }

        private void fmUsers_Load(object sender, EventArgs e)
        {

            lblId.Visible = false;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trenDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.trenDataSet.Users);
            if (Program.Role == "Администратор")
            {

            }
        }

        private void dgvUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lblId.Text = dgvUsers.SelectedRows[0].Cells[0].Value.ToString();
            tbLogin.Text = dgvUsers.SelectedRows[0].Cells[1].Value.ToString();
            tbPwd.Text = dgvUsers.SelectedRows[0].Cells[2].Value.ToString();
            tbRole.Text = dgvUsers.SelectedRows[0].Cells[3].Value.ToString();
            tbFIO.Text = dgvUsers.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                cmd = new SqlCommand("Delete from [Users] where id='" + lblId.Text + "'", connect);
                cmd.Parameters.AddWithValue("@id", lblId.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Удалено!");
                this.usersTableAdapter.Fill(this.trenDataSet.Users);

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.trenDataSet.Users);
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            connect.Open();
            cmd = new SqlCommand("Update [Users] Set [id]=@id, [FIO]=@FIO, [Login]=@Login, [Password]=@Password,[Role]=@Role", connect);
            cmd.Parameters.AddWithValue("id", lblId.Text);
            cmd.Parameters.AddWithValue("FIO", tbFIO.Text);
            cmd.Parameters.AddWithValue("Login", tbLogin.Text);
            cmd.Parameters.AddWithValue("Password", tbPwd.Text);
            cmd.Parameters.AddWithValue("Role", tbRole.Text);
            await cmd.ExecuteNonQueryAsync();
            connect.Close();
            MessageBox.Show("Изменено!");
        }
    }
}
