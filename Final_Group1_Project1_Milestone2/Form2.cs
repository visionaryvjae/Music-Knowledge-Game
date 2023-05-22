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
    public partial class frmPlayerCount : Form
    {

        bool Multiplayer;
        public frmPlayerCount()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Multiplayer = false;
            FrmGameSelect frmgameselect = new FrmGameSelect(Multiplayer);
            this.Hide();
            frmgameselect.ShowDialog();
            this.Close();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Multiplayer = true;
            FrmGameSelect frmgameselect = new FrmGameSelect(Multiplayer);
            this.Hide();
            frmgameselect.ShowDialog();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Multiplayer = true;
            FrmGameSelect frmgameselect = new FrmGameSelect(Multiplayer);
            this.Hide();
            frmgameselect.ShowDialog();
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Multiplayer = true;
            FrmGameSelect frmgameselect = new FrmGameSelect(Multiplayer);
            this.Hide();
            frmgameselect.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Multiplayer = true;
            FrmGameSelect frmgameselect = new FrmGameSelect(Multiplayer);
            this.Hide();
            frmgameselect.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Multiplayer = true;
            FrmGameSelect frmgameselect = new FrmGameSelect(Multiplayer);
            this.Hide();
            frmgameselect.ShowDialog();
            this.Close();
        }

        private void lblTwoPlay_Click(object sender, EventArgs e)
        {
            Multiplayer = true;
            FrmGameSelect frmgameselect = new FrmGameSelect(Multiplayer);
            this.Hide();
            frmgameselect.ShowDialog();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Multiplayer = false;
            FrmGameSelect frmgameselect = new FrmGameSelect(Multiplayer);
            this.Hide();
            frmgameselect.ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Multiplayer = false ;
            FrmGameSelect frmgameselect = new FrmGameSelect(Multiplayer);
            this.Hide();
            frmgameselect.ShowDialog();
            this.Close();
        }

        private void lblOneplay_Click(object sender, EventArgs e)
        {
            Multiplayer = false;
            FrmGameSelect frmgameselect = new FrmGameSelect(Multiplayer);
            this.Hide();
            frmgameselect.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPlayerCount_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
