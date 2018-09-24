using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tren
{
    public partial class fmAdmin : Form
    {
        public fmAdmin()
        {
            InitializeComponent();
        }

        private void fmAdmin_Load(object sender, EventArgs e)
        {
            btnUsers.Visible = false;

            if (Program.Role == "Администратор")
            {
                btnUsers.Visible = true;
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            fmUsers go = new fmUsers();
            go.ShowDialog();
            this.Visible = true;

        }
    }
}
