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
    public partial class Register: Form
    {
        string username, password;

        player p1 = new player();
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            username = TbUsername.Text;
            password = TbPassword.Text;

            p1.Username = username;
            p1.Password = password;

            p1.ConfirmRegister += p1.Registered;

            p1.registerPlayer();

            p1.takeCurrentUser(username, password);

            TbPassword.Clear();
            TbUsername.Clear();

            btnRegister.Visible = false;
            btnLogin.Visible = true;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            p1.Login(username, password);
        }
    }
}
