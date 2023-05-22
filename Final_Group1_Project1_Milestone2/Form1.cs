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
    public partial class FrmLogin : Form
    {
        player player1 = new player();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username, Password;

            Username = TbUsername.Text;
            Password = TbPassword.Text;

            player1.Login(Username, Password);

            player1.takeCurrentUser(Username, Password);

            TbPassword.Clear();
            TbUsername.Clear();

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
