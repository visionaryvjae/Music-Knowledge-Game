using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Group1_Project1_Milestone1
{
    class GameGenre : Games
    {
        
        int highscore;
        public delegate string HighScoreDelegate();
        public event HighScoreDelegate GetsHighScore;

        public int Highscore { get => highscore; set => highscore = value; }

        public GameGenre(int score1, int score2, List<string> genre) :base( score1, score2, genre)
        {
        }

        public GameGenre()
        {
        }

        public override int GetAnswer()
        {
            Random randomnum = new Random();
            int random, limit;

            limit = Artists.Count-1;

            random = randomnum.Next(0, limit);
                     
            return random;
        }


        public override void calculateHighScore(int score, int currentPlayer, int HighScore)
        {
            if (score > HighScore)
            {
                Highscore = score;
                GetsHighScore();
            }
        }

        public string OnHighScore()
        {
            return $"High score: {Highscore} ";
        }
    }
}
