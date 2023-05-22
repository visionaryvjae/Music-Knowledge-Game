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
    public partial class FrmGameSelect : Form
    {
        public bool Multiplayer;
        public FrmGameSelect(bool multiplayer)
        {
            InitializeComponent();
            Multiplayer = multiplayer;
        }

        private void btnGuessGenre_Click(object sender, EventArgs e)
        {
            FrmGameGenre frmgamegenre = new FrmGameGenre(Multiplayer);
            this.Hide();
           frmgamegenre.ShowDialog();
            this.Close();
        }

        private void BtnGuessArtist_Click(object sender, EventArgs e)
        {
            FrmGameArtist frmgameartsist = new FrmGameArtist(Multiplayer);
            this.Hide();
            frmgameartsist.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPlayerCount frmplayercount = new frmPlayerCount();
            this.Hide();
            frmplayercount.ShowDialog();
            this.Close();
        }

        private void FrmGameSelect_Load(object sender, EventArgs e)
        {
        }
    }
}
