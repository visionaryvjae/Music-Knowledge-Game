using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Group1_Project1_Milestone1
{
    public partial class FrmGameArtist : Form
    {
        string userAnswer;
        int index;
        int timer = 60;
        int highscore = 5;
        public int counter;
        player p2 = new player();
        GameArtist newgame = new GameArtist();
        bool Multiplayer;
        int CurrentPlayer = 1;
        artist at1 = new artist();
        public FrmGameArtist(bool multiplayer)
        {
            InitializeComponent();
            Multiplayer = multiplayer;
            p2.MultiplayerStatus(multiplayer);
        }

        private void btnArtistQuit_Click(object sender, EventArgs e)
        {
            FrmGameSelect frmgameselect = new FrmGameSelect(false);
            this.Hide();
            frmgameselect.ShowDialog();
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer = 60;
            backgroundWorker1.RunWorkerAsync();
            btnArtistAnswer.Visible = true;
            btnStart.Enabled = false;
            lblTimer.Visible = true;
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            /*for (int i = timer; i >= 0; i++)
            {
                Thread.Sleep(1000);
                timer--;
                backgroundWorker1.ReportProgress(0);
            }*/
            for (int i = timer; i > 0; i++)
            {
                Thread.Sleep(1000);
                timer--;
                backgroundWorker1.ReportProgress(0);
                if (timer == 0)
                {
                    backgroundWorker1.CancelAsync();
                    break;
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
            if (timer == 0)
            {
                lblTimer.Visible = false;
                btnStart.Enabled = true;
                string line = p2.getScores();
                int i = Convert.ToInt32(p2.getScores().IndexOf('-')), score1 = Convert.ToInt32(line.Substring(0, i)), score2 = Convert.ToInt32(line.Substring(i + 1));
                btnArtistAnswer.Visible = false;
                if ((score1 > highscore) && (CurrentPlayer == 1))
                {
                    highscore = score1;
                    HighScoreMessage highscoremessage = new HighScoreMessage();
                    newgame.GetsHighScore += highscoremessage.OnHighScore;
                    MessageBox.Show(highscoremessage.OnHighScore() + $" {highscore}");
                }
                if (CurrentPlayer == 2)
                {
                    newgame.AnnounceWinner(p2.getScores(), Multiplayer);
                }
                if (Multiplayer == true && CurrentPlayer == 1)
                {

                    MessageBox.Show("Get ready Player 2");
                    lblPlayername.Text = "Player 2";
                    lblScore.Text = "Score: ";
                    CurrentPlayer = 2;
                    timer = 60;
                }
                if ((score2 > highscore) && (CurrentPlayer == 2))
                {
                    highscore = score2;
                    HighScoreMessage highscoremessage = new HighScoreMessage();
                    newgame.GetsHighScore += highscoremessage.OnHighScore;
                    MessageBox.Show(highscoremessage.OnHighScore() + $" {highscore}");
                }
                if (Multiplayer == false)
                {
                    newgame.AnnounceWinner(p2.getScores(), Multiplayer);
                }

            }
            else
            {
                lblTimer.Text = $"Timer: {timer}";
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void FrmGameArtist_Load(object sender, EventArgs e)
        {
            btnArtistAnswer.Visible = false;
            userAnswer = rbOption1.Text;
            p2.ResetScore();
            CurrentPlayer = 1;
            lblPlayername.Text = p2.getCurrentUsername(Multiplayer);
            at1.getArtists();
            newgame.Artists = at1.getArtistList();
            highscore = p2.getHighScore(Multiplayer);
            index = at1.produceArtistindex();

            lblQuestion.Text = at1.SongTitles1[index];
            List<string> answers = new List<string>();
            Thread.Sleep(10);


            do
            {
                int x = newgame.GetAnswer();
                answers.Clear();
                answers.Add(newgame.Artists[x]);
                rbOption1.Text = answers[0];
                Thread.Sleep(10);
                x = newgame.GetAnswer();
                answers.Add(newgame.Artists[x]);
                rbOption2.Text = answers[1];
                Thread.Sleep(10);
                x = newgame.GetAnswer();
                answers.Add(newgame.Artists[x]);
                rbOption3.Text = answers[2];
                Thread.Sleep(10);
                x = newgame.GetAnswer();
                answers.Add(newgame.Artists[x]);
                rbOption4.Text = answers[3];
                Thread.Sleep(10);
            }
            while (answers.Contains(at1.Name[index]) == false);
        }

        
        private void rbOption4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbOption4.Checked)
            {
                userAnswer = rbOption4.Text;
            }
        }

        private void rbOption3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOption3.Checked)
            {
                userAnswer = rbOption3.Text;
            }
        }

        private void rbOption2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOption2.Checked)
            {
                userAnswer = rbOption2.Text;
            }
        }

        private void rbOption1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOption1.Checked)
            {
                userAnswer = rbOption1.Text;
            }
        }

        private void btnArtistAnswer_Click(object sender, EventArgs e)
        {
            lblScore.Text = p2.KeepScore(CurrentPlayer, at1.checkArtist(index, userAnswer));

            index = at1.produceArtistindex();

            lblQuestion.Text = at1.SongTitles1[index];
            List<string> answers = new List<string>();
            Thread.Sleep(10);


            do
            {
                int x = newgame.GetAnswer();
                answers.Clear();
                answers.Add(newgame.Artists[x]);
                rbOption1.Text = answers[0];
                Thread.Sleep(10);
                x = newgame.GetAnswer();
                answers.Add(newgame.Artists[x]);
                rbOption2.Text = answers[1];
                Thread.Sleep(10);
                x = newgame.GetAnswer();
                answers.Add(newgame.Artists[x]);
                rbOption3.Text = answers[2];
                Thread.Sleep(10);
                x = newgame.GetAnswer();
                answers.Add(newgame.Artists[x]);
                rbOption4.Text = answers[3];
                Thread.Sleep(10);
            }
            while (answers.Contains(at1.Name[index]) == false);

            rbOption1.Checked = false;
            rbOption2.Checked = false;
            rbOption3.Checked = false;
            rbOption4.Checked = false;
        }
    }
}
