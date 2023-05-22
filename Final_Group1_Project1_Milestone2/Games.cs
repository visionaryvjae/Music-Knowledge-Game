using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group1_Project1_Milestone1
{
    public abstract class Games
    {
        

        public int score1;
        public int score2;
    
        public int Score1 { get => score1; set => score1 = value; }
        public int Score2 { get => score2; set => score2 = value; }
        public List<string> Artists { get => genre; set => genre = value; }

        

        List<string> genre = new List<string>() { "reggae", "rap", "alt rock", "soul", "afro", "R&B", "pop", "jazz", "rock", "heavy metal", "punk rock", "funk", "blues" };

        protected Games(int score1, int score2, List<string> genre)
        {
            Score1 = score1;
            Score2 = score2;
            this.Artists = genre;
        }

        public Games()
        {
            
        }


        public void AnnounceWinner(string scores, bool multiplayer) 
        {
            int score1 = 0, score2 = 0, xHyphen;
            xHyphen = scores.IndexOf('-');
            score1 = Convert.ToInt32(scores.Substring(0, xHyphen));
            score2 = Convert.ToInt32(scores.Substring(xHyphen+1));
            if (multiplayer)
            {
                if (score1 > score2)
                {
                    MessageBox.Show($"Player 1 wins with a score of: {score1}!! :D", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (score1 == score2)
                {
                    MessageBox.Show($"It is a draw with both players getting a score of {score1}! :/", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Player 2 wins with a score of: {score2}!! :D", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show($"Good game! You scored {score1} points!! :D", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        public abstract int GetAnswer();

        public abstract void calculateHighScore(int score, int currentPlayer, int HighScore);


    }

    public class HighScoreMessage
    {
        public string OnHighScore()
        {
            return $"High score";
        }
    }
}
