using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group1_Project1_Milestone1
{
    public class GameArtist: Games
    {
        public delegate string HighScoreDelegate();
        public event HighScoreDelegate GetsHighScore;

        int highscore;
        List<string> artists = new List<string>();

        public int Highscore { get => highscore; set => highscore = value; }
        public List<string> Artists { get => artists; set => artists = value; }

        public override void calculateHighScore(int score, int currentPlayer, int HighScore)
        {
            if (score > HighScore)
            {
                Highscore = score;
                GetsHighScore();
            }
        }

        public GameArtist()
        {

        }


        public override int GetAnswer()
        {
            Random randomnum = new Random();
            int random, limit;

            limit = Artists.Count - 1;

            random = randomnum.Next(0, limit);

            return random;
        }

        public string OnHighScore()
        {
            return $"High score: {Highscore} ";
        }
    }
}
