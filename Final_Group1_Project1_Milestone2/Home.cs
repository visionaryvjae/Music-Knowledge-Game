using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group1_Project1_Milestone1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGotoLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void btnGotoRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register frmRegister = new Register();
            frmRegister.Show();
        }
    }
}
